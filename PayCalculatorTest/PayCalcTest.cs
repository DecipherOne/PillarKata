﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterCalc;

namespace PayCalculatorTest
{


    [TestClass]
    public class PayCalcTest
    {
        
        PayCalculator myCalc = new PayCalculator();

        [TestMethod]
        public void VerifyStartTimeIsValid()
        {
            myCalc.startTime[0] = 10;
            myCalc.startTime[1] = 00;
            myCalc.startTime[2] = 00;
            Assert.IsTrue(myCalc.startTime[0] > 5 && myCalc.startTime[0] < 13);
                        
        }
    }
}
