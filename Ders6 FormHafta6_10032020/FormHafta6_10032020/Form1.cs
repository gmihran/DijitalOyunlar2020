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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukari_Click(object sender, EventArgs e)
        {
            pBall.Top -= 10;
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            pBall.Left -= 10;
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            pBall.Left += 10;
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            pBall.Top += 10;
        }
    }
}
