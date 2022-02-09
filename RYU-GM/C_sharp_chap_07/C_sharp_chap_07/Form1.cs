using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_chap_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.Name = textBox1.Text;
            MessageBox.Show("이름은 "+a.Name+" 나이는 "+a.Age+"이다.");
            a.Age = int.Parse(textBox2.Text);
            MessageBox.Show("이름은 " + a.Name + " 나이는 " + a.Age + "이다.");
            a.Eat();
            a.Sleep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Dog d= new Dog();
            d.Name = textBox1.Text;
            MessageBox.Show("이름 "+d.Name+" 나이 "+d.Age+" 이다");
            d.Age = int.Parse(textBox2.Text);
            MessageBox.Show("이름 " + d.Name + " 나이 " + d.Age + " 이다");
            d.Color = textBox3.Text;
            MessageBox.Show("이름 " + d.Name + " 나이 " + d.Age + " 이며 털 색은"+d.Color+"이다");
            d.Sleep();
            d.Bark();
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat  d= new Cat();
            d.Name = textBox1.Text;
            MessageBox.Show("이름 " + d.Name + " 나이 " + d.Age + " 이다");
            d.Age = int.Parse(textBox2.Text);
            MessageBox.Show("이름 " + d.Name + " 나이 " + d.Age + " 이다");
            d.eyeColor=textBox4.Text;
            MessageBox.Show("이름 " + d.Name + " 나이 " + d.Age + " 이며 눈 색은" + d.eyeColor + "이다");
            d.Sleep();
            d.Meow();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            MessageBox.Show("이름 " + d.Name + " 나이 " + d.Age + " 이며 털 색은" + d.Color + "이다");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().ShowDialog();
            Show();
        }
    }
}
