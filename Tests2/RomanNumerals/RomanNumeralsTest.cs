using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class RomanNumeralsTest
    {
        public int arabicNumerals;

        [TestMethod]
        public void NumeralsConversion()
        {
            Assert.AreEqual("LXXXVII", ConvertToRomanNumerals(87));
        }

        string ConvertToRomanNumerals(int arabicNumeral)
        {
            string romanNumeral="";
            do
            {
                if (arabicNumeral>=10)
                    romanNumeral = romanNumeral+SelectRomanSymbolGreaterThanTen(ref arabicNumeral);
                else romanNumeral = romanNumeral + SelectRomanSymbolSmallerThanTen(ref arabicNumeral);
            } while (arabicNumeral != 0);
            return romanNumeral;   
        }
        string SelectRomanSymbolGreaterThanTen(ref int arabicNumeral)
        {
            switch (arabicNumeral/10)
                {
                case 10:
                    arabicNumeral -= 100;
                    return "C";
                case 9:
                    arabicNumeral -= 90;
                    return "XC";
                case 4:
                    arabicNumeral -= 40;
                    return "XL";
                default:
                    if (arabicNumeral >= 50)
                    {
                        arabicNumeral -= 50;
                        return "L";
                    }
                    arabicNumeral -= 10;
                    return "X";
                }
        }
        string SelectRomanSymbolSmallerThanTen(ref int arabicNumeral)
        {
            switch (arabicNumeral)
            {
                case 9:
                    arabicNumeral -= 9;
                    return "IX";
                case 4:
                    arabicNumeral -= 4;
                    return "IV";
                default:
                    if (arabicNumeral>=5)
                    {
                        arabicNumeral -= 5;
                        return "V";
                    }
                    arabicNumeral -= 1;
                    return "I";
            }
        }



    }
}
