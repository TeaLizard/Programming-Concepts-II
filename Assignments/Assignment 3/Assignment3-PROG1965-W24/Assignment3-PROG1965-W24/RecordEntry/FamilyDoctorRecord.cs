using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.RecordEntry
{
    internal class FamilyDoctorRecord : Record
    {

        public FamilyDoctorRecord(Doctor e)
        {
            {
                string id = e.GetEmpID().ToString();
                int idLength = id.Length;
                for (int i = 0; i < (6 - idLength); i++)
                {
                    id = $"0{id}";
                }
                entries.Add(id);
            }
            foreach (Patient p in e.MyPatients())
            {
                string id = p._PatientID.ToString();
                int idLength = id.Length;
                for (int i = 0; i < (6 - idLength); i++)
                {
                    id = $"0{id}";
                }
                entries.Add(id);
            }
        }
        public override string RecordEntry() // Replacing an entry, not adding one
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
