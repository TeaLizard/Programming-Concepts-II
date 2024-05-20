namespace Assignment2_PROG1965_W2024_Sec6
{
    partial class VehicleService
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxCustomerInfo = new GroupBox();
            listBoxProvinces = new ListBox();
            buttonResetCustomer = new Button();
            textBoxPhone = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxCity = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            labelPhone = new Label();
            labelPostalCode = new Label();
            labelProvince = new Label();
            labelCity = new Label();
            labelLastName = new Label();
            labelFirstName = new Label();
            numericUpDownModelYear = new NumericUpDown();
            labelHeading = new Label();
            groupBoxVehicleInfo = new GroupBox();
            listBoxModels = new ListBox();
            listBoxMakes = new ListBox();
            buttonResetVehicle = new Button();
            listBoxServices = new ListBox();
            labelComments = new Label();
            labelModelYear = new Label();
            labelModel = new Label();
            labelMake = new Label();
            PanelMessage = new Panel();
            button1 = new Button();
            MessageDisplayBox = new Label();
            groupBoxDateSelection = new GroupBox();
            buttonBookAppointment = new Button();
            monthCalendarMarch2024 = new MonthCalendar();
            labelTimeSlot = new Label();
            listBoxCalendar = new ListBox();
            groupBoxBookings = new GroupBox();
            listViewBookings = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            groupBoxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownModelYear).BeginInit();
            groupBoxVehicleInfo.SuspendLayout();
            PanelMessage.SuspendLayout();
            groupBoxDateSelection.SuspendLayout();
            groupBoxBookings.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCustomerInfo
            // 
            groupBoxCustomerInfo.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxCustomerInfo.Controls.Add(listBoxProvinces);
            groupBoxCustomerInfo.Controls.Add(buttonResetCustomer);
            groupBoxCustomerInfo.Controls.Add(textBoxPhone);
            groupBoxCustomerInfo.Controls.Add(textBoxPostalCode);
            groupBoxCustomerInfo.Controls.Add(textBoxCity);
            groupBoxCustomerInfo.Controls.Add(textBoxLastName);
            groupBoxCustomerInfo.Controls.Add(textBoxFirstName);
            groupBoxCustomerInfo.Controls.Add(labelPhone);
            groupBoxCustomerInfo.Controls.Add(labelPostalCode);
            groupBoxCustomerInfo.Controls.Add(labelProvince);
            groupBoxCustomerInfo.Controls.Add(labelCity);
            groupBoxCustomerInfo.Controls.Add(labelLastName);
            groupBoxCustomerInfo.Controls.Add(labelFirstName);
            groupBoxCustomerInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxCustomerInfo.Location = new Point(15, 64);
            groupBoxCustomerInfo.Margin = new Padding(4);
            groupBoxCustomerInfo.Name = "groupBoxCustomerInfo";
            groupBoxCustomerInfo.Padding = new Padding(4);
            groupBoxCustomerInfo.Size = new Size(396, 452);
            groupBoxCustomerInfo.TabIndex = 0;
            groupBoxCustomerInfo.TabStop = false;
            groupBoxCustomerInfo.Text = "Customer Information";
            // 
            // listBoxProvinces
            // 
            listBoxProvinces.FormattingEnabled = true;
            listBoxProvinces.ItemHeight = 28;
            listBoxProvinces.Items.AddRange(new object[] { "Select Provence", "AB\t", "BC\t", "MB\t", "NB", "NL", "NS\t", "NT", "NU", "ON", "PE\t", "QC", "SK\t", "YT" });
            listBoxProvinces.Location = new Point(158, 220);
            listBoxProvinces.Margin = new Padding(4);
            listBoxProvinces.Name = "listBoxProvinces";
            listBoxProvinces.Size = new Size(215, 60);
            listBoxProvinces.TabIndex = 15;
            // 
            // buttonResetCustomer
            // 
            buttonResetCustomer.Location = new Point(158, 378);
            buttonResetCustomer.Margin = new Padding(4);
            buttonResetCustomer.Name = "buttonResetCustomer";
            buttonResetCustomer.Size = new Size(216, 50);
            buttonResetCustomer.TabIndex = 14;
            buttonResetCustomer.Text = "Reset Customer";
            buttonResetCustomer.UseVisualStyleBackColor = true;
            buttonResetCustomer.Click += ResetCustomer;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(158, 306);
            textBoxPhone.Margin = new Padding(4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(215, 35);
            textBoxPhone.TabIndex = 13;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(158, 261);
            textBoxPostalCode.Margin = new Padding(4);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(215, 35);
            textBoxPostalCode.TabIndex = 12;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(158, 158);
            textBoxCity.Margin = new Padding(4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(215, 35);
            textBoxCity.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(158, 105);
            textBoxLastName.Margin = new Padding(4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(215, 35);
            textBoxLastName.TabIndex = 8;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(158, 51);
            textBoxFirstName.Margin = new Padding(4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(215, 35);
            textBoxFirstName.TabIndex = 7;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(34, 316);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(79, 30);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone ";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(34, 274);
            labelPostalCode.Margin = new Padding(4, 0, 4, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(126, 30);
            labelPostalCode.TabIndex = 5;
            labelPostalCode.Text = "Postal Code";
            // 
            // labelProvince
            // 
            labelProvince.AutoSize = true;
            labelProvince.Location = new Point(34, 232);
            labelProvince.Margin = new Padding(4, 0, 4, 0);
            labelProvince.Name = "labelProvince";
            labelProvince.Size = new Size(95, 30);
            labelProvince.TabIndex = 4;
            labelProvince.Text = "Province";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(45, 169);
            labelCity.Margin = new Padding(4, 0, 4, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(50, 30);
            labelCity.TabIndex = 3;
            labelCity.Text = "City";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(34, 107);
            labelLastName.Margin = new Padding(4, 0, 4, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(114, 30);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(34, 65);
            labelFirstName.Margin = new Padding(4, 0, 4, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(117, 30);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // numericUpDownModelYear
            // 
            numericUpDownModelYear.Location = new Point(121, 138);
            numericUpDownModelYear.Margin = new Padding(4);
            numericUpDownModelYear.Maximum = new decimal(new int[] { 2024, 0, 0, 0 });
            numericUpDownModelYear.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDownModelYear.Name = "numericUpDownModelYear";
            numericUpDownModelYear.Size = new Size(268, 35);
            numericUpDownModelYear.TabIndex = 16;
            numericUpDownModelYear.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // labelHeading
            // 
            labelHeading.AutoSize = true;
            labelHeading.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeading.ForeColor = SystemColors.HotTrack;
            labelHeading.Location = new Point(15, 11);
            labelHeading.Margin = new Padding(4, 0, 4, 0);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(604, 32);
            labelHeading.TabIndex = 1;
            labelHeading.Text = "Vehicle Service Appointment Booking (March 2024)";
            // 
            // groupBoxVehicleInfo
            // 
            groupBoxVehicleInfo.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxVehicleInfo.Controls.Add(numericUpDownModelYear);
            groupBoxVehicleInfo.Controls.Add(listBoxModels);
            groupBoxVehicleInfo.Controls.Add(listBoxMakes);
            groupBoxVehicleInfo.Controls.Add(buttonResetVehicle);
            groupBoxVehicleInfo.Controls.Add(listBoxServices);
            groupBoxVehicleInfo.Controls.Add(labelComments);
            groupBoxVehicleInfo.Controls.Add(labelModelYear);
            groupBoxVehicleInfo.Controls.Add(labelModel);
            groupBoxVehicleInfo.Controls.Add(labelMake);
            groupBoxVehicleInfo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxVehicleInfo.Location = new Point(504, 64);
            groupBoxVehicleInfo.Margin = new Padding(4);
            groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            groupBoxVehicleInfo.Padding = new Padding(4);
            groupBoxVehicleInfo.Size = new Size(446, 452);
            groupBoxVehicleInfo.TabIndex = 14;
            groupBoxVehicleInfo.TabStop = false;
            groupBoxVehicleInfo.Text = "Vehicle Information";
            // 
            // listBoxModels
            // 
            listBoxModels.FormattingEnabled = true;
            listBoxModels.ItemHeight = 28;
            listBoxModels.Location = new Point(121, 96);
            listBoxModels.Margin = new Padding(4);
            listBoxModels.Name = "listBoxModels";
            listBoxModels.Size = new Size(266, 60);
            listBoxModels.TabIndex = 17;
            // 
            // listBoxMakes
            // 
            listBoxMakes.FormattingEnabled = true;
            listBoxMakes.ItemHeight = 28;
            listBoxMakes.Location = new Point(122, 55);
            listBoxMakes.Margin = new Padding(4);
            listBoxMakes.Name = "listBoxMakes";
            listBoxMakes.Size = new Size(265, 60);
            listBoxMakes.TabIndex = 16;
            listBoxMakes.SelectedIndexChanged += UpdateModels;
            // 
            // buttonResetVehicle
            // 
            buttonResetVehicle.Location = new Point(121, 378);
            buttonResetVehicle.Margin = new Padding(4);
            buttonResetVehicle.Name = "buttonResetVehicle";
            buttonResetVehicle.Size = new Size(269, 50);
            buttonResetVehicle.TabIndex = 15;
            buttonResetVehicle.Text = "Reset Vehicle";
            buttonResetVehicle.UseVisualStyleBackColor = true;
            buttonResetVehicle.Click += ResetVehicle;
            // 
            // listBoxServices
            // 
            listBoxServices.FormattingEnabled = true;
            listBoxServices.ItemHeight = 28;
            listBoxServices.Items.AddRange(new object[] { "Air & Cabin Air Filter", "Air Conditioning Service", "Brake Fluid Exchange", "Brakes & Disks", "Engine Tune-Up", "Full Vehicle Inspection", "Lighting & Bulbs", "Oil & Filter Change", "Other", "Starting & Charging/Battery", "Tire Replacement/Rotation", "Wheel Alignment", "Wheel Balance" });
            listBoxServices.Location = new Point(122, 195);
            listBoxServices.Margin = new Padding(4);
            listBoxServices.Name = "listBoxServices";
            listBoxServices.Size = new Size(265, 144);
            listBoxServices.TabIndex = 11;
            // 
            // labelComments
            // 
            labelComments.AutoSize = true;
            labelComments.Location = new Point(34, 232);
            labelComments.Margin = new Padding(4, 0, 4, 0);
            labelComments.Name = "labelComments";
            labelComments.Size = new Size(81, 30);
            labelComments.TabIndex = 4;
            labelComments.Text = "Service";
            // 
            // labelModelYear
            // 
            labelModelYear.AutoSize = true;
            labelModelYear.Location = new Point(34, 148);
            labelModelYear.Margin = new Padding(4, 0, 4, 0);
            labelModelYear.Name = "labelModelYear";
            labelModelYear.Size = new Size(53, 30);
            labelModelYear.TabIndex = 2;
            labelModelYear.Text = "Year";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Location = new Point(34, 107);
            labelModel.Margin = new Padding(4, 0, 4, 0);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(74, 30);
            labelModel.TabIndex = 1;
            labelModel.Text = "Model";
            // 
            // labelMake
            // 
            labelMake.AutoSize = true;
            labelMake.Location = new Point(34, 65);
            labelMake.Margin = new Padding(4, 0, 4, 0);
            labelMake.Name = "labelMake";
            labelMake.Size = new Size(65, 30);
            labelMake.TabIndex = 0;
            labelMake.Text = "Make";
            // 
            // PanelMessage
            // 
            PanelMessage.BackColor = Color.White;
            PanelMessage.Controls.Add(button1);
            PanelMessage.Controls.Add(MessageDisplayBox);
            PanelMessage.Location = new Point(418, 169);
            PanelMessage.Name = "PanelMessage";
            PanelMessage.Size = new Size(599, 287);
            PanelMessage.TabIndex = 1;
            PanelMessage.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(238, 182);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Okay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CloseMessageBox;
            // 
            // MessageDisplayBox
            // 
            MessageDisplayBox.AutoSize = true;
            MessageDisplayBox.Location = new Point(38, 48);
            MessageDisplayBox.Name = "MessageDisplayBox";
            MessageDisplayBox.Size = new Size(59, 25);
            MessageDisplayBox.TabIndex = 0;
            MessageDisplayBox.Text = "label1";
            // 
            // groupBoxDateSelection
            // 
            groupBoxDateSelection.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxDateSelection.Controls.Add(buttonBookAppointment);
            groupBoxDateSelection.Controls.Add(monthCalendarMarch2024);
            groupBoxDateSelection.Controls.Add(labelTimeSlot);
            groupBoxDateSelection.Controls.Add(listBoxCalendar);
            groupBoxDateSelection.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxDateSelection.Location = new Point(1045, 64);
            groupBoxDateSelection.Margin = new Padding(4);
            groupBoxDateSelection.Name = "groupBoxDateSelection";
            groupBoxDateSelection.Padding = new Padding(4);
            groupBoxDateSelection.Size = new Size(388, 452);
            groupBoxDateSelection.TabIndex = 15;
            groupBoxDateSelection.TabStop = false;
            groupBoxDateSelection.Text = "Date and Time";
            // 
            // buttonBookAppointment
            // 
            buttonBookAppointment.BackColor = SystemColors.Desktop;
            buttonBookAppointment.ForeColor = SystemColors.ButtonHighlight;
            buttonBookAppointment.Location = new Point(34, 378);
            buttonBookAppointment.Margin = new Padding(4);
            buttonBookAppointment.Name = "buttonBookAppointment";
            buttonBookAppointment.Size = new Size(328, 50);
            buttonBookAppointment.TabIndex = 15;
            buttonBookAppointment.Text = "Book Appointment";
            buttonBookAppointment.UseVisualStyleBackColor = false;
            buttonBookAppointment.Click += BookAppointment;
            // 
            // monthCalendarMarch2024
            // 
            monthCalendarMarch2024.Location = new Point(34, 105);
            monthCalendarMarch2024.Margin = new Padding(11);
            monthCalendarMarch2024.MaxDate = new DateTime(2024, 3, 31, 0, 0, 0, 0);
            monthCalendarMarch2024.MinDate = new DateTime(2024, 3, 1, 0, 0, 0, 0);
            monthCalendarMarch2024.Name = "monthCalendarMarch2024";
            monthCalendarMarch2024.ShowToday = false;
            monthCalendarMarch2024.TabIndex = 11;
            // 
            // labelTimeSlot
            // 
            labelTimeSlot.AutoSize = true;
            labelTimeSlot.Location = new Point(38, 61);
            labelTimeSlot.Margin = new Padding(4, 0, 4, 0);
            labelTimeSlot.Name = "labelTimeSlot";
            labelTimeSlot.Size = new Size(103, 30);
            labelTimeSlot.TabIndex = 10;
            labelTimeSlot.Text = "Time Slot";
            // 
            // listBoxCalendar
            // 
            listBoxCalendar.FormattingEnabled = true;
            listBoxCalendar.ItemHeight = 28;
            listBoxCalendar.Items.AddRange(new object[] { "Select Time Slot", "09 AM - 10 AM", "10 AM - 11 AM", "11 AM - 12 PM", "12 PM - 01 PM", "01 PM - 02 PM", "02 PM - 03 PM", "03 PM - 04 PM", "04 PM - 05 PM" });
            listBoxCalendar.Location = new Point(146, 55);
            listBoxCalendar.Margin = new Padding(4);
            listBoxCalendar.Name = "listBoxCalendar";
            listBoxCalendar.Size = new Size(214, 60);
            listBoxCalendar.TabIndex = 9;
            // 
            // groupBoxBookings
            // 
            groupBoxBookings.Controls.Add(listViewBookings);
            groupBoxBookings.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxBookings.Location = new Point(15, 538);
            groupBoxBookings.Margin = new Padding(4);
            groupBoxBookings.Name = "groupBoxBookings";
            groupBoxBookings.Padding = new Padding(4);
            groupBoxBookings.Size = new Size(1418, 372);
            groupBoxBookings.TabIndex = 0;
            groupBoxBookings.TabStop = false;
            groupBoxBookings.Text = "Bookings";
            // 
            // listViewBookings
            // 
            listViewBookings.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listViewBookings.FullRowSelect = true;
            listViewBookings.GridLines = true;
            listViewBookings.Location = new Point(16, 32);
            listViewBookings.Margin = new Padding(4);
            listViewBookings.Name = "listViewBookings";
            listViewBookings.Size = new Size(1393, 328);
            listViewBookings.TabIndex = 0;
            listViewBookings.UseCompatibleStateImageBehavior = false;
            listViewBookings.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Date";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Time";
            columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "First Name";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Last Name";
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Postal Code";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Phone";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Make";
            columnHeader7.Width = 75;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Model";
            columnHeader8.Width = 75;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Year";
            columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Service";
            columnHeader10.Width = 212;
            // 
            // VehicleService
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 911);
            Controls.Add(PanelMessage);
            Controls.Add(groupBoxBookings);
            Controls.Add(groupBoxDateSelection);
            Controls.Add(groupBoxVehicleInfo);
            Controls.Add(labelHeading);
            Controls.Add(groupBoxCustomerInfo);
            Margin = new Padding(4);
            Name = "VehicleService";
            Text = "Vehicle Service Appointment Booking Form";
            Load += VehicleService_Load;
            groupBoxCustomerInfo.ResumeLayout(false);
            groupBoxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownModelYear).EndInit();
            groupBoxVehicleInfo.ResumeLayout(false);
            groupBoxVehicleInfo.PerformLayout();
            PanelMessage.ResumeLayout(false);
            PanelMessage.PerformLayout();
            groupBoxDateSelection.ResumeLayout(false);
            groupBoxDateSelection.PerformLayout();
            groupBoxBookings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxCustomerInfo;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label labelPhone;
        private Label labelPostalCode;
        private Label labelProvince;
        private Label labelCity;
        private Label labelLastName;
        private Label labelFirstName;
        private TextBox textBoxPhone;
        private TextBox textBoxPostalCode;
        private TextBox textBoxCity;
        private Label labelHeading;
        private GroupBox groupBoxVehicleInfo;
        private TextBox textBoxModel;
        private Label labelComments;
        private Label labelModelYear;
        private Label labelModel;
        private Label labelMake;
        private GroupBox groupBoxDateSelection;
        private ListBox listBoxServices;
        private ListBox listBoxCalendar;
        private Label labelTimeSlot;
        private MonthCalendar monthCalendarMarch2024;
        private Button buttonResetCustomer;
        private Button buttonResetVehicle;
        private Button buttonBookAppointment;
        private ListBox listBoxProvinces;
        private ListBox listBoxMakes;
        private ListBox listBoxModels;
        private GroupBox groupBoxBookings;
        private ListView listView1;
        private ListView listViewBookings;
        private NumericUpDown numericUpDownModelYear;
        private ColumnHeader columnHeaderDate;
        private ColumnHeader columnHeaderTime;
        private ColumnHeader columnHeaderFName;
        private ColumnHeader columnHeaderLName;
        private ColumnHeader columnHeaderMake;
        private ColumnHeader columnHeaderModel;
        private Panel PanelMessage;
        private Button button1;
        private Label MessageDisplayBox;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}
