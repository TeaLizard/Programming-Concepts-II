using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment3_PROG1965_W24.Model.HealthConditions.ICondition;

namespace Assignment3_PROG1965_W24.Model.HealthConditions
{
    internal class Hypertension : ICondition
    {
        public double SystolicPressure; // (mmHg)
        public double DiastolicPressure; // (mmHg)
        public Hypertension(double systolicPressure, double diastolicPressure)
        {
            SystolicPressure = systolicPressure;
            DiastolicPressure = diastolicPressure;
        }
        public Level Status() // Attention!! The way the level is to be implemented is not clear at all, I did what I could.
        {                     // It does not make sense, if you wanted a separate status for each variable you should have specefied.
                              // The way this is implemented does not make sense either. Why would low blood pressure show as red if is good??
            double weightedSystolic = SystolicPressure / 120;
            double weightedDiastolic = DiastolicPressure / 80;
            switch (weightedSystolic + weightedDiastolic)
            {
                case < 1.7:
                    return Level.LOW;
                case < 2:
                    return Level.NORMAL;
                case < 2.3:
                    return Level.HIGH;
                default:
                    return Level.CRITICAL;
            }
        }
    }
}
