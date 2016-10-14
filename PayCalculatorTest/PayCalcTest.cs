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
        public void VerifyBedTimeIsValid()
        {
            myCalc.bedTime[0] = 7;
            myCalc.bedTime[1] = 00;
            myCalc.bedTime[2] = 00;
            Assert.IsTrue(myCalc.bedTime[0] > 0 && myCalc.bedTime[0] >= 1 && myCalc.bedTime[0] < 13);
        }

        [TestMethod]
        public void VerifyEndTimeIsValid()
        {
            myCalc.endTime[0] = 7;
            myCalc.endTime[1] = 00;
            myCalc.endTime[2] = 00;
            Assert.IsTrue(myCalc.endTime[0] > 0 && myCalc.endTime[0] >= 1 && myCalc.endTime[0] < 13);
        }
    }
}
