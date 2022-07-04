using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszeProgramyKursChasz
{
    class Program
    {
        static void Main(string[] args)
        {
            //narysuj prostokat z gwiazdek 3 x 6
            Console.WriteLine("******");
            Console.WriteLine("*    *");
            Console.WriteLine("******");

            //narysuj prostokat x y podany przed użytkownika
            Console.WriteLine("Podaj szerokość");
            string a1 = Console.ReadLine();
            int b1 = int.Parse(a1);
            Console.WriteLine("Podaj wysokość");
            string a2 = Console.ReadLine();
            int b2 = int.Parse(a2);

            for (int i = 0; i < b2; i++) // np 2 wysokosc
            {
                for (int j = 0; j < b1; j++) // np 10 szerokosc
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // po iteracji z pętli wewnątrz robi nową linie dla kolejnej iteracji
            }
            Console.ReadKey();
        }
    }
}
