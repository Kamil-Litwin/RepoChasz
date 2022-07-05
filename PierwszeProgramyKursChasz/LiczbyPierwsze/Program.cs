using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiczbyPierwsze
{
    class Program
    {
        public static bool FindPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= squareRoot; i += 2)
                if (number % i == 0) return false;

            return true;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbe: ");
                int expression = Int32.Parse(Console.ReadLine());

                if (FindPrime(expression))
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");

                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
