using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_02_15_CSharp
{
    public class Twice
    {
       
               public int this[int i]
        {
            get { return i * 2; }
            set { System.Windows.Forms.MessageBox.Show(i+"값을 set 함");}
        }
    }
}
