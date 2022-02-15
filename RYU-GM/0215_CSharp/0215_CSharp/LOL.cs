using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215_CSharp
{
    public abstract class LOL
    {
        public string name { get; set; }
        public string race { get; set; }

        public abstract void BornVoice();
        public abstract void DieVoice();

    }
}
