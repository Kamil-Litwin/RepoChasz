using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki_własne
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dzielenie(5));//jeśli podamy 5, obsłuży się wyjątek
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        public static float Dzielenie(int a)
        {
            if (a == 5)
            {
                throw new DivededByFiveException("podmieniłem message");
            }
            return 10 / a;
        }
    }
    class DivededByFiveException : Exception
    {
        public DivededByFiveException()
        {
            Console.WriteLine("błąd");
        }

        public DivededByFiveException(string message) : base(message+" dzielenie przed 5 wyjątek")// można dopisać do message to 
        {
        }
    }
}
