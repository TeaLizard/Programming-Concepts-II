using Assignment3_PROG1965_W24.Model.Address;
using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.Model.HealthConditions;
using Assignment3_PROG1965_W24.Model.Patient;
using Assignment3_PROG1965_W24.RecordEntry;
using Assignment3_PROG1965_W24.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment3_PROG1965_W24.Utility.FileIO;
using static Assignment3_PROG1965_W24.Utility.Validators;
using static Assignment3_PROG1965_W24.Utility.StringUtility;
using Assignment3_PROG1965_W24.Model;

namespace Assignment3_PROG1965_W24.Forms
{
    public partial class FormManageStaff : Form
    {
        string _EmpID; // ID of the logged-in employee

        public FormManageStaff()
        {
            InitializeComponent();
        }
        public FormManageStaff(string id)
        {
            InitializeComponent();
            _EmpID = id;
        }

        private void AddNewEmployee(object sender, EventArgs e)
        {
            string roleString = listBoxRoles.Text;
            User.Role role = new User.Role();
            if (string.IsNullOrEmpty(roleString))
            {
                MessageBox.Show("Empty role");
                return;
            }
            switch (roleString)
            {
                case "Doctor":
                    role = User.Role.DOCTOR;
                    break;
                case "Secratery":
                    role = User.Role.SECRATERY;
                    break;
                case "Admin":
                    role = User.Role.ADMIN;
                    break;
            }

            string firstName = textBoxFirstName.Text.Trim();
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Empty first name");
                return;
            }
            string lastName = textBoxLastName.Text.Trim();
            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Empty last name");
                return;
            }

            string city = textBoxCity.Text.Trim();
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Empty city name");
                return;
            }

            string address = textBoxAddress.Text.Trim();
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Empty address");
                return;
            }

            Province province = new Province(textBoxProvince.Text.Trim());
            if (province._Code == "")
            {
                MessageBox.Show("Invalid Province (ex. Ontario)");
                return;
            }

            string postalCode = textBoxPostalCode.Text.Trim();
            if (ValidatePostalCode(postalCode) == "error")
            {
                return;
            }
            postalCode = FormatedPostalCode(ValidatePostalCode(postalCode));

            Phone phone = new Phone(textBoxPhoneNumber.Text.Trim());
            if (phone._Number == "error")
            {
                MessageBox.Show("Invalid phone number");
                return;
            }

            SIN sin = new SIN(textBoxSIN.Text.Trim());
            if (sin._siNumber == "error")
            {
                MessageBox.Show("Invalid social insurance number");
                return;
            }

            string password = textBoxPass.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Empty password");
                return;
            }

            ///////////////////////////////////////////////////////////////////////////////

            int id = GetNewID(_PatientsFilePath);
            if (id == -1)
            {
                return;
            }

            Contact contactInfo = new(address, city, province, postalCode, phone);
            Employee user = null;
            switch (role)
            {
                case User.Role.DOCTOR:
                    Doctor doctor = new(id, firstName, lastName, contactInfo, sin, password);
                    user = doctor;
                    break;
                case User.Role.SECRATERY:
                    Secretary secretary = new(id, firstName, lastName, contactInfo, sin, password);
                    user = secretary;
                    break;
                case User.Role.ADMIN:
                    Admin admin = new(id, firstName, lastName, contactInfo, sin, password);
                    user = admin;
                    break;

            }
            EmployeeRecord employeeRecord = new(user);
            AccessRecord accessRecord = new(user);

            AddRecord(employeeRecord.RecordEntry(), _EmployeesFilePath);
            AddRecord(accessRecord.RecordEntry(), _AccessFilePath);

            MessageBox.Show($"Record has been added");
        }

        private void FormManageStaff_Load(object sender, EventArgs e)
        {
            labelStatus.Text = $"Logged-in with ID: {_EmpID}";
        }
    }
}
