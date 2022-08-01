using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    class Program
    {
        static void Main(string[] args)
        {
            Postac p1 = new Postac("Kamil", 100);
            //przy wywołaniu jawnym to nie działa
            //p1.Atak(10);
            IAtakMagiczny atak = (IAtakMagiczny)p1;//odwołanie do określonego interfejsu
            atak.Atak(10);
            IAtakMieczen atak2 = (IAtakMieczen)p1;
            atak2.Atak(20);

            Console.ReadKey();

        }
    }

    interface IAtakMagiczny // interfejsy nie mogą przechowywać zmiennych, i nie mogą mieć ciała metody, zachowują się abstrakcyjnie
    {
        void Atak(int pkt);
    }
    interface IAtakMieczen
    {
        void Atak(int pkt);
    }

    class Postac : IAtakMagiczny, IAtakMieczen //interfejsów można dziedziczyć wiele
    {
        public Postac(string imie, int pktHP)
        {
            this.imie = imie;
            this.pktHP = pktHP;
        }
        public string imie;
        public int pktHP;

        void IAtakMagiczny.Atak(int pkt) // wywołanie jawne metod z interfejsu jeśli ta sama nazwa ctrl + . i druga opcja
        {
            Console.WriteLine("atak magiczny za"+" "+pkt+" punktów");
        }

        void IAtakMieczen.Atak(int pkt)
        {
            Console.WriteLine("atak mieczem za"+" "+pkt+" punktów");
        }

        //public void Atak(int pkt)//jeżeli są te same nazwy w obu intefejsach metod, wystarczy jedno wywołanie
        //{
        //    Console.WriteLine();
        //}
    }
}
