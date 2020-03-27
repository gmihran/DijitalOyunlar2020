using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ConsoleApp2
{
    class Bronz : Oyuncu
    {
        //Ensapsulation
        public string _rozet;
        
        public Bronz()
        {
            _rozet = "Bronz";
        }
        //Encapsulate işleminde prop yazıp tab tuşuna bastığınızda get ve set ile size mevcut yapıyı getirecektir.
        //get fonksiyonu değişken okunduğunda, set fonksiyonu değişken değiştiğinde çalışan fonskiyonlardır.
        //get değeri görüntülemek, set değeri değiştirmek anlamına gelir
        //Burada kullanıcının değeri değiştirememesi için önlem aldık
        //Bu değerin Bronz değeri dışında değer alamamasını sağladık, yani değeri encapsulate etmiş olduk.
        //Encapsulate işlemi Class'ın bazı değişkenlerini dışarıdan korumak, bazılarını ise dışarıya açmak için kullanılan bir özelliktir.
        public string rozet { 
            get { return _rozet;  } 
            set { _rozet = "Bronz"; }
            //rozet değeri kesinlikle Bronz dışında bir değere sahip olamaz. Kullanıcı bu değeri değiştiremez.
            //set { _rozet = value; }  //value kullanıcının girdiği değer demek oluyor
            //Yani bu durumda kullanıcı değere müdahale edebilir
        }
        public string GetProperties()
        {
            return String.Format("isim:{0} numara:{1} cinsiyet:{2} rozet:{3}", isim, no, cinsiyet, rozet);
        }
    }
}
