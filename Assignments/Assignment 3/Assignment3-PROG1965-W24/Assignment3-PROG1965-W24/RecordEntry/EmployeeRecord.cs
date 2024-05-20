using Assignment3_PROG1965_W24.Model.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.RecordEntry
{
    internal class EmployeeRecord : Record
    {
        public EmployeeRecord(Model.Employee.Employee e) {
            label = "";
            delimeter = ",";
            string id = e.GetEmpID().ToString();
            int idLength = id.Length;
            for (int i = 0; i < (6 - idLength); i++)
            {
                id = $"0{id}";
            }
            entries.Add(id);
            entries.Add(e.GetRole().ToString());
            entries.Add(e.GetSIN().ToString());
            entries.Add(e.GetFirstName());
            entries.Add(e.GetLastName());
            entries.Add(e.GetContact().ToString());

        }
        override public string RecordEntry()
        {
            string output = label;
            for(int i = 0;i< entries.Count - 1; i++)
            {
                output = output + entries[i] + delimeter;
            }
            return output + entries[entries.Count - 1];
        }
    }
}
