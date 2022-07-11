using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjeList_CD
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();//szybsza kolekcja ale tylko określony typ przechowuje
            //list.Add(2);
            //list.Add(5);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            List<Auto> list = new List<Auto>();
            list.Add(new Auto("Audi"));
            list.Add(new Auto("Toyota"));

            foreach (Auto item in list)
            {
                Console.WriteLine(item.Nazwa);
                Console.WriteLine(item.UruchomSilnik("wzium"));
            }

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            Nazwa = marka;
        }
        public string UruchomSilnik(string cos)
         {
            cos = "WZIUM";
            return cos;
         }
    }
}
