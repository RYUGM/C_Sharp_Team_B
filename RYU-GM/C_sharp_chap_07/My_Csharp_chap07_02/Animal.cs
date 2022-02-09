using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Csharp_chap07_02
{
 
    public class Animal : Creature
    {
        public string number { get; set; }  

        public void Sleep() {
            System.Windows.Forms.MessageBox.Show("개처럼 잔다");
        }
        public virtual void Eat() {
            System.Windows.Forms.MessageBox.Show("개처럼 먹는다");
        }

        public override void Born()
        {
            System.Windows.Forms.MessageBox.Show("응애");
            // throw new NotImplementedException();
        }

        public override void Die()
        {
            System.Windows.Forms.MessageBox.Show("깨꼬닥");
            // throw new NotImplementedException();
        }
    }
}
