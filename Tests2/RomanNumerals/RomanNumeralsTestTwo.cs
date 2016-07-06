using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumeralsTest
    {
        
        [TestMethod]
        public void NumeralsConversion()
        {
            Assert.AreEqual("LXXXVII",ConvertToRomanNumerals(87));
        }

        string ConvertToRomanNumerals(int number)
        {
            string [] romanNumeralsSmallerThanTen= {"","I","II","III","IV","V","VI","VII","VIII","IX"};
            string [] romanNumeralsGreaterThanTen = {"X","XX","XXX","XL","L","LX","LXX","LXXX","XC","C"};
            return romanNumeralsGreaterThanTen[number / 10 - 1] + romanNumeralsSmallerThanTen[number % 10];
        }
        
    }
}
