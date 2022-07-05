using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrukcje_skoku
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
        //while (true) // skok 1
        //{
        //    if (a > 10)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(a);
        //    a++;
        //}

        //for (int i = 0; i < 10; i++) // skok 2, ignoruje to co dalej i wykonuje petle dalej
        //{
        //    if (i % 2 == 1)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //jeden: // skok 3 , korzystanie z goto np. do etykiet, można zrobić przypadkową pętle, goto jest nie dobre
        //    Console.WriteLine("jeden");
        //    goto trzy;
        //dwa:
        //    Console.WriteLine("dwa");
        //trzy:
        //    Console.WriteLine("trzy");
        //    goto jeden;

            Console.ReadKey();
        }
    }
}
