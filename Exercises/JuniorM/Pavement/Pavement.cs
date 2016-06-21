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
            decimal pavementStones = CalculatePavementforSquare(8, 10, 2);
            Assert.AreEqual(20, pavementStones);
        }

        decimal CalculatePavementforSquare(decimal squareLength, decimal squareWidth, decimal buildingStoneSize)
        {
            decimal stonesNo = Math.Ceiling(squareLength/buildingStoneSize)*Math.Ceiling(squareWidth /buildingStoneSize);
            return stonesNo;            
        }

    }
}
