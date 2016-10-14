using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterCalc;

namespace PayCalculatorTest
{


    [TestClass]
    public class PayCalcTest
    {
        
        PayCalculator myCalc = new PayCalculator();

        [TestMethod]

        public void VerifySetStartTimeIsValid()
        {
            myCalc.SetStartTime(7, 0, 0);
            Assert.IsTrue(myCalc.startTime[0] > 0 && myCalc.startTime[0] >= 5 && myCalc.startTime[0] < 13);
        }

        [TestMethod]
        public void VerifySetStartTimeBoundsRestrictionIsValid()
        {
            myCalc.SetStartTime(64, 64, 64);
            Assert.AreEqual(12, myCalc.startTime[0]);
            Assert.AreEqual(0, myCalc.startTime[1]);
            Assert.AreEqual(0, myCalc.startTime[2]);
        }

        [TestMethod]
        public void VerifySetBedTimeIsValid()
        {
            myCalc.SetBedTime(9, 22, 0);
            Assert.IsTrue(myCalc.bedTime[0] > 0 && myCalc.bedTime[0] >= 1 && myCalc.bedTime[0] < 13);
        }

        [TestMethod]
        public void VerifySetEndTimeIsValid()
        {
            myCalc.SetEndTime(2, 52, 0);
            Assert.IsTrue(myCalc.endTime[0] > 0 && myCalc.endTime[0] >= 1 && myCalc.endTime[0] < 13);
        }
    }
}
