using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InClass_Asst5_PROG1965_W24
{
    internal class UserManager : User
    {
        private static string UserFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\IOFiles\Users.txt";

        public static void AddNewUser(User user)
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(UserFile, true);

                writer.WriteLine(user.ToString());
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { writer.Dispose(); }
        }

        public static User CreateNewUser(string name, string password, DateTime date)
        {
            int id = GetNewID();
            User user = new User(id, name, password, date);
            return user;
        }

        public static int GetNewID()
        {
            int id = 0;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(UserFile);

                bool isFirstID = true;
                while (!reader.EndOfStream)
                {
                    isFirstID = false;
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    id = int.Parse(fields[0].Trim());
                }
                if (isFirstID)
                {
                    id = 1;
                }
                else
                {
                    id++;
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Invalid input!"); }
            catch (Exception a) { MessageBox.Show(a.ToString()); }
            finally
            {
                reader.Dispose();
                reader.Close();
            }
            return id;
        }

        public static bool ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name.Trim()))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            return true;
        }

        public static bool ValidatePassword(string password)
        {
            Regex alphaRegex = new Regex(@"[A-Za-z]+");
            Regex numericRegex = new Regex(@"[0-9]+");
            Regex punctuationRegex = new Regex(@"[^a-zA-Z0-9\s]+");

            password = password.Trim();
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.");
                return false;
            }
            else if (!(alphaRegex.IsMatch(password) && numericRegex.IsMatch(password) && punctuationRegex.IsMatch(password)))
            {
                MessageBox.Show("Password must contain an alphabetical character, a numeric character, and a punctuation character.");
                return false;
            }

            return true;
        }

        public static bool ValidateDate(DateTime date)
        {
            if (date > DateTime.Now)
            {
                MessageBox.Show("Date cannot be in the future.");
                return false;
            }

            return true;
        }
    }
}
