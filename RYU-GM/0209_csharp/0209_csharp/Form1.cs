using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0209_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public int Power(int input)
        {
            int result;
            result = input * input;

            return result;
                               
        }

        public int Power_2(int input , int count)
        {
            int result = 1;
            for (int i = 1; i <= count; i++)
            {
                result = input * result;
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pw;
            pw=Power(int.Parse(textBox1.Text));
            label1.Text=pw.ToString();
            
        }

        private int SumAll(int end)
        {
            int result = 0;
            for (int i = end; i >= 0; i--) {
                result = i + result;
            }
            return result;
        }

        private int SumAll_2(int start, int end)
        {
            int result=0;
            for(int i= end; i>=start; i--)
            {
                result = i + result;
            }
            return result;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pw;
            pw = Power_2(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            label1.Text=pw.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int result;
            result = SumAll(int.Parse(textBox1.Text));
            label1.Text = result.ToString();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int result;

            result = SumAll_2(int.Parse(textBox1.Text), int.Parse(textBox2.Text));

            label1.Text=result.ToString();      
        }
    }
}
