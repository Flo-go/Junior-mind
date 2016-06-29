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
            Assert.AreEqual(2, CalculatePenalyForShortTerm(100));
        }
        double CalculatePenalyForShortTerm(int rent)
        {
            double penalty = rent * 2 / 100;
            return penalty;
        }

    }
}
