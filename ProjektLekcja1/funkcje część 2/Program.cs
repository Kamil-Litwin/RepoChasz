using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje_część_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Dodaj(4,4));
            Console.ReadKey();
        }

        static string Dodaj(int a, int b)
        {
            int wynik = a + b;
            if (wynik> 10)
            {
                return "wiekszy niz 10";
            }
            else
            {
                return "Wynik mniejszy niz 10";
            }
            ;
        }
    }
}
