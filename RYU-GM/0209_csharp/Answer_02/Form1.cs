using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Answer_02
{
    public partial class Form1 : Form
    {
        int limitTimer = 0;
        int answer = 0;
        int nowtime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            nowtime = 0;
            label2.Text = "Game Start!";
            answer = new Random().Next(1,26);
            Console.WriteLine("answer = "+ answer);

            int count = 1;
            for(int i = 0; i<5; i++)
            {
                for(int j= 0; j<5; j++)
                {
                    Button button = new Button();
                    Point point = new Point();
                    point.X = 115 * j;
                    point.Y = 50 * i;
                    button.Location = point;
                    button.Click += Button_Click;
                    button.Text = count.ToString();
                    count++;
                    Controls.Add(button);
                }
            }
            timer1.Enabled = true;
            try
            {
                limitTimer = int.Parse(textBox1.Text);
            }catch(Exception ex)
            {
                nowtime = -1;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(((Button)sender).Text == answer.ToString())
            {
                label2.Text = "You Win!";
                nowtime = 0;
                timer1.Enabled=false;
            }
            else
            {
                label2.Text = "보물이 아님!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime++;
            if(nowtime >= limitTimer || nowtime == -1)
            {
                label2.Text = "Game Over!";
                nowtime = 0;
                timer1.Enabled = false;
            }
        }
    }
}
