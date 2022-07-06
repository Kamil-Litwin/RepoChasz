using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settery_Gettery
{
    class czlowiek
    {
        public string imie;
        //private int wiek;

        //TEGO MOŻNA UŻYWAĆ W INNYCH JĘZYKACH PROGRAMOWANIA METODA DLA C# PONIŻEJ
        //public int getWiek()
        //{
        //    return wiek;
        //}
        //public void setWiek(int wiek)
        //{
        //    if(wiek >= 0  && wiek <= 200)
        //    {
        //        wiek = wiek;
        //    }    

        //public int wiek { get; set; }//snipet prop tab x2 dla wywołania get set funkcji, można zdecydować czy odczyt / zapis ma być możliwy
        //to wyżej jest "prymitywne"
        
        //niżej ustawiamy na propfull tabx2 lepsze
        private int wiek;

        public int WiekProperty
        {
            get { return wiek; }
            set 
            {
                if (value >= 0 && value <= 200)

                    wiek = value;
                else
                    wiek = 0;
            }
        }


    }
}
