using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavement
{
    [TestClass]
    public class Pavement
    {
        [TestMethod]

        public void SquarePavement()
        {
            decimal pavementStones = CalculatePavementforSquare(6, 6, 4);
            Assert.AreEqual(3, pavementStones);
        }

        decimal CalculatePavementforSquare(decimal squareLength, decimal squareWidth, decimal buildingStoneSize)
        {
            decimal stonesNo = squareLength * squareWidth / (buildingStoneSize * buildingStoneSize);
            return Math.Ceiling(stonesNo);            
        }

    }
}
