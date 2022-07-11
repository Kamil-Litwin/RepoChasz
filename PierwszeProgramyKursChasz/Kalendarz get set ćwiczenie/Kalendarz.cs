using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendarz_get_set_ćwiczenie
{
    class Kalendarz
    {
        public int rok;
        public int miesiac;
        DateTime teraz =  DateTime.Now;//bo to static xD

        public Kalendarz(int rok, int miesiac)
        {
            SprRok = rok;
            SprMsc = miesiac;
        }

        public int SprRok 
        { get { return rok; }
            set
            {
                if (value > 1900 && value < 2100)
                    rok = value;
                else
                    rok = teraz.Year;
            }
        }
        public int SprMsc 
        { get { return miesiac; }
          set
            {
                if (value > 0 && value < 13)
                    miesiac = value;
                else
                    miesiac = teraz.Month;
            }
        }
    }
}