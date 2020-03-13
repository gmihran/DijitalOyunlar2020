using System;

namespace Hafta3_ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int deger;
            
            Console.WriteLine("Değer giriniz:");
            deger=Convert.ToInt16(Console.ReadLine());
   
            for (int i = 0; i < deger; i++)
            {
                merhaba_yazdir();
            }
            
            //sayi_oku();
            Console.WriteLine("Büyük sayı(5,6):" + buyuksayi(5, 6));
            Console.WriteLine("Büyük sayı(5,6,7):" + buyuksayi(5,6,7));
            //int [] sayilar = new int[10];
            
            int[] sayilar = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Toplamlar:" + toplam(sayilar));
            degeroku();
            
            int sayi = 100;
            arttir100(sayi);
            Console.WriteLine("Sayı:"+sayi);

            arttir100(ref sayi);
            Console.WriteLine("Sayı:"+sayi);

            int sayi2;
            sayi5(out sayi2);
            Console.WriteLine("Sayı2:" + sayi2);
            kare(2,5,3);

            


            //toplam fonksiyonuna int bir dizi göndermek zorundayız.
            //Console.WriteLine("1..8 toplamları:" + toplam(1, 2, 3, 4, 5, 6, 7, 8)); //hata

            //params ifadesi ile tanımlanan toplama fonksiyonuna bir dizi veya istediğimiz kadar int değeri gönderebiliriz.
            Console.WriteLine("1..8 toplamları:" + toplama(1, 2, 3, 4, 5, 6, 7, 8));

            Console.WriteLine("Toplamlar:" + toplama());

            int[] sayilar2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine("1..5 toplamları:" + toplama(sayilar2));

            Console.WriteLine(ikideger());
            var sonuc = ikideger();
            Console.WriteLine("Toplamları:"+sonuc.Item1);
            Console.WriteLine("Çarpımları:"+sonuc.Item2);

            int[] sonuc2 = new int[2];
            sonuc2 = ikideger2();
            //int[] sonuc2 = ikideger2();
            Console.WriteLine("Toplamları:" + sonuc2[0]);
            Console.WriteLine("Çarpımları:" + sonuc2[1]);

            Console.WriteLine("5!="+faktoriyel(5));
            Console.WriteLine("1!=" + faktoriyel(1));
            faktoriyel_yazdir(-5);
            sayi = 10;
            faktoriyel_yazdir(sayi);

            sayi = -10;
            faktoriyel_yazdir(sayi);

            Console.WriteLine("Toplamlar:"+toplamlari_yazdir(5));

            Console.ReadKey();
        }
        
        

        //Ekrana Merhaba çıktısını veren fonksiyon tanımladık
        static void merhaba_yazdir()
        {
            Console.WriteLine("Merhaba");
        }
        //Klavyeden girilen iki sayıyı değişkene atayan fonksiyon
        static void sayi_oku()
        {
            int sayi1, sayi2;
            Console.WriteLine("İki sayı giriniz..:");
            sayi1 = Convert.ToInt16(Console.ReadLine());
            sayi2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Büyük sayı:"+buyuksayi(sayi1, sayi2)); 
        }

        //Overload (Metotların aşırı yüklenmesi):Aynı isme sahip metotların çağrılması çalışma zamanında metotların imzalarına(method signature) bakılarak yapılır.
        
        //sayi_oku() fonksiyonu ile girilen değerlerin büyük olanını geri döndüren fonksiyon
        static int buyuksayi(int s1, int s2)
        {
            if (s1 > s2)
                return s1;
            else
                return s2;
        }
        static int buyuksayi(int s1, int s2, int s3)
        {
            if (s1 > s2 && s1 > s3)
                return s1;
            else if (s2 > s3)
                return s2;
            else
                return s3;
            
        }
        //buyuk_sayi(int s1, int s2, int s3) fonksiyonundan gelen değerlerden en büyük olanın karesini hesaplayan fonksiyon
        static void kare(int s1, int s2, int s3)
        {
            int sonuc,buyuk;
            if (s1 > s2 && s1 > s3)
            {
                buyuk = s1;
                sonuc = (int)Math.Pow(s1, 2);
            }   
            else if (s2 > s3)
            {
                buyuk = s2;
                sonuc = (int)Math.Pow(s2, 2);
            }
            else
            {
                buyuk = s3;
                sonuc = (int)Math.Pow(s3, 2);
            }
                
            Console.WriteLine(buyuk+ " sayısının karesi:"+sonuc);
        }
        //Kendisine gönderilen int dizisinin içerisinde sayıların toplamını geri döndüren fonksiyon
        static int toplam(int [] sayilar)
        {
            int toplamlar=0;
            foreach (int sayi in sayilar)
            {
                toplamlar += sayi;
            }
            return toplamlar;
        }
        //Kullanıcıdan bir değer isteyelim
        //Bu değer kadar girdiği int değerleri toplam fonksiyonuna gönderelim
        static void degeroku()
        {
            int miktar;
            Console.Write("Kaç sayı giriş yapacaksınız:");
            miktar = Convert.ToInt16(Console.ReadLine());
            int[] sayilar = new int[miktar];
            for (int i = 0; i < miktar; i++)
            {
                sayilar[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Toplamlar:" + toplam(sayilar)); 
        }

        //Kendisine gönderilen değerin 100 fazlasını değerin içine atayan ve ekrana yazdıran fonksiyon 
        //Değişken içerisinde geçici değişiklik olur. (Copy Value)
        static void arttir100(int sayi)
        {
            sayi += 100;
            Console.WriteLine("arttir100:"+sayi);
        }

        //Kendisine gönderilen değerin 100 fazlasını değerin içine atayan ve ekrana yazdıran fonksiyon
        //Değişken içerisinde kalıcı değişiklik olur. (Referans Value)
        //Kendisine gönderilen değerin içerisine bir değer atanması zorunludur.
        static void arttir100(ref int sayi)
        {
            sayi += 100;
            Console.WriteLine("ref arttir100:"+sayi);
        }

        //Kendisine gönderilen değerin 100 fazlasını değerin içine atayan ve ekrana yazdıran fonksiyon
        //Değişken içerisinde kalıcı değişiklik olur. (Referans Value)
        //Kendisine gönderilen değerin içerisine herhangi bir değer atanmamış olabilir.
        static void sayi5(out int sayi)
        {
            sayi = 5;
            Console.WriteLine("out sayi5:" + sayi);
        }

        static int toplama(params int [] sayilar)
        {
            int toplam=0;
            if (sayilar.Length == 0)
                return toplam;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }

        //İki değer döndüren fonksiyon
        static Tuple<int,int> ikideger()
        {
            int a = 10;
            int b = 20;
            var tuple = new Tuple<int, int>(a + b, a * b);
            return tuple;
        }
        static int [] ikideger2()
        {
            int a = 10;
            int b = 20;
            int[] sonuc = new int[2];
            sonuc[0] = a + b;
            sonuc[1] = a * b;
            return sonuc;
        }

        //Recursive (Ön yinelemeli) Fonksiyon
        static int faktoriyel(int sayi)
        {
            if (sayi < 0)
                return 0;
            else if (sayi < 2)
                return 1;
            else
                return sayi * faktoriyel(sayi - 1);
        }
        static void faktoriyel_yazdir(int sayi)
        {
            int sonuc = faktoriyel(sayi);
            if (sonuc == 0)
                Console.WriteLine(sayi + "!= Tanımsız");
            else
                Console.WriteLine(sayi + "!=" + sonuc);
        }

        //1 ile girilen sayı aralığındaki sayıların toplamını hesaplatıyoruz. (Recursive fonksiyon)
        static int toplamlari_yazdir(int sayi)
        {
            if (sayi < 2)
                return 1;
            else
                return sayi + toplamlari_yazdir(sayi - 1);
        }

    }
}
