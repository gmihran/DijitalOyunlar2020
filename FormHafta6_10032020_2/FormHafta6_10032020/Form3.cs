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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pBall.Location.X;
            int y = pBall.Location.Y;
            LabelKonum.Text = x + "," + y;
            if (e.KeyCode == Keys.Right && x < this.Width-pBall.Width*1.25)
                x += 5;    //kaymanın 5 piksel olduğunu söylemiş oluruz                 

            else if (e.KeyCode == Keys.Left && x > 0)

                x -= 5;

            else if (e.KeyCode == Keys.Up && y > 0)

                y -= 5;

            else if (e.KeyCode == Keys.Down && y < this.Height - pBall.Height * 1.5)

                y += 5;

            pBall.Location = new Point(x, y);


            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
