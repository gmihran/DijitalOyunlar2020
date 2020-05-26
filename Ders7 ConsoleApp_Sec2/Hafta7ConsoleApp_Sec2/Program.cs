using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta7ConsoleApp_Sec2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc,bas,bit,bolen,s1,s2;
            double s;
            
            toplam();

            sonuc=toplam(5, 6);
            Console.WriteLine("Toplam:"+sonuc);
            
            sonuc = toplam(5, 10, 2);
            Console.WriteLine("Sonuç:"+sonuc);
            
            Console.WriteLine("Aralık değeri giriniz (Baş-Bit):");
            bas = Convert.ToInt16(Console.ReadLine());
            bit = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Bölen değerini giriniz:");
            bolen = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Toplam:"+toplam(bas,bit,bolen));
            
            pozneg();
            

            s=islem(5, 0);
            Console.WriteLine("Sonuç:"+s);

            while (true)
            {
                try
                {
                    Console.WriteLine("İki sayı giriniz:");
                    s1 = Convert.ToInt32(Console.ReadLine());
                    s2 = Convert.ToInt32(Console.ReadLine());
                    s = islem(s1, s2);
                    Console.WriteLine("Sonuç:" + s);
                    break;
                }
                catch (Exception)
                {

                    Console.WriteLine("Hatalı giriş");
                }
            }
            
            
            matris();
            

            Console.ReadKey();
        }

        //Klavyeden girilen iki sayının toplamını ekrana yazdıran fonksiyon
        static void toplam()
        {
            int s1, s2;
            Console.WriteLine("İki sayı giriniz:");
            s1 = Convert.ToInt16(Console.ReadLine());
            s2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Toplam:"+(s1+s2));

        }

        //Fonksiyona gönderilen iki sayının toplamını geri döndüren fonksiyon
        static int toplam(int s1,int s2)
        {
            return s1 + s2;
        }

        //Kendisine gönderilen iki değer arasındaki gönderilen üçüncü değere tam bölünenleri ekrana yazdıran ve toplamlarını geri döndüren fonksiyon
        static int toplam(int bas,int bit,int bolen)
        {
            int sonuc = 0;
            for (int sayi = bas ; sayi <= bit; sayi++)
            {
                if (sayi % bolen == 0)
                {
                    Console.WriteLine(sayi);
                    sonuc += sayi;
                }
            }
            return sonuc;
        }


        //Klavyeden sıfır girilene kadar girilen değerlerden pozitif ve negatif toplamları ekrana yazdıran fonksiyon
        //Do while ile while döngüsü arasındaki fark nedir?
        //İkisi de şart doğru olduğu sürece çalışır. Ama do while döngüsü her zaman en az 1 kere çalışır. Çünkü koşula bakmadan çalışmaya başlar. Döngü sonunda koşula bakar. While döngüsünde döngünün başında koşula bakılır.
        static void pozneg()
        {
            int sayi,poz=0,neg=0;
            Console.WriteLine("Klavyeden 0 girilinceye kadat poz,neg toplam hesaplayalım");
            do
            {
                Console.Write("Sayı:");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 0)
                    poz += sayi; //poz=poz+sayi;
                else if (sayi < 0)
                    neg += sayi; //neg=neg+sayi;
                else
                    Console.WriteLine("Döngü sona eriyor");
            } while (sayi!=0); //şart doğru olduğu sürece while döngüsü çalışır
            Console.WriteLine("Pozitif toplam:"+poz);
            Console.WriteLine("Negatif toplam:"+neg);
        }


        //Kendisine gönderilen değerlere göre klavyeden + girilirse toplama, - girilirse çıkarma, * girilirse çarpma, / girilirse bölme işlemini yapan sonucu geri döndüren fonksiyon
        static double islem(int sayi1,int sayi2)
        {
            char i;
            double sonuc=0;
            Console.WriteLine("+ - * / İşlemi giriniz:");
            i = Convert.ToChar(Console.ReadLine());
            switch (i)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    /*
                    try
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Sıfıra bölme hatası oluştu");
                    }
                    */
                    if (sayi2==0)
                        Console.WriteLine("Tanımsız");
                    else
                        sonuc = Convert.ToDouble(sayi1) / sayi2;
                    break;
                default:
                    break;
            }
            return sonuc;
        }




        //3*4 matrise rastgele 1 ile 10 arasında değer atayarak bu değerleri ekrana yazdıralım
        static void matris()
        {
            int[,] m = new int[3, 4];
            int[,] n = new int[3, 4];
            int[,] t = new int[3, 4];
            //int [,] a = { { 1, 2, 3 }, { 4, 5, 6 } }; //2*3 matris
            Random rnd = new Random();
            Console.WriteLine("m matrisi");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = rnd.Next(1, 11);
                    Console.Write(m[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("n matrisi");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    n[i, j] = rnd.Next(1, 11);
                    Console.Write(n[i, j] + "\t");
                }
                Console.WriteLine();
            }
            t = matristoplam(m, n);
            Console.WriteLine("t matrisi");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }


        //Kendisine gönderilen iki matrisi toplayıp sonucunu geri döndüren fonksiyon
        static int [,] matristoplam(int [,] m,int [,] n)
        {
            int[,] t= new int[3,4];
            Console.WriteLine("t matrisi");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    t[i, j] = m[i, j] + n[i, j];
                    Console.Write(t[i, j] + "\t");
                }
                Console.WriteLine();
            }

            return t;
        }






    }
}
