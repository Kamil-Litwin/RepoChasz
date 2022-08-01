using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUMY
{
    enum PoryRoku //: byte // mozna enumy dziedziczyć np byte żeby miej miejsca zajmowało
    {
        Wiosna =15, Lato =29, Jesień=5, Zima=-5
    }
    class Program
    {
        static void Main(string[] args)
        {
            PoryRoku poraRoku = PoryRoku.Wiosna;
            Console.WriteLine(poraRoku);
            Console.WriteLine((int)poraRoku);
            PoryRoku poraRoku2 = (PoryRoku)(-5);
            Console.WriteLine(poraRoku2);
            Console.ReadKey();
        }
    }
}
