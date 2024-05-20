using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.Model.Patient;
using Assignment3_PROG1965_W24.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.RecordEntry
{
    internal class AccessRecord : Record
    {
        public AccessRecord(Employee e)
        {
            entries.Add(StringUtility.GetFullID(e.GetEmpID()));
            entries.Add(e.GetPassword());
            string roleString = e.GetRole().ToString();
            StringUtility.ElegantCase(ref roleString);
            entries.Add(roleString);
        }
        public override string RecordEntry()
        {
            string output = "";
            for (int i = 0; i < entries.Count - 1; i++)
            {
                output = output + entries[i] + ",";
            }
            return output + entries[entries.Count - 1];
        }
    }
}
