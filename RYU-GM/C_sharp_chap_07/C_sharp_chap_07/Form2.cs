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
    public partial class Form2 : Form
    {
        List<Dog> dogs = new List<Dog>();   
        List<Cat> cats = new List<Cat>();
        List<Animal> animals = new List<Animal>();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog d = new Dog();  
            dogs.Add(d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cat c = new Cat();
            cats.Add(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Animal a = new Cat();
            a.Sleep();
            ((Cat)a).Meow();
            animals.Add(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animal a = new Dog();
            a.Sleep();
            ((Dog)a).Bark();
            animals.Add(a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(var item in dogs)
            {
                item.Sleep();
                item.Eat(); 
                item.Bark();    
            }

            foreach (var item in cats)
            {
                item.Sleep();
                item.Eat();
                item.Meow();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach(var item in animals)
            {
                item.Sleep();
                item.Eat();
                if(item is Dog)
                    (item as Dog).Bark();
                //if(item is Cat)
                //    (item as Cat).Meow();
                var cat = item as Cat;
                if (cat != null)
                    cat.Meow();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
