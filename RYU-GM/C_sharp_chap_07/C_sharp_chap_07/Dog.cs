using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_chap_07
{
    public class Dog : Animal
    {
        public string Color { get; set; }
        public  Dog() : base()
        {
            Color = "Unknown";
            Name = "Unknown";
        }
        public void Bark()
        {
            Console.WriteLine("멍멍");
            System.Windows.Forms.MessageBox.Show("멍멍멍");
            //base.Sleep();
            Run();
        }
    }
}
