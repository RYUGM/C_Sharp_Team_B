using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_chap_07
{
    public class Animal
    {
        public int Age { get; set; }    
        public string Name { get; set; }   
        
        

        public Animal()
        {
            Age = 0;
        }
        protected void Run()
        {
            System.Windows.Forms.MessageBox.Show(Name + "이/가 달립니다!");
        }
        public void Eat()
        {
            Console.WriteLine(Name+"쩝쩝");
            System.Windows.Forms.MessageBox.Show("??");
        }
        public void Sleep()
        {
            Console.WriteLine(Name+"ZZZ...");
        }
    }
}
