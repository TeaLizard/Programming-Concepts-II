using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment3_PROG1965_W24.Model.HealthConditions.ICondition;

namespace Assignment3_PROG1965_W24.Model.HealthConditions
{
    internal class Diabetes : ICondition
    {
        double bloodSugarLevel;

        public Diabetes(double val) { 
        bloodSugarLevel = val;
        }

        public Level Status() {

            Level level = new Level();

            switch (bloodSugarLevel)
            { 
                case < 80:
                    level=Level.LOW; 
                    break;

                case < 110:
                    level = Level.NORMAL;
                    break;

                case < 140:
                    level = Level.HIGH;
                    break;

                case < 180:
                    level = Level.CRITICAL;
                    break;

                default : return level;
            }
            return level;
        }
    }
}
