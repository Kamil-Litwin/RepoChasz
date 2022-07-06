using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty
{
    class Czlowiek
    {
        public Czlowiek()
        {
            //Console.WriteLine("jestem konstruktorem");//konstruktor wywoływany jest na samym początku przy stworzeniu obiektu klasy
        }
        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            //Console.WriteLine("jestem konstruktorem");//konstruktor wywoływany jest na samym początku przy stworzeniu obiektu klasy
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }
        public string imie = "BRAK";//nadanie public daje możliwość korzystania z nich w innych klasach
        public string nazwisko = "BRAK";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imie " + imie);
        }
        ~Czlowiek()
        {
            Console.WriteLine("jestem destruktorem");//wywoływany jest podczas usuwania obiektu klasy
            System.Diagnostics.Trace.WriteLine("jestem destruktorem");//wywołanie komunikatu w logu debug
        }
    }
}