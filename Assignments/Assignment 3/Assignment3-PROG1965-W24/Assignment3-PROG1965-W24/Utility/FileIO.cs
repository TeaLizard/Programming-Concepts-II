using Assignment3_PROG1965_W24.Model.Address;
using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.Model.HealthConditions;
using Assignment3_PROG1965_W24.Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.Utility
{
    public static class FileIO
    {
        public static readonly string _AccessFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                        @"\DataFiles\access.txt";
        public static readonly string _EmployeesFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                           @"\DataFiles\employees.txt";
        public static readonly string _FamilyDoctorFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                              @"\DataFiles\family.txt";
        public static readonly string _PatientsFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                          @"\DataFiles\patients.txt";
        public static readonly string _ReportsFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                         @"\DataFiles\Reports";
        public static readonly string _UnReadReportsFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                               @"\DataFiles\UnReadReports";
        public static readonly string _NotesFilePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                                               @"\DataFiles\Notes";
        //
        // Method: StringFound
        // Input: String "strWord" to be searched is at "filePath"
        // Output: Returns true if found, else returns false
        //
        public static bool StringFound(string strWord, string filePath)
        {
            bool found = false;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    if (record.Trim() == strWord.Trim())
                    {
                        found = true;
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }

            return found;
        }
        //
        // Method: RecordContain
        // Input: File to be searched is found at "filePath"
        // Output: Returns the full record which contains "field"
        //         Returns an empty string if no match found
        //
        public static string RecordContains(string field, string filePath) {

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(",");

                    foreach (string _field in fields)
                    {
                        if (_field.Trim() == field.Trim())
                        {
                            return record;
                        }
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }

            return "";

        }

        public static string RecordContains(string field1, string field2, string filePath)
        {

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(",");

                    if (record.Contains(field1.Trim()) && record.Contains(field2.Trim()))
                    {
                        return record;
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }

            return "";

        }

        public static string RecordContains(string field1, string field2, string field3, string filePath)
        {

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(",");

                    if (record.Contains(field1.Trim()) && record.Contains(field2.Trim()) && record.Contains(field3.Trim()))
                    {
                        return record;
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }

            return "";

        }
        //
        // Method: LastRecord
        // Input: File to be searched is found at "filePath"
        // Output: Returns the last record in the file
        //
        public static string LastRecord(string filePath)
        {

            string lastRecord = "";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    lastRecord = sr.ReadLine();
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }

            return lastRecord;
        }
        //
        // Method: AddRecord
        // Input: String "newRecord" to be appended to the file at "filePath"
        //
        public static void AddRecord(string newRecord, string filePath)
        {
            
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(filePath, true);
                sw.WriteLine(newRecord);
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sw.Dispose(); }
        }
        //
        // Method: UpdateRecord
        // Input: String "oldRecord" to be replaced with "newRecord" in file at "filePath"
        //
        public static void UpdateRecord(string oldRecord, string newRecord, string filePath)
        {

            StreamWriter sw = null;
            StreamReader sr = null;
            string placeholder = null;

            try
            {
                sr = new StreamReader(filePath);
                

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    
                    if (record == oldRecord)
                    {
                        placeholder += newRecord + "\n";
                    }
                    else
                    {
                        placeholder += record + "\n";
                    }
                }
                sr.Dispose();
                sw = new StreamWriter(filePath, false);
                sw.Write(placeholder);
                //MessageBox.Show(placeholder);
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); sw.Dispose(); }
        }

        public static void FillListBoxDoctor(ListBox listBox, string filePath)
        {
            listBox.Items.Clear();

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(",");

                    if (fields[1] == "Doctor") { listBox.Items.Add($"{fields[3]} {fields[4]}"); }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }
        }

        public static int GetNewID(string filePath)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                string id = "";
                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(",");

                    id = fields[0];
                }
                return (int.Parse(id) + 1);
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }

            MessageBox.Show("New id could not be created");
            return -1;
        }

        public static List<Patient> ListPatients(Doctor doctor)
        {
            List<Patient> patients = new List<Patient>();

            StreamReader familyReader = null;
            StreamReader patientReader = null;
            try
            {
                familyReader = new StreamReader(_FamilyDoctorFilePath);
                patientReader = new StreamReader(_PatientsFilePath);

                while (!familyReader.EndOfStream)
                {
                    string familyRecord = familyReader.ReadLine();
                    string[] familyFields = familyRecord.Split(",");
                    if (StringUtility.GetFullID(doctor.GetEmpID()) == familyFields[0]) // Found Doctor in family.txt
                    {
                        bool firstID = true;
                        foreach (string field in familyFields) // Pull all patient ids from this record
                        {
                            if (firstID) { firstID = false; continue; } // Don't read doctor's id
                            while (!patientReader.EndOfStream)
                            {
                                string patientRecord = patientReader.ReadLine();
                                string[] patientFields = patientRecord.Split(",");

                                if (patientFields[0] == field) // Patient id matches id found in family.txt
                                {
                                    Contact contactInfo = new(patientRecord);
                                    HealthCard healthCard = new(patientFields[2]);
                                    DateTime dob = DateTime.Now;
                                    List<ICondition> conditions = new List<ICondition>();
                                    Patient patient = new(int.Parse(patientFields[0]), patientFields[3], patientFields[4], contactInfo, healthCard, dob, conditions);
                                    patient.SetFamilyDoctor(doctor);
                                    patients.Add(patient); // Add Created Patients already in file from patients.txt
                                }
                            }
                            patientReader.BaseStream.Position = 0;
                        }
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { familyReader.Dispose(); patientReader.Dispose(); }

            return patients; // Return patients already on file
        }

        public static void FillRichTextBox(RichTextBox richTextBox, string filePath)
        {
            richTextBox.Text = "";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();

                    richTextBox.Text += $"{record}\n";
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }
        }

        public static void FillRichTextBox(RichTextBox richTextBox, string filePath, out string reportDate, out string healthCard)
        {
            reportDate = ""; healthCard = "";

            richTextBox.Text = "";
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                string record = sr.ReadLine();
                string[] fields = record.Split(" ");
                reportDate = fields[1].Replace("-", "");

                record = sr.ReadLine();
                fields = record.Split(" ");
                healthCard = fields[6].Replace("-", "");
                sr.ReadToEnd();
                sr.BaseStream.Position = 0;
                while (!sr.EndOfStream)
                {
                    record = sr.ReadLine();

                    richTextBox.Text += $"{record}\n";
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }
        }
    }
}
