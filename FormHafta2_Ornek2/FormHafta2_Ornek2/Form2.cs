using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormHafta2_Ornek2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sure = 0;
        int puan = 0;
        int sayi1, sayi2, islem, sonuc;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            //1000 = 1 saniye
            //Enabled true olduğu saniyede 1 çalışır.
            labelSure.Text = sure.ToString();
            labelPuan.Text = puan.ToString();
            txtSayi1.Enabled = false;
            txtSayi2.Enabled = false;

        }

        private void buttonBasla_Click(object sender, EventArgs e)
        {
            sure = 0;
            puan = 0;
            labelSure.Text = sure.ToString();
            labelPuan.Text = puan.ToString();
            txtSonuc.Text = string.Empty;
            timer1.Start();
            //timer çalışmaya başladı
            rastgele();
        }

        private void buttonBitir_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sure = 0;
            labelSure.Text = sure.ToString();
            puan = 0;
            labelPuan.Text = puan.ToString();
   
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {


            if (sonuc==Convert.ToInt16(txtSonuc.Text))
            {
                puan += 100;
                txtDurum.BackColor = Color.Green;
            }
            else
            {
                puan -= 50;
                txtDurum.BackColor = Color.Red;
            }
            labelPuan.Text = puan.ToString();
            rastgele();
            //txtSonuc.Clear();
            //txtSonuc.Text = "";
            txtSonuc.Text = string.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure += 1;
            labelSure.Text = sure.ToString();
            if (sure==10)
            {
                timer1.Stop();
                btnIslem.Enabled = false;
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                        item.Text = string.Empty;
                }
            }
        }
        void rastgele()
        {
            Random rnd = new Random();
            sayi1 = rnd.Next(5, 11); //5-10 arasında değer üretir
            sayi2 = rnd.Next(5, 11); //5-10 arasında değer üretir
            islem = rnd.Next(1, 4); //1-3 arasında değer üretir
            txtSayi1.Text = sayi1.ToString();
            txtSayi2.Text = sayi2.ToString();
            
            switch (islem)
            {
                case 1:
                    labelislem.Text = "+";
                    sonuc = sayi1 + sayi2;
                    break;
                case 2:
                    labelislem.Text = "-";
                    sonuc = sayi1 - sayi2;
                    break;
                case 3:
                    labelislem.Text = "*";
                    sonuc = sayi1 * sayi2;
                    break;
                default:
                    break;
            }
        }
    }
}
