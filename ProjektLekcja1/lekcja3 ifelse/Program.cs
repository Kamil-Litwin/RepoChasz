using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja3_ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            bool b = 2 < a;
            if (b == true) // dla if jeśli się pierwszy wykona wszelkie else są pomijane, jeśli chcemy wywołać kolejne sprawdzenie trzeba wprowadzić nowy IF
            {
                Console.WriteLine("ok");
            }
            else if( a == 1 ) 
            {
                Console.WriteLine("yyy");
            }
            else
            {
                Console.WriteLine("no nic");
            }
            if (b == true || a == 1) // dla if jeśli się pierwszy wykona wszelkie else są pomijane, jeśli chcemy wywołać kolejne sprawdzenie trzeba wprowadzić nowy IF
            {
                Console.WriteLine("ok");
                Console.WriteLine("yyy");
            }
            Console.ReadKey();
        }
    }
}
