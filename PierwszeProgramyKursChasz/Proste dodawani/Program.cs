using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proste_dodawani
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for (int i = 0; i < test; i++)
            {
                int ile = int.Parse(Console.ReadLine());
                string liczby = Console.ReadLine();
                string[] splitLiczb = liczby.Split(' ');
                int wynik = 0;
                    for (int j = 0; j < ile; j++)
                    {
                        wynik += int.Parse(splitLiczb[j]);
                    }
                    Console.WriteLine(wynik);
                }
            Console.ReadKey();
        }
    }
}
