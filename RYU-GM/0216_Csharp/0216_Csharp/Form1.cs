using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0216_Csharp
{
    public partial class Form1 : Form , ISubject
    {
        List<IObserver> _observers = new List<IObserver> ();
        public Form1()
        {
            InitializeComponent();
            Form2 frm2=new Form2(this);
            frm2.TopLevel = false;
            frm2.FormBorderStyle = FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            pa1.Controls.Add(frm2);
            frm2.Show();

            Form3 frm3 = new Form3(this);
            frm3.TopLevel = false;
            frm3.FormBorderStyle = FormBorderStyle.None;
            frm3.Dock = DockStyle.Fill;
            pa2.Controls.Add(frm3);
            frm3.Show();


            Form4 frm4 = new Form4(this, frm2, frm3);
            frm4.TopLevel=false;
            frm4.FormBorderStyle = FormBorderStyle.None;
            frm4.Dock = DockStyle.Fill;
            pa3.Controls.Add(frm4);
            frm4.Show();
        }

        public void notifyObserver()
        {
            foreach(IObserver item in _observers)
            {
                item.update(textBox1.Text);
            }
        }

        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void unregisterObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                notifyObserver();
            }
        }
    }
}
