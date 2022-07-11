using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> slownik = new Dictionary<int, string>();// kolekcja słownik, klucz i wartość
            slownik.Add(1, "pierwsza");
            slownik.Add(2, "druga");
            if (!slownik.ContainsKey(2))//if zanegowany - zabezpieczenie
            {
                slownik.Add(2, "trzy");
            }
            slownik.Add(4, "druga");
            foreach (var item in slownik)
            {
                //Console.WriteLine(item);
                Console.WriteLine("{0} : {1}", item.Key,item.Value);
            }
            Console.ReadKey();
        }
    }
}
