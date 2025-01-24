using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VektorMinMaxOOP
{
    public class VektorMinMax
    {
        private int[] tombvektor;
        private int legkisebb;
        private int legkisebbIndex;
        private int legnagyobb;
        private int legnagyobbIndex;

        public VektorMinMax() { }

        public VektorMinMax(int[] vektor)
        {
            SetVektor(vektor);
        }

        public void SetVektor(int[] vektor)
        {
            this.tombvektor = vektor;
            SetMin();
            SetMax();
        }

        public void SetMin()
        {
            legkisebb = tombvektor.Min();
            legkisebbIndex = Array.IndexOf(tombvektor, legkisebb);
        }

        public void SetMax()
        {
            legnagyobb = tombvektor.Max();
            legnagyobbIndex = Array.IndexOf(tombvektor, legnagyobb);
        }

        public (int, int) GetMin() => (legkisebb, legkisebbIndex);
        public (int, int) GetMax() => (legnagyobb, legnagyobbIndex);

        public (int, int)[] GetMinMax() => new[] { (legkisebb, legkisebbIndex), (legnagyobb, legnagyobbIndex) };
    }

    class Program
    {
        static void Main(string[] args)
        {
            VektorMinMax vektorMinMax = new VektorMinMax(new[] { 8,7,2,9,1,5 });
            Console.WriteLine("A legkisebb elem és indexe: " + vektorMinMax.GetMin());
            Console.WriteLine("A legnagyobb elem és indexe: " + vektorMinMax.GetMax());
            Console.ReadKey();
        }
    }
}