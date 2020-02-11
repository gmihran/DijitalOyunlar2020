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
             
            int genislik, yukseklik, alan, cevre;
            
        git:
            try
            {
                Console.Write("Genişlik:");
                genislik = int.Parse(Console.ReadLine());
                //Console ekranından okunan değerler (kullanıcı tarafından girişi yapılan
                Console.Write("Yükseklik:");
                yukseklik = Convert.ToUInt16(Console.ReadLine());
                //Unsigned = İşaretsiz  (Sadece pozitif sayıları içerir, Negatif sayılar içermez)
                //Signed = İşaretli (Hem pozitif, hem de negatif sayıları tutabilir)
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
           
            
            /*
             * Kullanıcıdan alınan yarıçap (r) değeri ile
             * dairenin alanını ve çevresini hesaplayıp ekrana yazdıran program
             * pi = 3.14 (sabit->const olarak tanımlanacak)
             * Alan = pi * r * r
             * Çevre = 2 * pi * r
             */
            int r;
            const double PI = 3.14;
            //const - sabitler : Program içerisinde bu değişkenin içinde saklanan değer değiştirilemez
            
            Console.Write("Yarıçap:");
            r = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Alan:" + PI * r * r);
            Console.WriteLine("Çevre:" + 2 * PI * r);
            
            /*
             * Denetim Masası -> Tarih ve saat -> Bölgesel ayarlar
             * Seçenekleri ile digit ve ondalık ayracı değiştirebiliriz
             * Türkiye'de digit için . (nokta), ondalık için , (virgül) kullanılırken İngiltere ve Amerika gibi ülkelerde tam tersi tercih edilmektedir. Bu durum yazılımda büyük sorunlara yol açabilmektedir.
             * Örneğin sayı değerini parçalama işleminde biz , (virgül) ile ayırma yapmak durumundayız, ama yurtdışında bu parçalama işlemi bu haliyle çalışmamaktadır. Bu da büyük problemlere yol açabilir
             */

            /*
             * Rastgele üretilen 10 adet sayıyı dizide saklayalım
             * 10 sayı içerisinde saklanan sayılar tekrar edemez
             * Sayı aralığı 1 ile 100 arasındadır
             * Kullanıcının 5 hakkı var
             * 1.tahminde bilirse 10 puan, 2.tahminde 9 puan... her tahmininde kazanabileceği puan 1 azalsın 
             * 5 tahminde bilemezse 3 puan kıralım
             * Oyun bitiminde tekrar oynamak ister misiniz diye soralım
             */
            int [] sayilar = new int[10];
            char oyun;
            int i,j,tahmin,puan,hak,skor=0;
            bool kontrol;
            var rand = new Random();
        devam:
            for (i = 0; i < 10; i++)
            {
                
            sayi:
                sayilar[i] = rand.Next(1, 101);
                for (j = 0; j < i; j++)
                {
                    if (sayilar[i] == sayilar[j])
                    {
                        goto sayi;
                    }
                }
                Console.Write(sayilar[i] + "\t");
            }
            hak = 5;
            puan = 10;
            kontrol = false;
            Console.WriteLine();
            do
            {
                Console.Write("Tahmininiz:");
                tahmin = Convert.ToUInt16(Console.ReadLine());
                
                
                for (i = 0; i < 10; i++)
                {
                    
                    if (tahmin == sayilar[i])
                    {
                        skor += puan;
                        kontrol = true;
                        break;
                    }

                }
                puan -= 1;
                hak -= 1;
            } while (hak>0 && kontrol==false);
            if (!kontrol) // if (kontrol==false)
                skor -= 3;
            Console.WriteLine("Skor:" + skor);
        tekrar:
            Console.Write("Tekrar oynamak ister misiniz? E/H:");
            oyun = Convert.ToChar(Console.ReadLine());
            if (oyun == 'E') //char değişkenlerin içerisindeki değerler '' ile atanır ya da karşılaştırılır
                             //string değişkenlerin içerisindeki değerler "" ile atanır ya da karşılaştırılır

                goto devam;
            else if (oyun == 'H')
                Console.WriteLine("Oyun sona erdi");
            else
            {
                Console.WriteLine("Hatalı giriş");
                goto tekrar;
            }

            //NOT: Aşağıdaki soruları derste çözmedik, çözümlerini inceleyiniz.

            /*
             * Girilen iki sayıdan büyük olanı bulan programı yazınız.
             */
            /*
           int sayi1, sayi2, bsayi=0;
           bool kontrol=false;
           Console.Write("1.sayı:");
           sayi1 = Int16.Parse(Console.ReadLine());
           Console.Write("2.sayı:");
           sayi2 = Convert.ToInt16(Console.ReadLine());
           if (sayi1 > sayi2)
               bsayi = sayi1;
           else if (sayi2 > sayi1)
               bsayi = sayi2;
           else
               kontrol = true;
           if (!kontrol)
               Console.WriteLine("Büyük sayı="+bsayi);
           else
               Console.WriteLine("Sayılar birbirine eşittir.");
           Console.ReadKey();
           */

            /*
             * 1'den girilen sayıya kadar olan sayıları ekrana yazdıralım
             */
            /*
          
            int sayi,i;
            Console.Write("Sayı:");
            sayi = Convert.ToInt16(Console.ReadLine());
            for(i=1;i<=sayi;i++)
            {
                Console.Write(i + "\n");
            }
            Console.ReadKey();
            */

            /*
             * 1'den girilen sayıya kadar olan sayıları ekrana yazdıralım
             * Sayı negatifse sayıdan 1'e kadar,
             * Sayı pozitifse 1'den sayıya kadar yazdıracak
             * Sayı sıfıra eşitse "geçersiz sayı" yazdıracak 
             * -5 girerse;
             * -5 -4 -3 -2 -1 0 1
             * 5 girerse;
             * 1 2 3 4 5
             */
            /*
           int sayi,i;
           Console.Write("Sayi:");
           sayi=Convert.ToInt16(Console.ReadLine());
           if (sayi > 0)
               for (i = 1; i <= sayi; i++)
                   Console.WriteLine(i);
           else if (sayi < 0)
               for (i = sayi; i <= 1; i++)
                   Console.WriteLine(i);
           else
               Console.WriteLine("geçersiz sayı");
           Console.ReadKey();
           */


            /*Girilen 5 sayıdan pozitif ve negatif olanların
             * toplamını ekrana yazdıralım
             */
            /*
           int sayi,ptoplam=0,ntoplam=0;
            for (int i=1;i<=5;i++)
           {
               Console.Write(i + ".Sayı:");
               sayi = Convert.ToInt16(Console.ReadLine());
               if (sayi > 0)
                   ptoplam += sayi; //ptoplam=ptoplam+sayi;
               else if(sayi<0)
                   ntoplam += sayi; //ntoplam=ntoplam+sayi;
           }
           Console.WriteLine("Pozitif Toplam=" + ptoplam);
           Console.WriteLine("Negatif Toplam=" + ntoplam);
           Console.ReadKey();
           */
            /*Rastgele üretilen 5 sayıdan pozitif ve negatif olanların
            * toplamını ekrana yazdıralım
            * Sayı aralığı -100 ile 100 arasında
            */
            /*
            int rastgele, pt = 0, nt = 0;
            Random rnd = new Random();
            for (int i = 1; i <= 5; i++) 
            {
                rastgele = rnd.Next()%201-100;
                //başladığı değeri -100
                //bittiği değer 201-100-1=100
                Console.WriteLine(rastgele);
                if (rastgele > 0)
                    pt += rastgele;
                else if (rastgele < 0)
                    nt += rastgele;
            }
            Console.WriteLine("Pozitif Toplam=" + pt);
            Console.WriteLine("Negatif Toplam=" + nt);
            Console.ReadKey();
            */

            /*1 ile 10 arasındaki değerleri diziye aktarıp
             * dizinin değerlerini ekrana yazdıralım*/

            /*
            int[] sayilar = new int[10];
            int i;
            for (i = 0; i <= 9; i++) 
            {
                sayilar[i] = i+1;
                //i döngüsü 0 değerinden başladığı için 
                //i+1 olarak yazdık
            }
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadKey();
            */

            /*Klavyeden girilen 5 değeri diziye aktaralım
             * Bu 5 değerden asal olanları ekrana yazdıralım             
             */

            /*
            int[] sayilar = new int[5];
            bool[] durumlar = new bool[5];
            //Asal ise durumlar=True 
            //Asal Değil ise durumlar=False
            int i,j;
            for(i=0;i<=4;i++)
            {
                Console.Write(i + 1 + ".sayı:");
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
                durumlar[i] = true;
                if (sayilar[i] <= 1)
                    durumlar[i] = false;
                else
                    for (j=2;j<sayilar[i];j++)
                    {
                        if (sayilar[i] % j == 0)
                        {
                            durumlar[i] = false;
                            break;
                        }
                        
                    }
            }
            for (i=0;i<=4;i++)
            {
                Console.Write(sayilar[i] + "->" );
                if (durumlar[i])
                    Console.WriteLine("Asal");
                else
                    Console.WriteLine("Asal Değil");
            }
            Console.ReadKey();
            */

            /*Girilen 5 sayıdan pozitif ve negatif olanları
             * diziye aktarıp ekrana yazdıralım
             */

            /*
            int[] pozitif = new int[5];
            int[] negatif = new int[5];
            int sayi,psayac=0,nsayac=0,i;
            for (i=1;i<=5;i++)
            {
                Console.Write("Sayı:");
                sayi = Convert.ToInt16(Console.ReadLine());
                if (sayi>0)
                {
                    pozitif[psayac] = sayi;
                    psayac ++;
                }
                else if(sayi<0)
                {
                    negatif[nsayac] = sayi;
                    nsayac++;
                }
            }
            Console.WriteLine("Pozitif Sayılar:");
            for (i = 0; i < psayac; i++)
                Console.WriteLine(pozitif[i]);
            Console.WriteLine("Negatif Sayılar:");
            for (i = 0; i < nsayac; i++)
                Console.WriteLine(negatif[i]);

            Console.ReadKey();
            */


            
            //Çalışma Ödevi: Aşağıdaki soruyu çözünüz.
            /*
             * Klavyeden sıfır değeri girilene kadar kullanıcıdan sayı istenecek.
             * Eğer kullanıcı pozitif bir sayı girerse; 
             * 1 ile girilen bu sayı arasındaki sayıların toplamını ekrana yazdıracak.
             * Eğer kullanıcı negatif bir sayı girerse; 
             * bu sayının karesini ekrana yazdıracak.
             */
            Console.ReadKey();
            //Herhangi bir tuşa basıncaya kadar console ekranını bekletir
        }
    }
}
