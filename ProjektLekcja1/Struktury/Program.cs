using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            //Punkt2D punkt1; //struktury można tworzyć bez "new", ale zmienne trzeba wprowadzić poniżej aby je wykorzystać, nie ma domyślnej
            //punkt1.x = 5;
            //punkt1.y = 10;
            //można też z "new"
            Punkt2D punkt1 = new Punkt2D(9, 4);
            Punkt2D punkt2;
            punkt2 = punkt1;
            punkt2.x = 7;

            Punkt2D punkt3 = punkt1 + punkt2;

            Console.WriteLine(punkt3.x);
            Console.WriteLine(punkt3.y);
            Console.WriteLine(punkt3.OdleglosOdSrodka());

            Console.ReadKey();
        }
    }

    struct Punkt2D
    {
        public static Punkt2D operator +(Punkt2D a, Punkt2D b) //deklarowanie dodawania 
        {
            return new Punkt2D(a.x + b.x, a.y + b.y);
        }
        public Punkt2D(int x, int y) //konstuktor w stukrurze musi mieć zadeklarowane zmienne i wywołać je domyślne 
        {
            this.x = x;
            this.y = y;
        }

        public int x;
        public int y;
        public double OdleglosOdSrodka()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)),1);
        }
    }
    struct Punkt3D : IComparable //struktury mogą dziedziczyć tylko po interfejsach
    {
        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
