using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolekcje___tablice
{
    class Program
    {
        static void Main(string[] args)
        {

            // #### LEKCJA 1 TABLIC PODSTAWY
            //int[] temperatury = new int[365];
            //string[] dniTygodnia = { "poniedzialek", "wtorek", "sroda", "czwarte", "piatek", "sobota", "niedziela" };
            //string[] dniTygodnia2 = new string[8];

            //for (int i = 0; i < dniTygodnia.Length; i++)
            //{
            //    Console.WriteLine(dniTygodnia[i]);
            //}

            //for (int i = 0; i < dniTygodnia2.Length; i++)// umieszczanie danych na tablicy 
            //{
            //    Console.WriteLine("podaj {0} wartość tablicy",i);
            //    dniTygodnia2[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < dniTygodnia2.Length; i++)//wywoływanie danych z tablicy na ktorej je umieszczalismy
            //{
            //    Console.WriteLine(dniTygodnia2[i]);
            //}

            //########### LEKCJA 2 

            //PODSTAWOWA TABLICA 2 WYMIAROWA
            //int[,] tab = new int[2, 3];

            ////Console.WriteLine(tab.GetLength(0));//pierwszy wymiar
            ////Console.WriteLine(tab.GetLength(1));//drugi wymiar

            //tab[0, 0] = 1;
            //tab[0, 1] = 2;
            //tab[0, 2] = 3;
            //tab[1, 0] = 4;
            //tab[1, 1] = 5;
            //tab[1, 2] = 6;

            //for (int i = 0; i < tab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tab.GetLength(1); j++)
            //    {
            //        Console.Write(tab[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //tablica w tablicy
            //int[][] tab = new int[2][];
            //tab[0] = new int[3];
            //tab[1] = new int[2];
            //tab[0][0] = 4;
            //tab[0][1] = 3;
            //tab[0][2] = 7;
            //tab[1][0] = 5;
            //tab[1][1] = 6;

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    for (int j = 0; j < tab[i].Length; j++)
            //    {
            //        Console.Write(tab[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(tab[1].Sum()); //sumowanie wartości z tablicy i różne inne funkcje na tablicy

            //Array.Sort(tab[0]);//posortuj po kolei

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    for (int j = 0; j < tab[i].Length; j++)
            //    {
            //        Console.Write(tab[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //Array.Reverse(tab[0]);//odwróć kolejność

            //for (int i = 0; i < tab.Length; i++)
            //{
            //    for (int j = 0; j < tab[i].Length; j++)
            //    {
            //        Console.Write(tab[i][j]);
            //    }
            //    Console.WriteLine();
            //}

            //############ TABLICA 2 wymiarowa której komórki posiadają dodatkowe tablice jednowymiarowe które przechowują wartości 
            //int[,][] tab = new int [2, 2][];
            //Random randomowe = new Random();
            //int losowe;

            //for (int i = 0; i < tab.GetLength(0); i++)//iteracja pierwszego wymiaru tablicy z elementami
            //{
            //    for (int j = 0; j < tab.GetLength(1); j++) //iteracja drugiego wymiary tablicy z elementami
            //    {
            //        losowe = randomowe.Next(1, 10); //zmienna przybierajaca losowe liczby
            //        Console.WriteLine("elementów w tablicy dla indeksu tab {0},{1}: "+losowe,i,j); // informacja do jakiej komórki pierwszej tablicy są umieszczane elementy 
            //        tab[i, j] = new int[losowe]; //generowanie wylosowanej liczby elementów drugiej tablicy w określonej komórce pierwszej tablicy
            //        for (int k = 0; k < losowe; k++) //iteracja do przypisania wartości w drugiej tablicy po wskazaniu na komórkę która je przechowuje
            //        {
            //            tab[i, j][k] = randomowe.Next(10, 20);//przypisanie do tabeli znajdującej się w jednej z komórek pierwszej tabeli elementów
            //            Console.Write(tab[i,j][k] + "\t");// wypisanie przypisanych elementów
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}


            //MOJA TABLICA 
            //int[][] tab2 = new int[5][];
            //Random randomowe2 = new Random();
            //int losowe2;

            //for (int i = 0; i < tab2.GetLength(0); i++) //sprawdzamy z tablicy głównej ile jest pod tablic
            //{
            //    losowe2 = randomowe2.Next(1, 10); //losowe liczby które będą odpowiadać za ilość elementów w poszczególnej tablicy
            //    tab2[i] = new int[losowe2]; //Tworzenie obiektu tablicy w tablicy i przypisanie jej ilości elementów
            //    for (int j = 0; j < losowe2; j++) //pętla iterująca po przypisanych ilościach elementów poszczególnych tablic
            //    {
            //        tab2[i][j] = randomowe2.Next(50, 60); //losowe liczby wprowadzane do tablic na tablicach
            //        Console.Write(tab2[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }
    }
}
