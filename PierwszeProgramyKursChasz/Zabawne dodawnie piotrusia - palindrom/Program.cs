using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawne_dodawnie_piotrusia___palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random iloscLiczb = new Random();
            int t = iloscLiczb.Next(0, 80);

            //int ilosc = int.Parse(Console.ReadLine());

            string[] n = new string[t];

            for (int i = 0; i < t; i++)
            {
                n[i] = iloscLiczb.Next(1, 80).ToString();
                //n[i] = Console.ReadLine();
                
                Console.WriteLine(n[i]);

            }

            for (int i = 0; i < t; i++)
            {

                int dlugosc = n[i].Length;
                if (dlugosc == 1)
                {
                    //Console.WriteLine(liczby[i]);
                }
                else
                {
                    string odwroc = string.Empty;

                    for (int j = n[i].Length - 1; j >= 0; j--)
                    {
                        odwroc += n[i][j];
                    }
                    //Console.WriteLine(liczby[i]);
                    //Console.WriteLine(odwroc);
                    int a = int.Parse(n[i]);
                    int b = int.Parse(odwroc);
                    int ileDodawan = 0;
                    while (a != b)// 69 != 96
                    {
                        //int c = a; //c = 69
                        a += b;//a = a + b // a = 69 + 96 = 165

                        string odwroc2 = string.Empty;
                        string aString = a.ToString();

                        for (int j = aString.Length - 1; j >= 0; j--)
                        {
                            odwroc2 += aString[j];
                        }

                        b = int.Parse(odwroc2);

                        ileDodawan++;

                    }
                    Console.WriteLine(a+" "+ileDodawan);
                }
                //Console.WriteLine(liczby[i]);
            }
            Console.ReadKey();
        }
    }
}
