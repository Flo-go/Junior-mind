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
            string [] romanNumeralsSmallerThanTen= {"I","II","III","IV","V","VI","VII","VIII","IX","X"};
            string [] romanNumeralsGreaterThanTen = {"XX","XXX","XL","L","LX","LXX","LXXX","XC","C"};
            int tens = number / 10;
            int ones = number % 10;
            switch (tens)
            {
                case 0:
                    return romanNumeralsSmallerThanTen[ones - 1];
                case 10:
                    return romanNumeralsGreaterThanTen[tens - 2];
                default:
                    return romanNumeralsGreaterThanTen[tens - 2] + romanNumeralsSmallerThanTen[ones - 1];
            }
        }
        
    }
}
