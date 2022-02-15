using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0215_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cogmo c;
        DrMun d;
        private void button1_Click(object sender, EventArgs e)
        {
             c = new Cogmo();
            c.name = "커그머";
            c.race = "괴물";
            c.BornVoice();
            c.DieVoice();

             d= new DrMun();
            d.name = "분도박사";
            d.race = "프랑켄";
            d.BornVoice();
            d.DieVoice();

            MessageBox.Show("C의 이름은"+c.name+"종족:"+c.race);
            MessageBox.Show("D의 이름은"+d.name+"종족:"+d.race);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.qKey();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.wKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.eKey();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.rKey();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d.qKey();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d.wKey();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d.eKey();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            d.rKey();
        }

        void ChampionAttack(IMonsterFight m)
        {
            m.Attack();
            m.PhysicalAttack();
            m.MagicArrow();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ChampionAttack(c);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ChampionAttack(d);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BabyMundo bm = new BabyMundo();
            ChampionAttack(bm);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IMonsterFight ac = new Cogmo();
            IMonsterFight am = new DrMun();
            IMonsterFight ab = new BabyMundo();

            ac.Attack();
            ac.MagicArrow();

            am.MagicArrow();
            am.Attack();

            ab.MagicArrow();
            ab.Attack();

            IList mylist = new ArrayList();
            List<IMonsterFight> my2 = new List<IMonsterFight>();

        }
    }
}
