using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta6_10032020
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int konum=0;
        private void btnDur_Click(object sender, EventArgs e)
        {
            konum = 0;
            timer1.Stop();
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            konum = 1;
            timer1.Start();
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            konum = 2;
            timer1.Start();
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            konum = 3;
            timer1.Start();
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            konum = 4;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (konum)
            {
                case 0:
                    timer1.Stop();
                    break;
                case 1:
                    pBall.Top -= 5;
                    break;
                case 2:
                    pBall.Left -= 5;
                    break;
                case 3:
                    pBall.Top += 5;
                    break;
                case 4:
                    pBall.Left += 5;
                    break;
                default:
                    break;
            }
            
        }

        private void pBall_Click(object sender, EventArgs e)
        {

        }
    }
}
