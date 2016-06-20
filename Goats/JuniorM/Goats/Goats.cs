using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats
{
    [TestClass]
    public class Goats
    {
        [TestMethod]

        public void HaySolution()
        {
            double HayFinal = CalculateHay(1, 1, 2, 2, 1);
            Assert.AreEqual(4, HayFinal);
        }

        double CalculateHay(int GoatsNoInit, int DaysInit, double KilosHayInit,int GoatsFinal, int DaysFinal)
        {
            return (GoatsNoInit*DaysFinal*KilosHayInit)/(GoatsFinal*DaysInit);
        }
        
    }
}
