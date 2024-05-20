using Assignment3_PROG1965_W24.Model.Patient;
using Assignment3_PROG1965_W24.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.RecordEntry
{
    internal class PatientRecord : Record
    {
        public PatientRecord(Patient e)
        {
            string id = e._PatientID.ToString();
            int idLength = id.Length;
            for (int i = 0; i < (6 - idLength); i++)
            {
                id = $"0{id}";
            }
            entries.Add(id);
            entries.Add(StringUtility.ShortDate(e._dob));
            entries.Add(e._HealthCard.ToString());
            entries.Add(e.GetFirstName());
            entries.Add(e.GetLastName());
            entries.Add(e.GetContact().ToString());
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
