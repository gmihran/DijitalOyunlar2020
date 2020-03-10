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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int mouseX, mouseY,x,y;
        private void Form5_MouseMove(object sender, MouseEventArgs e)
        {
            x = pBall.Location.X;
            y = pBall.Location.Y;
            mouseX = e.X;
            mouseY = e.Y;
        }
        Point ilkkonum;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (mouseX > x) //mouse nesnenin daha sağında ise çalışır
                pBall.Left += 5; //sağa doğru gider
            if (mouseX < x) //mouse nesnenin daha solunda ise çalışır
                pBall.Left -= 5; //sola doğru gider
            if (mouseY > y) //mouse nesnenin daha aşağısında ise çalışır
                pBall.Top += 5;  //aşağı doğru gider
            if (mouseY < y) //mouse nesnenin daha yukarısında ise çalışır
                pBall.Top -= 5;  //yukarı doğru gider
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            ilkkonum = pBall.Location;
            timer1.Start();
        }
    }
}
