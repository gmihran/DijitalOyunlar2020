using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ConsoleApp2
{
    //Inheritance(Kalıtım)
    class Gold : Oyuncu
    {
        //Ensapsulation
        public string _rozet;

        public Gold()
        {
            _rozet = "Gold";
        }
        //Encapsulate işleminde prop yazıp tab tuşuna bastığınızda get ve set ile size mevcut yapıyı getirecektir.
        //get fonksiyonu değişken okunduğunda, set fonksiyonu değişken değiştiğinde çalışan fonskiyonlardır.
        //get değeri görüntülemek, set değeri değiştirmek anlamına gelir
        //Burada kullanıcının değeri değiştirememesi için önlem aldık
        //Bu değerin Gold değeri dışında değer alamamasını sağladık, yani değeri encapsulate etmiş olduk.
        //Encapsulate işlemi Class'ın bazı değişkenlerini dışarıdan korumak, bazılarını ise dışarıya açmak için kullanılan bir özelliktir.
        public string rozet
        {
            get { return _rozet; }
            set { _rozet = "Gold"; }
        }
        public string GetProperties()
        {
            return String.Format("isim:{0} numara:{1} cinsiyet:{2} rozet:{3}", isim, no, cinsiyet, rozet);
        }
        public string GetOyuncuProperties()
        {
            string OyuncuProperties = base.GetOyuncu(); //Gold nesnesinin türediği class'taki GetOyuncu fonksiyonunu çağırdık. this demek bu class, base bunun türediği sınıf demektir. 
            string GoldProperties = String.Format(" Rozet:{0}", rozet);
            return OyuncuProperties + GoldProperties;
        }
    }
}
