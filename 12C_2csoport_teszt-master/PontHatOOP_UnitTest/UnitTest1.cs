using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest1;
using PontHatOOP;
using System;

namespace UnitTest1
{
    [TestClass]
    public class PontHatTests
    {
        private PontHat pontHat;

        [TestInitialize]
        public void Setup()
        {
            pontHat = new PontHat();
        }

        // Határértékek tesztelése
        [TestMethod]
        public void Test_50Pont_2es()
        {
            pontHat.Beallitas(50);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("2", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_64Pont_2es()
        {
            pontHat.Beallitas(64);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("2", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_65Pont_3as()
        {
            pontHat.Beallitas(65);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("3", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_79Pont_3as()
        {
            pontHat.Beallitas(79);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("3", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_80Pont_4es()
        {
            pontHat.Beallitas(80);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("4", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_89Pont_4es()
        {
            pontHat.Beallitas(89);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("4", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_90Pont_5os()
        {
            pontHat.Beallitas(90);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("5", pontHat.Eredmeny());
        }

        [TestMethod]
        public void Test_100Pont_5os()
        {
            pontHat.Beallitas(100);
            pontHat.OsztalyzatMegallapitas();
            Assert.AreEqual("5", pontHat.Eredmeny());
        }

        // Hibás értékek tesztelése
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_NegativPontSzam_Hiba()
        {
            pontHat.Beallitas(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_100PluszPontSzam_Hiba()
        {
            pontHat.Beallitas(101);
        }
    }
}