namespace Assignment3_PROG1965_W24.Forms
{
    partial class FormManageStaff
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
            groupBoxNewEmployee = new GroupBox();
            label1 = new Label();
            textBoxAddress = new TextBox();
            labelPass = new Label();
            textBoxPass = new TextBox();
            buttonNewEmployee = new Button();
            labelSIN = new Label();
            labelPhone = new Label();
            labelPostalCode = new Label();
            labelProvince = new Label();
            labelCity = new Label();
            labelLname = new Label();
            labelFname = new Label();
            labelRole = new Label();
            textBoxSIN = new TextBox();
            textBoxPhoneNumber = new TextBox();
            listBoxRoles = new ListBox();
            textBoxPostalCode = new TextBox();
            textBoxProvince = new TextBox();
            textBoxCity = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            labelStatus = new Label();
            groupBoxNewEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNewEmployee
            // 
            groupBoxNewEmployee.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxNewEmployee.Controls.Add(label1);
            groupBoxNewEmployee.Controls.Add(textBoxAddress);
            groupBoxNewEmployee.Controls.Add(labelPass);
            groupBoxNewEmployee.Controls.Add(textBoxPass);
            groupBoxNewEmployee.Controls.Add(buttonNewEmployee);
            groupBoxNewEmployee.Controls.Add(labelSIN);
            groupBoxNewEmployee.Controls.Add(labelPhone);
            groupBoxNewEmployee.Controls.Add(labelPostalCode);
            groupBoxNewEmployee.Controls.Add(labelProvince);
            groupBoxNewEmployee.Controls.Add(labelCity);
            groupBoxNewEmployee.Controls.Add(labelLname);
            groupBoxNewEmployee.Controls.Add(labelFname);
            groupBoxNewEmployee.Controls.Add(labelRole);
            groupBoxNewEmployee.Controls.Add(textBoxSIN);
            groupBoxNewEmployee.Controls.Add(textBoxPhoneNumber);
            groupBoxNewEmployee.Controls.Add(listBoxRoles);
            groupBoxNewEmployee.Controls.Add(textBoxPostalCode);
            groupBoxNewEmployee.Controls.Add(textBoxProvince);
            groupBoxNewEmployee.Controls.Add(textBoxCity);
            groupBoxNewEmployee.Controls.Add(textBoxLastName);
            groupBoxNewEmployee.Controls.Add(textBoxFirstName);
            groupBoxNewEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxNewEmployee.Location = new Point(36, 81);
            groupBoxNewEmployee.Margin = new Padding(4);
            groupBoxNewEmployee.Name = "groupBoxNewEmployee";
            groupBoxNewEmployee.Padding = new Padding(4);
            groupBoxNewEmployee.Size = new Size(385, 634);
            groupBoxNewEmployee.TabIndex = 0;
            groupBoxNewEmployee.TabStop = false;
            groupBoxNewEmployee.Text = "Add New Employee";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 200);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 20;
            label1.Text = "Address";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(165, 197);
            textBoxAddress.Margin = new Padding(4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(186, 31);
            textBoxAddress.TabIndex = 19;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(20, 533);
            labelPass.Margin = new Padding(4, 0, 4, 0);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(92, 25);
            labelPass.TabIndex = 18;
            labelPass.Text = "Password";
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(165, 522);
            textBoxPass.Margin = new Padding(4);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(186, 31);
            textBoxPass.TabIndex = 17;
            // 
            // buttonNewEmployee
            // 
            buttonNewEmployee.Location = new Point(44, 559);
            buttonNewEmployee.Margin = new Padding(4);
            buttonNewEmployee.Name = "buttonNewEmployee";
            buttonNewEmployee.Size = new Size(305, 45);
            buttonNewEmployee.TabIndex = 16;
            buttonNewEmployee.Text = "Add New Employee";
            buttonNewEmployee.UseVisualStyleBackColor = true;
            buttonNewEmployee.Click += AddNewEmployee;
            // 
            // labelSIN
            // 
            labelSIN.AutoSize = true;
            labelSIN.Location = new Point(29, 463);
            labelSIN.Margin = new Padding(4, 0, 4, 0);
            labelSIN.Name = "labelSIN";
            labelSIN.Size = new Size(42, 25);
            labelSIN.TabIndex = 15;
            labelSIN.Text = "SIN";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(14, 406);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(140, 25);
            labelPhone.TabIndex = 14;
            labelPhone.Text = "Phone Number";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(22, 353);
            labelPostalCode.Margin = new Padding(4, 0, 4, 0);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(111, 25);
            labelPostalCode.TabIndex = 13;
            labelPostalCode.Text = "Postal Code";
            // 
            // labelProvince
            // 
            labelProvince.AutoSize = true;
            labelProvince.Location = new Point(22, 300);
            labelProvince.Margin = new Padding(4, 0, 4, 0);
            labelProvince.Name = "labelProvince";
            labelProvince.Size = new Size(86, 25);
            labelProvince.TabIndex = 12;
            labelProvince.Text = "Province";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(29, 245);
            labelCity.Margin = new Padding(4, 0, 4, 0);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(45, 25);
            labelCity.TabIndex = 11;
            labelCity.Text = "City";
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Location = new Point(20, 156);
            labelLname.Margin = new Padding(4, 0, 4, 0);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(101, 25);
            labelLname.TabIndex = 10;
            labelLname.Text = "Last Name";
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Location = new Point(22, 97);
            labelFname.Margin = new Padding(4, 0, 4, 0);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(103, 25);
            labelFname.TabIndex = 9;
            labelFname.Text = "First Name";
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(22, 50);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(50, 25);
            labelRole.TabIndex = 8;
            labelRole.Text = "Role";
            // 
            // textBoxSIN
            // 
            textBoxSIN.Location = new Point(165, 458);
            textBoxSIN.Margin = new Padding(4);
            textBoxSIN.Name = "textBoxSIN";
            textBoxSIN.Size = new Size(186, 31);
            textBoxSIN.TabIndex = 7;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(165, 402);
            textBoxPhoneNumber.Margin = new Padding(4);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(186, 31);
            textBoxPhoneNumber.TabIndex = 6;
            // 
            // listBoxRoles
            // 
            listBoxRoles.FormattingEnabled = true;
            listBoxRoles.ItemHeight = 25;
            listBoxRoles.Items.AddRange(new object[] { "Admin", "Doctor", "Secratery" });
            listBoxRoles.Location = new Point(165, 45);
            listBoxRoles.Margin = new Padding(4);
            listBoxRoles.Name = "listBoxRoles";
            listBoxRoles.Size = new Size(186, 29);
            listBoxRoles.TabIndex = 5;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(165, 349);
            textBoxPostalCode.Margin = new Padding(4);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(186, 31);
            textBoxPostalCode.TabIndex = 4;
            // 
            // textBoxProvince
            // 
            textBoxProvince.Location = new Point(165, 297);
            textBoxProvince.Margin = new Padding(4);
            textBoxProvince.Name = "textBoxProvince";
            textBoxProvince.Size = new Size(186, 31);
            textBoxProvince.TabIndex = 3;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(165, 242);
            textBoxCity.Margin = new Padding(4);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(186, 31);
            textBoxCity.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(165, 151);
            textBoxLastName.Margin = new Padding(4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(186, 31);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(165, 96);
            textBoxFirstName.Margin = new Padding(4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(186, 31);
            textBoxFirstName.TabIndex = 0;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(36, 26);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(174, 25);
            labelStatus.TabIndex = 1;
            labelStatus.Text = "Logged-in with ID: ";
            // 
            // FormManageStaff
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 749);
            Controls.Add(labelStatus);
            Controls.Add(groupBoxNewEmployee);
            Margin = new Padding(4);
            Name = "FormManageStaff";
            Text = "FormManageStaff";
            Load += FormManageStaff_Load;
            groupBoxNewEmployee.ResumeLayout(false);
            groupBoxNewEmployee.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxNewEmployee;
        private TextBox textBoxPostalCode;
        private TextBox textBoxProvince;
        private TextBox textBoxCity;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private ListBox listBoxRoles;
        private Label labelCity;
        private Label labelLname;
        private Label labelFname;
        private Label labelRole;
        private TextBox textBoxSIN;
        private TextBox textBoxPhoneNumber;
        private Label labelSIN;
        private Label labelPhone;
        private Label labelPostalCode;
        private Label labelProvince;
        private Button buttonNewEmployee;
        private Label labelStatus;
        private Label labelPass;
        private TextBox textBoxPass;
        private Label label1;
        private TextBox textBoxAddress;
    }
}
