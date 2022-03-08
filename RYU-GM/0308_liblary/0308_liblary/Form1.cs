using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0308_liblary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            label_allBookCount.Text = DataManager.Books.Count.ToString();
            label_allUserCount.Text = DataManager.Users.Count.ToString();

            //label_allBorrowedBook.Text = DataManager.Books.Where(x => true).Count().ToString();
            label_allBorrowedBook.Text = DataManager.Books.Where(x => x.isBorrowed).Count().ToString();
            label_allDelayedBook.Text = DataManager.Books.Where(x => x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now).Count().ToString();

            if (DataManager.Users.Count > 0)
            {
                dataGridView_UserManager.DataSource = DataManager.Users;

            }
            if(DataManager.Books.Count > 0)
            {
                dataGridView_BookManager.DataSource = DataManager.Books;
            }

            dataGridView_BookManager.CellClick += (sender, e) =>
            {
                Book book = dataGridView_BookManager.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_BookName.Text = book.Name;
            };

            dataGridView_UserManager.CellClick += delegate (object sender, DataGridViewCellEventArgs e)
            {
                User user = dataGridView_UserManager.CurrentRow.DataBoundItem as User;
                textBox_UserId.Text = user.Id.ToString();
                //???
            };
            button_borrow.Click += Button_Borrow_Click;
            button_return.Click += Button_Return_Click;
        }

        private void Button_Return_Click(object sender, EventArgs e)
        {
           if(textBox_isbn.Text.Trim()=="")
                MessageBox.Show("ISBN 입력");
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                    if (book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt;
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;

                        TimeSpan timeDiff = DateTime.Now - oldDay;
                        if(timeDiff.Days>7)
                            MessageBox.Show(book.Name+"연체 상태로 반납");
                        else
                            MessageBox.Show(book.Name+"정상 반납.");
                    }
                    else
                    {
                        MessageBox.Show("대여중이 아님");
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("없는 책 입니다.");
                }
               
            }
        }

        private void Button_Borrow_Click(object sender, EventArgs e)
        {
            if(textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("isbn 입력");

            }else if (textBox_UserId.Text.Trim() == "")
            {
                MessageBox.Show("사용자 ID 입력");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                    if(book.isBorrowed)
                    {
                        MessageBox.Show("이미 빌렸습니다.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox_UserId.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;
                        DataManager.Save();
                        MessageBox.Show($"{book.Name}이/가 {user.Name}님께 대여되었습니다.");
                    }
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("존재하지 않는 도서 혹은 사용자");
                }
            }
        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_now.Text = DateTime.Now.ToString("yyyy년 MM dd일 HH시 mm분 ss초");
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookManager().ShowDialog();

            DataManager.Load();
            dataGridView_BookManager.DataSource = null;
            if (DataManager.Books.Count > 0)
                dataGridView_BookManager.DataSource = DataManager.Books;
            
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UserManager().ShowDialog();
            DataManager.Load();
            dataGridView_BookManager.DataSource = null;
            if(DataManager.Users.Count>0)
                dataGridView_BookManager.DataSource = DataManager.Users;    

            label_allUserCount.Text = DataManager.Users.Count.ToString();
        }
    }
}
