using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHafta5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru-1: Console'dan alınan 2 değerin aralarında asal olup olmadığının çıktısını veren programı yazınız. Bu programda asal olup olmadıklarını bir fonksiyonda kontrol ediniz.
            
            asal(15, 3);
            asal(5, 6);
            asal(30, 15);
            asal(2, 4);
            asal(1, 3);
            

            //Soru-2: Kullanıcının girdiği sayı sıfır değerine eşit olana kadar girilen değerlerin miktarını,toplamını ve ortalamasını ekrana yazdıralım
            toplam();

            //Soru-3: Kullanıcının girdiği sayı sıfır değerine eşit olana kadar girilen negatif ve pozitif değerlerin miktarını,toplamını ve ortalamasını ekrana yazdıralım
            toplam2();

            //Soru-4: İki boyutlu 2*3 bir matris tanımlayıp içerisine rastgele 1-10 arasında sayı atayıp, yazdıralım. Bu matrisi klavyeden girilen değer ile çarpıp, sonuçları yazdıralım
            matris();

            //Soru-5: Satırlar çarpımı ve sütunlar çarpımını hesaplatıp, en büyük çarpım sonucunu ekrana yazdıralım
            matris2();

            //Soru-6: 3*4 Matriste yer alan değerleri yan yana ve alt alta 2'şer 2'şer çarparak bu değerlerin en büyüğünü bulmaya çalışalım.
            matris3();

            Console.ReadKey();
        }   
        //Soru-1
        public static void asal(int s1,int s2)
        {
            bool kontrol = true; //sayıların aralarında asal olması
            int kucuksayi;
            if (s1 < s2)
                kucuksayi = s1;
            else
                kucuksayi = s2;
            for (int i = 2; i <= kucuksayi; i++)
            {
                if (s1 % i == 0 && s2 % i == 0) { 
                    kontrol = false; ////sayıların aralarında asal olmaması
                    break;
                }
            }
            if (kontrol)
                Console.WriteLine(s1+ " " + s2 + " Sayıları aralarında asaldır");
            else
                Console.WriteLine(s1 + " " + s2 + " Sayıları aralarında asal değildir");
        }

        //Soru-2:Kullanıcının girdiği sayı sıfır değerine eşit olana kadar girilen değerlerin miktarını,toplamını ve ortalamasını ekrana yazdıralım
        public static void toplam()
        {
            int sayi, toplam=0;
            float miktar = 0;
            do
            {
                Console.WriteLine("Sayı:");
                sayi = Convert.ToInt16(Console.ReadLine());
                toplam += sayi;
                miktar++;
            } while (sayi!=0);
            Console.WriteLine("Toplam:" + toplam);
            Console.WriteLine("Miktar:"+miktar);
            Console.WriteLine("Ortalama:"+toplam/miktar);
        }

        //Soru-3: Kullanıcının girdiği sayı sıfır değerine eşit olana kadar girilen negatif ve pozitif değerlerin miktarını,toplamını ve ortalamasını ekrana yazdıralım
        public static void toplam2()
        {
            int[] sayilar=new int[100];
            int ptoplam = 0,ntoplam=0, pmiktar=0, nmiktar=0, miktar = 0;
            do
            {
                Console.WriteLine("Sayı:");
                sayilar[miktar] = Convert.ToInt16(Console.ReadLine());
                miktar++;
            } while (sayilar[miktar-1] != 0);
            for (int i = 0; i < miktar; i++)
            {
                if (sayilar[i] < 0)
                {
                    ntoplam += sayilar[i];
                    nmiktar++;
                }
                else if (sayilar[i]>0)
                {
                    ptoplam += sayilar[i];
                    pmiktar++;
                }
            }
            Console.WriteLine("Pozitif Toplam:" + ptoplam);
            Console.WriteLine("Pozitif Miktar:" + pmiktar);
            try
            {
                Console.WriteLine("Pozitif Ortalama:" + ptoplam / pmiktar);
            }
            catch (Exception)
            {

                Console.WriteLine("Ortalama Hesaplanamıyor.");
            }
            
            Console.WriteLine("Negatif Toplam:" + ntoplam);
            Console.WriteLine("Negatif Miktar:" + nmiktar);
            
            try
            {
                Console.WriteLine("Negatif Ortalama:" + ntoplam / nmiktar);
            }
            catch (Exception)
            {

                Console.WriteLine("Ortalama Hesaplanamıyor.");
            }
        }

        //Soru-4: İki boyutlu 2*3 bir matris tanımlayıp içerisine rastgele 1-10 arasında sayı atayıp, yazdıralım. Bu matrisi klavyeden girilen değer ile çarpıp, sonuçları yazdıralım
        public static void matris()
        {
            int[,] m = new int[2,3];
            int[,] n = new int[2, 3];
            int deger;
            Random rnd = new Random();
            for (int i = 0; i < 2; i++) //satırlar
            {
                for (int j = 0; j < 3; j++) //sütunlar
                {
                    m[i, j] = rnd.Next(1, 11);
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.Write("Çarpım kat değeri:");
            deger = int.Parse(Console.ReadLine());
            for (int i = 0; i < 2; i++) //satırlar
            {
                for (int j = 0; j < 3; j++) //sütunlar
                {
                    n[i, j] = m[i, j] * deger;
                    //Console.Write(m[i, j]*deger + "\t");
                    Console.Write(n[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }

        //Soru-5: Satırlar çarpımı ve sütunlar çarpımını hesaplatıp, en büyük çarpım sonucunu ekrana yazdıralım
        public static void matris2()
        {
            //3*4 matris
            int[,] m = { {1,2,3,4},{3,4,5,6},{5,6,7,8} };
            //int[] satir = new int[3];
            //int[] sutun = new int[4];
            int[] satir = { 1, 1, 1 };
            int[] sutun = { 1, 1, 1, 1 };
            int satirmak = int.MinValue, sutunmak = int.MinValue;
            Console.WriteLine("Satırların çarpımı");
            for (int i = 0; i < 3; i++) //satir
            {

                for (int j = 0; j < 4; j++) //sütun
                {
                    //satırların toplamı
                    satir[i] *= m[i, j];
                }
                Console.WriteLine(satir[i]);
                if (satirmak < satir[i])
                    satirmak = satir[i];
            }
            Console.WriteLine("Sütunların çarpımı");
            for (int i = 0; i < 4; i++) //sütun
            {

                for (int j = 0; j < 3; j++) //satır
                {
                    //sütunların toplamı
                    sutun[i] *= m[j,i];
                }
                Console.WriteLine(sutun[i]);
                if (sutunmak < sutun[i])
                    sutunmak = sutun[i];
            }
            Console.WriteLine("Satırların mak değeri:"+satirmak);
            Console.WriteLine("Sütunların mak değeri:"+sutunmak);
            if (satirmak>sutunmak)
                Console.WriteLine("Matrisin mak değeri:"+satirmak);
            else
                Console.WriteLine("Matrisin mak değeri:"+sutunmak);
        }

        //Soru-6: 3*4 Matriste yer alan değerleri yan yana ve alt alta 2'şer 2'şer çarparak bu değerlerin en büyüğünü bulmaya çalışalım.
        public static void matris3()
        {
            //3 - 4 matris
            int[,] m = { { 1, 2, 3, 4 }, { 3, 4, 5, 6 }, { 5, 6, 7, 8 } };
            //int[] satir = new int[3];
            //int[] sutun = new int[4];
            int a=0;
            int[] satir = { 1, 1, 1, 1, 1, 1, 1, 1 }; //8 çarpım sonucu
            int[] sutun = { 1, 1, 1, 1 ,1, 1, 1, 1, 1}; //9 Çarpım sonu
            int mak = int.MinValue;
            Console.WriteLine("Sütunların çarpımı");
            for (int i = 0; i < 3; i++) //satır
            {
                for (int j = 0; j < 3; j++) //sütun
                {
                    sutun[a++] = m[i, j] * m[i, j + 1];
                    Console.WriteLine(sutun[a - 1]);
                    if (mak < sutun[a - 1])
                        mak = sutun[a - 1];
                }
                
            }
            Console.WriteLine("Satırların çarpımı:");
            a = 0;
            for (int i = 0; i < 4; i++) //sütun
            {
                for (int j = 0; j < 2; j++) //satır
                {
                    
                    satir[a++] = m[j, i] * m[j+1, i];
                    Console.WriteLine(satir[a - 1]);
                    if (mak < satir[a - 1])
                        mak = satir[a - 1];
                }
                

            }
            Console.WriteLine("Matristeki mak değer:"+mak);
        }
    }
}
