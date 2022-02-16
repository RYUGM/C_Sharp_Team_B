using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCsharp_chap10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = a * a;
                MessageBox.Show("제곱:" + b + "이다");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

                return;
            }
            finally
            {
                MessageBox.Show("finally");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                MessageBox.Show("a"+a);
                
            }
            catch (FormatException ex)
            {
                MessageBox.Show("형식 잘못");

               
            }catch(Exception ex)
            {
                MessageBox.Show("???");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool error= int.TryParse(textBox1.Text,out int value);
                MessageBox.Show("Test"+ value);
                if(error == false)
                throw new Exception("형식");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Test1");
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

               
            }
        }
    }
}
