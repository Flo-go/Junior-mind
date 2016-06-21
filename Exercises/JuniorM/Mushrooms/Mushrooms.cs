using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class Mushrooms
    {
        [TestMethod]

        public void MushroomsSolution()
        {
            int RedMushrooms = CalculateRedMushrooms(18,5);
            Assert.AreEqual(15, RedMushrooms);
        }

        int CalculateRedMushrooms(int TotalMushrooms, int RateRedvsWhiteMushrooms)
        {
            return TotalMushrooms*RateRedvsWhiteMushrooms/(RateRedvsWhiteMushrooms+1);
        }

    }
}
