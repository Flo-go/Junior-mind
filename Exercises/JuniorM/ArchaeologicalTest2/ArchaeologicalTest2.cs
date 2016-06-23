using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArchaeologicalSite
{
    [TestClass]
    public class ArchaeologicalSite
    {
        [TestMethod]
        public void BuildingArea()
        {

            double area = CalculateArea(1, 2, 5, 2, 4, 1);
            Assert.AreEqual(2, area);

        }

        double CalculateArea(double firstLongitude, double firstLatitude, double secondLongitude, double secondLatitude, double thirdLongitude, double thirdLatitude)
        {
            double area = (firstLongitude * secondLatitude + secondLongitude * thirdLatitude + firstLatitude * thirdLongitude - thirdLongitude * secondLatitude - firstLatitude * secondLongitude - firstLongitude * thirdLatitude) / 2;
            return Math.Abs(area);

        }
    }
}
