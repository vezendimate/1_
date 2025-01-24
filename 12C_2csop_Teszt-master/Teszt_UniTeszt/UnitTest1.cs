using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Teszt_UniTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange: Beállítások és várt eredmény megadása
            string vartEredm = "hello vilag";

            //Act: Tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Teszt.Program.Main();
                var kapottEredm = sw.ToString().Trim();

                //Assert: Kiértékelés
                Assert.AreEqual(vartEredm, kapottEredm);
                
            }
        }
    }
}
