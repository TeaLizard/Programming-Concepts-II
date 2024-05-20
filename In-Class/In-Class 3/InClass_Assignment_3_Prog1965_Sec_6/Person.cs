using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Assignment_3_Prog1965_Sec_6
{
    public class Person
    {
        private string? DateOfBirth;
        public Person() { }
        public Person(string dateOfBirth) 
        { 
            DateOfBirth = dateOfBirth;
        }

        public string GetDOB()
        {
            return DateOfBirth;
        }
        public void SetDOB(string dateOfBirth)
        {
            DateOfBirth = dateOfBirth; 
        }
    }
}
