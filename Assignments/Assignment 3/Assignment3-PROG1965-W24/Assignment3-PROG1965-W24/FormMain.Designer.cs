namespace Assignment3_PROG1965_W24
{
    partial class FormMain
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
            buttonAdminManagePatients = new Button();
            groupBoxAdmin = new GroupBox();
            buttonAdminManageStaff = new Button();
            groupBoxSecratery = new GroupBox();
            buttonSecrateryManageDocuments = new Button();
            buttonSecrateryManagePatients = new Button();
            groupBoxDoctor = new GroupBox();
            buttonDoctorManagePatients = new Button();
            radioButtonAdmin = new RadioButton();
            radioButtonDoctor = new RadioButton();
            radioButtonSecratery = new RadioButton();
            groupBoxLogin = new GroupBox();
            labelSelect = new Label();
            buttonLogout = new Button();
            labelStatus = new Label();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            labelEmpID = new Label();
            textBoxUserName = new TextBox();
            groupBoxFooter = new GroupBox();
            groupBox1 = new GroupBox();
            groupBoxAdmin.SuspendLayout();
            groupBoxSecratery.SuspendLayout();
            groupBoxDoctor.SuspendLayout();
            groupBoxLogin.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAdminManagePatients
            // 
            buttonAdminManagePatients.Location = new Point(17, 35);
            buttonAdminManagePatients.Name = "buttonAdminManagePatients";
            buttonAdminManagePatients.Size = new Size(187, 81);
            buttonAdminManagePatients.TabIndex = 0;
            buttonAdminManagePatients.Text = "Manage Patients";
            buttonAdminManagePatients.UseVisualStyleBackColor = true;
            buttonAdminManagePatients.Click += buttonAdminManagePatients_Click;
            // 
            // groupBoxAdmin
            // 
            groupBoxAdmin.BackColor = SystemColors.ActiveCaption;
            groupBoxAdmin.Controls.Add(buttonAdminManageStaff);
            groupBoxAdmin.Controls.Add(buttonAdminManagePatients);
            groupBoxAdmin.Location = new Point(12, 118);
            groupBoxAdmin.Name = "groupBoxAdmin";
            groupBoxAdmin.Size = new Size(419, 138);
            groupBoxAdmin.TabIndex = 2;
            groupBoxAdmin.TabStop = false;
            groupBoxAdmin.Text = "Admin Controls";
            groupBoxAdmin.Visible = false;
            // 
            // buttonAdminManageStaff
            // 
            buttonAdminManageStaff.Location = new Point(216, 35);
            buttonAdminManageStaff.Name = "buttonAdminManageStaff";
            buttonAdminManageStaff.Size = new Size(187, 81);
            buttonAdminManageStaff.TabIndex = 4;
            buttonAdminManageStaff.Text = "Manage Staff";
            buttonAdminManageStaff.UseVisualStyleBackColor = true;
            buttonAdminManageStaff.Click += buttonAdminManageStaff_Click;
            // 
            // groupBoxSecratery
            // 
            groupBoxSecratery.BackColor = SystemColors.ActiveCaption;
            groupBoxSecratery.Controls.Add(buttonSecrateryManageDocuments);
            groupBoxSecratery.Controls.Add(buttonSecrateryManagePatients);
            groupBoxSecratery.Location = new Point(12, 118);
            groupBoxSecratery.Name = "groupBoxSecratery";
            groupBoxSecratery.Size = new Size(419, 138);
            groupBoxSecratery.TabIndex = 6;
            groupBoxSecratery.TabStop = false;
            groupBoxSecratery.Text = "Secratery Controls";
            groupBoxSecratery.Visible = false;
            // 
            // buttonSecrateryManageDocuments
            // 
            buttonSecrateryManageDocuments.Location = new Point(216, 35);
            buttonSecrateryManageDocuments.Name = "buttonSecrateryManageDocuments";
            buttonSecrateryManageDocuments.Size = new Size(187, 78);
            buttonSecrateryManageDocuments.TabIndex = 4;
            buttonSecrateryManageDocuments.Text = "Manage Documents";
            buttonSecrateryManageDocuments.UseVisualStyleBackColor = true;
            buttonSecrateryManageDocuments.Click += buttonSecrateryManageDocuments_Click;
            // 
            // buttonSecrateryManagePatients
            // 
            buttonSecrateryManagePatients.Location = new Point(17, 35);
            buttonSecrateryManagePatients.Name = "buttonSecrateryManagePatients";
            buttonSecrateryManagePatients.Size = new Size(187, 78);
            buttonSecrateryManagePatients.TabIndex = 0;
            buttonSecrateryManagePatients.Text = "Manage Patients";
            buttonSecrateryManagePatients.UseVisualStyleBackColor = true;
            buttonSecrateryManagePatients.Click += buttonSecrateryManagePatients_Click;
            // 
            // groupBoxDoctor
            // 
            groupBoxDoctor.BackColor = SystemColors.ActiveCaption;
            groupBoxDoctor.Controls.Add(buttonDoctorManagePatients);
            groupBoxDoctor.Location = new Point(12, 118);
            groupBoxDoctor.Name = "groupBoxDoctor";
            groupBoxDoctor.Size = new Size(419, 138);
            groupBoxDoctor.TabIndex = 6;
            groupBoxDoctor.TabStop = false;
            groupBoxDoctor.Text = "Doctor Controls";
            groupBoxDoctor.Visible = false;
            // 
            // buttonDoctorManagePatients
            // 
            buttonDoctorManagePatients.Location = new Point(20, 37);
            buttonDoctorManagePatients.Name = "buttonDoctorManagePatients";
            buttonDoctorManagePatients.Size = new Size(190, 84);
            buttonDoctorManagePatients.TabIndex = 0;
            buttonDoctorManagePatients.Text = "Manage Patients";
            buttonDoctorManagePatients.UseVisualStyleBackColor = true;
            buttonDoctorManagePatients.Click += buttonDoctorManagePatients_Click;
            // 
            // radioButtonAdmin
            // 
            radioButtonAdmin.AutoSize = true;
            radioButtonAdmin.Checked = true;
            radioButtonAdmin.Location = new Point(263, 54);
            radioButtonAdmin.Name = "radioButtonAdmin";
            radioButtonAdmin.Size = new Size(104, 34);
            radioButtonAdmin.TabIndex = 3;
            radioButtonAdmin.TabStop = true;
            radioButtonAdmin.Text = "Admin";
            radioButtonAdmin.UseVisualStyleBackColor = true;
            radioButtonAdmin.Click += ChangeBackground;
            // 
            // radioButtonDoctor
            // 
            radioButtonDoctor.AutoSize = true;
            radioButtonDoctor.Location = new Point(413, 54);
            radioButtonDoctor.Name = "radioButtonDoctor";
            radioButtonDoctor.Size = new Size(105, 34);
            radioButtonDoctor.TabIndex = 4;
            radioButtonDoctor.Text = "Doctor";
            radioButtonDoctor.UseVisualStyleBackColor = true;
            radioButtonDoctor.Click += ChangeBackground;
            // 
            // radioButtonSecratery
            // 
            radioButtonSecratery.AutoSize = true;
            radioButtonSecratery.Location = new Point(568, 54);
            radioButtonSecratery.Name = "radioButtonSecratery";
            radioButtonSecratery.Size = new Size(129, 34);
            radioButtonSecratery.TabIndex = 5;
            radioButtonSecratery.Text = "Secratery";
            radioButtonSecratery.UseVisualStyleBackColor = true;
            radioButtonSecratery.Click += ChangeBackground;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.BackColor = Color.SteelBlue;
            groupBoxLogin.Controls.Add(labelSelect);
            groupBoxLogin.Controls.Add(radioButtonAdmin);
            groupBoxLogin.Controls.Add(radioButtonSecratery);
            groupBoxLogin.Controls.Add(radioButtonDoctor);
            groupBoxLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxLogin.ForeColor = SystemColors.Control;
            groupBoxLogin.Location = new Point(12, 12);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Size = new Size(759, 100);
            groupBoxLogin.TabIndex = 6;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "Welcome";
            // 
            // labelSelect
            // 
            labelSelect.AutoSize = true;
            labelSelect.Location = new Point(44, 39);
            labelSelect.Name = "labelSelect";
            labelSelect.Size = new Size(137, 30);
            labelSelect.TabIndex = 12;
            labelSelect.Text = "Select a Role";
            // 
            // buttonLogout
            // 
            buttonLogout.ForeColor = Color.DarkRed;
            buttonLogout.Location = new Point(235, 59);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(90, 30);
            buttonLogout.TabIndex = 12;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(6, 98);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(198, 30);
            labelStatus.TabIndex = 11;
            labelStatus.Text = "Login with your ID";
            // 
            // buttonLogin
            // 
            buttonLogin.ForeColor = SystemColors.InfoText;
            buttonLogin.Location = new Point(235, 59);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(90, 30);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "ENTER";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(123, 60);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(111, 35);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(123, 34);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(105, 30);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Password";
            // 
            // labelEmpID
            // 
            labelEmpID.AutoSize = true;
            labelEmpID.Location = new Point(6, 34);
            labelEmpID.Name = "labelEmpID";
            labelEmpID.Size = new Size(136, 30);
            labelEmpID.TabIndex = 7;
            labelEmpID.Text = "Employee ID";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(6, 60);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(111, 35);
            textBoxUserName.TabIndex = 6;
            // 
            // groupBoxFooter
            // 
            groupBoxFooter.BackColor = Color.SteelBlue;
            groupBoxFooter.Font = new Font("Segoe UI Semilight", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxFooter.ForeColor = SystemColors.ButtonHighlight;
            groupBoxFooter.Location = new Point(12, 262);
            groupBoxFooter.Name = "groupBoxFooter";
            groupBoxFooter.Size = new Size(759, 26);
            groupBoxFooter.TabIndex = 7;
            groupBoxFooter.TabStop = false;
            groupBoxFooter.Text = "Health is Wealth Clinic Inc.";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(buttonLogout);
            groupBox1.Controls.Add(labelStatus);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(labelEmpID);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(437, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 138);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 573);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxAdmin);
            Controls.Add(groupBoxDoctor);
            Controls.Add(groupBoxSecratery);
            Controls.Add(groupBoxFooter);
            Controls.Add(groupBoxLogin);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "FormMain";
            Text = "Health is Wealth - Main Form";
            Load += FormMain_Load;
            groupBoxAdmin.ResumeLayout(false);
            groupBoxSecratery.ResumeLayout(false);
            groupBoxDoctor.ResumeLayout(false);
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdminManagePatients;
        private GroupBox groupBoxAdmin;
        private RadioButton radioButtonAdmin;
        private RadioButton radioButtonDoctor;
        private RadioButton radioButtonSecratery;
        private GroupBox groupBoxLogin;
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Label labelEmpID;
        private Button buttonLogin;
        private Button buttonAdminManageStaff;
        private GroupBox groupBoxFooter;
        private GroupBox groupBoxDoctor;
        private Button buttonDoctorManagePatients;
        private GroupBox groupBoxSecratery;
        private Button buttonSecrateryManageDocuments;
        private Button buttonSecrateryManagePatients;
        private Label labelStatus;
        private Button buttonLogout;
        private GroupBox groupBox1;
        private Label labelSelect;
    }
}
