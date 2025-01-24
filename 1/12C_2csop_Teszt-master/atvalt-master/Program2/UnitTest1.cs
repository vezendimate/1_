using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace AtvaltOOP.Tests
{
    [TestFixture]
    public class AtvaltTests
    {
        [Test]
        public void TestAtvaltToTizes()
        {
            var atvalt = new Atvalt("1101");
            var eredmeny = atvalt.AtvaltToTizes();
            Assert.AreEqual("13", eredmeny);
        }

        [Test]
        public void TestAtvaltToBinaris()
        {
            var atvalt = new Atvalt("13");
            var eredmeny = atvalt.AtvaltToBinaris();
            Assert.AreEqual("1101", eredmeny);
        }

        [Test]
        public void TestInvalidBinarisInput()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Atvalt("1234"));
            Assert.AreEqual("Hibás bináris szám.", ex.Message);
        }

        [Test]
        public void TestEmptyInput()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Atvalt(""));
            Assert.AreEqual("A szám nem lehet üres.", ex.Message);
        }

        [Test]
        public void TestInvalidDecimalInput()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Atvalt("abc"));
            Assert.AreEqual("A tizes szám átváltása nem sikerült.", ex.Message);
        }
    }
}
