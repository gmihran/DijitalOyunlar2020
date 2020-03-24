using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            toplam();

            int sonuc, s1, s2;
            double sonuc2;
            sonuc=toplam(5, 6);
            Console.WriteLine("Toplam:"+sonuc);

            sonuc=yazdir(10, 25, 5);
            Console.WriteLine("Toplamlar:"+sonuc);

            pozneg();

            sonuc2 = islem(5, 0);
            Console.WriteLine("İşlem sonucu:"+sonuc2);
            
            while (true)
            {
                Console.WriteLine("\nİki değer giriniz:");
                try
                {
                    s1 = Convert.ToInt32(Console.ReadLine());
                    s2 = Convert.ToInt32(Console.ReadLine());
                    sonuc2 = islem(s1, s2);
                    Console.WriteLine("Sonuc:"+sonuc2);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı giriş");
                }
                catch (Exception)
                {
                    Console.WriteLine("Bilinmeyen bir hata oluştu");
                }
            }
            
            matris();

            Console.ReadKey();
        }
        //Klavyeden girilen iki sayının toplamını ekrana yazdıran fonksiyon
        static void toplam()
        {
            int sayi1, sayi2;
            Console.WriteLine("İki sayı giriniz:");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplamlar:"+(sayi1+sayi2));
        }

        //Fonksiyona gönderilen iki sayının toplamını geri döndüren fonksiyon
        static int toplam(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        //Kendisine gönderilen iki değer arasındaki gönderilen üçüncü değere tam bölünenleri ekrana yazdıran ve toplamlarını geri döndüren fonksiyon
        static int yazdir(int bas,int bit,int bolen)
        {
            int toplam = 0;
            for (int deger = bas; deger <= bit; deger++)
            {
                if (deger%bolen==0)
                {
                    Console.WriteLine(deger);
                    toplam += deger;
                }
            }
            return toplam;
        }

        //Klavyeden sıfır girilene kadar girilen değerlerden pozitif ve negatif toplamları ekrana yazdıran fonksiyon
        //Do while ile while döngüsü arasındaki fark nedir?
        //İkisi de şart doğru olduğu sürece çalışır. Ama do while döngüsü her zaman en az 1 kere çalışır. Çünkü koşula bakmadan çalışmaya başlar. Döngü sonunda koşula bakar. While döngüsünde döngünün başında koşula bakılır.
        static void pozneg()
        {
            Console.WriteLine("\nKlavyeden 0 değerini girine kadar döngü devam edecektir.");
            int sayi,negtoplam=0,poztoplam=0;
            do
            {
                Console.Write("Sayı:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                    poztoplam += sayi;
                else if (sayi < 0)
                    negtoplam += sayi;
                else //sayi==0 ise else yapısı çalışır
                    Console.WriteLine("Döngü sona eriyor");
            } while (sayi!=0); //şart doğru olduğu sürece çalışır.
            Console.WriteLine("Pozitif toplam:"+poztoplam);
            Console.WriteLine("Negatif toplam:"+negtoplam);
        }

        //Kendisine gönderilen değerlere göre klavyeden + girilirse toplama, - girilirse çıkarma, * girilirse çarpma, / girilirse bölme işlemini yapan sonucu geri döndüren fonksiyon
        static double islem(int s1,int s2)
        {
            double sonuc=0;
            char i;
            Console.WriteLine("\n+ - * / işlemini giriniz:");
            i = Convert.ToChar(Console.ReadLine());
            switch (i)
            {
                case '+':
                    sonuc = s1 + s2;
                    break;
                case '-':
                    sonuc = s1 - s2;
                    break;
                case '*':
                    sonuc = s1 * s2;
                    break;
                case '/':
                    if (s2 == 0)
                        Console.WriteLine("Tanımsız");
                    else
                        sonuc = Convert.ToDouble(s1) / s2;
                    break;
                default:
                    break;
            }
            return sonuc;
        }

        //3*4 matrise rastgele 1 ile 10 arasında değer atayarak bu değerleri ekrana yazdıralım
        static void matris()
        {
            int[,] m=new int[3,4];
            int[,] n = new int[3, 4];
            int[,] t = new int[3, 4];
            Random rnd = new Random();
            Console.WriteLine("\n m matrisi ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i,j] = rnd.Next(1, 11);
                    //1 ile 10 arasında rastgele sayı üretir
                    //Son değerin 1 fazlasını yazarız.
                    Console.Write(m[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" n matrisi ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    n[i, j] = rnd.Next(1, 11);
                    //1 ile 10 arasında rastgele sayı üretir
                    //Son değerin 1 fazlasını yazarız.
                    Console.Write(n[i, j] + "\t");
                }
                Console.WriteLine();
            }
            t=matristoplam(m, n);
            Console.WriteLine(" t matrisi ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    t[i, j] = m[i, j] + n[i, j];
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        //Kendisine gönderilen iki matrisi toplayıp sonucunu geri döndüren fonksiyon
        static int[,] matristoplam(int[,] m,int[,] n)
        {
            int [,] t = new int[3, 4];
            Console.WriteLine(" t matrisi ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    t[i, j] = m[i, j] + n[i, j];
                    Console.Write(t[i,j] + "\t");
                }
                Console.WriteLine();
            }
            return t;
            
        }

    }
}
