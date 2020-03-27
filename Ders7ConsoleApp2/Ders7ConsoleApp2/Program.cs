using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders7ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu gmihran = new Oyuncu();
            Console.WriteLine($"isim:{gmihran.isim} no:{gmihran.no} cinsiyet:{gmihran.cinsiyet}");
            gmihran.isim = "Gözde";
            gmihran.no = 1;
            gmihran.cinsiyet = 'K';
            Console.WriteLine(gmihran.isim);
            Console.WriteLine(gmihran.no);
            Console.WriteLine(gmihran.cinsiyet);
            Console.WriteLine($"isim:{gmihran.isim} no:{gmihran.no} cinsiyet:{gmihran.cinsiyet}");


            Oyuncu king = new Oyuncu();
            Console.WriteLine($"isim:{king.isim} no:{king.no} cinsiyet:{king.cinsiyet}");

            Oyuncu hello = new Oyuncu(2,"Kemal",'E');
            Console.WriteLine($"isim:{hello.isim} no:{hello.no} cinsiyet:{hello.cinsiyet}");
            hello.isim = "Kamil";
            Console.WriteLine($"isim:{hello.isim} no:{hello.no} cinsiyet:{hello.cinsiyet}");

            hello.SetOyuncu(3, "Ayla", 'K');
            Console.WriteLine($"isim:{hello.isim} no:{hello.no} cinsiyet:{hello.cinsiyet}");

            Console.WriteLine(hello.GetOyuncu());
            Console.WriteLine(king.GetOyuncu());

            Gold sevgi = new Gold();
            Console.WriteLine(sevgi.GetOyuncu());
            sevgi.SetOyuncu(5, "Sevgi", 'K');
            Console.WriteLine(sevgi.GetOyuncu());

            Gold oyuncu = new Gold() { no = 6, cinsiyet = 'K', isim = "Oyuncu" };
            Console.WriteLine(oyuncu.GetOyuncu());
            Console.WriteLine(oyuncu.rozet);
            oyuncu.rozet = "Bronz";
            Console.WriteLine(oyuncu.rozet);
            
            Console.WriteLine(oyuncu.GetProperties());

            Console.WriteLine(oyuncu.GetOyuncuProperties()); 

            Bronz oyuncu2 = new Bronz() { no = 7, cinsiyet = 'K', isim = "Oyuncu2" }; 
            Console.WriteLine(oyuncu2.GetOyuncu());
            Console.WriteLine(oyuncu2.rozet);
            oyuncu2.rozet = "Gold";
            Console.WriteLine(oyuncu2.rozet);

            Console.WriteLine(oyuncu2.GetProperties());


            Console.ReadKey();
        }
    }
}
