using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy_i_obiekty___static_vs_non_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);//dzieki static możemy odwołać się od razu do zmiennej z klasy, nie tworzymy obiektu klasy
            CzlowiekStatic.liczbaLudnosci = 10000;
            Console.WriteLine(CzlowiekStatic.liczbaLudnosci);

            Czlowiek czlowiek = new Czlowiek();//największa korzyść klas statycznych -> nie nadpisujemy sobie danych, możemy stworzyć nowy obiekt który będzie przechowywał wartości domyślne z klasy źródłowej
            czlowiek.imie = "Marek";
            Console.WriteLine(czlowiek.imie);
            Czlowiek czlowiek1 = new Czlowiek();
            Console.WriteLine(czlowiek1.imie);

            Math.Abs(-5);//przykład klasy statycznej -> szybki dostęp, nie muszą przechowywać wartości które wysyłamy, mają zrealizować zmianę podanej zmiennej.
            Console.WriteLine(Czlowiek.liczbaLudnosci);// w klasie nie statycznej można odwołać metodę statyczną w tym przypadku liczbaLudnosci
            //liczba ludnosci nie może być wywołana w tej klasie na utworzonym obiekcie czlowiek, czlowiek1. 

            Console.ReadKey();
        }
    }
}
