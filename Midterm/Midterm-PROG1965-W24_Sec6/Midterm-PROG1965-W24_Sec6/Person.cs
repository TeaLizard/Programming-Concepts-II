using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_PROG1965_W24_Sec6
{
    public class Person : FormPersons
    {
        string _firstName;  // First name of the person
        string _lastName;   // Last name of the person
        Int64 _sin;         // Social insurance number
        DateTime _birthday; // Date of birth

        // Constructor for the class Person
        public Person(string fName, string lName, Int64 sin, DateTime dob)
        {

            _firstName = fName;
            _lastName = lName;
            _sin = sin;
            _birthday = dob;
        }

        //Over-ridden ToString() method
        public override string ToString()
        {
            return $"{_firstName} {_lastName} Age:{Age()} SIN:{_sin}";
        }

        // Method: Returns the age of the person in years 
        int Age()
        {
            int ageReturn = DateTime.Now.Year - _birthday.Year;
            return ageReturn;
        }
    }
}
