using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Patient
{
    public class HealthCard
    {
        public string _Number;

        public HealthCard(string number)
        {
            _Number = Utility.Validators.ValidateHealthCardNumber(number);
        }

        public override string ToString()
        {
            return Utility.StringUtility.FormatedHealthCardNumber(_Number);
        }
    }
}
