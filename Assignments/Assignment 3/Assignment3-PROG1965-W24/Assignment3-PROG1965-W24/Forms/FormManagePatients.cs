using Assignment3_PROG1965_W24.Model.Address;
using Assignment3_PROG1965_W24.Model.Patient;
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
using static Assignment3_PROG1965_W24.Utility.Validators;
using static Assignment3_PROG1965_W24.Utility.StringUtility;
using static Assignment3_PROG1965_W24.Utility.FileIO;
using Assignment3_PROG1965_W24.Model.HealthConditions;
using Assignment3_PROG1965_W24.RecordEntry;
using Assignment3_PROG1965_W24.Model.Employee;

namespace Assignment3_PROG1965_W24.Forms
{
    public partial class FormManagePatients : Form
    {
        string _EmpID;
        string _EmployeeFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                   @"\DataFiles\employees.txt";
        string _PatientFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                  @"\DataFiles\patients.txt";

        public FormManagePatients()
        {
            InitializeComponent();
        }
        public FormManagePatients(string id)
        {
            InitializeComponent();
            _EmpID = id;
        }

        private void FormManagePatients_Load(object sender, EventArgs e)
        {
            labelLoggedInID.Text = $"Logged in with ID: {_EmpID}";

            FileIO.FillListBoxDoctor(listBoxDoctors, _EmployeeFilePath);
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            string firstName = textBoxFname.Text.Trim();
            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Empty first name");
                return;
            }
            string lastName = textBoxLname.Text.Trim();
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

            Province province = new Province(textBoxProv.Text.Trim());
            if (province._Code == "")
            {
                MessageBox.Show("Invalid Province (ex. Ontario)");
                return;
            }

            string postalCode = textBoxPcode.Text.Trim();
            if (ValidatePostalCode(postalCode) == "error")
            {
                return;
            }
            postalCode = FormatedPostalCode(ValidatePostalCode(postalCode));

            Phone phone = new Phone(textBoxPhone.Text.Trim());
            if (phone._Number == "error")
            {
                MessageBox.Show("Invalid phone number");
                return;
            }

            DateTime dob = dateTimePickerDOB.Value;
            if (dob == null)
            {
                MessageBox.Show("Enter your dat of birth");
                return;
            }
            else if (dob > DateTime.Now)
            {
                MessageBox.Show("Cannot be born in the future");
                return;
            }

            HealthCard healthCard = new HealthCard(textBoxHealthCard.Text.Trim());
            if (healthCard._Number == "error")
            {
                return;
            }

            string doctorName = listBoxDoctors.Text.Trim();
            if (string.IsNullOrEmpty(doctorName))
            {
                MessageBox.Show("Select your doctor");
                return;
            }


            ///////////////////////////////////////////////////////////////////////////////

            int id = FileIO.GetNewID(_PatientFilePath);
            if (id == -1)
            {
                return;
            }

            Contact contactInfo = new(address, city, province, postalCode, phone);
            List<ICondition> conditions = new List<ICondition>();

            Patient patient = new(id, firstName, lastName, contactInfo, healthCard, dob, conditions);
            PatientRecord patientRecord = new(patient);
            
            Doctor doctor = new(doctorName);
            
            FamilyDoctorRecord oldFamilyDoctorRecord = new(doctor); // Doctors current patients

            patient.SetFamilyDoctor(doctor);
            doctor.MyPatients().Add(patient); // Add this patient
             
            FamilyDoctorRecord newFamilyDoctorRecord = new(doctor); // All of the doctors patient with new patient

            AddRecord(patientRecord.RecordEntry(), _PatientsFilePath);
            // Replace old record of doctor's patients with new patient added vvv
            UpdateRecord(oldFamilyDoctorRecord.RecordEntry(), newFamilyDoctorRecord.RecordEntry(), _FamilyDoctorFilePath);

            MessageBox.Show($"Record has been added");
            
        }
    }
}
