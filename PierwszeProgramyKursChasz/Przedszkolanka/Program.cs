using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przedszkolanka
{
//W ostatnim czasie przedszkole opanowała nietypowa epidemia.Nie dotknęła ona przedszkolaków,
//tylko panie opiekujące się dziećmi.Pośród nielicznych zdrowych pozostała, ulubiona przez wszystkie maluchy,
//pani Agnieszka. Postanowiła osłodzić podopiecznym nieobecność wychowawczyń i rozdać im trochę cukierków.
//Przedszkolanka wie, że następnego dnia będzie się zajmowała jedną z dwóch grup. Zna też liczbę dzieci w każdej z nich.
//Chce teraz dobrać taką liczbę słodyczy, by można nią było obdarować wszystkie dzieci, niezależnie od grupy,
//którą będzie prowadziła.Musi przy tym spełnić kilka warunków. Po pierwsze, każdy z przedszkolaków powinien
//otrzymać jednakową (oczywiście niezerową) liczbę cukierków.Po drugie, liczba słodyczy powinna być taka,
//by można było rozdać je wszystkie. Po trzecie, ponieważ budżet przedszkola jest ograniczony,
//pani Agnieszka musi kupić minimalną liczbę cukierków spełniającą dwa wcześniejsze warunki.
//Pomóż sympatycznej przedszkolance i napisz program, który obliczy, ile cukierków powinna kupić.


//Wejście
//Dane podawane są na standardowe wejście.W pierwszym wierszu podana jest liczba N (1<=N<=20) zestawów danych.
//Dalej podawane są zestawy danych zgodnie z poniższym opisem:


//Jeden zestaw danych
//W pierwszym i jedynym wierszu zestawu danych znajdują się dwie liczby całkowite a i b (10<=a, b<=30),
//oddzielone pojedynczą spacją, oznaczające odpowiednio liczbę przedszkolaków w grupach,
//z których jedna zostanie przydzielona pani Agnieszce.

//Wyjście
//Wyniki programu powinny być wypisywane na standardowe wyjście.
//W kolejnych wierszach należy podać odpowiedzi obliczone dla kolejnych zestawów danych.
//Wynikiem dla jednego zestawu jest liczba cukierków, jaką powinna zakupić przedszkolanka.



//WRÓCIĆ DO TEGO PO PRZEROBIENIU TABLIC

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string tekst = Console.ReadLine();
                string[] teksttab = tekst.Split(' ');
                int mniejsza = int.Parse(teksttab[0]);
                int wieksza = int.Parse(teksttab[1]);
                int tmp;
                if(mniejsza > wieksza)
                {
                    tmp = mniejsza;
                    mniejsza = wieksza;
                    wieksza = tmp;
                }
                int wynik = wieksza;
                while (wynik % mniejsza != 0 || wynik % wieksza != 0)
                {
                    wynik += wieksza;
                }
                Console.WriteLine(wynik);
            }
            Console.ReadKey();
        }
    }
}
