using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AtvaltOOP
{
    public class Atvalt
    {
        //Osztályváltozók
        string eredmeny = string.Empty;
        int decSzam = 0;

        public Atvalt() { } // Az eredményt ebbe képezzük
        public Atvalt(string szam) //Az átalakítandó decimális szám változója
        {
            // Ellenörzöm az inputot
            if (isBinaris(szam)) binarisToDecimalis(szam); // Ha bináris, átalakítom decimálissá,egyébként...
            else if (isDecimal(szam)) decimalToBinaris(szam); //... ha deimalis,akkor átalakítom binárissá, egyébként...
            else throw new FormatException("A megadott adat nem szám"); // .. hibás az adat

        }
        private void decimalToBinaris(string szam)
        {
            //Az eljaras a 2-es maradekos osztas elve
            while (decSzam > 0)
            {
                eredmeny = decSzam % 2 + eredmeny;
                decSzam /= 2;  
            }
        }

        public bool isDecimal(string szam)
        {
            // A decimálist úgy vizsgaljuk, hogy konvertálható-e
            bool eredm = true;
            try
            {
                decSzam = Math.Abs(Convert.ToInt32(szam));
                // Egyuttal el is tároljulk az eredményt
            }
            catch (Exception) {
                eredm = false;
            }
            return eredm;

        }
        private void binarisToDecimalis(string szam) {
            //Az eljárás a helyi és alaki értéki érték szorzata
            int j = 1;
            for (int i = szam.Length - 1; i >= 0; i--) {
                decSzam += Convert.ToInt32(szam[i]) * j;
                j *= 2;
            }
        }
        public bool isBinaris(string szam)
        {
            bool eredm=true; 
            if (szam[0] == '0') //  Mivel az elvárás szerint a binaris szám első karaktere 0!
                for (int i = 1; i < szam.Length; i++)  
                    if (szam[i]!='0' && szam[i] != '1')
                    {
                        eredm = false;
                        break;
                    }
            return eredm;
            {

            }
        }

    }
}
