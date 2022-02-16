using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyCsharp_chap12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> numbers=new List<int>() { 1,2,3,4,5,6,7,8,9,10};
        private void button1_Click(object sender, EventArgs e)
        {
            var output = from item in numbers where item % 2 != 0 select item;
            label1.Text = "";
            string result = "";
            foreach(var item in output)
            {
                result += item;
            }
            label1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var output = from item in numbers where item % 2 == 0 select item;
            label2.Text = "";
            string result = "";
            foreach (var item in output)
            {
                result += item;
            }
            label2.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var output = from aa in numbers where aa % 2 != 0 select aa * aa;
            string result = "";
            foreach(var item in output)
            {
                result += item + " ";
            }
            label3.Text = result;
        }
        List<Product> products = new List<Product>();
        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int price = int.Parse(textBox2.Text);
            products.Add(new Product() { Name = name, Price = price });
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int price = int.Parse(textBox2.Text);
            products.Add(new Product() { Name = name, Price = price });
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var output = from item in products where item.Price < 1500 select new {itemName=item.Name, doublePrice = item.Price * 2, halfprice = item.Price / 2 };
            string result = "";
            foreach(var item in output)
            {
                result = $"{item.itemName}의 두배 가격은{item.doublePrice} , 반값은{item.halfprice}{Environment.NewLine}";
            }
            label4.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var output = from item in products where item.Price < 1500 select item;
            string result = "";
            foreach(var item in output)
            {
                result+=item.Name+"is"+item.Price+"won"+Environment.NewLine;
            }
            label5.Text= result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml= XElement.Load(url);
           
            Console.WriteLine(myxml);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url);

            var output = from item in myxml.Descendants("data") select new { 
            Day= item.Element("day").Value,
            weather=item.Element("wfKor").Value
            };
            foreach(var item in output)
            {
                Console.WriteLine(item.Day+" "+item.weather);
            }
         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url);
            var output = from item in myxml.Descendants("data")
                         select new Weather()
                         {
                             Day = item.Element("day").Value,
                             korWeather = item.Element("wfKor").Value
                         };
            foreach (var item in output)
            {
                Console.WriteLine(item.Day + " " + item.korWeather);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string url = "http://www.kma.go.kr/wid/queryDFS.jsp?gridx=59&gridy=127";
            XElement myxml = XElement.Load(url);

            foreach (var item in myxml.Descendants("data"))
            {
                Console.WriteLine(item.Element("day").Value);
                Console.WriteLine(item.Element("wfKor").Value);
            }
            List<Weather> ws = new List<Weather>();
            foreach (var item in myxml.Descendants("data"))
            {
                Weather w = new Weather();
                w.Day = item.Element("day").Value;
                w.korWeather = item.Element("wfKor").Value;
                ws.Add(w);
             
            }
            foreach(var item in ws)
            {
                Console.WriteLine(item.Day+" "+item.korWeather);
            }

        }
    }
}
