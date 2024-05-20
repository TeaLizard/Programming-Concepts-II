using Assignment3_PROG1965_W24.Forms;
using Assignment3_PROG1965_W24.Model.Address;
using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.Model.HealthConditions;
using Assignment3_PROG1965_W24.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Model.Patient
{
    public class Patient : User
    {
        public int _PatientID;
        public HealthCard _HealthCard;
        public DateTime _dob;
        public Employee.Doctor? _FamilyDoctor;
        public List<HealthConditions.ICondition> _Conditions;

        public Patient(int patientID, string first, string last, Contact address, HealthCard healthCard, DateTime dob, List<HealthConditions.ICondition> conditions)
        {
            _PatientID = patientID;
            _FirstName = first;
            _LastName = last;
            _Address = address;
            _HealthCard = healthCard;
            _dob = dob;
            _Conditions = conditions;
            SetRole();
        }

        public Patient(string fullName)
        {
            string[] name = fullName.Split(" ");
            string record = FileIO.RecordContains(name[0], name[1], FileIO._PatientsFilePath);

            if (record == "")
            {
                MessageBox.Show("Doctor not found");
                return;
            }
            else
            {
                string[] fields = record.Split(",");
                _PatientID = int.Parse(fields[0]);
                _FirstName = name[0];
                _LastName = name[1];

                Contact contactInfo = new(record);
                _Address = contactInfo;
                HealthCard healthCard = new(fields[2]);
                _HealthCard = healthCard;
                int year = int.Parse(fields[1].Substring(6, 4));
                int month = int.Parse(fields[1].Substring(3, 2));
                int day = int.Parse(fields[1].Substring(0, 2));

                DateTime dob = new DateTime(year, month, day);
                _dob = dob;

                _Conditions = new List<ICondition>();

                SetRole();
            }
        }

        public override void SetRole()
        {
            _Role = Role.PATIENT;
        }

        public Employee.Doctor GetFamilyDoctor()
        {
            return _FamilyDoctor;
        }

        public void SetFamilyDoctor(Employee.Doctor doc)
        {
            _FamilyDoctor = doc;
        }
    }
}
