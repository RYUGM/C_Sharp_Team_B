using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Csharp_chap07_02
{
    enum MachineState
    {
        ON, Idle = 100, OFF
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("메시지 박스 내용","제목",MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal a = new Animal();
            a.Eat();
            a.Sleep();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            d.Eat();
            d.Sleep();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            c.Eat();
            c.Sleep();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Animal d= new Dog();
            d.Eat();
            d.Sleep();
            (d as Dog).Sleep();

            (d as Animal).Eat();
            (d as Animal).Sleep();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal c = new Cat();
            c.Eat();
            c.Sleep();

            (c as Animal).Eat();
            (c as Animal).Sleep();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            Cat c = new Cat();

            (d as Animal).Eat();
            (c as Animal).Eat();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();
            Cat c = new Cat();

            (d as Animal).Sleep();
            (c as Animal).Sleep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        MachineState myState;
        private void button8_Click(object sender, EventArgs e)
        {
            myState = MachineState.ON;
            MessageBox.Show("기계 상태 :"+MachineState.ON);
            MessageBox.Show("기계 상태 :"+(int)MachineState.ON);
            MessageBox.Show("기계 상태 :"+(MachineState)0);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            myState = MachineState.Idle;
            MessageBox.Show("기계 상태 :" + MachineState.Idle);
            MessageBox.Show("기계 상태 :" + (int)MachineState.Idle);
            MessageBox.Show("기계 상태 :" + (MachineState)100);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myState = MachineState.OFF;
            MessageBox.Show("기계 상태 :" + MachineState.OFF);
            MessageBox.Show("기계 상태 :" + (int)MachineState.OFF);
            MessageBox.Show("기계 상태 :" + (MachineState)101);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기계 상태 : "+myState);
            MessageBox.Show("기계 상태 : "+(int)myState);

        }
    }
}
