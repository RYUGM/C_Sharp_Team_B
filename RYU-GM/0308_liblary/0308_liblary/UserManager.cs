using System;
using System.Linq;
using System.Windows.Forms;

namespace _0308_liblary
{
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
            if(DataManager.Users.Count>0)
                dataGridView_Users.DataSource = DataManager.Users;  


            dataGridView_Users.CellClick += dataGridView_Users_cellClick;

        }

        private void dataGridView_Users_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = dataGridView_Users.CurrentRow.DataBoundItem as User;
            textBox_userId.Text=user.Id.ToString();
            textBox_userName.Text=user.Name;
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
          
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (DataManager.Users.Exists(x => x.Id == int.Parse(textBox_userId.Text)))
            {
                MessageBox.Show("이미 존재하는 ID");
            }
            else
            {
                User user = new User() { Id = int.Parse(textBox_userId.Text), Name = textBox_userName.Text };
                DataManager.Users.Add(user);

                dataGridView_Users.DataSource = null;
                dataGridView_Users.DataSource = DataManager.Users;
                DataManager.Save();


            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                User user = DataManager.Users.Single(x => x.Id == int.Parse(textBox_userId.Text));
                user.Name = textBox_userName.Text;
                try
                {
                    Book book = DataManager.Books.Single((x) => x.UserId == int.Parse(textBox_userId.Text));
                    book.UserName = textBox_userName.Text;
                }
                catch (Exception)
                {

                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("해당 아이디 없음");

            }
            dataGridView_Users.DataSource = null;
            dataGridView_Users.DataSource = DataManager.Users;
            DataManager.Save();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox_userId.Text));
                DataManager.Users.Remove(user);

                dataGridView_Users.DataSource = null;
                if (DataManager.Users.Count > 0)
                    dataGridView_Users.DataSource = DataManager.Users;

                DataManager.Save();
            }
            catch (Exception)
            {

                MessageBox.Show("사용자 없음");
            }
        }
    }
}
