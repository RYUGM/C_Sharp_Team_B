using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap09_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = "";
            //if (checkBox1.Checked)
            //    info += checkBox1.Text + ",";
            //if (checkBox2.Checked)
            //    info += checkBox2.Text + ",";
            //if (checkBox3.Checked)
            //    info += checkBox3.Text;


            
            //if (checkBox1.Checked)
            //    infoList.Add(checkBox1.Text);
            //    if (checkBox2.Checked)
            //    infoList.Add(checkBox2.Text);
            //if (checkBox3.Checked)
            //    infoList.Add(checkBox3.Text);

            //info = String.Join(",", infoList);

            foreach(var item in Controls)
            {
                //if(item is CheckBox)
                //    if (item as CheckBox).Checked)
                //        infoList.Add(item as CheckBox).Text);


            }

           
        }
        List<string> infoList = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var item in Controls)
            {
                if(item is GroupBox)
                {
                    GroupBox groupBox = item as GroupBox;
                    foreach (var in_item in groupBox.Controls)
                    {
                        if(in_item is RadioButton)
                        {
                            RadioButton r = in_item as RadioButton;
                            if (r.Checked)
                                infoList.Add(r.Text);
                        }
                    }
                }
                string result = string.Join(",", infoList);
                MessageBox.Show(result);


                {

                }
            }
        }
    }
}
