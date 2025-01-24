using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulátorOOP
{
    public class Calc
    {
        private double elsoszam;
        private double masodikszam;
        private char muvelet;
        private double vegeredmeny;

        public Calc() { }

        public Calc(double elsoszam, double masodikszam, char muvelet)
        {
            this.elsoszam = elsoszam;
            this.masodikszam = masodikszam;
            this.muvelet = muvelet;
        }

        public void SetSzám1(double szam) => elsoszam = szam;
        public void SetSzám2(double szam) => masodikszam = szam;
        public void SetMűveletJel(char jel) => muvelet = jel;

        public void SetEredmény()
        {
            switch (muvelet)
            {
                case '+': vegeredmeny = elsoszam + masodikszam; break;
                case '-': vegeredmeny = elsoszam - masodikszam; break;
                case '*': vegeredmeny = elsoszam *masodikszam; break;
                case '/': vegeredmeny = masodikszam != 0 ? elsoszam / masodikszam : 0; break;
                default: throw new InvalidOperationException("Ismeretlen művelet");
            }
        }

        public double GetEredmény() => vegeredmeny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(2, 7, '*');
            calc.SetEredmény();
            Console.WriteLine("Az eredmény: " + calc.GetEredmény());
            Console.ReadKey();
        }

    }
}
