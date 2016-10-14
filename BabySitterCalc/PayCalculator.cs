using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BabySitterCalc
{
    public class PayCalculator
    {
        public int [] startTime = { 0,0,0};
        public int[] bedTime = { 0, 0, 0 };
        public int[] endTime = { 0, 0, 0 };

        public void SetStartTime(int hour, int min, int secs)
        {
            hour = BoundsCheck(5, 12, hour);
            min = BoundsCheck(0, 59, min);
            secs = BoundsCheck(0, 59, secs);

            if (min > 30)
            {
                hour += 1;
                hour = BoundsCheck(5, 12, hour);
                min = 0;
                secs = 0;
            }

            startTime[0] = hour;
            startTime[1] = min;
            startTime[2] = secs;
        }

        public void SetBedTime(int hour, int min, int secs)
        {
            hour = BoundsCheck(5, 12, hour);
            min = BoundsCheck(0, 59, min);
            secs = BoundsCheck(0, 59, secs);

            if (min > 30)
            {
                hour += 1;
                hour = BoundsCheck(5, 12, hour);
                min = 0;
                secs = 0;
            }

            bedTime[0] = hour;
            bedTime[1] = min;
            bedTime[2] = secs;
        }

        public int BoundsCheck(int min, int max, int arg)
        {
            if (arg < min)
            {
                arg = min;
            }
            else if( arg > max)
            {
                arg = max;
            }

            return arg;
        }
    }
}
