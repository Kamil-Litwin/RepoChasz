using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_queue_i_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //##KOLEJKA
            //Queue<int> kolejka = new Queue<int>();//kolejka, wywoływanie elementów tak jak w przypadku poniżej najpierw consola wywoła 1 element
            ////potem foreach wywoła pozostałe elementy czyli 2 i 3 fajne :D
            ////ogólnie kolejka daje na koniec, stos wsadza nowy element na pierwsze miejsce
            //kolejka.Enqueue(1);
            //kolejka.Enqueue(2);
            //kolejka.Enqueue(3);

            //Console.WriteLine(kolejka.Peek());//podglad wartośći która aktualnie jest kolejna do wywołania przy użyciu dequeue
            //Console.WriteLine(kolejka.Dequeue());
            //Console.WriteLine(kolejka.Peek());//można używać ale uważać żeby nie wywoływać gdy już nie ma elementów kolejki bo leci błąd

            //kolejka.Enqueue(4);

            //foreach (var item in kolejka)
            //{
            //    Console.WriteLine(item);
            //}

            Stack<int> stos = new Stack<int>();
            stos.Push(1);
            stos.Push(2);
            stos.Push(3);

            Console.WriteLine(stos.Peek());//wyświetla ostatni dodany element stosu jako pierwszy

            stos.Push(4);

            Console.WriteLine(stos.Pop());//wyświetla i odrzuca ostatni element stosu
            Console.WriteLine(stos.Pop());

            foreach (var item in stos)
            {
                Console.WriteLine("foreach: "+item);
            }


            Console.ReadKey();
        }
    }
}
