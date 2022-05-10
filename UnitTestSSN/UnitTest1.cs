using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSN_;

namespace UnitTestSSN
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDigits()
        {
            Digits digits = new Digits("123-45-7896");
            string result = digits.Magnitud();
            Assert.AreEqual("Your SSN is correct.", result);
        }

        [TestMethod]
        public void TestSeparate()
        {
            Digits digits = new Digits("123-45-7896");
            string result = digits.Separate();
            Assert.AreEqual("Your SSN is correct.", result);
        }
        [TestMethod]
        public void TestFirstPart()
        {
            Digits digits = new Digits("123-45-7896");
            string result = digits.FirstPart();
            Assert.AreEqual("Your SSN is correct." , result);
        }
        [TestMethod]
        public void TestSecondPart()
        {
            Digits digits = new Digits("123-45-7896");
            string result = digits.SecondPart();
            Assert.AreEqual("Your SSN is correct.", result);
        }
        [TestMethod]
        public void TestThirdPart()
        {
            Digits digits = new Digits("000-45-7896");
            string result = digits.ThirdPart();
            Assert.AreEqual("Your SSN is correct.", result);
        }
    }
}
