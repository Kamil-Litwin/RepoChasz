using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacje_na_stringach__params_i_object_
{
    class Program
    {
        static void Main(string[] args)
        {
            //object przyjmuje dowolny typ danych
            //object obj = 1;
            //object obj2 = "String";
           
            Console.WriteLine(GenerujTekst("Mam na imie #0 i mam #1 lat, wczoraj zjadłem #2, za który zapłaciłem #3", "Kamil", 22, "Stek", 29.50));
            Console.ReadKey();
        }

        //PARAMS OBJECT -> chodzi o to że mając zmienną string jako tekst , i params object, możemy przy takiej pętli wywołać
        //dowolną ilość wywołań zmiennych bez przeciążania a pętla obsłuży tyle przypadków ile będzie - bez względu na typ danych
        //ponieważ całość zostaje przekonwertowana do stringa i w takiej formie finalnie umieszczona - inty, floaty co kolwiek. :D
        public static string GenerujTekst(string tekst, params object[] args)//tablica obiektów który może przyjmować wiele różnych elementów o różnych typach
        //params zawsze na koncu i tylko jeden 
        {
            for (int i = 0; i < args.GetLength(0); i++)// petla obsluzy tylko wywolane zmienne z #
            {
                tekst = tekst.Replace("#" + i, args[i].ToString());
            }
            return tekst;
        }
    }
}
