using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ConsoleApp2
{
    public class Oyuncu
    {
        public int no;
        public string isim;
        //K- Kadın, E- Erkek
        public char cinsiyet;

        //Yapıcı (Constructor) Fonksiyon

        //Default Constructor (Varsayılan Yapıcı)
        public Oyuncu()
        {
            no = 0;
            isim = "Tanımsız";
            cinsiyet = '?';
        }
        //Parameterized Constructor (Parametrelendirilmiş Yapıcı)
        public Oyuncu(int numara,string isim,char cinsiyet)
        {
            this.no = numara;
            this.isim = isim;
            this.cinsiyet = cinsiyet;
        }

        public void SetOyuncu(int no,string isim,char cinsiyet)
        {
            this.no = no;
            this.isim = isim;
            this.cinsiyet = cinsiyet;
        }
        public string GetOyuncu()
        {
            return String.Format("No:{0} İsim:{1} Cinsiyet:{2}", no, isim, cinsiyet);
        }
    }
}
