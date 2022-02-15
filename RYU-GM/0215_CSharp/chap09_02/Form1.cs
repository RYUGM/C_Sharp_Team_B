using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chap09_02
{
    public partial class Form1 : Form
    {
        List<Product> products=new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = textBox1.Text;
            product.Price = int.Parse(textBox2.Text);
            products.Add(product);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            products.Sort();
            string list = "";
            foreach(Product product in products)
            {
                list+= " 제품명: "+product.Name + " 가격 : "+product.Price+Environment.NewLine;
            }
            label3.Text = list;
        }
    }
}
