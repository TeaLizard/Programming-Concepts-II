using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace InClass_4_PROG1965_W24_Sec_6
{
    public partial class FormMain : Form
    {
        // Path to the file containing information of all booked appointments
        string _FileAppointments = Path.Combine(Environment.CurrentDirectory, "bookings.txt");

        // Path to the file containing information of all branches
        string _FileBranches = Path.Combine(Environment.CurrentDirectory, "locations.txt");

        // Path to the file containing information of all services provided at all branches
        string _FileServices = Path.Combine(Environment.CurrentDirectory, "services.txt");

        string selectedRecord = "";

        public FormMain()
        {
            InitializeComponent();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            CreateColumnHeaders(dataGridViewAppts);
            CreateColumnHeaders(dataGridViewSearchResults);
            FileUtilities.loadRecords(dataGridViewAppts, _FileAppointments);
            FileUtilities.LoadListFromFile(listBoxBranch, _FileBranches);
            FileUtilities.LoadListFromFile(listBoxSearchBranch, _FileBranches);
        }
        private void CreateColumnHeaders(DataGridView dgv)
        {

            dgv.Columns.Add("D", "Date");
            dgv.Columns.Add("N", "Name");
            dgv.Columns.Add("P", "Phone");
            dgv.Columns.Add("L", "Location");
            dgv.Columns.Add("S", "Service");
        }
        private void loadServices(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int selectedInd = lb.SelectedIndex;

            ListBox targetListBox = null;
            if (lb == listBoxBranch)
                targetListBox = listBoxService;
            if (lb == listBoxSearchBranch)
                targetListBox = listBoxSearchService;

            FileUtilities.LoadListFromFile(targetListBox, _FileServices, selectedInd);
        }

        private void buttonNewAppt_Click(object sender, EventArgs e)
        {
            Appointment booking = new Appointment(textBoxName.Text, textBoxPhone.Text, dateTimePickerAppt.Value, listBoxBranch.Text, listBoxService.Text);
            FileUtilities.AddRecord(booking.ToString(), _FileAppointments);
            FileUtilities.loadRecords(dataGridViewAppts, _FileAppointments);
        }

        private void DataGridViewAppts_Double_Click(object sender, EventArgs e)
        {
            dateTimePickerAppt.Value = DateTime.Parse(dataGridViewAppts.CurrentRow.Cells["D"].Value.ToString());
            textBoxName.Text = dataGridViewAppts.CurrentRow.Cells["N"].Value.ToString();
            textBoxPhone.Text = dataGridViewAppts.CurrentRow.Cells["P"].Value.ToString();
            listBoxBranch.SelectedItem = dataGridViewAppts.CurrentRow.Cells["L"].Value.ToString();
            listBoxService.SelectedItem = dataGridViewAppts.CurrentRow.Cells["S"].Value.ToString();


            Appointment selectedBooking = new Appointment(textBoxName.Text, textBoxPhone.Text, dateTimePickerAppt.Value, listBoxBranch.Text, listBoxService.Text);
            selectedRecord = selectedBooking.ToString();
        }

        private void buttonUpdateAppt_Click(object sender, EventArgs e)
        {
            Appointment updatedBooking = new Appointment(textBoxName.Text, textBoxPhone.Text, dateTimePickerAppt.Value, listBoxBranch.Text, listBoxService.Text);
            FileUtilities.UpdateRecord(selectedRecord, updatedBooking.ToString(), _FileAppointments);
            FileUtilities.loadRecords(dataGridViewAppts, _FileAppointments);
        }

        private void buttonCancelAppt_Click(object sender, EventArgs e)
        {
            FileUtilities.DeleteRecord(selectedRecord, _FileAppointments);
            FileUtilities.loadRecords(dataGridViewAppts, _FileAppointments);
        }

        private void buttonSearchAppts_Click(object sender, EventArgs e)
        {
            FileUtilities.FindMatches(listBoxSearchBranch.Text, listBoxSearchService.Text, _FileAppointments, dataGridViewSearchResults);
        }
    }
}
