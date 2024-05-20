using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Drawing.Font;
using static Assignment3_PROG1965_W24.Model.HealthConditions.ICondition;
using Assignment3_PROG1965_W24.Model.HealthConditions;
using Assignment3_PROG1965_W24.Model.Employee;
using static Assignment3_PROG1965_W24.Utility.FileIO;
using static Assignment3_PROG1965_W24.Utility.StringUtility;
using static Assignment3_PROG1965_W24.Utility.Validators;
using Assignment3_PROG1965_W24.Model.Patient;

namespace Assignment3_PROG1965_W24.Forms
{
    public partial class FormManageDocuments : Form
    {

        string selectedFile = "";
        string selectedPatientHC = "";
        string reportDate = "";
        private static string EmployeeID;
        private static Patient _Patient;

        public FormManageDocuments()
        {
            InitializeComponent();
        }
        public FormManageDocuments(string id)
        {
            InitializeComponent();
            EmployeeID = id;
        }
        public static void AppendColorText(RichTextBox box, string text, Color color, System.Drawing.Font font)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = text.Length;
            box.SelectionColor = color;
            box.SelectionFont = font;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void FormManageDocuments_Load(object sender, EventArgs e)
        {
            labelLoggedInID.Text = $"Logged-in with ID: {EmployeeID}";

            buttonLoadReport.Enabled = true;
            buttonSaveReport.Enabled = false;
            buttonAnalytics.Enabled = false;
            buttonEditNote.Enabled = false;
            buttonSaveNote.Enabled = false;

            richTextBoxLoadFile.Enabled = false;
            richTextBoxNote.Enabled = false;
        }

        private void LoadReport(object sender, EventArgs e)
        {
            ListBoxFolder.Items.Clear();
            ListBoxFile.Items.Clear();

            PanelReport.Visible = true;

            ListBoxFolder.Items.Add(_UnReadReportsFilePath);
            foreach (string directory in Directory.GetDirectories(_ReportsFilePath))
            {
                ListBoxFolder.Items.Add(directory);

            }
        }

        private void UpdateListBoxFiles(object sender, EventArgs e)
        {
            ListBoxFile.Items.Clear();

            foreach (string file in Directory.GetFiles(ListBoxFolder.Text))
            {
                ListBoxFile.Items.Add(file);
            }
        }

        private void ClosePanel(object sender, EventArgs e)
        {
            PanelReport.Visible = false;
            if (string.IsNullOrEmpty(ListBoxFile.Text))
            {
                MessageBox.Show("Report not selected");
            }
            else
            {
                selectedFile = ListBoxFile.Text;
                FillRichTextBox(richTextBoxLoadFile, selectedFile, out reportDate, out selectedPatientHC);

                richTextBoxLoadFile.Enabled = true;
                buttonAnalytics.Enabled = true;
                buttonSaveReport.Enabled = true;
            }
        }

        private void SaveReport(object sender, EventArgs e)
        {
            //File.WriteAllText(@$"{_ReportsFilePath}\{selectedPatientHC}\{reportDate}.txt", richTextBoxLoadFile.Text);

            // This creates or overrides the folder and file. vvv
            try
            {
                File.WriteAllText(@$"{_ReportsFilePath}\{selectedPatientHC}\{reportDate}.txt", richTextBoxLoadFile.Text);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory($@"{_ReportsFilePath}\{selectedPatientHC}");
                File.WriteAllText(@$"{_ReportsFilePath}\{selectedPatientHC}\{reportDate}.txt", richTextBoxLoadFile.Text);
            }
        }

        public void SaveReport(string text, string fileType, string filePath)
        {
            //File.WriteAllText(@$"{filePath}\{selectedPatientHC}\{DateTime.Now.ToString("ssmmhh-ddMMyyyy")}.{fileType}", text);
            //File.WriteAllText(@$"{filePath}\test\test.{fileType}", text);

            // This creates or overrides the folder and file. vvv
            try
            {
                File.WriteAllText(@$"{filePath}\{selectedPatientHC}\{DateTime.Now.ToString("ssmmhh-ddMMyyyy")}.{fileType}", text);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory($@"{filePath}\{selectedPatientHC}");
                File.WriteAllText(@$"{filePath}\{selectedPatientHC}\{DateTime.Now.ToString("ssmmhh-ddMMyyyy")}.{fileType}", text);
            }
        }

        private void ShowAnalytics(object sender, EventArgs e)
        {
            buttonEditNote.Enabled = true;
            string[] conditionValues = new string[5];
            string[] records = richTextBoxLoadFile.Text.Split("\n");
            string[] savedRecords = new string[5];
            foreach (string record in records)
            {
                string[] fields = record.Split(' ');
                if (record.Contains("Blood Sugar level"))
                {
                    conditionValues[0] = fields[4];
                    savedRecords[0] = record;
                }
                else if (record.Contains("(LDL)"))
                {
                    conditionValues[1] = fields[3];
                    savedRecords[1] = record;
                }
                else if (record.Contains("(HDL)"))
                {
                    conditionValues[2] = fields[3];
                    savedRecords[2] = record;
                }
                else if (record.Contains("(systolic)"))
                {
                    conditionValues[3] = fields[4];
                    savedRecords[3] = record;
                }
                else if (record.Contains("(diastolic)"))
                {
                    conditionValues[4] = fields[4];
                    savedRecords[4] = record;
                }
            }

            Diabetes diabetes = new Diabetes(double.Parse(conditionValues[0]));
            Cholestrol cholestrol = new Cholestrol(double.Parse(conditionValues[1]), double.Parse(conditionValues[2]));
            Hypertension hypertension = new Hypertension(double.Parse(conditionValues[3]), double.Parse(conditionValues[4]));

            bool[] isNormal = { true, true, true };

            if (diabetes.Status() != Level.NORMAL) // Attention!! If you test this and get red text when it wasn't red on yours
            {                                      // it's because I implemented it differently the best I could.
                isNormal[0] = false;
            }
            if (cholestrol.Status() != Level.NORMAL)
            {
                isNormal[1] = false;
            }
            if (hypertension.Status() != Level.NORMAL)
            {
                isNormal[2] = false;
            }

            richTextBoxNote.Text = "";

            if (isNormal[0])
            {
                richTextBoxNote.Text += savedRecords[0] + "\n";
            }
            else
            {
                AppendColorText(richTextBoxNote, savedRecords[0] + "\n", Color.Red, SpecialFont.Font); // Got font from an empty label I made
            }
            if (isNormal[1])
            {
                richTextBoxNote.Text += savedRecords[1] + "\n";
                richTextBoxNote.Text += savedRecords[2] + "\n";
            }
            else
            {
                AppendColorText(richTextBoxNote, savedRecords[1] + "\n", Color.Red, SpecialFont.Font); // Got font from an empty label I made
                AppendColorText(richTextBoxNote, savedRecords[2] + "\n", Color.Red, SpecialFont.Font);
            }
            if (isNormal[2])
            {
                richTextBoxNote.Text += savedRecords[3] + "\n";
                richTextBoxNote.Text += savedRecords[4] + "\n";
            }
            else
            {
                AppendColorText(richTextBoxNote, savedRecords[3] + "\n", Color.Red, SpecialFont.Font); // Got font from an empty label I made
                AppendColorText(richTextBoxNote, savedRecords[4] + "\n", Color.Red, SpecialFont.Font);
            }

            string[] nameGetter = records[1].Split(" ");

            Patient patient = new Patient($"{nameGetter[1]} {nameGetter[2]}");

            if (!isNormal[0])
            {
                patient._Conditions.Add(diabetes);
            }
            if (!isNormal[1])
            {
                patient._Conditions.Add(cholestrol);
            }
            if (!isNormal[2])
            {
                patient._Conditions.Add(hypertension);
            }

            _Patient = patient;
        }

        private void EditNote(object sender, EventArgs e)
        {
            richTextBoxNote.Enabled = true;
            buttonSaveNote.Enabled = true;
        }

        private void SaveNote(object sender, EventArgs e)
        {
            //string[] records = richTextBoxLoadFile.Text.Split("\n");
            //string[] noteRecords = richTextBoxNote.Text.Split("\n");

            //records[5] = noteRecords[0];
            //records[11] = noteRecords[1];
            //records[12] = noteRecords[2];
            //records[28] = noteRecords[3];
            //records[29] = noteRecords[4];

            //string result = "";
            //foreach (string record in records)
            //{
            //    result += $"{record}\n";
            //}
            //SaveReport(result, "rtf", _NotesFilePath);

            //string filePath = $@"{_NotesFilePath}\{selectedPatientHC}\{DateTime.Now.ToString("ssmmhh - ddMMyyyy")}.rtf";
            string filePath = $@"{_NotesFilePath}\{selectedPatientHC}\test.rtf";
            //File.WriteAllText(filePath, richTextBoxNote.SelectedRtf);

            richTextBoxNote.SaveFile(filePath);
        }
    }
}
