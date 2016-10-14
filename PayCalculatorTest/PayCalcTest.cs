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
        public void VerifySetBedTimeBoundsRestrictionIsValid()
        {
            myCalc.SetBedTime(64, 64, 64);
            Assert.AreEqual(12, myCalc.bedTime[0]);
            Assert.AreEqual(0, myCalc.bedTime[1]);
            Assert.AreEqual(0, myCalc.bedTime[2]);
        }

        [TestMethod]
        public void VerifySetEndTimeIsValid()
        {
            myCalc.SetEndTime(2, 52, 0);
            Assert.IsTrue(myCalc.endTime[0] > 0 && myCalc.endTime[0] >= 1 && myCalc.endTime[0] < 13);
        }

        [TestMethod]
        public void VerifySetEndTimeBoundsRestrictionIsValid()
        {
            myCalc.SetEndTime(64, 64, 64);
            Assert.AreEqual(1, myCalc.endTime[0]);
            Assert.AreEqual(0, myCalc.endTime[1]);
            Assert.AreEqual(0, myCalc.endTime[2]);
        }

        [TestMethod]
        public void VerifyCalculatePayFromStartToBed()
        {
            myCalc.SetStartTime(5, 0, 0);
            myCalc.SetBedTime(9, 0, 0);
            myCalc.CalculatePayFromStartToBed();
            Assert.AreEqual(48, myCalc.startToBedPay);

        }

        [TestMethod]
        public void VerifyCalculatePayFromBedToMidnight()
        {
            myCalc.SetBedTime(10, 55, 1); //This will round up to 11
            myCalc.CalculatePayFromBedToMidnight();
            Assert.AreEqual(8, myCalc.bedToMidnightPay);

        }

        [TestMethod]
        public void VerifyCalculatePayFromMidnightToEnd()
        {
            myCalc.SetEndTime(3, 29, 1); 
            myCalc.CalculatePayFromMidNightToEnd();
            Assert.AreEqual(48, myCalc.midnightToEndPay);

        }

        [TestMethod]
        public void VerifyCalculateNightsPay()
        {
            myCalc.SetStartTime(5, 31, 1); //round up to 6
            myCalc.SetBedTime(10, 42, 0); //round up to 11
            myCalc.SetEndTime(3, 45, 21); //round up to 4
            myCalc.CalculateNightsPay();
            Assert.AreEqual(132, myCalc.fullPay);

        }
    }
}
