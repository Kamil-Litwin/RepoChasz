using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Działanie_na_plikach.txt
{
    class Program
    {
        static void Main(string[] args)
        {
        ad1:
            string path = @"plik.txt";//ścieżka pośrednia tam gdzie jest projekt
            StreamWriter sw;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("plik utworzony w lokalizacji "+path);
            }
            else
            {
                sw = new StreamWriter(path, true);//bool na true dopisuje informacje, false usuwa dane i wrzuca nowe (podmiana) (append = podmiana)
                Console.WriteLine("plik został otwarty");
            }
            Console.WriteLine("Podaj tekst do zapisu w pliku");
            string tekst = Console.ReadLine();
            sw.WriteLine(tekst);
            sw.Close();
            ad2:
            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZawartość pliku: ");
            while((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". "+s);
            }
            sr.Close();

            Console.WriteLine("Co chcesz dalej robić? Wybierz przypisaną liczbę \n1.Kolejna linia \n2.Odczyt \nAby zakończyć wprowadź dowolny znak");
            string zmienna = (Console.ReadLine());

            if(zmienna == "1")
            {
                goto ad1;
            }
            else if(zmienna == "2")
            {
                goto ad2;
            }
            else
            {
             
            }


            Console.ReadKey();
        }
    }
}
