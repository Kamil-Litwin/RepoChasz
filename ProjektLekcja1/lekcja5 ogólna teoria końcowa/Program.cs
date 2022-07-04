using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja5_ogólna_teoria_końcowa
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = int.MaxValue;
            //double s = 5.1;

            ////i = s; //dziala w ta strone
            //i = (int)s;//rzutowanie
            //Console.WriteLine(i);

            //ODCZYTYWANIE DANYCH Z KONSOLI
            //odczytywanie danych jako zmiennych wprowadzonych w konsoli
            //string s = Console.ReadLine();
            //Console.WriteLine(s);

            //wprowadzenie wartości z klawiatury podanej jako "1" doda nam wartość z IFa, w innym przypadku nic
            //if (Console.ReadKey().Key == ConsoleKey.D1)
            //    Console.WriteLine("Prawda");

            //KONWERSJA TYPÓW

            //konwersja typów (string > int)
            //string s = Console.ReadLine();
            //int i = int.Parse(s) + 2;
            //Console.WriteLine(i);

            //zmienna i jest już obiektem i przechowuje w sobie dziedziczone metody po .
            //konwersja w druga strone (int > string)
            //s = i.ToString();
            //Console.WriteLine(s);

            //łĄCZENIE I FORMATOWANIE WRITELINE
            string s1 = "elo";
            string s2 = ", co tam";
            string s3 = s1 + s2; //kontatenacja
            Console.WriteLine(s3);
            Console.WriteLine(s1 + s2 + "!!! {0}\n{1}",s1,s2);//przekazywanie zmiennych do środka tekstu w ""
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(s1 + s2 + "!!! {0}\n{1}",s1,s2);//przekazywanie zmiennych do środka tekstu w ""
            
            Console.ReadKey();
        }
    }
}
