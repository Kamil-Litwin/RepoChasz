using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_2
{
    //virtual dużo więcej przyjmuje modyfikacji, można wyjść od podstawy 
    // przy abstract metoda w klasie głównej musi być pusta, i później wywołana w klasie z której dziedziczy
    //abstract klasa nie może być utworzona w głównym wywołaniu
    class Program
    {
        static void Main(string[] args)
        {
            Mag p1 = new Mag("elf",200,100);
            Console.WriteLine(p1.imie+" "+p1.pktHP+" "+p1.mana);
            p1.Ruch();
            Console.ReadKey();
        }
    }

    abstract class Postac
    {
        public int MyProperty { get; set; }
        public Postac()
        {

        }
        public Postac(string imie, int pktHP)
        {
            this.imie = imie;
            this.pktHP = pktHP;
        }
        //public virtual void Ruch()//dodanie virtual - otwarta metoda na dalsze modyfikacje
        //{
        //    Console.WriteLine("Ruch Postaci");
        //}
        public abstract void Ruch();//jeśli metoda jest abstrakcyjna, to klasa też musi być
        public string imie;
        public int pktHP;
    }

    sealed class Mag : Postac// sealed - zablokowanie opcji dalszego dziedziczenia z klasy mag
    {
        public Mag(string imie, int pktHP, int mana) : base (imie,pktHP) //dziedziczenie z konstruktora z klasy wyższej
        {
            this.mana = mana;
        }
        //new public void Ruch()//new bo mamy już dziedziczoną taką samą metodę, ale można to też zignorować
        //{
        //    Console.WriteLine("mag nie chodzi mag to stan umysłu");
        //}
        //public override void Ruch()//można nadpisać ale nie trzeba, wtedy odwołuje się do standardowej metody dziedziczonej
        //{
        //    base.Ruch();
        //    Console.WriteLine("Ruch maga");
        //}
        public override void Ruch()
        {
            Console.WriteLine("Ruch maga");
        }
        public int mana;
    }

//    class SuperMag : Mag
//    {

//    }
}
