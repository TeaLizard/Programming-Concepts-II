using Assignment3_PROG1965_W24.Model.Address;
using Assignment3_PROG1965_W24.Model.Patient;
using Assignment3_PROG1965_W24.RecordEntry;
using Assignment3_PROG1965_W24.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Employee
{
    public class Doctor : Employee
    {
        string _FamilyDoctorFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                       @"\DataFiles\family.txt";
        string _EmployeeFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                   @"\DataFiles\employee.txt";

        public List<Patient.Patient> _Patients = new List<Patient.Patient>();
        public Doctor(int id, string first, string last, Contact address, SIN sin)
        {
            _EmpID = id;
            _FirstName = first;
            _LastName = last;
            _Address = address;
            _SIN = sin;
            SetRole();
            _Patients = FileIO.ListPatients(this);
        }
        public Doctor(int id, string first, string last, Contact address, SIN sin, string password)
        {
            _EmpID = id;
            _FirstName = first;
            _LastName = last;
            _Address = address;
            _SIN = sin;
            _Password = password;
            SetRole();
            _Patients = FileIO.ListPatients(this);
        }

        public Doctor(string fullName)
        {
            string[] name = fullName.Split(" ");
            string record = FileIO.RecordContains(name[0], name[1], FileIO._EmployeesFilePath);

            if (record == "")
            {
                MessageBox.Show("Doctor not found");
                return;
            }
            else
            {
                string[] fields = record.Split(",");
                _EmpID = int.Parse(fields[0]);
                _FirstName = name[0];
                _LastName = name[1];

                Contact contactInfo = new(record);

                SIN sin = new(fields[2]);
                _SIN = sin;

                SetRole();

                _Patients = FileIO.ListPatients(this);
            }
            
        }
        public override void SetRole()
        {
            _Role = Role.DOCTOR;
        }

        public List<Patient.Patient> MyPatients()
        {
            return _Patients;
        }
    }
}