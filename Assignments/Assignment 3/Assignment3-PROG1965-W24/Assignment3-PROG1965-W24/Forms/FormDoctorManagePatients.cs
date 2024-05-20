using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.Model.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment3_PROG1965_W24.Utility.FileIO;
using static Assignment3_PROG1965_W24.Utility.StringUtility;
using static Assignment3_PROG1965_W24.Utility.Validators;

namespace Assignment3_PROG1965_W24.Forms
{
    public partial class FormDoctorManagePatients : Form
    {
        string patientsFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                              @"\DataFiles\patients.txt";
        string familyFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                            @"\DataFiles\family.txt";
        string reportsDirPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                @"\DataFiles\Reports";
        string notesDirPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                              @"\DataFiles\Notes";
        string logged_in_Doctor_ID;
        private static Doctor _LoggedInDoctor;
        string selected_patient_HC;
        private static string selectedNoteFilePath = "";
        public FormDoctorManagePatients()
        {
            InitializeComponent();
        }
        public FormDoctorManagePatients(string login)
        {
            InitializeComponent();
            logged_in_Doctor_ID = login;
        }

        private void FormDoctorManagePatients_Load(object sender, EventArgs e)
        {
            labelStatus.Text = $"Logged-in ID: {logged_in_Doctor_ID}";

            buttonNewNote.Enabled = false;
            buttonSave.Enabled = false;
            richTextBoxNote.Enabled = false;
            richTextBoxReport.Enabled = false;

            string record = RecordContains(GetFullID(int.Parse(logged_in_Doctor_ID)), _EmployeesFilePath);
            string[] fields = record.Split(",");

            _LoggedInDoctor = new($"{fields[3]} {fields[4]}");

            ListBoxMyPatients.Items.AddRange(MyPatientsHealthCardNumbers().ToArray());
        }

        public static string GetHealthCardNumber(int patientID)
        {
            string record = RecordContains(GetFullID(patientID), _PatientsFilePath);
            string[] fields = record.Split(",");


            return fields[2];
        }

        public static List<string> MyPatientsHealthCardNumbers()
        {
            List<string> list = new List<string>();
            foreach (Patient patient in _LoggedInDoctor.MyPatients()) // It would be better to just pull the HCs from these patients
            {
                list.Add(GetHealthCardNumber(patient._PatientID));
            }
            return list;
        }

        private void HealthCardSelected(object sender, EventArgs e)
        {
            ListBoxMyPatientReports.Items.Clear();
            ListBoxMyPatientNotes.Items.Clear();

            int infoAvailable = 0;

            selected_patient_HC = ListBoxMyPatients.Text;

            if (Directory.Exists($@"{_ReportsFilePath}/{selected_patient_HC.Replace("-", "")}"))
            { // Populate with reports
                //Directory.EnumerateFiles($@"{_ReportsFilePath}/{selected_patient_HC.Replace("-", "")}").ToArray()
                foreach (string file in Directory.EnumerateFiles($@"{_ReportsFilePath}/{selected_patient_HC.Replace("-", "")}").ToArray())
                {
                    string fileName = file.Split(@"\")[file.Split(@"\").Length - 1].Split(".")[0];
                    ListBoxMyPatientReports.Items.Add(fileName);
                }
            }
            else { infoAvailable++; MessageBox.Show("No reports found"); }

            if (Directory.Exists($@"{_NotesFilePath}/{selected_patient_HC.Replace("-", "")}"))
            { // Populate with reports
                //Directory.EnumerateFiles($@"{_ReportsFilePath}/{selected_patient_HC.Replace("-", "")}").ToArray()
                foreach (string file in Directory.EnumerateFiles($@"{_NotesFilePath}/{selected_patient_HC.Replace("-", "")}").ToArray())
                {
                    string fileName = file.Split(@"\")[file.Split(@"\").Length - 1].Split(".")[0];
                    ListBoxMyPatientNotes.Items.Add(fileName);
                }
            }
            else { infoAvailable++; MessageBox.Show("No notes found"); }

            buttonNewNote.Enabled = true;
        }

        private void LoadReport(object sender, EventArgs e)
        {
            string filePath = @$"{_ReportsFilePath}\{selected_patient_HC.Replace("-", "")}\{ListBoxMyPatientReports.Text}.txt";

            FillRichTextBox(richTextBoxReport, filePath);
        }

        private void LoadNote(object sender, EventArgs e)
        {
            string filePath = @$"{_NotesFilePath}\{selected_patient_HC.Replace("-", "")}\{ListBoxMyPatientNotes.Text}.rtf";
            selectedNoteFilePath = filePath;

            //FillRichTextBox(richTextBoxNote, filePath);
            richTextBoxNote.Rtf = File.ReadAllText(filePath);

            richTextBoxNote.Enabled = true;
            buttonSave.Enabled = true;
        }

        private void NewNote(object sender, EventArgs e)
        {
            buttonSave.Enabled = true;
            selectedNoteFilePath = "";
            richTextBoxNote.Clear();
        }

        private void SaveNote(object sender, EventArgs e)
        {
            if (selectedNoteFilePath != "")
            {
                richTextBoxNote.SaveFile(selectedNoteFilePath);
            }
            else
            {
                string filePath = @$"{_NotesFilePath}\{selected_patient_HC.Replace("-", "")}\{DateTime.Now.ToString("ssmmhh-ddMMyyyy")}.rtf";
                richTextBoxNote.SaveFile(filePath);
            }
        }
    }
}
