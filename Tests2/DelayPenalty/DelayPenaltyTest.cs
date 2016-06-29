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
            Assert.AreEqual(4, CalculatePenalty(200,5));
        }

        [TestMethod]
        public void PenaltyForMediumTerm()
        {
            Assert.AreEqual(10, CalculatePenalty(200, 20));
        }

        [TestMethod]
        public void PenaltyForLongTerm()
        {
            Assert.AreEqual(20, CalculatePenalty(200, 35));
        }
        double CalculatePenalty(int rent, int days)
        {
            int percentPenalty = 2;
            if (IsMediumTerm(days))
                percentPenalty = 5;
            else
             if (IsLongTerm(days))
                    percentPenalty = 10;
           return rent * percentPenalty / 100;
        }

        private static bool IsMediumTerm(int days)
        {
            return days >10 && days<31;
        }
        private static bool IsLongTerm(int days)
        {
            return days > 30 && days< 41;
        }
    }
}
