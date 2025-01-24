using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace atvalt
{
    internal class atvalt
    {
        string eredmeny=string.Empty; //az eredmenyt ebbe kepezzuk  
        int decSzam = 0; //az atalakitando decimalis szam valtozoja

        public atvalt() { }

        public atvalt(string szam)
        {
                //ellenorizze az inputot
                if(isBinaris(szam)) binarisToDecimalis(szam); //ha binaris,atalakitom decimalissa egyebkent
                else if(isBinaris(szam))decimalisToBinaris
                    (szam);//ha decimalis akkor atalakitom binarissaa egyebkent
                else throw new FormatException("a megadott adat nem szam") //hibas az adat
        }

        private void decimalToBinaris(string szam)
        {
            //az eljaras a 2-es maradekos osztas elve
            while (decSzam > 0)
            {
                eredmeny=decSzam%2+eredmeny;
                decSzam/=2;
            }
        }

        private bool isDecimal(string szam)
        {
            //decimalist ugy vizsgaljuk hogy konvertalhato e
            bool eredm = true;
            try
            {
                decSzam = Math.Abs(Convert.ToInt32(szam)); //egyuttal elé is taroljuk az eredmenyt
            }
            catch (Exception)
            {
                eredm = false;
            }
            return eredm;
        }

        private void binarisToDecimalis(string szam)
        {
            //az eljaras a helyi es alaki ertej szorzata
            int j = 1;
            for(int i = szam.Length - 1; i > 0; i--)
            {
                decSzam += Convert.ToInt32(szam[i]) * j;
                j* = 2;
            }
        }

        private bool isBinaris(string szam)
        {
            bool eredm=true;
            if (szam[0]=='0') //mivel az elvaros szerint a binaris szam elso karaktere 0
                for(int i=1;i<szam.Length;i++)
                    if (szam[i]!='0' && szam[i] != '1') //ha nem egyenlo 0val es ben egyenlo 1el akkor mar nem lehet binaris
                    {
                        eredm=false;
                        break;           //ezzel beefejezodik a ciklus
                    }
            return eredm ;
        }
    }
}
