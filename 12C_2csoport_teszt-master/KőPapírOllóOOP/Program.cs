using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KőPapírOllóOOP
{
    using System;

    namespace KőPapírOllóOOP
    {
        public class Kpo
        {
            private string ad1;
            private string ad2;
            private string eredmeny;

            public Kpo() { }

            public Kpo(string ad1, string ad2)
            {
                this.ad1 = ad1;
                this.ad2 = ad2;
            }

            public void SetTip1(string tip) => ad1 = tip;
            public void SetTip2(string tip) => ad2 = tip;

            public void SetEredmény()
            {
                if (ad1 == ad2) eredmeny = "Döntetlen lett!";
                else if ((ad1 == "Kő" && ad2 == "Olló") || (ad1 == "Papír" && ad2 == "Kő") || (ad1 == "Olló" && ad2 == "Papír"))
                    eredmeny = "Első játékos a nyertes!";
                else
                    eredmeny = "Második játékos a nyertes!";
            }

            public string GetEredmény() => eredmeny;
        }

        class Program
        {
            static void Main(string[] args)
            {
                Kpo kpo = new Kpo("Papír", "Kő");
                kpo.SetEredmény();
                Console.WriteLine("Játéknak az eredménye: " + kpo.GetEredmény());
                Console.ReadKey();
            }
        }
    }
}