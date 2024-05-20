using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InClass_Assignment_3_Prog1965_Sec_6
{
    public partial class FormMain : Form
    {
        public List<Driver> Drivers = new List<Driver>();
        public string[] Appointments = new string[100];
        public int AppointmentIndex = 0;

        public FormMain()
        {
            InitializeComponent();
        }

        string BookedTest(DateTime testTime, Driver testTaker)
        {

            //DateTime.ToShortDateString() returns a string value of DateTime in the form DD.MM.YYYY
            return testTime.ToShortDateString() + " : " + testTaker.ToString();
        }

        private void EnterClick(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string licenceNumber = textBoxDriverLic.Text.Trim().ToUpper();
            string licenceClass = textBoxDrivClass.Text.Trim().ToUpper();
            bool isG2;
            DateTime dateOfBirth = dateTimePickerDOB.Value;
            DateTime date = monthCalendarTest.SelectionStart;

            Regex liscenceClassFormat = new Regex(@"^G[1-2]$");
            Regex licenceNumberFormatG1 = new Regex(@"^3 ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9]$");
            Regex licenceNumberFormatG2 = new Regex(@"^5 ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9] ?-?[0-9]$");

            if (licenceClass == "G2")
            {
                isG2 = true;
            }
            else if (licenceClass == "G1")
            {
                isG2 = false;
            }
            else
            {
                labelError.Text = "Invalid licence level";
                MessagesBox.Visible = true;
                return;
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                labelError.Text = "Name cannot be empty";
                MessagesBox.Visible = true;
                return;
            }
            try
            {
                if (licenceNumberFormatG1.IsMatch(licenceNumber) && isG2)
                {
                    throw new Exception("Invalid licence number");
                }
                else if (licenceNumberFormatG2.IsMatch(licenceNumber) && isG2 == false)
                {
                    throw new Exception("Invalid licence number");
                }
                else if (licenceNumberFormatG1.IsMatch(licenceNumber) == false && licenceNumberFormatG2.IsMatch(licenceNumber) == false)
                {
                    throw new Exception("Invalid licence number");
                }
                int i = 0;
                string[] licenceArray = new string[9];
                foreach (char c in licenceNumber)
                {
                    Regex number = new Regex(@"^[0-9]$");

                    if (number.IsMatch(c.ToString()))
                    {
                        licenceArray[i++] = c.ToString();
                    }
                }
                licenceNumber = "";
                for (i = 0; i < 9; i++)
                {
                    licenceNumber += licenceArray[i];
                }
            }
            catch (Exception ex)
            {
                labelError.Text = ex.Message;
                MessagesBox.Visible = true;
                return;
            }

            if (date < DateTime.Today)
            {
                labelError.Text = "Invalid date";
                MessagesBox.Visible = true;
                return;
            }
            else if (dateOfBirth.AddYears(18) < date)
            {
                labelError.Text = "Must be at least 18";
                MessagesBox.Visible = true;
                return;
            }

            Driver driver = new(firstName, lastName, licenceNumber, licenceClass);
            Drivers.Add(driver);

            Appointments[AppointmentIndex++] = (BookedTest(date, driver));

        }

        private void OkayClick(object sender, EventArgs e)
        {
            MessagesBox.Visible = false;
        }

        private void AppointmentsClick(object sender, EventArgs e)
        {
            listBoxAppointments.Items.Clear();
            foreach (string s in Appointments)
            {
                if (s == null) continue;
                listBoxAppointments.Items.Add(s);
            }
        }

        private void DriversClick(object sender, EventArgs e)
        {
            listBoxAppointments.Items.Clear();
            foreach (Driver driver in Drivers)
            {
                if (driver == null) continue;
                listBoxAppointments.Items.Add(driver.ToString());
            }
        }

        private void FormMainLoad(object sender, EventArgs e)
        {
            Regex format = new(@"^\s\w*z+\w*$");
            bool formatTriggered = false;
            string[] strings = { "ablaze with fury", "a dozen eggs", "blind with ambition", "inept jazz trio", "kitchen with refrigeration", "late-night pizza joint", "a Regex wiz!", "training on weather patterns", "a C# zealot" };
            List<string> outStrings = new List<string>();
            foreach (string s in strings)
            {
                if (format.IsMatch(s))
                {
                    formatTriggered = true;
                    outStrings.Add(s);
                }
            }
            if (!formatTriggered)
            {
                labelRegexPost.Text = "No strings match given format";
            }
            else
            {
                foreach (string s in outStrings)
                {
                    labelRegexPost.Text += $"{s}\n";
                }
            }
        }
    }
}
