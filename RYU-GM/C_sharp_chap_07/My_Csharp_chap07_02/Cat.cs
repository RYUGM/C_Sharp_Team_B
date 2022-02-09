using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Csharp_chap07_02
{
    public class Cat : Animal

    {
        public double number    { get; set; }   

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("잔다옹");
        }

        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("캔따개~");
        }


    }
}
