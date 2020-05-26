using System;

namespace ConsoleAppHafta4_2
{
    class Personel
    {
        public int maas;
        public int yas;
        public string gorev;
        public string cinsiyet;
        public int girisyili;
        public int cikisyili;
        public bool calismadurumu;

        


    }
    class Idaripersonel : Personel
    {
          public string calismasaatleri; 
    }
    class AkademikPersonel : Personel
    {
        public string unvan;
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Varsayılan Yapıcı Metot(Default Constructors)
        }
    }
}
