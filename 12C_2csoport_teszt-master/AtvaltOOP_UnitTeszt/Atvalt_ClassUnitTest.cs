using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AtvaltOOP;

namespace AtvaltOOP_UnitTeszt
{
    [TestClass]
    public class Atvalt_ClassUnitTest
    // A teszt osztály nevében jelzem, hogy melyik osztályt tesztelem
    {

        //Mivel mindegyik teszt az osztály metodusát teszteli, ezert az osztaly itt egyszer példányosítható

        Atvalt atvalt = new Atvalt();
        [TestMethod]
        public void isDecimal_True() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            // Arrange- Tesztkörnyezet beállítása
            string szoveg = "21";
            bool vartEredm = true, kapottEredm = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void isDecimal_False() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            // Arrange- Tesztkörnyezet beállítása
            string szoveg = "k";
            bool vartEredm = false, kapottEredm = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm = atvalt.isDecimal(szoveg);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm, vartEredm);


        }
        [TestMethod]
        public void isBinaris_True() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg2 = "21";
            bool vartEredm2 = true, kapottEredm2 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm2 = atvalt.isBinaris(szoveg2);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm2, vartEredm2);


        }
        [TestMethod]
        public void isBinaris_False() // A tesztmetodus nevében jelzem, hoyg melyik metodust tesztelem és mire
        {
            string szoveg3 = "k";
            bool vartEredm3 = true, kapottEredm3 = false;
            // Act- A vizsgált metódus végrehajtása
            kapottEredm3 = atvalt.isBinaris(szoveg3);
            // Act- Az eredmény kiértékelése
            Assert.AreEqual(kapottEredm3, vartEredm3);


        }

    }
}