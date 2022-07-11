using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settery_Gettery
{
    class Program
    {
        static void Main(string[] args)
        {
            czlowiek kamil = new czlowiek();
            kamil.imie = "Kamil";
            kamil.WiekProperty = -30;//tu trafia set -> ustawia dane / wprowadza
            kamil.WiekProperty = -20;
            //kamil.setWiek(20);
            //kamil.setWiek(30);

            //Console.WriteLine($"Jestem {kamil.imie} lat {kamil.getWiek()}");
            Console.WriteLine($"Jestem {kamil.imie} lat {kamil.WiekProperty}");//tu trafia get -> pobiera dane /odczytuje
            Console.ReadKey();
        }
    }
}
