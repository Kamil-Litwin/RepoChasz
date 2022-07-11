using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        //Dziedziczenie - czy są ciekawe klasy systemowe z bibliotek z któych można fajne rzeczy dziedziczyć
        static void Main(string[] args)
        {
            //CialoNiebieskie cialoNiebieskie = new CialoNiebieskie();// nie można utworzyć obiektu klasy abstrakcyjnej
            //cialoNiebieskie.Nazwa = "Mars";
            //Console.WriteLine(cialoNiebieskie.Nazwa);
            
            Ziemia ziemia1 = new Ziemia();
            ziemia1.Nazwa = "Ziemia";
            ziemia1.atmosfera();
            ziemia1.PoraDniaINocy();
            ziemia1.RuchObrotowoy();
            Console.ReadKey();
        }

        abstract class CialoNiebieskie 
        {
            public String Nazwa 
            { 
              get;
              set;
            }
            public void RuchObrotowoy()
            {
                Console.WriteLine("Każde ciało niebieskie ma ruch obrotowy");
            }
        }

        abstract class Planeta : CialoNiebieskie //klasa planeta dziedziczy z klasy CialoNiebieskie i może korzystać z jej metod
        {
            public void PoraDniaINocy()
            {
                Console.WriteLine("pory dnia i nocy");
            }
        }

        class Ziemia : Planeta
        {
            public void atmosfera()
            {
                Console.WriteLine("ziemia posiada atmosfere");
            }
        }
    }
}
