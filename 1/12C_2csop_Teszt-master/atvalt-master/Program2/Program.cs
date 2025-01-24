using System;

namespace AtvaltOOP
{
    public class Atvalt
    {
        private string inputSzam;

        // Konstruktor
        public Atvalt(string szam)
        {
            InputSzam = szam;
        }

        // Szám input sztringként
        public string InputSzam
        {
            get { return inputSzam; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("A szám nem lehet üres.");
                if (!IsValidInput(value))
                    throw new ArgumentException("Hibás bináris szám.");
                inputSzam = value;
            }
        }

        // Átváltás binárisból tizes alapúba
        public string AtvaltToTizes()
        {
            try
            {
                return Convert.ToInt32(InputSzam, 2).ToString();
            }
            catch (FormatException)
            {
                throw new ArgumentException("A bináris szám átváltása nem sikerült.");
            }
        }

        // Átváltás tizesből binárisba
        public string AtvaltToBinaris()
        {
            try
            {
                int tizes = int.Parse(InputSzam);
                return Convert.ToString(tizes, 2);
            }
            catch (FormatException)
            {
                throw new ArgumentException("A tizes szám átváltása nem sikerült.");
            }
        }

        // Eredmény lekérése sztringként
        public string GetResult()
        {
            return InputSzam;
        }

        // Segédmetódus a valid bemenet ellenőrzésére bináris szám esetén
        private bool IsValidInput(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }
    }
}
