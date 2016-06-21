using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training

{
    [TestClass]
    public class Training
    {
        [TestMethod]

        public void TrainingSolution()
        {
            int Rehearsals = CalculateRehearsals(4);
            Assert.AreEqual(16, Rehearsals);
        }

        int CalculateRehearsals(int NumberOfRounds)
        {
            return (NumberOfRounds-1)*NumberOfRounds+NumberOfRounds;
        }

    }
}
