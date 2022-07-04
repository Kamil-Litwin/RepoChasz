using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwszeProgramyZgadywankaLiczb
{
    class Program
    {
        static void Main(string[] args)
        {

            int wylosowana;
            int liczbaGracza;

            Console.WriteLine("Gra w zgadywanie liczb");
            Console.WriteLine("Podaj liczbę w zakresie 1-10 i sprawdź jak Ci poszło");

            do
            {
                Random rnd = new Random();
                wylosowana = rnd.Next(1, 11); // dla przedziału 1-10
                liczbaGracza = int.Parse(Console.ReadLine());

                Console.WriteLine("twoja liczba to: " + liczbaGracza);
                Console.WriteLine("wylosowana liczba to: " + wylosowana);

                if (wylosowana > liczbaGracza)
                {
                    Console.WriteLine("Twoja liczba {0} jest mniejsza niż wylosowana {1}", liczbaGracza, wylosowana);
                }
                else if (wylosowana < liczbaGracza)
                {
                    Console.WriteLine("Twoja liczba {0} jest wieksza niż wylosowana {1}", liczbaGracza, wylosowana);
                }
                else
                {
                    Console.WriteLine("WYGRAŁEŚ!!! stawiasz piwo :D");
                }
            }
            while (wylosowana != liczbaGracza);
            Console.ReadKey();

        }
    }
}
