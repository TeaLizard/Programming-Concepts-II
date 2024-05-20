using Assignment3_PROG1965_W24.Forms;
using Assignment3_PROG1965_W24.Model;
using Assignment3_PROG1965_W24.Model.Address;
using Assignment3_PROG1965_W24.Model.Employee;
using Assignment3_PROG1965_W24.RecordEntry;
using Assignment3_PROG1965_W24.Utility;
using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Eventing.Reader;
using static Assignment3_PROG1965_W24.Model.User;
using static Assignment3_PROG1965_W24.Utility.FileIO;
using static Assignment3_PROG1965_W24.Utility.StringUtility;

namespace Assignment3_PROG1965_W24
{
    public partial class FormMain : Form
    {
        private bool _LoggedIn = false;
        private Role _LoginRole = new Role();
        protected string _LoginID = "";
        private string _passwordsFile = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                        @"\DataFiles\access.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelStatus.Text = "Login with your ID";
            buttonLogin.Visible = true;
            buttonLogout.Visible = false;
            groupBoxAdmin.Visible = true;
            groupBoxDoctor.Visible = false;
            groupBoxSecratery.Visible = false;
            ControlAdmin();

        }
        private void ControlAdmin()
        {
            buttonAdminManagePatients.Enabled = _LoggedIn;
            buttonAdminManageStaff.Enabled = _LoggedIn;
            buttonDoctorManagePatients.Enabled = _LoggedIn;
            buttonSecrateryManagePatients.Enabled = _LoggedIn;
            buttonSecrateryManageDocuments.Enabled = _LoggedIn;

            buttonLogin.Visible = !_LoggedIn;
            buttonLogout.Visible = _LoggedIn;

            radioButtonAdmin.Enabled = !_LoggedIn;
            radioButtonDoctor.Enabled = !_LoggedIn;
            radioButtonSecratery.Enabled = !_LoggedIn;

            if (_LoggedIn)
            {
                labelStatus.Text = $"User: {_LoginID} | Logged in";
            }
            else
            {
                labelStatus.Text = "";
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Role loginRole = new Role();
            if (radioButtonAdmin.Checked)
            {
                loginRole = Role.ADMIN;
            }
            else if (radioButtonDoctor.Checked)
            {
                loginRole = Role.DOCTOR;
            }
            else if (radioButtonSecratery.Checked)
            {
                loginRole = Role.SECRATERY;
            }
            else
            {
                MessageBox.Show("Select user role");
                return;
            }

            string id = textBoxUserName.Text.Trim();
            int idLength = id.Length;
            for (int i = 0; i < (6 - idLength); i++)
            {
                id = $"0{id}";
            }

            string roleString = loginRole.ToString();
            ElegantCase(ref roleString);
            string record = RecordContains(id, textBoxPassword.Text.Trim(), roleString, _passwordsFile);

            if (record != "") // Username, password, and role match
            {
                _LoggedIn = true;
                _LoginRole = loginRole;
                _LoginID = id;

                //labelStatus.Text = $"User: {id} | Logged in";

                switch (_LoginRole)
                {
                    case Role.ADMIN:
                        groupBoxAdmin.Visible = true;
                        break;
                    case Role.DOCTOR:
                        groupBoxDoctor.Visible = true;
                        groupBoxAdmin.Visible = false;
                        break;
                    case Role.SECRATERY:
                        groupBoxSecratery.Visible = true;
                        groupBoxAdmin.Visible = false;
                        break;
                }

                ControlAdmin();
            }
            else // Login failed
            {
                MessageBox.Show("Login failed");
                return;
            }
        }

        private void buttonAdminManagePatients_Click(object sender, EventArgs e)
        {
            buttonSecrateryManagePatients_Click(sender, e);
        }

        private void buttonAdminManageStaff_Click(object sender, EventArgs e)
        {
            FormManageStaff mp = new(_LoginID);
            mp.ShowDialog();
        }

        private void buttonDoctorManagePatients_Click(object sender, EventArgs e)
        {
            FormDoctorManagePatients mp = new(_LoginID);
            mp.ShowDialog();
        }

        private void buttonSecrateryManageDocuments_Click(object sender, EventArgs e)
        {
            FormManageDocuments mp = new(_LoginID);
            mp.ShowDialog();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            _LoggedIn = false;
            _LoginRole = new Role();
            _LoginID = "";
            ControlAdmin();
        }

        private void buttonSecrateryManagePatients_Click(object sender, EventArgs e)
        {
            FormManagePatients mp = new FormManagePatients(_LoginID);
            mp.ShowDialog();
        }

        private void ChangeBackground(object sender, EventArgs e)
        {
            if (!_LoggedIn)
            {
                if (radioButtonAdmin.Checked)
                {
                    groupBoxAdmin.Visible = true;
                    groupBoxDoctor.Visible = false;
                    groupBoxSecratery.Visible = false;
                }
                else if (radioButtonDoctor.Checked)
                {
                    groupBoxAdmin.Visible = false;
                    groupBoxDoctor.Visible = true; // This won't turn true for some reason
                    groupBoxSecratery.Visible = false;
                }
                else if (radioButtonSecratery.Checked)
                {
                    groupBoxAdmin.Visible = false;
                    groupBoxDoctor.Visible = false;
                    groupBoxSecratery.Visible = true;
                }
            }
        }
    }
}
