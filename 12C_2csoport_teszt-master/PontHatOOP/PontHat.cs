using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontHatOOP
{
    public class PontHat
    {
        private int pontszam;
        private string osztalyzat;

        // Konstruktor
        public PontHat()
        {
            pontszam = 0;
            osztalyzat = string.Empty;
        }

        // Pontszám beállítása
        public void Beallitas(int pont)
        {
            if (pont < 0 || pont > 100)
            {
                throw new ArgumentOutOfRangeException("A pontszámnak 0 és 100 között kell lennie.");
            }
            pontszam = pont;
        }

        // Osztályzat meghatározása
        public void OsztalyzatMegallapitas()
        {
            if (pontszam >= 90)
            {
                osztalyzat = "5";
            }
            else if (pontszam >= 80)
            {
                osztalyzat = "4";
            }
            else if (pontszam >= 65)
            {
                osztalyzat = "3";
            }
            else if (pontszam >= 50)
            {
                osztalyzat = "2";
            }
            else
            {
                osztalyzat = "1";
            }
        }

        // Eredmény lekérése
        public string Eredmeny()
        {
            return osztalyzat;
        }
    }
}