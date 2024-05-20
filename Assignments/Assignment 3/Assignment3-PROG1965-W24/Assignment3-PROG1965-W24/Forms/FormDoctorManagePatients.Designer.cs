namespace Assignment3_PROG1965_W24.Forms
{
    partial class FormDoctorManagePatients
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
            groupBoxMyPatients = new GroupBox();
            labelStatus = new Label();
            labelNotes = new Label();
            labelReports = new Label();
            ListBoxMyPatientNotes = new ListBox();
            ListBoxMyPatientReports = new ListBox();
            ListBoxMyPatients = new ListBox();
            richTextBoxNote = new RichTextBox();
            richTextBoxReport = new RichTextBox();
            groupBox1 = new GroupBox();
            buttonSave = new Button();
            buttonNewNote = new Button();
            groupBoxMyPatients.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMyPatients
            // 
            groupBoxMyPatients.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxMyPatients.Controls.Add(labelStatus);
            groupBoxMyPatients.Controls.Add(labelNotes);
            groupBoxMyPatients.Controls.Add(labelReports);
            groupBoxMyPatients.Controls.Add(ListBoxMyPatientNotes);
            groupBoxMyPatients.Controls.Add(ListBoxMyPatientReports);
            groupBoxMyPatients.Controls.Add(ListBoxMyPatients);
            groupBoxMyPatients.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxMyPatients.Location = new Point(28, 30);
            groupBoxMyPatients.Margin = new Padding(4);
            groupBoxMyPatients.Name = "groupBoxMyPatients";
            groupBoxMyPatients.Padding = new Padding(4);
            groupBoxMyPatients.Size = new Size(312, 480);
            groupBoxMyPatients.TabIndex = 0;
            groupBoxMyPatients.TabStop = false;
            groupBoxMyPatients.Text = "My Patients";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(42, 402);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(127, 25);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Logged-in ID:";
            // 
            // labelNotes
            // 
            labelNotes.AutoSize = true;
            labelNotes.Location = new Point(40, 281);
            labelNotes.Margin = new Padding(4, 0, 4, 0);
            labelNotes.Name = "labelNotes";
            labelNotes.Size = new Size(62, 25);
            labelNotes.TabIndex = 4;
            labelNotes.Text = "Notes";
            // 
            // labelReports
            // 
            labelReports.AutoSize = true;
            labelReports.Location = new Point(37, 158);
            labelReports.Margin = new Padding(4, 0, 4, 0);
            labelReports.Name = "labelReports";
            labelReports.Size = new Size(79, 25);
            labelReports.TabIndex = 3;
            labelReports.Text = "Reports";
            // 
            // ListBoxMyPatientNotes
            // 
            ListBoxMyPatientNotes.FormattingEnabled = true;
            ListBoxMyPatientNotes.ItemHeight = 25;
            ListBoxMyPatientNotes.Location = new Point(21, 324);
            ListBoxMyPatientNotes.Margin = new Padding(4);
            ListBoxMyPatientNotes.Name = "ListBoxMyPatientNotes";
            ListBoxMyPatientNotes.Size = new Size(283, 54);
            ListBoxMyPatientNotes.TabIndex = 2;
            ListBoxMyPatientNotes.SelectedIndexChanged += LoadNote;
            // 
            // ListBoxMyPatientReports
            // 
            ListBoxMyPatientReports.FormattingEnabled = true;
            ListBoxMyPatientReports.ItemHeight = 25;
            ListBoxMyPatientReports.Location = new Point(21, 200);
            ListBoxMyPatientReports.Margin = new Padding(4);
            ListBoxMyPatientReports.Name = "ListBoxMyPatientReports";
            ListBoxMyPatientReports.Size = new Size(283, 54);
            ListBoxMyPatientReports.TabIndex = 1;
            ListBoxMyPatientReports.SelectedIndexChanged += LoadReport;
            // 
            // ListBoxMyPatients
            // 
            ListBoxMyPatients.FormattingEnabled = true;
            ListBoxMyPatients.ItemHeight = 25;
            ListBoxMyPatients.Location = new Point(21, 60);
            ListBoxMyPatients.Margin = new Padding(4);
            ListBoxMyPatients.Name = "ListBoxMyPatients";
            ListBoxMyPatients.Size = new Size(283, 54);
            ListBoxMyPatients.TabIndex = 0;
            ListBoxMyPatients.SelectedIndexChanged += HealthCardSelected;
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.Location = new Point(369, 31);
            richTextBoxNote.Margin = new Padding(4);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(543, 754);
            richTextBoxNote.TabIndex = 1;
            richTextBoxNote.Text = "";
            // 
            // richTextBoxReport
            // 
            richTextBoxReport.Location = new Point(942, 31);
            richTextBoxReport.Margin = new Padding(4);
            richTextBoxReport.Name = "richTextBoxReport";
            richTextBoxReport.Size = new Size(543, 754);
            richTextBoxReport.TabIndex = 2;
            richTextBoxReport.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(buttonNewNote);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 540);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(312, 246);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Note";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(55, 141);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(202, 70);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += SaveNote;
            // 
            // buttonNewNote
            // 
            buttonNewNote.Location = new Point(55, 32);
            buttonNewNote.Margin = new Padding(4);
            buttonNewNote.Name = "buttonNewNote";
            buttonNewNote.Size = new Size(202, 74);
            buttonNewNote.TabIndex = 0;
            buttonNewNote.Text = "New Note";
            buttonNewNote.UseVisualStyleBackColor = true;
            buttonNewNote.Click += NewNote;
            // 
            // FormDoctorManagePatients
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1511, 811);
            Controls.Add(groupBox1);
            Controls.Add(richTextBoxReport);
            Controls.Add(richTextBoxNote);
            Controls.Add(groupBoxMyPatients);
            Margin = new Padding(4);
            Name = "FormDoctorManagePatients";
            Text = "Manage Patients";
            Load += FormDoctorManagePatients_Load;
            groupBoxMyPatients.ResumeLayout(false);
            groupBoxMyPatients.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMyPatients;
        private ListBox ListBoxMyPatientReports;
        private ListBox ListBoxMyPatients;
        private ListBox ListBoxMyPatientNotes;
        private Label labelStatus;
        private Label labelNotes;
        private Label labelReports;
        private RichTextBox richTextBoxNote;
        private RichTextBox richTextBoxReport;
        private GroupBox groupBox1;
        private Button buttonSave;
        private Button buttonNewNote;
    }
}