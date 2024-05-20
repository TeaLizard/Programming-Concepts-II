using Assignment3_PROG1965_W24.Model.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Employee
{
    public class Admin : Employee
    {
        public Admin(int id, string first, string last, Contact address, SIN sin, string password)
        {
            _EmpID = id;
            _FirstName = first;
            _LastName = last;
            _Address = address;
            _SIN = sin;
            _Password = password;
            SetRole();
        }

        public override void SetRole()
        {
            _Role = Role.ADMIN;
        }
    }
}
