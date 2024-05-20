namespace Assignment3_PROG1965_W24.Forms
{
    partial class FormManagePatients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddPatient = new Button();
            groupBoxNewPatient = new GroupBox();
            textBoxAddress = new TextBox();
            label1 = new Label();
            labelDoctor = new Label();
            listBoxDoctors = new ListBox();
            textBoxHealthCard = new TextBox();
            labelHC = new Label();
            dateTimePickerDOB = new DateTimePicker();
            labelDOB = new Label();
            textBoxPhone = new TextBox();
            textBoxPcode = new TextBox();
            textBoxProv = new TextBox();
            textBoxCity = new TextBox();
            textBoxLname = new TextBox();
            textBoxFname = new TextBox();
            labelPhone = new Label();
            labelPcode = new Label();
            labelProv = new Label();
            labelCity = new Label();
            labelFname = new Label();
            labelLname = new Label();
            labelLoggedInID = new Label();
            groupBoxNewPatient.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddPatient
            // 
            buttonAddPatient.Location = new Point(144, 558);
            buttonAddPatient.Margin = new Padding(4);
            buttonAddPatient.Name = "buttonAddPatient";
            buttonAddPatient.Size = new Size(209, 36);
            buttonAddPatient.TabIndex = 0;
            buttonAddPatient.Text = "Add New Patient";
            buttonAddPatient.UseVisualStyleBackColor = true;
            buttonAddPatient.Click += buttonAddPatient_Click;
            // 
            // groupBoxNewPatient
            // 
            groupBoxNewPatient.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxNewPatient.Controls.Add(textBoxAddress);
            groupBoxNewPatient.Controls.Add(label1);
            groupBoxNewPatient.Controls.Add(labelDoctor);
            groupBoxNewPatient.Controls.Add(listBoxDoctors);
            groupBoxNewPatient.Controls.Add(textBoxHealthCard);
            groupBoxNewPatient.Controls.Add(labelHC);
            groupBoxNewPatient.Controls.Add(dateTimePickerDOB);
            groupBoxNewPatient.Controls.Add(labelDOB);
            groupBoxNewPatient.Controls.Add(textBoxPhone);
            groupBoxNewPatient.Controls.Add(buttonAddPatient);
            groupBoxNewPatient.Controls.Add(textBoxPcode);
            groupBoxNewPatient.Controls.Add(textBoxProv);
            groupBoxNewPatient.Controls.Add(textBoxCity);
            groupBoxNewPatient.Controls.Add(textBoxLname);
            groupBoxNewPatient.Controls.Add(textBoxFname);
            groupBoxNewPatient.Controls.Add(labelPhone);
            groupBoxNewPatient.Controls.Add(labelPcode);
            groupBoxNewPatient.Controls.Add(labelProv);
            groupBoxNewPatient.Controls.Add(labelCity);
            groupBoxNewPatient.Controls.Add(labelFname);
            groupBoxNewPatient.Controls.Add(labelLname);
            groupBoxNewPatient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxNewPatient.Location = new Point(15, 92);
            groupBoxNewPatient.Margin = new Padding(4);
            groupBoxNewPatient.Name = "groupBoxNewPatient";
            groupBoxNewPatient.Padding = new Padding(4);
            groupBoxNewPatient.Size = new Size(382, 624);
            groupBoxNewPatient.TabIndex = 1;
            groupBoxNewPatient.TabStop = false;
            groupBoxNewPatient.Text = "New Patient";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(142, 185);
            textBoxAddress.Margin = new Padding(4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(209, 31);
            textBoxAddress.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 185);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 20;
            label1.Text = "Address";
            // 
            // labelDoctor
            // 
            labelDoctor.AutoSize = true;
            labelDoctor.Location = new Point(22, 515);
            labelDoctor.Margin = new Padding(4, 0, 4, 0);
            labelDoctor.Name = "labelDoctor";
            labelDoctor.Size = new Size(70, 25);
            labelDoctor.TabIndex = 19;
            labelDoctor.Text = "Doctor";
            // 
            // listBoxDoctors
            // 
            listBoxDoctors.FormattingEnabled = true;
            listBoxDoctors.ItemHeight = 25;
            listBoxDoctors.Location = new Point(144, 505);
            listBoxDoctors.Margin = new Padding(4);
            listBoxDoctors.Name = "listBoxDoctors";
            listBoxDoctors.Size = new Size(208, 29);
            listBoxDoctors.TabIndex = 17;
            // 
            // textBoxHealthCard
            // 
            textBoxHealthCard.Location = new Point(142, 446);
            textBoxHealthCard.Margin = new Padding(4);
            textBoxHealthCard.Name = "textBoxHealthCard";
            textBoxHealthCard.Size = new Size(209, 31);
            textBoxHealthCard.TabIndex = 16;
            // 
            // labelHC
            // 
            labelHC.AutoSize = true;
            labelHC.Location = new Point(20, 451);
            labelHC.Margin = new Padding(4, 0, 4, 0);
            labelHC.Name = "labelHC";
            labelHC.Size = new Size(113, 25);
            labelHC.TabIndex = 15;
            labelHC.Text = "Health Card";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(142, 390);
            dateTimePickerDOB.Margin = new Padding(4);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(209, 31);
            dateTimePickerDOB.TabIndex = 14;
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.Location = new Point(20, 403);
            labelDOB.Margin = new Padding(4, 0, 4, 0);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(123, 25);
            labelDOB.TabIndex = 13;
            labelDOB.Text = "Date of Birth";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(142, 334);
            textBoxPhone.Margin = new Padding(4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(209, 31);
            textBoxPhone.TabIndex = 12;
            // 
            // textBoxPcode
            // 
            textBoxPcode.Location = new Point(142, 278);
            textBoxPcode.Margin = new Padding(4);
            textBoxPcode.Name = "textBoxPcode";
            textBoxPcode.Size = new Size(209, 31);
            textBoxPcode.TabIndex = 11;
            // 
            // textBoxProv
            // 
            textBoxProv.Location = new Point(142, 214);
            textBoxProv.Margin = new Padding(4);
            textBoxProv.Name = "textBoxProv";
            textBoxProv.Size = new Size(209, 31);
            textBoxProv.TabIndex = 10;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(142, 155);
            textBoxCity.Margin = new Padding(4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(209, 31);
            textBoxCity.TabIndex = 9;
            // 
            // textBoxLname
            // 
            textBoxLname.Location = new Point(142, 99);
            textBoxLname.Margin = new Padding(4);
            textBoxLname.Name = "textBoxLname";
            textBoxLname.Size = new Size(209, 31);
            textBoxLname.TabIndex = 8;
            // 
            // textBoxFname
            // 
            textBoxFname.Location = new Point(142, 40);
            textBoxFname.Margin = new Padding(4);
            textBoxFname.Name = "textBoxFname";
            textBoxFname.Size = new Size(209, 31);
            textBoxFname.TabIndex = 7;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(20, 341);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(66, 25);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone";
            // 
            // labelPcode
            // 
            labelPcode.AutoSize = true;
            labelPcode.Location = new Point(20, 284);
            labelPcode.Margin = new Padding(4, 0, 4, 0);
            labelPcode.Name = "labelPcode";
            labelPcode.Size = new Size(111, 25);
            labelPcode.TabIndex = 5;
            labelPcode.Text = "Postal Code";
            // 
            // labelProv
            // 
            labelProv.AutoSize = true;
            labelProv.Location = new Point(20, 220);
            labelProv.Margin = new Padding(4, 0, 4, 0);
            labelProv.Name = "labelProv";
            labelProv.Size = new Size(86, 25);
            labelProv.TabIndex = 4;
            labelProv.Text = "Province";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(20, 160);
            labelCity.Margin = new Padding(4, 0, 4, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(45, 25);
            labelCity.TabIndex = 3;
            labelCity.Text = "City";
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Location = new Point(20, 44);
            labelFname.Margin = new Padding(4, 0, 4, 0);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(103, 25);
            labelFname.TabIndex = 2;
            labelFname.Text = "First Name";
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Location = new Point(20, 104);
            labelLname.Margin = new Padding(4, 0, 4, 0);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(101, 25);
            labelLname.TabIndex = 1;
            labelLname.Text = "Last Name";
            // 
            // labelLoggedInID
            // 
            labelLoggedInID.AutoSize = true;
            labelLoggedInID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLoggedInID.Location = new Point(15, 37);
            labelLoggedInID.Margin = new Padding(4, 0, 4, 0);
            labelLoggedInID.Name = "labelLoggedInID";
            labelLoggedInID.Size = new Size(167, 25);
            labelLoggedInID.TabIndex = 2;
            labelLoggedInID.Text = "Logged in with ID:";
            // 
            // FormManagePatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 732);
            Controls.Add(labelLoggedInID);
            Controls.Add(groupBoxNewPatient);
            Margin = new Padding(4);
            Name = "FormManagePatients";
            Text = "FormManagePatients";
            Load += FormManagePatients_Load;
            groupBoxNewPatient.ResumeLayout(false);
            groupBoxNewPatient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddPatient;
        private GroupBox groupBoxNewPatient;
        private Label labelFname;
        private Label labelLname;
        private TextBox textBoxPhone;
        private TextBox textBoxPcode;
        private TextBox textBoxProv;
        private TextBox textBoxCity;
        private TextBox textBoxLname;
        private TextBox textBoxFname;
        private Label labelPhone;
        private Label labelPcode;
        private Label labelProv;
        private Label labelCity;
        private Label labelHC;
        private DateTimePicker dateTimePickerDOB;
        private Label labelDOB;
        private TextBox textBoxHealthCard;
        private Label labelLoggedInID;
        private Label labelDoctor;
        private ListBox listBoxDoctors;
        private TextBox textBoxAddress;
        private Label label1;
    }
}