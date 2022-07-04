using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLekcja1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zmienna2 = 100;
            var zmienna = int.MaxValue + zmienna2; //vsc wstepnie nie wie że przekracza wartość maksymalną, ale kompilator zwraca błędne dane
            //Całkowite
            byte zmienna4 = byte.MaxValue; //tylko wartości dodatnie
            sbyte zmienna41 = sbyte.MinValue; //przechowuje -128 ujemnie
            short zmienna5 = short.MaxValue;
            long zmienna8 = long.MaxValue; //najdłuższa wartość gdy potrzebna
            //Zmiennoprzecinkowe
            float zmienna9 = 1.40F;
            double zmienna10 = 10.55555;
            decimal zmienna11 = 9.231M;
            //
            char zmienna12 = 'X'; //jedna wartość
            var zmienna3 = "hello";
            //logiczne
            bool zmienna13 = 5>22;
            bool zmienna14 = 5 > 2 && 5 < 22;
            
            Console.WriteLine("hello world");
            Console.WriteLine(zmienna);
            Console.WriteLine(zmienna9);
            Console.WriteLine(zmienna14);
            Console.ReadKey();
        }
    }
}
