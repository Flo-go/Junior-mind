using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzz
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            Assert.AreEqual("FizzBuzz", DetermineFizzBuzz(60));
        }

        [TestMethod]
        public void FizzTest()
        {
            Assert.AreEqual("Fizz", DetermineFizzBuzz(36));
        }

        [TestMethod]
        public void BuzzTest()
        {
            Assert.AreEqual("Buzz", DetermineFizzBuzz(65));
        }
        string DetermineFizzBuzz(int number)
        {
            int reminderFromThree;
            int reminderFromFive;
            Math.DivRem(number, 3, out reminderFromThree);
            Math.DivRem(number, 5, out reminderFromFive);
            if (reminderFromThree == 0 & reminderFromFive == 0)
            {
                return "FizzBuzz";
            }
            if (reminderFromThree == 0)
            {
                return "Fizz";
            }
            return "Buzz";
        }
    }
}
