namespace InClass_Assignment_3_Prog1965_Sec_6
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
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxDriverLic = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelDrivLic = new Label();
            labelDOB = new Label();
            groupBox1DriverInfo = new GroupBox();
            labelDrivClass = new Label();
            textBoxDrivClass = new TextBox();
            buttonEnterData = new Button();
            monthCalendarTest = new MonthCalendar();
            groupBoxAppointments = new GroupBox();
            listBoxAppointments = new ListBox();
            MessagesBox = new GroupBox();
            buttonOkay = new Button();
            labelError = new Label();
            buttonShowAllAppts = new Button();
            buttonClearAllAppts = new Button();
            label1 = new Label();
            labelRegexPost = new Label();
            groupBox1DriverInfo.SuspendLayout();
            groupBoxAppointments.SuspendLayout();
            MessagesBox.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(34, 84);
            textBoxFirstName.Margin = new Padding(4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(409, 36);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(34, 169);
            textBoxLastName.Margin = new Padding(4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(409, 36);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxDriverLic
            // 
            textBoxDriverLic.Location = new Point(34, 264);
            textBoxDriverLic.Margin = new Padding(4);
            textBoxDriverLic.Name = "textBoxDriverLic";
            textBoxDriverLic.Size = new Size(262, 36);
            textBoxDriverLic.TabIndex = 2;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDOB.Location = new Point(34, 356);
            dateTimePickerDOB.Margin = new Padding(4);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(409, 35);
            dateTimePickerDOB.TabIndex = 3;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(26, 46);
            labelFirstName.Margin = new Padding(4, 0, 4, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(113, 30);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(26, 132);
            labelLastName.Margin = new Padding(4, 0, 4, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(112, 30);
            labelLastName.TabIndex = 5;
            labelLastName.Text = "Last Name";
            // 
            // labelDrivLic
            // 
            labelDrivLic.AutoSize = true;
            labelDrivLic.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDrivLic.Location = new Point(26, 229);
            labelDrivLic.Margin = new Padding(4, 0, 4, 0);
            labelDrivLic.Name = "labelDrivLic";
            labelDrivLic.Size = new Size(143, 30);
            labelDrivLic.TabIndex = 6;
            labelDrivLic.Text = "Driver Licence";
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDOB.Location = new Point(26, 323);
            labelDOB.Margin = new Padding(4, 0, 4, 0);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(131, 30);
            labelDOB.TabIndex = 7;
            labelDOB.Text = "Date of Birth";
            // 
            // groupBox1DriverInfo
            // 
            groupBox1DriverInfo.Controls.Add(labelDrivClass);
            groupBox1DriverInfo.Controls.Add(textBoxDrivClass);
            groupBox1DriverInfo.Controls.Add(dateTimePickerDOB);
            groupBox1DriverInfo.Controls.Add(labelFirstName);
            groupBox1DriverInfo.Controls.Add(labelLastName);
            groupBox1DriverInfo.Controls.Add(textBoxFirstName);
            groupBox1DriverInfo.Controls.Add(labelDrivLic);
            groupBox1DriverInfo.Controls.Add(labelDOB);
            groupBox1DriverInfo.Controls.Add(textBoxLastName);
            groupBox1DriverInfo.Controls.Add(textBoxDriverLic);
            groupBox1DriverInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1DriverInfo.Location = new Point(15, 15);
            groupBox1DriverInfo.Margin = new Padding(4);
            groupBox1DriverInfo.Name = "groupBox1DriverInfo";
            groupBox1DriverInfo.Padding = new Padding(4);
            groupBox1DriverInfo.Size = new Size(466, 422);
            groupBox1DriverInfo.TabIndex = 8;
            groupBox1DriverInfo.TabStop = false;
            groupBox1DriverInfo.Text = "Book Driving Test";
            // 
            // labelDrivClass
            // 
            labelDrivClass.AutoSize = true;
            labelDrivClass.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDrivClass.Location = new Point(318, 229);
            labelDrivClass.Margin = new Padding(4, 0, 4, 0);
            labelDrivClass.Name = "labelDrivClass";
            labelDrivClass.Size = new Size(135, 30);
            labelDrivClass.TabIndex = 9;
            labelDrivClass.Text = "Current Level";
            // 
            // textBoxDrivClass
            // 
            textBoxDrivClass.Location = new Point(332, 264);
            textBoxDrivClass.Margin = new Padding(4);
            textBoxDrivClass.Name = "textBoxDrivClass";
            textBoxDrivClass.Size = new Size(110, 36);
            textBoxDrivClass.TabIndex = 8;
            // 
            // buttonEnterData
            // 
            buttonEnterData.BackColor = Color.Black;
            buttonEnterData.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEnterData.ForeColor = Color.White;
            buttonEnterData.Location = new Point(496, 365);
            buttonEnterData.Margin = new Padding(4);
            buttonEnterData.Name = "buttonEnterData";
            buttonEnterData.Size = new Size(328, 72);
            buttonEnterData.TabIndex = 9;
            buttonEnterData.Text = "Enter";
            buttonEnterData.UseVisualStyleBackColor = false;
            buttonEnterData.Click += EnterClick;
            // 
            // monthCalendarTest
            // 
            monthCalendarTest.Location = new Point(496, 74);
            monthCalendarTest.Margin = new Padding(11);
            monthCalendarTest.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            monthCalendarTest.MinDate = new DateTime(2024, 2, 15, 0, 0, 0, 0);
            monthCalendarTest.Name = "monthCalendarTest";
            monthCalendarTest.TabIndex = 10;
            // 
            // groupBoxAppointments
            // 
            groupBoxAppointments.Controls.Add(listBoxAppointments);
            groupBoxAppointments.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxAppointments.Location = new Point(858, 31);
            groupBoxAppointments.Margin = new Padding(4);
            groupBoxAppointments.Name = "groupBoxAppointments";
            groupBoxAppointments.Padding = new Padding(4);
            groupBoxAppointments.Size = new Size(362, 318);
            groupBoxAppointments.TabIndex = 13;
            groupBoxAppointments.TabStop = false;
            groupBoxAppointments.Text = "Drivers and Appointments";
            // 
            // listBoxAppointments
            // 
            listBoxAppointments.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBoxAppointments.FormattingEnabled = true;
            listBoxAppointments.ItemHeight = 25;
            listBoxAppointments.Location = new Point(8, 50);
            listBoxAppointments.Margin = new Padding(4);
            listBoxAppointments.Name = "listBoxAppointments";
            listBoxAppointments.Size = new Size(349, 254);
            listBoxAppointments.TabIndex = 0;
            // 
            // MessagesBox
            // 
            MessagesBox.Controls.Add(buttonOkay);
            MessagesBox.Controls.Add(labelError);
            MessagesBox.Location = new Point(501, 124);
            MessagesBox.Name = "MessagesBox";
            MessagesBox.Size = new Size(300, 150);
            MessagesBox.TabIndex = 17;
            MessagesBox.TabStop = false;
            MessagesBox.Text = "MessagesBox";
            MessagesBox.Visible = false;
            // 
            // buttonOkay
            // 
            buttonOkay.Location = new Point(94, 97);
            buttonOkay.Name = "buttonOkay";
            buttonOkay.Size = new Size(112, 34);
            buttonOkay.TabIndex = 1;
            buttonOkay.Text = "OK";
            buttonOkay.UseVisualStyleBackColor = true;
            buttonOkay.Click += OkayClick;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(33, 59);
            labelError.Name = "labelError";
            labelError.Size = new Size(59, 25);
            labelError.TabIndex = 0;
            labelError.Text = "label2";
            // 
            // buttonShowAllAppts
            // 
            buttonShowAllAppts.BackColor = Color.LimeGreen;
            buttonShowAllAppts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShowAllAppts.Location = new Point(885, 356);
            buttonShowAllAppts.Margin = new Padding(4);
            buttonShowAllAppts.Name = "buttonShowAllAppts";
            buttonShowAllAppts.Size = new Size(171, 72);
            buttonShowAllAppts.TabIndex = 14;
            buttonShowAllAppts.Text = "Appointments";
            buttonShowAllAppts.UseVisualStyleBackColor = false;
            buttonShowAllAppts.Click += AppointmentsClick;
            // 
            // buttonClearAllAppts
            // 
            buttonClearAllAppts.BackColor = Color.LimeGreen;
            buttonClearAllAppts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClearAllAppts.Location = new Point(1081, 356);
            buttonClearAllAppts.Margin = new Padding(4);
            buttonClearAllAppts.Name = "buttonClearAllAppts";
            buttonClearAllAppts.Size = new Size(118, 72);
            buttonClearAllAppts.TabIndex = 15;
            buttonClearAllAppts.Text = "Drivers";
            buttonClearAllAppts.UseVisualStyleBackColor = false;
            buttonClearAllAppts.Click += DriversClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(501, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 30);
            label1.TabIndex = 16;
            label1.Text = "Pick a test Date";
            // 
            // labelRegexPost
            // 
            labelRegexPost.AutoSize = true;
            labelRegexPost.Location = new Point(570, 466);
            labelRegexPost.Name = "labelRegexPost";
            labelRegexPost.Size = new Size(0, 25);
            labelRegexPost.TabIndex = 18;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 518);
            Controls.Add(labelRegexPost);
            Controls.Add(MessagesBox);
            Controls.Add(label1);
            Controls.Add(buttonClearAllAppts);
            Controls.Add(buttonShowAllAppts);
            Controls.Add(groupBoxAppointments);
            Controls.Add(monthCalendarTest);
            Controls.Add(buttonEnterData);
            Controls.Add(groupBox1DriverInfo);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "OwenWilliams8932027";
            Load += FormMainLoad;
            groupBox1DriverInfo.ResumeLayout(false);
            groupBox1DriverInfo.PerformLayout();
            groupBoxAppointments.ResumeLayout(false);
            MessagesBox.ResumeLayout(false);
            MessagesBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxDriverLic;
        private DateTimePicker dateTimePickerDOB;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelDrivLic;
        private Label labelDOB;
        private GroupBox groupBox1DriverInfo;
        private Button buttonEnterData;
        private MonthCalendar monthCalendarTest;
        private Label labelDrivClass;
        private TextBox textBoxDrivClass;
        private GroupBox groupBoxAppointments;
        private ListBox listBoxAppointments;
        private Button buttonShowAllAppts;
        private Button buttonClearAllAppts;
        private Label label1;
        private GroupBox MessagesBox;
        private Button buttonOkay;
        private Label labelError;
        private Label labelRegexPost;
    }
}
