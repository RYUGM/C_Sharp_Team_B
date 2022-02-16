using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCsharp_chap11
{
    public partial class Form1 : Form
    {
        delegate void TestFunc();

        void Hello()
        {
            MessageBox.Show("hello");
        }
        void Bye()
        {
            MessageBox.Show("bye");
        }
        void DoDelegateFunc(TestFunc t,int c)
        {
            for(int i = 0; i<c; i++)
            {
                t();
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            //DoDelegateFunc(Hello, 2);
            //DoDelegateFunc(Bye, 1);
            button18.Click += delegate (object sender, EventArgs e)
            {
                System.Windows.Forms.MessageBox.Show("Test");
            };
            button17.Click += (sender, e) => { MessageBox.Show("Test Lamda"); };

            button18.Click += addFunc;

        }
        private void addFunc(object sender , EventArgs e)
        {
            MessageBox.Show("한번 클릭시 여러개의 메소드가 호출 가능");
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<5; i++)
            {
                Hello();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i =0; i<10; i++)
            {
                Bye();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TestFunc t = Hello;
            t();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TestFunc t = Bye;
            t();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DoDelegateFunc(Hello, 2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DoDelegateFunc(Bye, 5);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DoDelegateFunc(delegate () { MessageBox.Show("람다  아님"); }, 2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DoDelegateFunc( () => { MessageBox.Show("람다"); }, 2);
        }

        delegate string myStringValue(string str);
        string changeBigChar(string str)
        {

            return str.ToUpper();
        } 

        string changetSmallChar(string str)
        {
            return str.ToLower();

        }
        void ShowChange(myStringValue s, string str)
        {
            MessageBox.Show("원본: " + str + " 변경 후: "+"["+s(str)+"]");
            
        }
        private void button11_Click(object sender, EventArgs e)
        {
            myStringValue a = changeBigChar;
            myStringValue b = changetSmallChar;

            string msg1 = a(textBox1.Text);
            string msg2 = b(textBox1.Text);

            MessageBox.Show(msg1+msg2);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShowChange(changetSmallChar, textBox1.Text);
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShowChange(delegate (string str) {

            char[] charArr = str.ToCharArray();
                Array.Reverse(charArr);


                return new string(charArr);

            }, textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ShowChange((a) => { 
                char[] charArr=a.ToCharArray();
                Array.Sort(charArr);
                
                return new string(charArr); }, 
                textBox1.Text);
        }

        delegate void callBackHell(TestFunc t, myStringValue s, string str);

        void myhell(TestFunc t,myStringValue s, string str)
        {
            t();
            s(str);
            MessageBox.Show("str 원본"+str);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            myhell(Hello, changeBigChar, textBox1.Text);
            myhell(() => { MessageBox.Show(textBox1.Text + "안녕"); },
                (a) => { return a.ToLower() + a.ToUpper(); }, textBox1.Text);

            callBackHell abc = (aa, bb, cc) => { aa(); string s = bb(cc); MessageBox.Show(s); };
            abc(Hello, changeBigChar, textBox1.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Thread a = new Thread(() => { for (int i = 0; i < 100; i++) { Console.Write("A"); } });
            Thread b = new Thread(() => { for (int i = 0; i < 100; i++) { Console.Write("B"); } });
            Thread c = new Thread(() => { for (int i = 0; i < 100; i++) { Console.Write("C"); } });


            a.Start();
            b.Start();
            c.Start();  

          
        }
    }
}
