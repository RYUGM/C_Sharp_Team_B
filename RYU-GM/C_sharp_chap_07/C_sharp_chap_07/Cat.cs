using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_chap_07
{
    public class Cat : Animal
    {
        public string eyeColor { get; set; }

        public void Meow()
        {
            Console.WriteLine("야옹");
            Run();
        }
    }
}
