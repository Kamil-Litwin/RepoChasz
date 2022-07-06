using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_operacje_na_stringach
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch(); // diagnostyka szybkości działania rozwiązań 
            int ile = 10000;

            stopWatch.Start();
            BudujString(ile);// komentarz dodany do metody "///" uzupełniony podpowiada działanie metody
            stopWatch.Stop();
            Console.WriteLine("standardowa metoda budowania: {0} ms", stopWatch.ElapsedMilliseconds);

            stopWatch.Reset();

            stopWatch.Start();
            BudujStringBuilder(ile);
            stopWatch.Stop();
            Console.WriteLine("StringBuilder metoda budowania: {0} ms", stopWatch.ElapsedMilliseconds);

            Console.ReadKey();
        }

        //###### Obie metody to konkatenacja tekstu, pierwsza standardowa, druga polegająca na StringBuilder klasie do konkatenacji stringów
        /// <summary>
        /// Metoda buduje string
        /// </summary>
        /// <param name="ile">Podaj długość pętli</param>
        /// <returns>zwracamy gotowy tekst</returns>
        public static string BudujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        public static string BudujStringBuilder(int ile)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            {
                //append, append line podobnie jak write i write line
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}
