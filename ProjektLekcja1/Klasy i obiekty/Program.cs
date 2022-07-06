using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Czlowiek kamil = new Czlowiek();
            Console.WriteLine(kamil.imie);
            kamil.imie = "Bartek";
            Console.WriteLine(kamil.imie);
            Czlowiek kamil2 = new Czlowiek("Zbyszek","inny");
            Console.WriteLine(kamil2.imie +" "+ kamil2.nazwisko);
            kamil2.PrzedstawSie();
            Console.ReadKey();
        }
    }
}
