using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WoodFlooring
{
    [TestClass]
    public class WoodFlooring
    {
        [TestMethod]

        public void WoodFlooringSolution()
        {
            double woodFlooringQuantity = CalculateRequiredWoodFlooring(6, 4, 1.5, 0.5);
            Assert.AreEqual(37, woodFlooringQuantity);
        }

        double CalculateRequiredWoodFlooring(double roomLength, double roomWidth, double floorboardLength, double floorboardWidth)
        {
            double quantity = roomLength * roomWidth / (floorboardLength * floorboardWidth);
            return Math.Ceiling(quantity+quantity*15/100);
        }

    }
}
