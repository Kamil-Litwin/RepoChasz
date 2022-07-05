using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcje_część_1
{
    class Program
    {
        // argument wprowadzony przez properties w debug
        static void Main(string[] args)
        {
            // Console.WriteLine("witaj " +args[0]); //zwraca argument z funkcji i zwracamy jej argument podany w debugu
            // Puste();
            //Dodaj(5, 5);
            int a = 4;
            int b = 6;
            Dodaj(a, b);
            Dodaj(a, b, 5);
            Dodaj(a, b, d: 5);//gdy chcemy pominąć argument domyślny np c w tym przypadku
            
            Console.ReadKey();
        }

        static void Puste()
        {
            Console.WriteLine("Wynik dodawania");
        }
        static void Dodaj(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine("Wynik dodawania " + wynik);
        }
        static void Dodaj(int a, int b, int c)// można dać argument stały np c = 0 wtedy w wywołaniu nie musimy podawać określonego argumentu
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania " + wynik);
        }
        static void Dodaj(int a, int b, int c = 0, int d= 0)// można dać argument stały np c = 0 wtedy w wywołaniu nie musimy podawać określonego argumentu
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania " + wynik);
        }
    }
}
