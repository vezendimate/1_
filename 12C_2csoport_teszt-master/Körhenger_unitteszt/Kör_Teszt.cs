using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KörHenger;
namespace Körhenger_unitteszt


{
    [TestClass]
    public class Kör_Teszt 
    {
        [TestMethod]
        public void TestMethod1()
        {

            
                double sugár = 5;
                Kör kor = new Kör(sugár);
                kor.SetKerület();
                double vártEredm = 31.4;
            
        }
            [TestMethod]
            public void Terület_Teszt()
            {
            }
    }
}
