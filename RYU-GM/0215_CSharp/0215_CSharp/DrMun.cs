using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0215_CSharp
{
    public class DrMun : LOL,IqwerKey , IMonsterFight
    {
        public void Attack()
        {
            System.Windows.Forms.MessageBox.Show("평타");
        }

        public override void BornVoice()
        {
            System.Windows.Forms.MessageBox.Show("문도");
            //throw new NotImplementedException();
        }

        public override void DieVoice()
        {
            System.Windows.Forms.MessageBox.Show("ㅈㅅ");
            //throw new NotImplementedException();
        }

        public void eKey()
        {
            System.Windows.Forms.MessageBox.Show("문도E기술");
        }

        public void MagicArrow()
        {
            System.Windows.Forms.MessageBox.Show("없음");

        }

        public void PhysicalAttack()
        {
            System.Windows.Forms.MessageBox.Show("식칼 던지기");
        }

        public void qKey()
        {
            System.Windows.Forms.MessageBox.Show("문도q기술");
        }

        public void rKey()
        {
            System.Windows.Forms.MessageBox.Show(name+"궁극기"+race);
        }

        public void wKey()
        {
            System.Windows.Forms.MessageBox.Show("문도w기술");
        }
    }
}
