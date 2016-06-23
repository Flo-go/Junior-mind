using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BirdFlight
{
    [TestClass]
    public class BirdFlight
    {
        [TestMethod]

        public void BirdFlightSolution()
        {
            double flightDistance = CalculateBirdFlight(35);
            Assert.AreEqual(26.25, flightDistance);
        }

        double CalculateBirdFlight(double distanceBetweenTrains)
        {
            return distanceBetweenTrains*3/4;
        }

    }
}
