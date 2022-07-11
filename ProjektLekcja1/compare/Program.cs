using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("Audi", 2000);
            Auto auto2 = new Auto("BMW", 1980);
            Auto auto3 = new Auto("Toyota", 2010);
            Auto auto4 = new Auto("fiat", 1999);
            List<Auto> list = new List<Auto>();
            list.Add(auto1);
            list.Add(auto2);
            list.Add(auto3);
            list.Add(auto4);

            //list.Sort();
            list.Sort(new AutoComparer());//wywołujemy sortowanie i implementujemy własną klasę 

            foreach (var item in list)
            {
                Console.WriteLine(item.Rocznik+" - "+ item.Model);
            }


            Console.ReadKey();
        }
    }


    //ta klasa łatwiejsza do zrozumienia przyjmuje 2 obiekty z klasy auto i porównuje je ze sobą, następnie IFy układają/sortują
    class AutoComparer : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x.Rocznik < y.Rocznik)
                return 1;
            else if (x.Rocznik == y.Rocznik)
                return 0;
            else
                return -1;
        }
    }

    class Auto : IComparable//aby posortować elementy listy dodaje do klasy IComparable co wymusza dodanie metody CompareTo
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {//this oznacza w całej klasie w tym wypadku Auto
            this.Model = Model;
            this.Rocznik = Rocznik;
        }

        //to jakieś trudniejsze jest
        //public int CompareTo(object obj)
        //{
        //    var arg = (Auto)obj; //rzutujemy na Auto bo wiemy że to ma wpaść tutaj
        //    if (Rocznik < arg.Rocznik)//sprawdzamy czy Rocznik wewnątrz tej klasy jest mniejszy od tego który przyszedł
        //        return 1;
        //    else if (Rocznik == arg.Rocznik)
        //        return 0;
        //    else
        //        return -1;
        //}
    }
}