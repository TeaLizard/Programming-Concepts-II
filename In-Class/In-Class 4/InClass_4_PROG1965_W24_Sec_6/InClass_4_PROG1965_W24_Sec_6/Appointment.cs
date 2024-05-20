using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_4_PROG1965_W24_Sec_6
{
    internal class Appointment
    {
        string _Name { get; set; }
        string _Phone { get; set; }
        DateTime _ApptDate { get; set; }
        string _Location { get; set; }
        string _Service { get; set; }

        public Appointment(string n, string p, DateTime d, string l, string s) {
            _Name = n;
            _Phone = p;
            _ApptDate = d;
            _Location = l;
            _Service = s;
        }

        public override string ToString()
        {
            return $"{_ApptDate.ToString("MM/dd/yyyy")},{_Name},{_Phone},{_Location},{_Service}";
        }
    }
}
