using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Teszt;


namespace unitteszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {//Arrange:Beállítások és a várt eredmény megadása
            string vartEredm = "Hello Vilag";
            // Act: Tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Teszt.Program.Main();
                var kapotteredm = sw.ToString().Trim();

                //Asswert: Kiértékelés
                Assert.AreEqual(vartEredm, kapotteredm);
                

            }
           

        }


    }
}
