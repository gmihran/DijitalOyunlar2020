using System;

namespace Hafta2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * Kullanıcıdan alınan genişlik ve yükseklik değerleri ile;
            * dikdörtgenin alanını ve çevresini hesaplayıp ekrana yazdıran program
            * Alan = Genişlik * Yükseklik
            * Çevre = 2 * (Genişlik + Yükseklik)
            */
            /*
            int genislik, yukseklik, alan, cevre;
        git:
            try
            {
                Console.Write("Genişlik:");
                genislik = int.Parse(Console.ReadLine());
                Console.Write("Yükseklik:");
                yukseklik = Convert.ToUInt16(Console.ReadLine());
                //unsigned(işaretsiz) = Sadece pozitif değer alabilir, negatif değer alamaz
                //signed(işaretli) = hem pozitif, hem de negatif değer alabilir
                alan = genislik * yukseklik;
                cevre = 2 * (genislik + yukseklik);
                Console.WriteLine("Alan:" + alan);
                Console.WriteLine("Çevre:" + cevre);
            }
            catch (Exception)
            {
                Console.WriteLine("Hatalı giriş");
                goto git;
            }
            */


            /*
             * Kullanıcıdan alınan yarıçap (r) değeri ile
             * dairenin alanını ve çevresini hesaplayıp ekrana yazdıran program
             * pi = 3.14 (sabit->const olarak tanımlanacak)
             * Alan = pi * r * r
             * Çevre = 2 * pi * r
             */
             /*
            double r;
            const double PI = 3.14;
            //const - sabit olarak tanımlanan değişkenlerin içerisindeki tutulan değerler değiştirilemez
            Console.Write("Yarıçap:");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alan:" + PI * r * r);
            Console.WriteLine("Çevre:" + 2 * PI * r);
            */
            /*
             * Denetim Masası -> Tarih ve saat -> Bölgesel ayarlar
             * Seçenekleri ile digit ve ondalık ayracı değiştirebiliriz
             * Türkiye'de digit için . (nokta), ondalık için , (virgül) kullanılırken İngiltere ve Amerika gibi ülkelerde tam tersi tercih edilmektedir. Bu durum yazılımda büyük sorunlara yol açabilmektedir.
             * Örneğin sayı değerini parçalama işleminde biz , (virgül) ile ayırma yapmak durumundayız, ama yurtdışında bu parçalama işlemi bu haliyle çalışmamaktadır. Bu da büyük problemlere yol açabilir
             */

            /*
             * Oyunun amacı rastgele üretilen 10 sayı arasından 1 sayıyı bilebilmek
             * Rastgele üretilen 10 adet sayıyı dizide saklayalım
             * 10 sayı içerisinde saklanan sayılar tekrar edemez
             * Sayı aralığı 1 ile 100 arasındadır
             * Kullanıcının 5 hakkı var
             * 1.tahminde bilirse 10 puan, 2.tahminde 9 puan... her tahmininde kazanabileceği puan 1 azalsın 
             * 5 tahminde bilemezse 3 puan kıralım
             * Oyun bitiminde tekrar oynamak ister misiniz diye soralım
             */
            int[] sayilar=new int[10];
            int i, tahmin, hak, puan, skor=0;
            char durum;
            Random rand = new Random();
            bool kontrol;
        devam:
            kontrol = false;
            hak = 5;
            puan = 10;
            for (i = 0; i < 10; i++)
            {
            uret:
                sayilar[i] = rand.Next(1,101);
                for (int j = 0; j < i; j++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        goto uret;
                    }
                }
                Console.Write(sayilar[i] + "\t");
            }
            Console.WriteLine();

            do
            {
                Console.Write("Tahmininiz:");
                tahmin = Convert.ToUInt16(Console.ReadLine());
                for (i = 0; i < 10; i++)
                {
                    if (tahmin == sayilar[i])
                    {
                        Console.WriteLine("Tebrikler bildiniz");
                        skor += puan;
                        kontrol = true;
                        break;
                    }
                }
                hak -= 1;
                puan -= 1; //puan--; //--puan;
            } while (hak>0 && kontrol==false);
            if (!kontrol) // (kontrol==false)
                skor -= 3;
            Console.WriteLine("Skor:" + skor);
        tekrar:
            Console.WriteLine("Devam etmek istiyor musunuz? E/H:");
            durum = Convert.ToChar(Console.ReadLine());
            if (durum == 'E')
                //Eğer değişken char ise atama ve karşılaştırma işlemlerinde '', eğer değişken string ise atama ve karşılaştırma işlemlerinde "" kullanırız.
                goto devam;
            else if (durum=='H')
                Console.WriteLine("Oyun sona erdi");
            else
            {
                Console.WriteLine("Hatalı giriş");
                goto tekrar;
            }
                
            Console.ReadKey();
            //Klavyeden herhangi bir tuşa basıncaya kadar console ekranını beklet

        }
    }
}
