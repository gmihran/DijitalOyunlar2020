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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text =   textBox1.Text.ToUpper();

            //Klasik odaklama işlemini yaptık.
            //textBox1.Focus();

            //Cursor için başlangıç noktasını metin uzunluğu
            //olarak belirledik, böylece metnin sonunda başlayacak.
            textBox1.SelectionStart = textBox1.Text.Length;

            //seçili olan alanın uzunluğu 0 olsun. Bu kodu yazmasak da istediğimiz sonucu elde ederiz. Ama seçim işlemlerinde bu kodu kullanabilirsiniz.
            textBox1.SelectionLength = 0;

            //https://stackoverflow.com/questions/20423211/setting-cursor-at-the-end-of-any-text-of-a-textbox

            


        }

        private void btnBuyukHarf_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
            string kelime;
            kelime= textBox1.Text.ToUpper();
            labelKelime.Text = kelime;
        }

        private void buttonRastgele_Click(object sender, EventArgs e)
        {
            string[] kelimeler = { "Sevgi", "Barış", "Dostluk", "Arkadaşlık", "Şefkat", "Aşk", "Bağlılık" };
            Random rnd = new Random();
            string kelime = kelimeler[rnd.Next(0, kelimeler.Length)];
            labelRastK.Text = kelime;

        }
    }
}
