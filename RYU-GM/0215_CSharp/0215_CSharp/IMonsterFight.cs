using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215_CSharp
{
    public interface IMonsterFight :IFight
    {
        void MagicArrow();
        void PhysicalAttack();
    }
}
