using System.Text.RegularExpressions;

namespace Midterm_PROG1965_W24_Sec6
{
    public partial class FormPersons : Form
    {
        public List<Person> _list = new List<Person>();
        public FormPersons()
        {
            InitializeComponent();
        }

        private void FormPersons_Load(object sender, EventArgs e)
        {

        }

        private void RegisterUser(object sender, EventArgs e)
        {
            string registerFirstName = textBoxFirstName.Text;
            string registerLastName = textBoxLastName.Text;
            string registerSINString = textBoxSIN.Text;
            Int64 registerSIN;
            DateTime registerDOB = dateTimePickerDOB.Value;

            Regex nameFormat = new Regex(@"^[A-Za-z]{1,99}$");

            if (!nameFormat.IsMatch(registerFirstName.Trim()))
            {
                labelMessages.Text = "Name fields must have between 1-99 alphabetical characters.";
                groupBoxAlert.Visible = true;
                return;
            }
            else if (!nameFormat.IsMatch(registerLastName.Trim()))
            {
                labelMessages.Text = "Name fields must have between 1-99 alphabetical characters.";
                groupBoxAlert.Visible = true;
                return;
            }

            try
            {
                Regex SINFormat = new(@"^[0-9]{3}[- ]?[0-9]{3}[- ]?[0-9]{3}$");

                if (SINFormat.IsMatch(registerSINString.Trim()))
                {
                    registerSINString = registerSINString.Trim();
                    registerSINString = registerSINString.Replace("-", string.Empty);
                    registerSINString = registerSINString.Replace(" ", string.Empty);
                    registerSIN = Convert.ToInt64(registerSINString);
                }
                else
                {
                    throw new Exception("SIN format is 'xxx-xxx-xxx', 'xxx xxx xxx', or 'xxxxxxxxx' where x is a digit 0-9.");
                }
            }
            catch (Exception ex)
            {
                labelMessages.Text = ex.Message;
                groupBoxAlert.Visible = true;
                return;
            }

            Person person = new(registerFirstName, registerLastName, registerSIN, registerDOB);
            _list.Add(person);
            listBoxPersons.Items.Add(person.ToString());
        }

        private void CloseAlert(object sender, EventArgs e)
        {
            groupBoxAlert.Visible = false;
        }

        private void HideAll(object sender, EventArgs e)
        {
            listBoxPersons.Items.Clear();
        }

        private void ShowAll(object sender, EventArgs e)
        {
            foreach (Person person in _list)
            {
                listBoxPersons.Items.Add(person.ToString());
            }
        }

        private void ClearAll(object sender, EventArgs e)
        {
            listBoxPersons.Items.Clear();
            _list.Clear();
        }
    }
}
