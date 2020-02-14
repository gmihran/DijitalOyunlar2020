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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form ilk açıldığında bu olay gerçekleşir
            txtSonuc.Enabled = false;
            //Enabled = true ise nesne aktiftir.
            //Yani kullanıcı içerisine değer girebilir.
            txtSayi1.BackColor = Color.Red;
            txtSayi2.BackColor = Color.Red;

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {

            //txtSonuc.Text =  txtSayi1.Text + txtSayi2.Text;
            //Bu değerleri (string) yan yana toplar   
            int sayi1, sayi2;
            try
            {
                sayi1 = Convert.ToInt16(txtSayi1.Text);
                sayi2 = Convert.ToInt16(txtSayi2.Text);
                //txtSonuc.Text = (sayi1 + sayi2).ToString();
                txtSonuc.Text = Convert.ToString(sayi1 + sayi2);
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı giriş yaptınız.", "Hatalı giriş");

                
            }
            
        }
       
        
        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (txtSayi1.Text == string.Empty || txtSayi2.Text == string.Empty)
                MessageBox.Show("Değerleri giriniz.");
            else
            {
                
                int sayi1 = Convert.ToInt16(txtSayi1.Text);
                int sayi2 = Convert.ToInt16(txtSayi2.Text);
                if (radioTopla.Checked)
                    txtSonuc.Text = (sayi1 + sayi2).ToString();
                else if (radioCarp.Checked)
                    txtSonuc.Text = (sayi1 * sayi2).ToString();
                else if (radioCikar.Checked)
                    txtSonuc.Text = (sayi1 - sayi2).ToString();
                else if (radioBol.Checked)
                {
                    try
                    {

                        txtSonuc.Text = (Convert.ToInt16(txtSayi1.Text) / Convert.ToInt16(txtSayi2.Text)) .ToString();
                    }
                    catch (DivideByZeroException)
                    {

                        MessageBox.Show("Sıfıra bölme hatası oluştu");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hata oluştu");
                    }
               
                }
                   
            }
            
        }

        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {
            if (txtSayi1.Text == string.Empty)
                txtSayi1.BackColor = Color.Red;
            else
                txtSayi1.BackColor = Color.White;
        }

        private void txtSayi2_TextChanged(object sender, EventArgs e)
        {
            if (txtSayi2.Text == string.Empty)
                txtSayi2.BackColor = Color.Red;
            else
                txtSayi2.BackColor = Color.White;
        }

        
    }
}
