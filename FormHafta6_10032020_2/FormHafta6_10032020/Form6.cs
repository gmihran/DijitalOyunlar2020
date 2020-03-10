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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int konum;
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
                case 5:
                    pBall.Top -= 5;
                    pBall.Left -= 5;
                    break;
                case 6:
                    pBall.Top -= 5;
                    pBall.Left += 5;
                    break;
                case 7:
                    pBall.Top += 5;
                    pBall.Left -= 5;
                    break;
                case 8:
                    pBall.Top += 5;
                    pBall.Left += 5;
                    break;
                default:
                    break;
            }
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

        private void btnDur_Click(object sender, EventArgs e)
        {
            konum = 0;
            timer1.Stop();
        }

        private void btnSolYukari_Click(object sender, EventArgs e)
        {
            konum = 5;
            timer1.Start();
        }

        private void btnSagYukari_Click(object sender, EventArgs e)
        {
            konum = 6;
            timer1.Start();
        }

        private void btnSolAsagi_Click(object sender, EventArgs e)
        {
            konum = 7;
            timer1.Start();
        }

        private void btnSagAsagi_Click(object sender, EventArgs e)
        {
            konum = 8;
            timer1.Start();
        }
    }
}
