using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "program";
            String s2 = new string("program".ToArray());
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));

            Auto auto1 = new Auto("Audi", 2000);
            
            Auto auto2 = new Auto("Audi", 2000);

            //po przeciążeniu metody equals i zdefiniowaniu że porównujemy modele aut i wtedy przejdzie
            Console.WriteLine(auto1.Equals(auto2));// equals jest tutaj silnym porównaniem i chociaż zgadzają się argumenty przeciążenia to są to różne obiekty
            //tu poniżej wtedy w dalszym ciągu będzie false
            Console.WriteLine(auto1 == auto2);// tutaj tak samo są to różne obiekty

            Console.ReadKey();
        }
    }

    class Auto
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {//this oznacza w całej klasie w tym wypadku Auto
            this.Model = Model;
            this.Rocznik = Rocznik;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Auto auto)
        {
            return auto.Model == this.Model && auto.Rocznik == this.Rocznik;//przeciążenie funkcji equals tak aby porównywane były konkretne elementy klasy
        }
    }
}
