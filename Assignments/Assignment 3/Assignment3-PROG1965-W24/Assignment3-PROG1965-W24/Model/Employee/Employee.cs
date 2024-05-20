using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Employee
{
    public abstract class Employee : User
    {
        protected int _EmpID;
        protected SIN _SIN;
        protected string? _Password;
        public int GetEmpID() { return _EmpID; }
        public SIN GetSIN() { return _SIN; }
        public string? GetPassword() {  return _Password; }
    }
}
