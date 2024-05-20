using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Midterm_PROG1965_W24_Sec6
{
    partial class FormPersons
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
            labelFirstName = new Label();
            labelLastName = new Label();
            labelSIN = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxSIN = new TextBox();
            listBoxPersons = new ListBox();
            button1 = new Button();
            labelTitle = new Label();
            dateTimePickerDOB = new DateTimePicker();
            buttonShowAll = new Button();
            buttonClearAll = new Button();
            groupBoxRegisterNewUser = new GroupBox();
            labelDOB = new Label();
            groupBoxAlert = new GroupBox();
            buttonCloseBox = new Button();
            labelMessages = new Label();
            groupBox1 = new GroupBox();
            buttonHideAll = new Button();
            groupBox2 = new GroupBox();
            labelAnswersQ2 = new Label();
            groupBox3 = new GroupBox();
            labelAnswersQ3 = new Label();
            groupBoxRegisterNewUser.SuspendLayout();
            groupBoxAlert.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(32, 58);
            labelFirstName.Margin = new Padding(4, 0, 4, 0);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(97, 25);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(34, 122);
            labelLastName.Margin = new Padding(4, 0, 4, 0);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(95, 25);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelSIN
            // 
            labelSIN.AutoSize = true;
            labelSIN.Location = new Point(32, 184);
            labelSIN.Margin = new Padding(4, 0, 4, 0);
            labelSIN.Name = "labelSIN";
            labelSIN.Size = new Size(40, 25);
            labelSIN.TabIndex = 2;
            labelSIN.Text = "SIN";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(184, 49);
            textBoxFirstName.Margin = new Padding(4);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(310, 31);
            textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(184, 111);
            textBoxLastName.Margin = new Padding(4);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(310, 31);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxSIN
            // 
            textBoxSIN.Location = new Point(184, 172);
            textBoxSIN.Margin = new Padding(4);
            textBoxSIN.Name = "textBoxSIN";
            textBoxSIN.Size = new Size(310, 31);
            textBoxSIN.TabIndex = 5;
            // 
            // listBoxPersons
            // 
            listBoxPersons.FormattingEnabled = true;
            listBoxPersons.ItemHeight = 25;
            listBoxPersons.Location = new Point(20, 32);
            listBoxPersons.Margin = new Padding(4);
            listBoxPersons.Name = "listBoxPersons";
            listBoxPersons.Size = new Size(186, 304);
            listBoxPersons.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(184, 296);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(311, 36);
            button1.TabIndex = 8;
            button1.Text = "Register New User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += RegisterUser;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = SystemColors.MenuHighlight;
            labelTitle.Location = new Point(326, 32);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(256, 32);
            labelTitle.TabIndex = 9;
            labelTitle.Text = "User Registration Form";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Location = new Point(182, 232);
            dateTimePickerDOB.Margin = new Padding(4);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.ShowUpDown = true;
            dateTimePickerDOB.Size = new Size(312, 31);
            dateTimePickerDOB.TabIndex = 10;
            // 
            // buttonShowAll
            // 
            buttonShowAll.Location = new Point(250, 108);
            buttonShowAll.Margin = new Padding(4);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(118, 36);
            buttonShowAll.TabIndex = 11;
            buttonShowAll.Text = "Show All";
            buttonShowAll.UseVisualStyleBackColor = true;
            buttonShowAll.Click += ShowAll;
            // 
            // buttonClearAll
            // 
            buttonClearAll.ForeColor = Color.Red;
            buttonClearAll.Location = new Point(250, 301);
            buttonClearAll.Margin = new Padding(4);
            buttonClearAll.Name = "buttonClearAll";
            buttonClearAll.Size = new Size(118, 36);
            buttonClearAll.TabIndex = 12;
            buttonClearAll.Text = "Clear All";
            buttonClearAll.UseVisualStyleBackColor = true;
            buttonClearAll.Click += ClearAll;
            // 
            // groupBoxRegisterNewUser
            // 
            groupBoxRegisterNewUser.Controls.Add(labelDOB);
            groupBoxRegisterNewUser.Controls.Add(textBoxFirstName);
            groupBoxRegisterNewUser.Controls.Add(labelFirstName);
            groupBoxRegisterNewUser.Controls.Add(textBoxLastName);
            groupBoxRegisterNewUser.Controls.Add(dateTimePickerDOB);
            groupBoxRegisterNewUser.Controls.Add(button1);
            groupBoxRegisterNewUser.Controls.Add(labelLastName);
            groupBoxRegisterNewUser.Controls.Add(textBoxSIN);
            groupBoxRegisterNewUser.Controls.Add(labelSIN);
            groupBoxRegisterNewUser.Location = new Point(55, 101);
            groupBoxRegisterNewUser.Margin = new Padding(4);
            groupBoxRegisterNewUser.Name = "groupBoxRegisterNewUser";
            groupBoxRegisterNewUser.Padding = new Padding(4);
            groupBoxRegisterNewUser.Size = new Size(528, 360);
            groupBoxRegisterNewUser.TabIndex = 13;
            groupBoxRegisterNewUser.TabStop = false;
            groupBoxRegisterNewUser.Text = "New User Information";
            // 
            // labelDOB
            // 
            labelDOB.AutoSize = true;
            labelDOB.Location = new Point(32, 243);
            labelDOB.Margin = new Padding(4, 0, 4, 0);
            labelDOB.Name = "labelDOB";
            labelDOB.Size = new Size(112, 25);
            labelDOB.TabIndex = 11;
            labelDOB.Text = "Date of Birth";
            // 
            // groupBoxAlert
            // 
            groupBoxAlert.Controls.Add(buttonCloseBox);
            groupBoxAlert.Controls.Add(labelMessages);
            groupBoxAlert.Location = new Point(12, 150);
            groupBoxAlert.Name = "groupBoxAlert";
            groupBoxAlert.Size = new Size(590, 150);
            groupBoxAlert.TabIndex = 18;
            groupBoxAlert.TabStop = false;
            groupBoxAlert.Text = "Alert";
            groupBoxAlert.Visible = false;
            // 
            // buttonCloseBox
            // 
            buttonCloseBox.Location = new Point(210, 100);
            buttonCloseBox.Name = "buttonCloseBox";
            buttonCloseBox.Size = new Size(112, 34);
            buttonCloseBox.TabIndex = 18;
            buttonCloseBox.Text = "Okay";
            buttonCloseBox.UseVisualStyleBackColor = true;
            buttonCloseBox.Click += CloseAlert;
            // 
            // labelMessages
            // 
            labelMessages.AutoSize = true;
            labelMessages.Font = new System.Drawing.Font("Segoe UI", 8F);
            labelMessages.Location = new Point(26, 47);
            labelMessages.Name = "labelMessages";
            labelMessages.Size = new Size(52, 21);
            labelMessages.TabIndex = 17;
            labelMessages.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonHideAll);
            groupBox1.Controls.Add(listBoxPersons);
            groupBox1.Controls.Add(buttonClearAll);
            groupBox1.Controls.Add(buttonShowAll);
            groupBox1.Location = new Point(589, 101);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(396, 360);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registered Users";
            // 
            // buttonHideAll
            // 
            buttonHideAll.Location = new Point(252, 64);
            buttonHideAll.Margin = new Padding(4);
            buttonHideAll.Name = "buttonHideAll";
            buttonHideAll.Size = new Size(118, 36);
            buttonHideAll.TabIndex = 13;
            buttonHideAll.Text = "Hide All";
            buttonHideAll.UseVisualStyleBackColor = true;
            buttonHideAll.Click += HideAll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelAnswersQ2);
            groupBox2.Location = new Point(55, 481);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(439, 104);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Answers: Question 2";
            // 
            // labelAnswersQ2
            // 
            labelAnswersQ2.AutoSize = true;
            labelAnswersQ2.Location = new Point(7, 49);
            labelAnswersQ2.Margin = new Padding(4, 0, 4, 0);
            labelAnswersQ2.Name = "labelAnswersQ2";
            labelAnswersQ2.Size = new Size(100, 25);
            labelAnswersQ2.TabIndex = 0;
            labelAnswersQ2.Text = "Answers: D";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelAnswersQ3);
            groupBox3.Location = new Point(528, 481);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(458, 104);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Answers: Question 3";
            // 
            // labelAnswersQ3
            // 
            labelAnswersQ3.AutoSize = true;
            labelAnswersQ3.Location = new Point(19, 49);
            labelAnswersQ3.Margin = new Padding(4, 0, 4, 0);
            labelAnswersQ3.Name = "labelAnswersQ3";
            labelAnswersQ3.Size = new Size(100, 25);
            labelAnswersQ3.TabIndex = 1;
            labelAnswersQ3.Text = "Answers: D";
            // 
            // FormPersons
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 606);
            Controls.Add(groupBoxAlert);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxRegisterNewUser);
            Controls.Add(labelTitle);
            Margin = new Padding(4);
            Name = "FormPersons";
            Text = "Owen Williams 8932017";
            Load += FormPersons_Load;
            groupBoxRegisterNewUser.ResumeLayout(false);
            groupBoxRegisterNewUser.PerformLayout();
            groupBoxAlert.ResumeLayout(false);
            groupBoxAlert.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelSIN;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxSIN;
        private ListBox listBoxPersons;
        private Button button1;
        private Label labelTitle;
        private DateTimePicker dateTimePickerDOB;
        private Button buttonShowAll;
        private Button buttonClearAll;
        private GroupBox groupBoxRegisterNewUser;
        private GroupBox groupBox1;
        private Button buttonHideAll;
        private Label labelDOB;
        private GroupBox groupBox2;
        private Label labelAnswersQ2;
        private GroupBox groupBox3;
        private Label labelAnswersQ3;
        private Label labelMessages;
        private GroupBox groupBoxAlert;
        private Button buttonCloseBox;
    }
}
