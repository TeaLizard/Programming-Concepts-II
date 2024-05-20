using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Employee
{
    public class SIN
    {
        public string _siNumber;

        public SIN(string number)
        {
            _siNumber = Utility.Validators.ValidateSIN(number);
        }

        public override string ToString()
        {
            return Utility.StringUtility.FormatedSIN(_siNumber);
        }
    }
}
