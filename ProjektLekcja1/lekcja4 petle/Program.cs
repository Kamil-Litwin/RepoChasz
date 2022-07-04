using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4_petle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            //while(a < 20)
            //{
            //    a++; // a+=2 - wartości iteracji co 2
            //    Console.WriteLine(a);
            //}

            //for(int b = 0; b < 5; b++) // zmienna b dostępna jest tylko wewnątrz for // 3 cześci for są opcjonalne
            //{
            //    Console.WriteLine(b);
            //}

            do
            {
                a++;
                Console.WriteLine(a);
            }
            while (a <= 5);
            Console.ReadKey();
        }
    }
}
