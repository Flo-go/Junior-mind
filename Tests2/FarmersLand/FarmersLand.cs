using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarmersLand
{
    [TestClass]
    public class FarmersLand
    {
        [TestMethod]
        public void FarmersLandTest()
        {
            Assert.AreEqual(770, CalculateFieldInitialSize(230, 770000));
        }
        double CalculateFieldInitialSize (double additionalFieldLength, double finalFieldArea)
        {
            double discriminant = Math.Pow(additionalFieldLength, 2) + 4 * finalFieldArea;
            return (Math.Sqrt(discriminant)-additionalFieldLength)/2;
        }
        
    }
}
