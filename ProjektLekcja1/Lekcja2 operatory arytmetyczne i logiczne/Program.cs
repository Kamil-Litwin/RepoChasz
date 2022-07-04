using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja2_operatory_arytmetyczne_i_logiczne
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 9;
            int c;

            // c = b % a; //reszta z dzielenia. Kolejność bardzo istotna, w przypadku tej reszty wynik będzie z przed inkrementowania zmiennej a.
            //c = a + b;
            a += b; // do a doda się zmienna b , szybsza metoda niż c = a + b, tak samo jest z odejmowaniem, mnozeniem, dzielenim, reszta z dzielenia
            a += 1; //iteracja o 1 będzie często potem -> inkrementacja w c# a++
            a++; //-> inkrementacja w c# o jedne, a--odejmuje o 1. czyli to samo co a += 1;
            bool d = 2 == 2;
            bool e = 2 != 2;
            bool f = !(2 == 2);
            bool g = 1 == 1 && 1 != 1; // AND
            bool h = 1 == 1 || 1 != 1; // OR Prawda jeśli jedno jest prawda
            bool i = 1 == 1 || true && false; // W tym przypadku AND wykonuje się najpierw, przez co True z początku zawsze będzie nad wynikiem z &&

            

            c = b % a; //reszta z dzielenia


            Console.WriteLine(i);
            Console.WriteLine(Math.Pow(5, 2));
            Console.ReadKey();
        }
    }
}
