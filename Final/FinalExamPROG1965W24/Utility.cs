using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FinalExamPROG1965W24
{
    internal static class Utility
    {
        public static bool ValidateAndFormatDate(ref string date)
        {
            if (string.IsNullOrEmpty(date.Trim()))
            {
                MessageBox.Show("Invalid date");
                return false;
            }
            date = date.Replace(" ", "").Replace("-", "");

            Regex dateFormat = new(@"^[0-9]{8}$");

            if (!dateFormat.IsMatch(date))
            {
                MessageBox.Show("Invalid date");
                return false;
            }
            else
            {
                date = date.Insert(2, "-").Insert(5, "-");
            }

            return true;
        }

        public static bool ValidateAndFormatISBN(ref string isbn) 
        {
            if (string.IsNullOrEmpty(isbn.Trim())) // ! removed
            {
                MessageBox.Show("Invalid ISBN");
                return false;
            }

            isbn = isbn.Replace(" ", "").Replace("-", "").Replace("ISBN13:", "");

            Regex isbnFormat = new(@"^[0-9]{13}$");

            if (!isbnFormat.IsMatch(isbn))
            {
                MessageBox.Show("Invalid ISBN");
                return false;
            }
            else
            {
                isbn = isbn.Insert(3, "-").Insert(5, "-").Insert(9, "-").Insert(15, "-");
            }

            if (isbn.Substring(0, 3) != "978" && isbn.Substring(0, 3) != "979")
            {
                MessageBox.Show("Invalid ISBN");
                return false;
            }

            return true;
        }

        public static void AddRecord(string filePath, string record)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(filePath, true);
                sw.WriteLine(record);
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sw.Dispose(); }
        }

        public static void RecordSearch(string field, string filePath, RichTextBox textBox, out int i)
        {
            textBox.Text = "";
            i = 1;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(filePath);

                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split("|");

                    foreach (string _field in fields)
                    {
                        if (_field.Trim().ToLower() == field.Trim().ToLower())
                        {
                            textBox.Text += $"({i}) {record}\n\n";
                            i++;
                        }
                    }
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
