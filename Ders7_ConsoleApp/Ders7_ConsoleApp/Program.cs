using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
        /*
        Araştırma:
        1-Diziler ile Listeler arasındaki farklılıklar ve birbirlerine göre avantajları ve dejavantajları nelerdir?
        2-Constructor(Kurucu / Yapıcı) Nedir? Örnekler vererek açıklayınız.
        3-Encapsulate işlemi nedir? Örnekler vererek açıklayınız.

        Kod Geliştirme: 
        1-Dizideki bir elemanı tamamen diziden çıkarabilmek için gerekli olan kod nedir?
        2-Constructor(Kurucu / Yapıcı) oluşturunuz.Tanımladığınız bir Class'tan Inheritance(Kalıtım) yoluyla yeni Class'lar tanımlayarak bu Class'lar üzerinde çeşitli tanımlamalar, fonksiyonlar gerçekleştiriniz. Bu Class'lar üzerinde bir Encapsulate işlemi uygulayınız. 
        Encapsulate işlemine örnek verecek olursak; OyuncuPuan diye bir Class üzerinde bir oyuncunun can ve puan değerlerinin negatif sayı olmaması sağlanabilir.Biz dersteki örneklerde Bronz nesnesi için rozet değerinin Bronz, Gold nesnesi için rozet değerinin Gold değerlerinin dışında bir değer alamamasını sağlamıştık. O örneği de tekrar inceleyebilirsiniz.Encapsulate işleminde prop yazıp tab tuşuna bastığınızda get ve set ile size mevcut yapıyı getirecektir.
        get fonksiyonu değişken okunduğunda, set fonksiyonu değişken değiştiğinde çalışan fonskiyonlardır.
        */
            /* 
             *
             *Diziler Örnek-1
             * 
             */
            int[] sayilar = { 1, 2, 3, 4, 5 , 6};
            //sayilar[0] = 1;
            //sayilar[1] = 2;
            Console.WriteLine("Dizinin uzunluğu:" + sayilar.Length);
            int uzunluk = sayilar.Length;
            Console.WriteLine("Dizinin uzunluğu:" + uzunluk);

            Console.WriteLine("Dizinin elemanları silinmeden önce");
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);
            
            Array.Clear(sayilar, 0, uzunluk); //uzunluk=sayilar.Length
            //Array.Clear(dizi_adı, index_numarası, silinecek_değer_miktarı);
            Console.WriteLine("Dizinin elemanları silindikten sonra");
            for (int i = 0; i < uzunluk; i++)
                Console.WriteLine(sayilar[i]);

            Console.WriteLine("Dizinin uzunluğu:" + sayilar.Length);

            //sayilar[6] = 10;
            //sayilar1[7] = 10; //Kod çalıştırıldığında; System.IndexOutOfRangeException: 'Dizin, dizi sınırlarının dışındaydı.'  hatasıyla karşılaşılır. Girilen index değeri dizi boyutunun (uzunluğunun) index değerleri dışına taşmıştır. Dizi index değeri 0 değerinden başladığı için bu değer maksimum 4 olabilir.

            Array.Resize(ref sayilar, 10);
            sayilar[6] = 10;

            Console.WriteLine(sayilar[6]);
            Console.WriteLine("Dizinin tamamı:");
            for (int i = 0; i < sayilar.Length ; i++)
                Console.WriteLine(sayilar[i]);

            Console.WriteLine("Dizinin uzunluğu:" + sayilar.Length);

            /* 
             *
             *Diziler Örnek-2
             * 
             */
            int[] sayilar2 = new int[] { 3, 14, 15, 92, 6 };
            foreach (int sayi in sayilar2)
            {
                //Console.Write(sayi+" ");
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();
            /* 
             *
             *Diziler Örnek-3
             * 
             */
            
            string[] sehirler1 = { "İstanbul", "Kocaeli", "Ankara", "İzmir", "Sinop", "Bursa" };
            string[] sehirler2 = new string[4];
            string aranan;
            int index;
            sehirler2[0] = "İstanbul";
            sehirler2[1] = "Kocaeli";
            sehirler2[2] = "Ankara";
            sehirler2[3] = "Sinop";
            Console.WriteLine("Şehirlerin Miktarı:" + sehirler1.Length);
            Console.WriteLine("Şehirlerin Miktarı:" + sehirler2.Length);
            aranan = "İstanbul";
            index=Array.IndexOf(sehirler1, aranan); //İstanbul değeri dizinin içerisinde yer aldığı için değerin index numarası dönecektir
            Console.WriteLine($"Şehrin indisi(indexi):{index}");

            aranan = "Sinop";
            index = Array.IndexOf(sehirler1, aranan);
            Console.WriteLine($"{aranan} şehrinin indisi:{index}");

            aranan = "Muğla";
            index = Array.IndexOf(sehirler1, aranan); //Muğla değeri dizinin içerisinde yer almadığı için -1 değeri dönmüştür
            Console.WriteLine($"{aranan} şehrinin indisi:{index}"); //-1 değeri döndü

            if (index==-1)
                Console.WriteLine($"{aranan} şehri bulunamadı");
            else
                Console.WriteLine($"{aranan} şehri bulundu. Şehrin indisi:{index}");

            aranan = "Ankara";
            index = Array.IndexOf(sehirler1, aranan); 
            if (index == -1)
                Console.WriteLine($"{aranan} şehri bulunamadı");
            else
                Console.WriteLine($"{aranan} şehri bulundu. Şehrin indisi:{index}");

            Console.WriteLine("{0} şehrinin indisi:{1}",aranan,index);

            /* 
             *
             *Diziler Örnek-4
             * 
             */
            int[] sayilar4 = new int[] { 5, 10, 2, 7, 25, 140, 27, 34 ,-5 , 4};

            //Dizideki en büyük değeri bulmanın 1.yolu:
            int mak = sayilar4.Max();

            //Dizideki en küçük değeri bulmanın 1.yolu:
            int min = sayilar4.Min();

            Console.WriteLine($"Mak:{mak} Min:{min}");


            //Dizideki en büyük ve en küçük değeri bulmanın 2.yolu:
            mak = sayilar4[0]; //Dizinin ilk elemanını mak değişkeninde tuttuk
            min = sayilar4[0]; //Dizinin ilk elemanını mak değişkeninde tuttuk
            for (int i = 1;i<sayilar4.Length;i++)
            {
                if (mak < sayilar4[i])
                    mak = sayilar4[i];
                if (min > sayilar4[i])
                    min = sayilar4[i];
            }
            Console.WriteLine($"Mak:{mak} Min:{min}");


            /* 
             *
             *Diziler Örnek-5
             * 
             */
            //Soru: 8 Elemanlı bir diziye 1-20 arasında rastgele sayılar atayalım
            //3'e bölünmeyen sayıların miktarını bulalım
            //5 ile 10 arasındaki sayıların toplamını bulalım
            //10'dan küçük veya eşit, 15'den büyük veya eşit olan sayıların ortalamasını bulalım
            int[] sayilar5 = new int[8];
            Random rnd = new Random();
            int miktar1=0, toplam=0, miktar2=0, toplam2=0;
            for (int i = 0; i < sayilar5.Length; i++)
            {
                sayilar5[i] = rnd.Next(1, 21); //son değerin 1 fazlası yazılır
                Console.Write("{0}\t", sayilar5[i]);
            }
            Console.WriteLine();
            foreach (int sayi in sayilar5)
            {
                //3'e bölünmeyen sayıların miktarını bulalım
                if (sayi % 3 != 0)
                    miktar1++;
                //5 ile 10 arasındaki sayıların toplamını bulalım
                if (sayi >= 5 && sayi <= 10)
                    toplam+=sayi;
                //10'dan küçük veya eşit, 15'den büyük veya eşit olan sayıların ortalamasını bulalım
                //ortalama=toplam/miktar
                if (sayi <= 10 || sayi >= 15)
                {
                    miktar2++;
                    toplam2 += sayi;
                }                  
            }
            Console.WriteLine("3'e tam bölünmeyenlerin miktarı:{0}",miktar1);
            Console.WriteLine("5 ile 10 arasındaki sayıların toplamı:{0}",toplam);
            Console.WriteLine("10'dan küçük veya eşit, 15'den büyük veya eşit olan sayıların ortalaması:{0}",toplam2/miktar2);

            /* 
             *
             *Diziler Örnek-6
             * 
             */
            //Girilen kelimenin harflerini alt alta ve kelimeyi tersten ekrana yazdıralım
            Console.Write("Kelime:");
            string kelime;
            //kelime = Console.ReadLine();
            kelime = "Beykoz";
            //Girilen kelimenin harflerini alt alta ekrana yazdıralım
            Console.WriteLine("1.yöntem:");
            foreach (char harf in kelime) 
            {
                Console.WriteLine(harf);
            }
            Console.WriteLine("2.yöntem:");
            for (int i = 0; i < kelime.Length ; i++)
            {
                Console.WriteLine(kelime[i]);
            }

            //Girilen kelimeyi tersten ekrana yazdıralım
            //Beykoz zokyeB
            for (int i=kelime.Length-1;i>=0;i--)
            {
                Console.Write(kelime[i]);
            }
            Console.WriteLine();
            /* 
             *
             *Listeler Örnek-1
             * 
             */

            List<int> listeler1 = new List<int>();
            listeler1.Add(1); //0.indeks
            listeler1.Add(2); //1.indeks
            listeler1.Add(3); //2.indeks
            listeler1.Add(4); //3.indeks
            listeler1.Add(5); //4.indeks
            listeler1.Add(6); //5.indeks

            uzunluk = listeler1.Count();
            Console.WriteLine("Uzunluk:"+uzunluk);

            foreach (int sayi in listeler1)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();
            Console.WriteLine(listeler1[0]); //1 değeri silindi
            listeler1.Remove(1); //Listedeki ilk gelen 1 değerini siler
            Console.WriteLine(listeler1[0]); //2 değerini 0.indeks olarak çıktı verir

            uzunluk = listeler1.Count();
            Console.WriteLine("Uzunluk:" + uzunluk);
            foreach (int sayi in listeler1)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();
            //2 3 4 5 6 
            listeler1.RemoveAt(0); //Listedeki 0.indeksi siler
            //3 4 5 6
            Console.WriteLine(listeler1[0]); //3 değerini 0.indeks olarak çıktı verir

            uzunluk = listeler1.Count();
            Console.WriteLine("Uzunluk:" + uzunluk);
            foreach (int sayi in listeler1)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();
            //3 4 5 6
            if (listeler1.Contains(6)) //Liste 6 sayısını içeriyorsa True, içermiyorsa False değerini döndürür
                Console.WriteLine("Liste 6 değerini içerir");
            else
                Console.WriteLine("Liste 6 değerini içermez");

            if (listeler1.Contains(1)) //Liste 1 sayısını içeriyorsa True, içermiyorsa False değerini döndürür
                Console.WriteLine("Liste 1 değerini içerir");
            else
                Console.WriteLine("Liste 1 değerini içermez");
            Console.WriteLine();

            

            listeler1.Clear(); //Listenin tüm elemanları silindi

            uzunluk = listeler1.Count();
            Console.WriteLine("Uzunluk:" + uzunluk);
            foreach (int sayi in listeler1)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            Console.Write("Sayı:");
            int sayi1 = Convert.ToInt16(Console.ReadLine());
            listeler1.Add(sayi1);

            uzunluk = listeler1.Count();
            Console.WriteLine("Uzunluk:" + uzunluk);
            foreach (int sayi in listeler1)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();

            Console.Write("Aranan sayı:");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            if (listeler1.Contains(sayi1))
                Console.WriteLine("Sayı bulundu");
            else
                Console.WriteLine("Sayı bulunamadı");
            Console.ReadKey();
        }
    }
}
