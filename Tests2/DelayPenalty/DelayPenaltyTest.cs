using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DelayPenalty
{
    [TestClass]
    public class DelayPenaltyTest
    {
        [TestMethod]
        public void PenaltyForShortTerm()
        {
            Assert.AreEqual(2, CalculatePenalty(100,5));
        }

        [TestMethod]
        public void PenaltyForMediumTerm()
        {
            Assert.AreEqual(5, CalculatePenalty(100, 20));
        }
        double CalculatePenalty(int rent, int days)
        { 
            int percentPenalty = days < 11 ? 2 : 5;
            return rent*percentPenalty/100;
        }

    }
}
