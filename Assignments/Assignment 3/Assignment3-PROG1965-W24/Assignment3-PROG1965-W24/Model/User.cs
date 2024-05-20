using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3_PROG1965_W24.Model.Address;

namespace Assignment3_PROG1965_W24.Model
{
    public abstract class User
    {
        // Insert constant values to complete the code for the enum "Role" 
        public enum Role { DOCTOR = 0, ADMIN = 1, SECRATERY = 2, PATIENT = 3 }
        protected string _FirstName;
        protected string _LastName;
        protected Contact _Address;
        protected Role _Role; // For class Model and OOP task 1, It looks like you already did what you asked me to do already I assume _Role is the _RoleType you were reffereing to
        
        public string GetFirstName() { 
            return _FirstName; 
        }
        public string GetLastName() { 
            return _LastName; 
        }
        public Contact GetContact()
        {
            return _Address;
        }
        public Role GetRole()
        {
            return _Role;
        }
        public abstract void SetRole();
    }
}
