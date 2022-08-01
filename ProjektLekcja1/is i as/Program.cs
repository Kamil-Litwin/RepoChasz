using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_i_as
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zwierze zwierz = new Zwierze();//zwierze nie wie jak pic
            Zwierze zwierz = new Kot();//tworzony zwierz jako nowy obiekt kot wie jak pic mleko i mozna z z niego rzutować
            Kot kot = new Kot();

            
            Kot kot2 = zwierz as Kot;
            //kot2.PijeMleko();//null reference pusta referencja bo kot2 po zwierzu nie umie pić mleka sprawdzone niżej na ifie
            //jeśli jest new Kot(); to zadziała wtedy if i wywoła funkcje bo rzutuje na Kota jako obiekt
            //to co wyżej podobne do tego niżej ale z użyciem as //rzutowanie, as zabezpiecza rzutowanie na null jeśli się nie powiedzie
            //Kot kot3 = (Kot)zwierz;

            //zwierz = kot;//bez tego rzutowanie się nie powiedzie w przypadku poniżej

            if(!(kot2==null))
            {
                kot2.PijeMleko();
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("not correct");
            }
            Console.ReadKey();
        }
    }

    class Zwierze
    {
        public void DajGlos()
        {
            Console.WriteLine("głos");
        }
    }
    class Kot : Zwierze
    {
       public void PijeMleko()
        {
            Console.WriteLine("pije mleko");
        }
    }
}
