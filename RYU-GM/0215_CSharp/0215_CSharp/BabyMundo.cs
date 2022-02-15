using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215_CSharp
{
    public class BabyMundo : DrMun,IMonsterFight
    {
     
        public new void  MagicArrow()
        {
            System.Windows.Forms.MessageBox.Show("파이어 볼트");
        }
    }
}
