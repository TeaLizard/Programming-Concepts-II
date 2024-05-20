using Assignment3_PROG1965_W24.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Address
{
    public class Contact
    {
        string? _StreetAddress;
        string? _City;
        Province? _Province;
        string? _PostalCode;
        Phone? _Phone;

        public Contact() { }

        public Contact(string record)
        {
            string[] fields = record.Split(',');

            _StreetAddress = fields[5];
            _City = fields[6];
            _Province = new Province(fields[7]);
            _PostalCode = fields[8];
            _Phone = new Phone(fields[9]);
        }
        public Contact(string streetAddress, string city, Province prov, string postalCode, Phone ph)
        {
            Utility.StringUtility.ElegantCase(ref streetAddress);
            _StreetAddress = streetAddress;
            Utility.StringUtility.ElegantCase(ref city);
            _City = city;
            _Province = prov;
            _PostalCode = StringUtility.FormatedPostalCode(Validators.ValidatePostalCode(postalCode));
            _Phone = ph;
        }
        public override string ToString()
        {
            return _StreetAddress + "," + _City + "," + _Province.ToString() + "," + _PostalCode + ",Phone:" + _Phone.ToString();
        }
    }
}
