using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz_get_set_ćwiczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //niżej wywoływane bez konstruktora
            //Kalendarz data = new Kalendarz();
            //data.SprMsc = 14;
            //data.SprRok = 201;
            //Console.WriteLine(data.SprRok + " " + data.SprMsc);

            //aby zadziałało w konstruktorze odwołałem się do metod get set
            Kalendarz data = new Kalendarz(1600, 14);
            //data.SprMsc = 14;
            //data.SprRok = 1600;
            Console.WriteLine(data.SprRok +" "+ data.SprMsc);

            Console.ReadKey();
        }
    }
}