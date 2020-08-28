using System;
using System.Collections.Generic;
using System.Text;
using static Vital.Range;


namespace Vital
{
    public class VitalsChecker
    {
        public static bool vitalsAreOk(float bpm, float spo2, float respRate)
        {
            bool bpmVital = CheckRange(bpm,70,100,"Beats Per Minute");
            bool spo2Vital = CheckRange(spo2,80,100,"Blood Oxygen Level");
            bool respRateVital = CheckRange(respRate,30,95,"Respiratory Rate");
            return(bpmVital && spo2Vital && respRateVital);
        }
    }
}
