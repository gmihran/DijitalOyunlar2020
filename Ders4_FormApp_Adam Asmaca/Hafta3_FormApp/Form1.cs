using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3_FormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtHarf_TextChanged(object sender, EventArgs e)
        {
            TxtHarf.Text =   TxtHarf.Text.ToUpper();

            //Klasik odaklama işlemini yaptık.
            //TxtHarf.Focus();

            //Cursor için başlangıç noktasını metin uzunluğu
            //olarak belirledik, böylece metnin sonunda başlayacak.
            TxtHarf.SelectionStart = TxtHarf.Text.Length;

            //seçili olan alanın uzunluğu 0 olsun. Bu kodu yazmasak da istediğimiz sonucu elde ederiz. Ama seçim işlemlerinde bu kodu kullanabilirsiniz.
            TxtHarf.SelectionLength = 0;



            //https://stackoverflow.com/questions/20423211/setting-cursor-at-the-end-of-any-text-of-a-textbox

     


        }
        private void harf_kontrol()
        {
            string harf = TxtHarf.Text;
            for (int i= 0; i < kelime.Length; i++)
            {
                if (kelime[i] == harf[0])
                {

                }
            }
        }


        string kelime; 
        //public değişken. Bu fonksiyonlar(metotlar) bu değişkene ulaşabilir.

        private void buttonRastgele_Click(object sender, EventArgs e)
        {
            string[] kelimeler = { "Sevgi", "Barış", "Dostluk", "Arkadaşlık", "Şefkat", "Aşk", "Bağlılık" };
            Random rnd = new Random();
            kelime = kelimeler[rnd.Next(0, kelimeler.Length)];
            labelRastK.Text = kelime;

            timer1.Start();
        }
        int sure = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //cevap vermesi için kullanıcının 30 sn'si var
            sure++;
            
            if (sure == 10)
            {
                //Kullanıcı cevap vermemişse yanacak.
                //Fonksiyon tetiklenecek

                sure = 0;
            }
            labelSure.Text = sure.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            //1000 değeri 1 sn'ye karşılık gelir
        }
    }
}
