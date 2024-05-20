using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClass_Asst5_PROG1965_W24
{
    public partial class FormPartOne : Form
    {
        string _QuestionsPartOne = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\IOFiles\Users.txt";

        public FormPartOne()
        {
            InitializeComponent();
        }

        private void FormPartOne_Load(object sender, EventArgs e)
        {

        }

        private void CreateUser(object sender, EventArgs e)
        {
            string name = NameBox.Text.Trim();
            string password = PasswordBox.Text.Trim();
            DateTime date = DateTimePicker.Value;
            if (!UserManager.ValidateName(name))
            {
                return;
            }
            else if (!UserManager.ValidatePassword(password))
            {
                return;
            }
            else if (!UserManager.ValidateDate(date))
            {
                return;
            }

            User user = UserManager.CreateNewUser(name, password, date);
            UserManager.AddNewUser(user);
        }
    }
}
