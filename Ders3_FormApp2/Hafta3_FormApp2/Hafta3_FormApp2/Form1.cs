using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3_FormApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kelime,k;
        private void buttonOyna_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] kelimeler = { "sevgi", "elma", "armut", "greyfurt", "portakal", "muz", "kivi" };
            kelime = kelimeler[rnd.Next(0, kelimeler.Length)];
            labelKelime.Text = kelime;
            
            for (int i = 0; i < kelime.Length; i++)
            {
                k = k + "_";
            }
            labelKontrol.Text = k;
        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            
        }

        private void textHarf_TextChanged(object sender, EventArgs e)
        {
            textHarf.Text = textHarf.Text.ToLower();
            textHarf.SelectionStart = textHarf.Text.Length;
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textHarf.Select();
        }
    }
}
