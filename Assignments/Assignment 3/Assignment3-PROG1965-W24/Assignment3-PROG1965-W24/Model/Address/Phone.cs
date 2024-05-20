using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Address
{
    public class Phone
    {
        public string _Number;
        public Phone(string phoneNumber)
        {
            _Number = Utility.Validators.ValidatePhoneNumber(phoneNumber);
        }

        public override string ToString()
        {
            return Utility.StringUtility.FormatedPhoneNumber(_Number);
        }
    }
}
