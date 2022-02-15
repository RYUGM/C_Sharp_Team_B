using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215_CSharp
{
    public class Cogmo : LOL, IqwerKey , ISkinColor,IMonsterFight
    {
        public void Attack()
        {
            System.Windows.Forms.MessageBox.Show("평타");
        }

        public override void BornVoice()
        {
            System.Windows.Forms.MessageBox.Show("쿠웨엑");
            //throw new NotImplementedException();
        }

        public override void DieVoice()
        {
            System.Windows.Forms.MessageBox.Show("ㅜㅜ");
            //throw new NotImplementedException();
        }

        public void eKey()
        {
            System.Windows.Forms.MessageBox.Show("E기술");
        }

        public void MagicArrow()
        {
            System.Windows.Forms.MessageBox.Show("포이즌 애로우");
        }

        public void PhysicalAttack()
        {
            System.Windows.Forms.MessageBox.Show("돌진");
        }

        public void qKey()
        {
            System.Windows.Forms.MessageBox.Show("Q기술");
        }

        public void rKey()
        {
            System.Windows.Forms.MessageBox.Show(name + "궁극기" + race + "족");
        }

        public void showColor()
        {
            System.Windows.Forms.MessageBox.Show("고구마");
        }

        public void wKey()
        {
            System.Windows.Forms.MessageBox.Show("W기술");
        }
    }
}
