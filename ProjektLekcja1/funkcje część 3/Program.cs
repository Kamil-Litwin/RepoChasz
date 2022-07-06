using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funkcje_część_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;
            int[] tab = new int[2];
            tab[0] = 5;
            tab[1] = 4;
            Test(tab);
            Console.WriteLine("po: " + tab[0] + " " + tab[1]);// tablica 

            Console.WriteLine("przed a: "+ a);
            Test(ref a);// na funkcji Test() dodawana jest 5 do wyniku a oryginału, co finalnie poprzez referencje zmienia jej wartość o wyliczenie z funkcji
            Test1(out b);
            Console.WriteLine("po a: " + a);// po wywołaniu funkcji i jej zakończeniu wciąż to samo
            Console.WriteLine("po b: "+ b); 
            Console.ReadKey();
        }
        static void Test(ref int b)//ref -> referencja do zmiennej -> przy jej użyciu zmiana wywoałana działaniem tej funkcji ma wpływ na dalszą wartość w głównej funkcji
        {
            b += 5;
            Console.WriteLine(" w funkcji a: " + b);
        }
        static void Test1(out int b)//out czyli można przyjąć brak zmiennej na wywołaniu funkcji
        {
            b = 5;
            b += 5;
            Console.WriteLine(" w funkcji b: " + b);
        }
        static void Test(int[] tab)
        {
            //nowa tablica nadpisuje starą tablice
            tab = new int[2];//gdy nadamy nową tablice w funkcji to wartości podczas wywołania w głównej main będą te które są nadane tam
            tab[0] = 555;
            tab[1] = 444;
            Console.WriteLine("w funkcji: " + tab[0] +" "+ tab[1]);
        }
    }
    
}
