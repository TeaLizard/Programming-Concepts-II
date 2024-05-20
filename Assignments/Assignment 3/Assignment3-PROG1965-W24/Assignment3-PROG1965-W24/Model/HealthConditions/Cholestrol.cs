using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment3_PROG1965_W24.Model.HealthConditions.ICondition;

namespace Assignment3_PROG1965_W24.Model.HealthConditions
{
    internal class Cholestrol : ICondition
    {
        public double LDL; // (mg/dL)
        public double HDL; // (mg/dL)
        public Cholestrol(double ldl, double hdl)
        {
            LDL = ldl;
            HDL = hdl;
        }

        public Level Status() // Attention!! The way the level is to be implemented is not clear at all, I did what I could.
        {                     // It does not make sense, if you wanted a separate status for each variable you should have specefied.
                              // The way this is implemented does not make sense either. Why would high HDL or low LDL show as red if they are good??
            switch (LDL / HDL)
            {
                case < 4.5:
                    return Level.LOW;
                case < 6:
                    return Level.NORMAL;
                case < 9:
                    return Level.HIGH;
                default:
                    return Level.CRITICAL;
            }
        }
    }
}
