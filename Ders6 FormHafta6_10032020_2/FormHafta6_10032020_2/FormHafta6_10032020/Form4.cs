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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pBall.Location.X;
            int y = pBall.Location.Y;           
            if (e.KeyCode == Keys.Right && x < this.Width - pBall.Width * 1.25)
                x += 5;    //kaymanın 5 piksel olduğunu söylemiş oluruz             
            else if (e.KeyCode == Keys.Left && x > 0)
                x -= 5;
            else if (e.KeyCode == Keys.Up && y > 0)
                y -= 5;
            else if (e.KeyCode == Keys.Down && y < this.Height - pBall.Height * 2)
                y += 5;
            pBall.Location = new Point(x, y);
            foreach (Label lbl in this.Controls.OfType<Label>())
            {
                //lbl.BackColor = Color.Black;
                if (pBall.Bounds.IntersectsWith(lbl.Bounds))
                    //MessageBox.Show("çarpıştı");
                    pBall.Location = new Point(ilkkonumX, ilkkonumY);
                    //pBall.Location = new Point(ilkkonum.X,ilkkonum.Y);
            } 
        }
        int ilkkonumX, ilkkonumY;
        //Point ilkkonum;
        private void Form4_Load(object sender, EventArgs e)
        {
            ilkkonumX = pBall.Location.X;
            ilkkonumY = pBall.Location.Y;
            //ilkkonum = pBall.Location;
        }
    }
}
