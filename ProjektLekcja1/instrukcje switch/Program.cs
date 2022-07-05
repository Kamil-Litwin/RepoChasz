using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcje_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba;
            liczba = int.Parse(Console.ReadLine());

            //liczba // przykład switch na ifach
            //if (liczba == 1)
            //{
            //    Console.WriteLine("jeden");
            //}
            //else if (liczba == 2)
            //{
            //    Console.WriteLine("dwa");
            //}
            //else if (liczba == 3)
            //{
            //    Console.WriteLine("trzy");
            //}
            //else
            //{
            //    Console.WriteLine("inne");
            //}


            switch (liczba)
            {
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    goto case 2;
                case 4:
                    Console.WriteLine("cztery");
                    goto koniec;
                default:
                    Console.WriteLine("inne");
                    break;
            }
            Console.WriteLine("tego nie widać gdy goto przeskakuje, ale widać po instukcji break który łamie tylko switcha");
            koniec:
            Console.WriteLine("koniec");

            Console.ReadKey();
        }
    }
}
