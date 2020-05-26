using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1, sayi2;
            sayi1 = 1;
            Console.WriteLine(sayi1);
            sayi2 = 2;
            Console.WriteLine(sayi2);
            //Bu iki sayının toplamını yazdıralım
            Console.WriteLine(sayi1 + sayi2);
            Console.WriteLine("Toplam:" + sayi1 + sayi2);
            //sayi1 ve sayi2 değerlerini yan yana toplar
            //Matematiksel toplama işlemi yapmaz
            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            //Önce sayıları toplar, sonra toplamı yazdırır

            string kelime = "Merhaba";
            Console.WriteLine("Kelime:" + kelime);



            /*
             * Kullanıcının girdiği 2 sayının toplamını yazdıralım
             */
            
            Console.Write("1.Sayı..:");
            sayi1=Convert.ToInt16(Console.ReadLine());
            //Console'dan okunan değerler string olarak saklanır
            //int değere atama yaparken mutlaka convert etmemiz gerekir
            Console.Write("2.Sayı..:");
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Toplam:" + (sayi1 + sayi2));
            
            /*
             * Klavyeden girilen sayı tek ise sayının karesini,
             * çift ise küpünü ekrana yazdıralım
             */
            int sayi;
            /*
            Console.Write("Sayı..:");
            sayi = Convert.ToInt16(Console.ReadLine());
            if (sayi % 2 == 0)
                Console.WriteLine(Math.Pow(sayi, 3));
            else
                Console.WriteLine(Math.Pow(sayi, 2));
                */

            string isim;
            
            Console.Write("İsminiz...:");
            isim = Console.ReadLine();
            Console.WriteLine("Hoşgeldin " + isim);
            Console.WriteLine("İsminiz " + isim[0] + " harfiyle başlıyor");
            Console.WriteLine("İsminiz " + isim[isim.Length-1] + " harfiyle bitiyor");
            
            /*
             * Kullanıcının girdiği kelimenin uzunluğuna göre;
             * 10 ve üzeri ise "Kelime çok uzun"
             * 5 ile 9 arasında ise "Kelime orta uzunlukta"
             * 5 altında ise "Kelime çok kısa" çıktısı verelim
             */
            int uzunluk;
            
            uzunluk = isim.Length;
            if (uzunluk>=10)
                Console.WriteLine("Kelime çok uzun");
            else if (uzunluk>=5)
                Console.WriteLine("Kelime orta uzunlukta");
            else
                Console.WriteLine("Kelime çok kısa");
            Console.WriteLine("Uzunluk:" + uzunluk);
           
            //Console ekranını bir tuşa basılıncaya
            //kadar bekletir.

            /*
             * Sayının 2,5 ve 10'a bölünebilme durumlarını yazdıralım
             * Çıktılar aşağıdaki gibi olmalıdır:
             * 2'ye bölünebilir
             * 5'e bölünebilir
             * 10'a bölünebilir
             * 2,5 ve 10'a bölünemez
             */
             
            Console.Write("Sayı..:");
            sayi =Convert.ToInt16(Console.ReadLine());
            if (sayi%10==0)
                Console.WriteLine("10'a bölünebilir");
            else if (sayi%2==0)
                Console.WriteLine("2'ye bölünebilir");
            else if (sayi%5==0)
                Console.WriteLine("5'e bölünebilir");
            else
                Console.WriteLine("2'ye, 5'e ve 10'a bölünemez");
                
            //Soru: bölünür mü demeliyiz bölünebilir mi :)
            //bölünebilir = istersen bölebilirsin (keyfine kalmış:)
            //bölünebilir = başka sayılara da bölünebilir

            /* 
            * 1 ile 10 arasındaki sayıları tab boşluğu bırakarak
            * yan yana ekrana yazdıralım
            */
            int i;
            for (i = 1 ; i <= 10; i++)
                Console.Write(i + "\t");
            Console.WriteLine();

            /* 
             * 1 ile 10 arasındaki tek sayıları tab boşluğu bırakarak
             * yan yana ekrana yazdıralım
             */

            //1.Yöntem:
            for (i = 1; i <= 10; i++)
                if (i % 2 == 1)
                    Console.Write(i + "\t");
            Console.WriteLine();

            //2.Yöntem:
            for (i = 1; i <= 10; i+=2)
                 Console.Write(i + "\t");
            Console.WriteLine();

            /* 
             * 1 ile 10 arasındaki çift sayıları tab boşluğu bırakarak
             * yan yana ekrana yazdıralım
             */
            //1.Yöntem:
            for (i = 1; i <= 10; i++)
                if (i % 2 == 0)
                    Console.Write(i + "\t");
            Console.WriteLine();

            //2.Yöntem:
            for (i = 2; i <= 10; i += 2)
                Console.Write(i + "\t");
            Console.WriteLine();

            /*
             * Kullanıcının girdiği 5 değerin toplamını yazdıralım
             */
            int toplam=0;
            for (i = 1; i < 6; i++){
                Console.Write("Sayı..:");
                sayi = Convert.ToInt16(Console.ReadLine());
                toplam += sayi; //toplam = toplam + sayi;
                //toplam += Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Toplam:" + toplam);

            //Kısayol: cw yazıp tab tuşuna basarak 
            //Console.WriteLine() kodunu getirebiliriz

            /*
             * Kullanıcının girdiği 5 değerin toplamını ve 
             * tek sayıların, çift sayıların toplamını yazdıralım
             */
            toplam = 0;
            int tektoplam = 0, cifttoplam = 0;
            for (i = 1; i < 6; i++)
            {
                Console.Write("Sayı..:");
                sayi = Convert.ToInt16(Console.ReadLine());
                toplam += sayi; //toplam = toplam + sayi;
                if (sayi % 2 == 0)
                    cifttoplam += sayi;
                else
                    tektoplam += sayi;
            }
            Console.WriteLine("Toplam:" + toplam);
            Console.WriteLine("Tek Toplam:" + tektoplam);
            Console.WriteLine("Çift Toplam:" + cifttoplam);


            Console.ReadKey();
        }
    }
}
