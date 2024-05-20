using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Assignment_3_Prog1965_Sec_6
{
    public class Driver : Person
    {
        public string FirstName, LastName;
        public string? LicenceNumber, LicenceClass;
        public Driver(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Driver(string firstName, string lastName, string licenceNumber, string licenceClass)
        {
            FirstName = firstName;
            LastName = lastName;
            LicenceNumber = licenceNumber;
            LicenceClass = licenceClass;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {LicenceNumber} {LicenceClass}";
        }
    }
}
