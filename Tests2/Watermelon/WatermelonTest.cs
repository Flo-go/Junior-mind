using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Watermelon
{
    [TestClass]
    public class WatermelonTest
    {
        [TestMethod]
        public void WatermelonSlices()
        {
            Assert.AreEqual("DA", EvenSlicesSolution(54));
        }
        string EvenSlicesSolution(int kilos)
        {
            int reminder;
            int quotient = Math.DivRem(kilos, 2, out reminder);
            string evenSlices = reminder > 0 ^ quotient==1 ? "NU" : "DA";
            return evenSlices;
        } 


    }
}
