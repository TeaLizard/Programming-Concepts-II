namespace Assignment3_PROG1965_W24.Forms
{
    partial class FormManageDocuments
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
            richTextBoxLoadFile = new RichTextBox();
            buttonLoadReport = new Button();
            buttonSaveReport = new Button();
            richTextBoxNote = new RichTextBox();
            groupBoxNewReports = new GroupBox();
            buttonAnalytics = new Button();
            labelLoggedInID = new Label();
            groupBoxReportNote = new GroupBox();
            buttonEditNote = new Button();
            buttonSaveNote = new Button();
            labelNewRe0ort = new Label();
            PanelReport = new Panel();
            ButtonClosePanel = new Button();
            ListBoxFile = new ListBox();
            ListBoxFolder = new ListBox();
            label1 = new Label();
            SpecialFont = new Label();
            groupBoxNewReports.SuspendLayout();
            groupBoxReportNote.SuspendLayout();
            PanelReport.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBoxLoadFile
            // 
            richTextBoxLoadFile.Anchor = AnchorStyles.None;
            richTextBoxLoadFile.Location = new Point(460, 88);
            richTextBoxLoadFile.Margin = new Padding(0);
            richTextBoxLoadFile.Name = "richTextBoxLoadFile";
            richTextBoxLoadFile.Size = new Size(599, 732);
            richTextBoxLoadFile.TabIndex = 0;
            richTextBoxLoadFile.Text = "";
            // 
            // buttonLoadReport
            // 
            buttonLoadReport.Location = new Point(56, 82);
            buttonLoadReport.Margin = new Padding(4);
            buttonLoadReport.Name = "buttonLoadReport";
            buttonLoadReport.Size = new Size(289, 56);
            buttonLoadReport.TabIndex = 1;
            buttonLoadReport.Text = "Load Report";
            buttonLoadReport.UseVisualStyleBackColor = true;
            buttonLoadReport.Click += LoadReport;
            // 
            // buttonSaveReport
            // 
            buttonSaveReport.Location = new Point(56, 146);
            buttonSaveReport.Margin = new Padding(4);
            buttonSaveReport.Name = "buttonSaveReport";
            buttonSaveReport.Size = new Size(289, 51);
            buttonSaveReport.TabIndex = 2;
            buttonSaveReport.Text = "Save Report";
            buttonSaveReport.UseVisualStyleBackColor = true;
            buttonSaveReport.Click += SaveReport;
            // 
            // richTextBoxNote
            // 
            richTextBoxNote.Location = new Point(16, 59);
            richTextBoxNote.Margin = new Padding(4);
            richTextBoxNote.Name = "richTextBoxNote";
            richTextBoxNote.Size = new Size(369, 383);
            richTextBoxNote.TabIndex = 5;
            richTextBoxNote.Text = "";
            // 
            // groupBoxNewReports
            // 
            groupBoxNewReports.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxNewReports.Controls.Add(buttonAnalytics);
            groupBoxNewReports.Controls.Add(labelLoggedInID);
            groupBoxNewReports.Controls.Add(buttonLoadReport);
            groupBoxNewReports.Controls.Add(buttonSaveReport);
            groupBoxNewReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxNewReports.Location = new Point(31, 30);
            groupBoxNewReports.Margin = new Padding(4);
            groupBoxNewReports.Name = "groupBoxNewReports";
            groupBoxNewReports.Padding = new Padding(4);
            groupBoxNewReports.Size = new Size(394, 270);
            groupBoxNewReports.TabIndex = 6;
            groupBoxNewReports.TabStop = false;
            groupBoxNewReports.Text = "Check New Reports";
            // 
            // buttonAnalytics
            // 
            buttonAnalytics.Location = new Point(56, 211);
            buttonAnalytics.Margin = new Padding(4);
            buttonAnalytics.Name = "buttonAnalytics";
            buttonAnalytics.Size = new Size(289, 51);
            buttonAnalytics.TabIndex = 4;
            buttonAnalytics.Text = "Analytics";
            buttonAnalytics.UseVisualStyleBackColor = true;
            buttonAnalytics.Click += ShowAnalytics;
            // 
            // labelLoggedInID
            // 
            labelLoggedInID.AutoSize = true;
            labelLoggedInID.Location = new Point(16, 41);
            labelLoggedInID.Margin = new Padding(4, 0, 4, 0);
            labelLoggedInID.Name = "labelLoggedInID";
            labelLoggedInID.Size = new Size(169, 25);
            labelLoggedInID.TabIndex = 3;
            labelLoggedInID.Text = "Logged-in with ID:";
            // 
            // groupBoxReportNote
            // 
            groupBoxReportNote.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxReportNote.Controls.Add(buttonEditNote);
            groupBoxReportNote.Controls.Add(buttonSaveNote);
            groupBoxReportNote.Controls.Add(richTextBoxNote);
            groupBoxReportNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxReportNote.Location = new Point(31, 308);
            groupBoxReportNote.Margin = new Padding(4);
            groupBoxReportNote.Name = "groupBoxReportNote";
            groupBoxReportNote.Padding = new Padding(4);
            groupBoxReportNote.Size = new Size(394, 512);
            groupBoxReportNote.TabIndex = 7;
            groupBoxReportNote.TabStop = false;
            groupBoxReportNote.Text = "Test Report - NewNote";
            // 
            // buttonEditNote
            // 
            buttonEditNote.Location = new Point(218, 462);
            buttonEditNote.Margin = new Padding(4);
            buttonEditNote.Name = "buttonEditNote";
            buttonEditNote.Size = new Size(169, 36);
            buttonEditNote.TabIndex = 7;
            buttonEditNote.Text = "Edit Note";
            buttonEditNote.UseVisualStyleBackColor = true;
            buttonEditNote.Click += EditNote;
            // 
            // buttonSaveNote
            // 
            buttonSaveNote.Location = new Point(16, 462);
            buttonSaveNote.Margin = new Padding(4);
            buttonSaveNote.Name = "buttonSaveNote";
            buttonSaveNote.Size = new Size(169, 36);
            buttonSaveNote.TabIndex = 6;
            buttonSaveNote.Text = "Save Note";
            buttonSaveNote.UseVisualStyleBackColor = true;
            buttonSaveNote.Click += SaveNote;
            // 
            // labelNewRe0ort
            // 
            labelNewRe0ort.AutoSize = true;
            labelNewRe0ort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNewRe0ort.Location = new Point(466, 30);
            labelNewRe0ort.Margin = new Padding(4, 0, 4, 0);
            labelNewRe0ort.Name = "labelNewRe0ort";
            labelNewRe0ort.Size = new Size(114, 25);
            labelNewRe0ort.TabIndex = 8;
            labelNewRe0ort.Text = "New Report";
            // 
            // PanelReport
            // 
            PanelReport.Controls.Add(ButtonClosePanel);
            PanelReport.Controls.Add(ListBoxFile);
            PanelReport.Controls.Add(ListBoxFolder);
            PanelReport.Controls.Add(label1);
            PanelReport.Location = new Point(12, 12);
            PanelReport.Name = "PanelReport";
            PanelReport.Size = new Size(1149, 511);
            PanelReport.TabIndex = 9;
            PanelReport.Visible = false;
            // 
            // ButtonClosePanel
            // 
            ButtonClosePanel.Location = new Point(495, 438);
            ButtonClosePanel.Name = "ButtonClosePanel";
            ButtonClosePanel.Size = new Size(112, 34);
            ButtonClosePanel.TabIndex = 3;
            ButtonClosePanel.Text = "Okay";
            ButtonClosePanel.UseVisualStyleBackColor = true;
            ButtonClosePanel.Click += ClosePanel;
            // 
            // ListBoxFile
            // 
            ListBoxFile.FormattingEnabled = true;
            ListBoxFile.ItemHeight = 25;
            ListBoxFile.Location = new Point(65, 237);
            ListBoxFile.Name = "ListBoxFile";
            ListBoxFile.Size = new Size(1023, 154);
            ListBoxFile.TabIndex = 2;
            // 
            // ListBoxFolder
            // 
            ListBoxFolder.FormattingEnabled = true;
            ListBoxFolder.ItemHeight = 25;
            ListBoxFolder.Location = new Point(65, 93);
            ListBoxFolder.Name = "ListBoxFolder";
            ListBoxFolder.Size = new Size(1023, 129);
            ListBoxFolder.TabIndex = 1;
            ListBoxFolder.SelectedIndexChanged += UpdateListBoxFiles;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Select Report";
            // 
            // SpecialFont
            // 
            SpecialFont.AutoSize = true;
            SpecialFont.Font = new Font("Courier New", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SpecialFont.Location = new Point(1082, 573);
            SpecialFont.Name = "SpecialFont";
            SpecialFont.Size = new Size(0, 22);
            SpecialFont.TabIndex = 10;
            // 
            // FormManageDocuments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 908);
            Controls.Add(SpecialFont);
            Controls.Add(PanelReport);
            Controls.Add(labelNewRe0ort);
            Controls.Add(groupBoxReportNote);
            Controls.Add(groupBoxNewReports);
            Controls.Add(richTextBoxLoadFile);
            Margin = new Padding(4);
            Name = "FormManageDocuments";
            Text = "Patients and Documents Management";
            Load += FormManageDocuments_Load;
            groupBoxNewReports.ResumeLayout(false);
            groupBoxNewReports.PerformLayout();
            groupBoxReportNote.ResumeLayout(false);
            PanelReport.ResumeLayout(false);
            PanelReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBoxLoadFile;
        private Button buttonLoadReport;
        private Button buttonSaveReport;
        private RichTextBox richTextBoxNote;
        private GroupBox groupBoxNewReports;
        private Label labelLoggedInID;
        private GroupBox groupBoxReportNote;
        private Button buttonSaveNote;
        private Button buttonEditNote;
        private Label labelNewRe0ort;
        private Button buttonAnalytics;
        private Panel PanelReport;
        private Label label1;
        private Button ButtonClosePanel;
        private ListBox ListBoxFile;
        private ListBox ListBoxFolder;
        private Label SpecialFont;
    }
}