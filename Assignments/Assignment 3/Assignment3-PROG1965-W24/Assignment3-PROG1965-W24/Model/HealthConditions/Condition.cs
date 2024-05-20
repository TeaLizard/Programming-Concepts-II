using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.HealthConditions
{
    public interface ICondition
    {
        public enum Level { LOW, NORMAL, HIGH, CRITICAL }

        public Level Status();
    }
}
