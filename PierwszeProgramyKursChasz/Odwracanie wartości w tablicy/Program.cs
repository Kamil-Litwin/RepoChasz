using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odwracanie_wartości_w_tablicy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int t = int.Parse(Console.ReadLine());
            //string[] n = new string[t];

            //for (int i = 0; i < t; i++)
            //{
            //    //int n = int.Parse(Console.ReadLine());


            //    n[i] = Console.ReadLine();
            //    n[i] = n[i].Substring(2);

            //    string odwroc = string.Empty;

            //    for (int j = n[i].Length - 1; j >= 0; j--)
            //    {
            //        odwroc += n[i][j];
            //    }
            //    //n[i] = odwroc;
            //    Console.WriteLine(odwroc);
            //}
            ////for (int k = 0; k < t; k++)
            ////{

            ////}
            ///
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string tekst = Console.ReadLine();
                tekst = tekst.Substring(2);
                object[] tab = tekst.Split(' ');

                for (int j = tab.Length - 1;j >= 0 ;j--)
                {
                    Console.Write(tab[j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
