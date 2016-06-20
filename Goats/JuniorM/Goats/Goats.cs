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
            double HayFinal = CalculateHay(2, 1, 5, 4, 2);
            Assert.AreEqual(20, HayFinal);
        }

        double CalculateHay(int GoatsNoInit, int DaysInit, double KilosHayInit,int GoatsNoFinal, int DaysFinal)
        {
            return (GoatsNoFinal*DaysFinal*KilosHayInit/GoatsNoInit)/DaysInit;
        }
        
    }
}
