using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass_4_PROG1965_W24_Sec_6
{
    public static class FileUtilities
    {
        public static void AddRecord(string newRecord, string filePath)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(filePath, true);

                writer.WriteLine(newRecord);
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { writer.Dispose(); }
        }
        public static void UpdateRecord(string origRecord, string newRecord, string filePath)
        {
            string tempFile = Path.Combine(Environment.CurrentDirectory, "temp.txt");
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(filePath);
                writer = new StreamWriter(tempFile, true);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    //string[] fields = record.Split(",");

                    if (record != origRecord)
                    {
                        writer.WriteLine(record);
                    }
                    else
                    {
                        writer.WriteLine(newRecord);
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally {
                writer.Dispose();
                reader.Dispose();
            }

            File.Delete(filePath);
            File.Move(tempFile, filePath);
            File.Delete(tempFile);
        }
        public static void DeleteRecord(string origRecord, string filePath)
        {
            string tempFile = Path.Combine(Environment.CurrentDirectory, "temp.txt");
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(filePath);
                writer = new StreamWriter(tempFile, true);

                bool recordFound = false;
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    //string[] fields = record.Split(",");

                    if (record != origRecord || recordFound)
                    {
                        writer.WriteLine(record);
                    }
                    else
                    {
                        recordFound = true;
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                writer.Dispose();
                reader.Dispose();
            }

            File.Delete(filePath);
            File.Move(tempFile, filePath);
            File.Delete(tempFile);
        }
        public static void LoadListFromFile(ListBox listBox, string filePath)
        {
            StreamReader reader = null;
            listBox.Items.Clear();
            try
            {
                reader = new StreamReader(filePath);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");
                    listBox.Items.Add(fields[1]);
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File with provinces name not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally {
                reader.Dispose();
            }
        }

        public static void LoadListFromFile(ListBox listBox, string filePath, int selectedIndex)
        {
            StreamReader reader = null;
            listBox.Items.Clear();
            try
            {
                reader = new StreamReader(filePath);
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    if (int.Parse(fields[0]) == selectedIndex)
                    {
                        for (int i = 1; i < fields.Length; i++)
                        {
                            listBox.Items.Add(fields[i]);
                        }
                        return;
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally { /*reader.Dispose();*/ }
        }

        public static void loadRecords(DataGridView dgv, string filePath)
        {
            dgv.Rows.Clear();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filePath);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    dgv.Rows.Add(fields);
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally {
                reader.Dispose();
                reader.Close();
            }
            /////////////////////////////////////////////
        }

        public static void FindMatches(string branch, string service, string filePath, DataGridView dgv)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filePath);
                dgv.Rows.Clear();

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    if (fields[3] == branch && fields[4] == service)
                    {
                        dgv.Rows.Add(fields);
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File with provinces name not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally
            {
                reader.Dispose();
            }
        }
    }
}
