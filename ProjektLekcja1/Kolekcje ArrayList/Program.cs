using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje_Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList();
            lista.Add(2);
            lista.Add("Kamil");
            lista.Add(new Auto("Audi"));
            lista.Insert(0, "ala");//wstawia w konkretny index wartość do listy, przesuwając reszte

            Console.WriteLine(lista.Count);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].ToString());//przerobienie różnych elementów tablicy na stame stringi
            }
            lista.RemoveAt(1);//od tablicy różni się tym że w arraylist zmniejsza liczbę elementów listy, tablica by tylko usuneła element z indeksu
            //lista.Clear();//czyszczenie listy
            foreach (var item in lista)
            {
                Console.WriteLine(item);//foreach wywołuje każdy element kolekcji do niej złożonej
            }
            Console.ReadKey();
        }
    }

    class Auto
    {
        public String Nazwa { get; set; }
        public Auto(String marka)
        {
            Nazwa = marka;
        }

        public override string ToString()//nadpisanie w ramach klasy działania funkcji ToString
        {
            return Nazwa;// przeciążenie nazwy poprzez zwracanie stringa z nazwą innej metody
        }
    }
}
