using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace cultureinfo___systematyzacja_nazewnictwa
{
    class Program
    {
        static void Main(string[] args)
        {
            // var c = CultureInfo.GetCultures(CultureTypes.AllCultures);
            //foreach (var item in c)
            //{
            //    Console.Write(item.Name);
            //    Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);//separatory w różnych krajach
            //}

            Console.WriteLine(CultureInfo.CurrentCulture.Name);
            var newCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();//(CultureInfo) rzutowanie dzięki czemu niżej możemy się odwołać do funkcji
            newCulture.NumberFormat.NumberDecimalSeparator = ":";
            newCulture.NumberFormat.NegativeSign = "+";
            CultureInfo.CurrentCulture = newCulture;

            int a = -5;
            float b = 3.14F;
            Console.WriteLine($"{a}  {b}");
            Console.ReadKey();
        }
    }
}
