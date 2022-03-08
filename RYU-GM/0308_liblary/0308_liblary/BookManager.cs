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
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
            if (DataManager.Books.Count > 0)
            {
                dataGridView_books.DataSource = DataManager.Books;
            }
        }

        private void BookManager_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            foreach (var item in DataManager.Books)
            {
                if(item.Isbn == textBox_lsbn.Text)
                {
                    existBook = true;
                    break;
                }
             
            }
            if (existBook)
            {
                MessageBox.Show("이미 존재하는 책");
            }
            else
            {
                Book book = new Book();
                book.Isbn = textBox_lsbn.Text;
                book.Name = textBox_bookName.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);
                DataManager.Books.Add(book);

                dataGridView_books.DataSource = null;
                dataGridView_books.DataSource = DataManager.Books;
                DataManager.Save();
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            Book book = null;
            for(int i = 0; i<DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_lsbn.Text)
                {
                    book = DataManager.Books[i];
                    book.Name = textBox_bookName.Text;
                    book.Publisher = textBox_publisher.Text;
                    book.Page = int.Parse(textBox_page.Text);

                    dataGridView_books.DataSource = null;
                    dataGridView_books.DataSource = DataManager.Books;
                    DataManager.Save();
                    break;

                }
            }
            if(book == null)
            {
                MessageBox.Show("존재하지 않는 책");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            bool existBook = false;
            for(int i = 0; i<DataManager.Books.Count; i++)
            {
                if(DataManager.Books[i].Isbn == textBox_lsbn.Text)
                {
                    DataManager.Books.RemoveAt(i);
                    existBook = true;
                    break;


                }
            }
            if(existBook == false)
            {
                MessageBox.Show("없는 책");
            }
            else
            {
                dataGridView_books.DataSource = null;
                if(DataManager.Books.Count > 0)
                {
                    dataGridView_books.DataSource = DataManager.Books;
                }
                   DataManager.Save();
               
            }
        }

        private void dataGridView_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Book book = dataGridView_books.CurrentRow.DataBoundItem as Book;
            textBox_lsbn.Text = book.Isbn;
            textBox_bookName.Text = book.Name;
            textBox_publisher.Text= book.Publisher;
            textBox_page.Text = book.Page.ToString();
        }
    }
}
