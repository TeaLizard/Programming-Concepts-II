using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

// Owen Williams 8932017 | Assignment 2

namespace Assignment2_PROG1965_W2024_Sec6
{
    public partial class VehicleService : Form
    {
        string[,] _bookings = new string[31, 8];
        string _allMakesFile = Path.Combine(Environment.CurrentDirectory, "CarMakes.txt");
        string _allModelsFile = Path.Combine(Environment.CurrentDirectory, "CarModels.txt");
        string _allBookingsFile = Path.Combine(Environment.CurrentDirectory, "Bookings.txt");
        public VehicleService()
        {
            InitializeComponent();
        }

        private void VehicleService_Load(object sender, EventArgs e)
        {
            //PanelMessage.Visible = true;
            //MessageDisplayBox.Text = CamelCase("  AABB AB  ") + CamelCase("  AABB AB  ").Length.ToString();
            //return;

            StreamReader reader = null;

            try
            {
                reader = new StreamReader(_allBookingsFile);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    if (!GetDateAndTime(out int dayIndex, out int timeSlotIndex, Convert.ToDateTime(fields[0]), fields[1]))
                    {
                        return;
                    }
                    _bookings[dayIndex, timeSlotIndex] = record;
                }
                foreach (string record in _bookings)
                {
                    if (record == null) continue;

                    string[] fields = record.Split(",");
                    ListViewItem booking = new(fields);
                    listViewBookings.Items.Add(booking);
                }

            }
            catch (Exception ex)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = ex.Message;
                return;
            }
            finally
            {
                reader.Close();
            }

            reader = null;

            try
            {
                reader = new StreamReader(_allMakesFile);

                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    listBoxMakes.Items.Add(fields[1]);
                }


            }
            catch (Exception ex)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = ex.Message;
                return;
            }
            finally
            {
                reader.Close();
            }
        }

        private void BookAppointment(object sender, EventArgs e)
        {
            if (!ValidateBooking())
            {
                return;
            }

            try
            {
                listViewBookings.Items.Clear();
                foreach (string record in _bookings)
                {
                    if (record == null) continue;

                    string[] fields = record.Split(",");
                    ListViewItem booking = new(fields);
                    listViewBookings.Items.Add(booking);
                }
            }
            catch (Exception ex)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = ex.Message;
                return;
            }
            finally
            {

            }

        }

        private bool ValidateBooking()
        {
            if (!ValidateCustomer(out string firstName, out string lastName, out _, out _, out string postalCode, out long phoneNumber))
            {
                return false;
            }

            if (!ValidateVehicle(out string make, out string model, out string year, out string service))
            {
                return false;
            }


            if (!GetDateAndTime(out int dayIndex, out int timeSlotIndex, out DateTime date, out string timeSlot))
            {
                return false;
            }

            string booking = $"{date},{timeSlot},{firstName},{lastName},{postalCode},{phoneNumber},{make},{model},{year},{service}";
            _bookings[dayIndex, timeSlotIndex] = booking;

            /////

            StreamWriter writer = null;
            try
            {
                writer = new(_allBookingsFile, true);
                writer.WriteLine(booking);
            }
            catch (Exception ex)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = ex.Message;
                return false;
            }
            finally
            {
                writer.Flush();
                writer.Close();
            }
            return true;
        }

        private bool ValidateCustomer(out string firstName, out string lastName, out string cityName, out string provenceName, out string postalCode, out long phoneNumber)
        {
            Regex nameFormat = new(@"^[A-Za-z]{1,30}$");
            Regex cityFormat = new(@"^[A-Za-z ]{1,30}$");
            Regex postalCodeFormat = new(@"^[A-Z][0-9][A-Z][ -]?[0-9][A-Z][0-9]$");
            Regex phoneNumberFormat = new(@"^[0-9]{3}[ -]?[0-9]{3}[ -]?[0-9]{4}$");
            Regex provenceFormat = new(@"^[A-Z]{2}$");

            firstName = textBoxFirstName.Text.Trim();
            lastName = textBoxLastName.Text.Trim();
            cityName = textBoxCity.Text.Trim();
            provenceName = listBoxProvinces.Text.Trim();
            postalCode = textBoxPostalCode.Text.ToUpper().Trim();
            string phoneNumberString = textBoxPhone.Text.Trim();
            phoneNumber = 0;

            try
            {
                if (!nameFormat.IsMatch(firstName))
                {
                    throw new Exception("Enter your first name");
                }
                if (!nameFormat.IsMatch(lastName))
                {
                    throw new Exception("Enter your last name");
                }

                if (!cityFormat.IsMatch(cityName))
                {
                    throw new Exception("Enter your city name");
                }

                if (!provenceFormat.IsMatch(provenceName))
                {
                    throw new Exception("Enter your provence");
                }

                if (!postalCodeFormat.IsMatch(postalCode))
                {
                    throw new Exception("Enter your postal code");
                }
                else
                {
                    postalCode = postalCode.Replace("-", string.Empty);
                    postalCode = postalCode.Replace(" ", string.Empty);
                }

                if (!phoneNumberFormat.IsMatch(phoneNumberString))
                {
                    throw new Exception("Enter your phone number");
                }
                else
                {
                    phoneNumberString = phoneNumberString.Replace("-", string.Empty);
                    phoneNumberString = phoneNumberString.Replace(" ", string.Empty);
                    phoneNumber = long.Parse(phoneNumberString);
                }
            }
            catch (Exception ex)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = ex.Message;
                return false;
            }

            return true;
        }

        private bool ValidateVehicle(out string make, out string model, out string year, out string service)
        {
            make = listBoxMakes.Text;
            model = listBoxModels.Text;
            year = numericUpDownModelYear.Value.ToString();
            service = listBoxServices.Text;

            if (make == "")
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Enter vehicle make";
                return false;
            }
            if (model == "")
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Enter vehicle model";
                return false;
            }
            if (year == "")
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Enter vehicle year";
                return false;
            }
            if (service == "")
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Enter your vehicle's service";
                return false;
            }

            return true;
        }
        private void CloseMessageBox(object sender, EventArgs e)
        {
            PanelMessage.Visible = false;
        }

        private static string CamelCase(string inputString)
        {
            if (inputString == null)
            {
                inputString = string.Empty;
                return inputString;
            }

            char[] chars = inputString.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    chars[i] = char.ToLower(chars[i]);
                }
            }

            while (chars[0] == ' ')
            {
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    chars[i] = chars[i + 1];
                }

                char[] charsHolder = new char[chars.Length];
                chars.CopyTo(charsHolder, 0);

                chars = new char[charsHolder.Length - 1];
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = charsHolder[i];
                }
            }

            while (chars[chars.Length - 1] == ' ')
            {
                char[] charsHolder = new char[chars.Length - 1];
                for (int i = 0; i < chars.Length - 1; i++)
                {
                    charsHolder[i] = chars[i];
                }
                chars = charsHolder;
            }

            chars[0] = char.ToUpper(chars[0]);

            inputString = new string(chars);
            return inputString;
        }

        private bool GetDateAndTime(out int dayIndexOutput, out int timeSlotIndexOutput, out DateTime date, out string timeSlotString)
        {
            dayIndexOutput = 0;
            timeSlotIndexOutput = 0;

            date = monthCalendarMarch2024.SelectionStart;
            timeSlotString = listBoxCalendar.Text;

            if (date < DateTime.Now)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Select an available time in the future";
                return false;
            }

            if (timeSlotString == string.Empty)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Select a time slot";
                return false;
            }

            dayIndexOutput = date.Day - 1;
            if (timeSlotString == "Select Time Slot")
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Select a time slot";
                return false;
            }
            else
            {
                timeSlotString = $"{timeSlotString.Substring(0, 2)}-{timeSlotString.Substring(8, 2)}";
                if (Convert.ToInt32(timeSlotString.Substring(0, 2)) > 8)
                {
                    timeSlotIndexOutput = Convert.ToInt32(timeSlotString.Substring(0, 2)) - 9;
                }
                else
                {
                    timeSlotIndexOutput = Convert.ToInt32(timeSlotString.Substring(0, 2)) + 3;
                }
            }

            if (_bookings[dayIndexOutput, timeSlotIndexOutput] != null)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Select open date and time slots";
                return false;
            }
            else
            {

            }

            return true;
        }// Add bookings

        private bool GetDateAndTime(out int dayIndexOutput, out int timeSlotIndexOutput, DateTime date, string timeSlotString)
        {
            dayIndexOutput = 0;
            timeSlotIndexOutput = 0;

            dayIndexOutput = date.Day - 1;
            if (timeSlotString == "Select Time Slot")
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Select a time slot";
                return false;
            }
            else
            {
                if (Convert.ToInt32(timeSlotString.Substring(0, 2)) > 8)
                {
                    timeSlotIndexOutput = Convert.ToInt32(timeSlotString.Substring(0, 2)) - 9;
                }
                else
                {
                    timeSlotIndexOutput = Convert.ToInt32(timeSlotString.Substring(0, 2)) + 3;
                }
            }

            if (_bookings[dayIndexOutput, timeSlotIndexOutput] != null)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = "Select open date and time slots";
                return false;
            }

            return true;
        }// Form load

        private void UpdateModels(object sender, EventArgs e)
        {
            StreamReader reader = null;

            try
            {
                reader = new(_allModelsFile);

                listBoxModels.Items.Clear();
                while (!reader.EndOfStream)
                {
                    string record = reader.ReadLine();
                    string[] fields = record.Split(",");

                    if (listBoxMakes.SelectedIndex == int.Parse(fields[0]))
                    {
                        for (int i = 1; i < fields.Length; i++)
                        {
                            listBoxModels.Items.Add(fields[i]);
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                PanelMessage.Visible = true;
                MessageDisplayBox.Text = ex.Message;
            }
            finally
            {
                reader.Close();
            }
        }

        private void ResetCustomer(object sender, EventArgs e)
        {
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            listBoxProvinces.SelectedItems.Clear();
            textBoxPostalCode.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
        }

        private void ResetVehicle(object sender, EventArgs e)
        {
            listBoxMakes.SelectedItems.Clear();
            listBoxModels.SelectedItems.Clear();
            numericUpDownModelYear.Value = 1950;
            listBoxServices.SelectedItems.Clear();
        }
    }
}
