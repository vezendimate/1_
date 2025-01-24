using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzámTesztOOP
{
    public class SzámTeszt
    {
        private int elsoszam;
        private int masodikszam;
        private int vegeredmeny;

        public SzámTeszt() { }

        public SzámTeszt(int elsoszam, int masodikszam)
        {
            this.elsoszam = elsoszam;
            this.masodikszam = masodikszam;
        }

        public void SetSzám1(int szam) => elsoszam = szam;
        public void SetSzám2(int szam) => masodikszam = szam;

        public void SetEredmény()
        {
            if (elsoszam == masodikszam) vegeredmeny = 0;
            else if (elsoszam > masodikszam) vegeredmeny = 1;
            else vegeredmeny = 2;
        }

        public int GetEredmény() => vegeredmeny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            SzámTeszt szamTeszt = new SzámTeszt(90, 200);
            szamTeszt.SetEredmény();
            Console.WriteLine("Az eredmény: " + szamTeszt.GetEredmény());
            Console.ReadKey();
        }
    }
}