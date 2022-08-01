using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjątki_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dzielenie(0));//jeśli podamy 5, obsłuży się wyjątek
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("nie wolno przez zero w szkole uczyli: "+e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("coś nie tak: " + e.Message);
            }
            finally
            {
                Console.WriteLine("zawsze jestem na końcu i sprzątam");//jeśli cokolwiek miało by się nie wykonwać - finally zawsze pojawi się na koniec
            }
            Console.ReadKey();

        }

        public static float Dzielenie(int a)
        {
            if(a == 5)
            {
                throw new Exception("Nigdy nie dziel przez 5!");
            }
            return 10 / a;
        }
    }
}
