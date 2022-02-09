using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Csharp_chap07_02
{
    public class Dog : Animal
    {
        public new int number { get; set; } 

        public new void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("잠좀 잡시다");
        }
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("멍멍탕탕");
        }

    }
}
