namespace InClass_4_PROG1965_W24_Sec_6
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
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            labelName = new Label();
            labelPhone = new Label();
            labelService = new Label();
            labelBranch = new Label();
            buttonNewAppt = new Button();
            listBoxBranch = new ListBox();
            dataGridViewAppts = new DataGridView();
            groupBoxAppt = new GroupBox();
            labelApptDate = new Label();
            dateTimePickerAppt = new DateTimePicker();
            buttonCancelAppt = new Button();
            buttonUpdateAppt = new Button();
            listBoxService = new ListBox();
            groupBoxAppts = new GroupBox();
            groupBoxSearch = new GroupBox();
            labelServiceSearch = new Label();
            labelBranchSearch = new Label();
            buttonSearchAppts = new Button();
            listBoxSearchService = new ListBox();
            listBoxSearchBranch = new ListBox();
            groupBoxSearchResults = new GroupBox();
            dataGridViewSearchResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppts).BeginInit();
            groupBoxAppt.SuspendLayout();
            groupBoxAppts.SuspendLayout();
            groupBoxSearch.SuspendLayout();
            groupBoxSearchResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResults).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(123, 26);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(177, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(123, 70);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(177, 27);
            textBoxPhone.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(116, 20);
            labelName.TabIndex = 2;
            labelName.Text = "Customer Name";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(7, 77);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(108, 20);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone Number";
            // 
            // labelService
            // 
            labelService.AutoSize = true;
            labelService.Location = new Point(9, 197);
            labelService.Name = "labelService";
            labelService.Size = new Size(56, 20);
            labelService.TabIndex = 5;
            labelService.Text = "Service";
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new Point(9, 158);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new Size(54, 20);
            labelBranch.TabIndex = 6;
            labelBranch.Text = "Branch";
            // 
            // buttonNewAppt
            // 
            buttonNewAppt.Location = new Point(9, 234);
            buttonNewAppt.Name = "buttonNewAppt";
            buttonNewAppt.Size = new Size(71, 29);
            buttonNewAppt.TabIndex = 8;
            buttonNewAppt.Text = "Book";
            buttonNewAppt.UseVisualStyleBackColor = true;
            buttonNewAppt.Click += buttonNewAppt_Click;
            // 
            // listBoxBranch
            // 
            listBoxBranch.FormattingEnabled = true;
            listBoxBranch.Location = new Point(123, 154);
            listBoxBranch.Name = "listBoxBranch";
            listBoxBranch.Size = new Size(177, 24);
            listBoxBranch.TabIndex = 10;
            listBoxBranch.SelectedIndexChanged += loadServices;
            // 
            // dataGridViewAppts
            // 
            dataGridViewAppts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppts.Location = new Point(17, 26);
            dataGridViewAppts.MultiSelect = false;
            dataGridViewAppts.Name = "dataGridViewAppts";
            dataGridViewAppts.RowHeadersWidth = 51;
            dataGridViewAppts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAppts.Size = new Size(701, 237);
            dataGridViewAppts.TabIndex = 16;
            dataGridViewAppts.DoubleClick += DataGridViewAppts_Double_Click;
            // 
            // groupBoxAppt
            // 
            groupBoxAppt.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxAppt.Controls.Add(labelApptDate);
            groupBoxAppt.Controls.Add(dateTimePickerAppt);
            groupBoxAppt.Controls.Add(buttonCancelAppt);
            groupBoxAppt.Controls.Add(buttonUpdateAppt);
            groupBoxAppt.Controls.Add(listBoxService);
            groupBoxAppt.Controls.Add(textBoxName);
            groupBoxAppt.Controls.Add(textBoxPhone);
            groupBoxAppt.Controls.Add(listBoxBranch);
            groupBoxAppt.Controls.Add(labelName);
            groupBoxAppt.Controls.Add(labelPhone);
            groupBoxAppt.Controls.Add(buttonNewAppt);
            groupBoxAppt.Controls.Add(labelBranch);
            groupBoxAppt.Controls.Add(labelService);
            groupBoxAppt.Location = new Point(12, 12);
            groupBoxAppt.Name = "groupBoxAppt";
            groupBoxAppt.Size = new Size(322, 282);
            groupBoxAppt.TabIndex = 22;
            groupBoxAppt.TabStop = false;
            groupBoxAppt.Text = "Manage Appointments";
            // 
            // labelApptDate
            // 
            labelApptDate.AutoSize = true;
            labelApptDate.Location = new Point(9, 118);
            labelApptDate.Name = "labelApptDate";
            labelApptDate.Size = new Size(41, 20);
            labelApptDate.TabIndex = 16;
            labelApptDate.Text = "Date";
            // 
            // dateTimePickerAppt
            // 
            dateTimePickerAppt.Location = new Point(123, 111);
            dateTimePickerAppt.Name = "dateTimePickerAppt";
            dateTimePickerAppt.Size = new Size(177, 27);
            dateTimePickerAppt.TabIndex = 15;
            // 
            // buttonCancelAppt
            // 
            buttonCancelAppt.Location = new Point(229, 234);
            buttonCancelAppt.Name = "buttonCancelAppt";
            buttonCancelAppt.Size = new Size(71, 29);
            buttonCancelAppt.TabIndex = 14;
            buttonCancelAppt.Text = "Cancel";
            buttonCancelAppt.UseVisualStyleBackColor = true;
            buttonCancelAppt.Click += buttonCancelAppt_Click;
            // 
            // buttonUpdateAppt
            // 
            buttonUpdateAppt.Location = new Point(123, 234);
            buttonUpdateAppt.Name = "buttonUpdateAppt";
            buttonUpdateAppt.Size = new Size(71, 29);
            buttonUpdateAppt.TabIndex = 13;
            buttonUpdateAppt.Text = "Update";
            buttonUpdateAppt.UseVisualStyleBackColor = true;
            buttonUpdateAppt.Click += buttonUpdateAppt_Click;
            // 
            // listBoxService
            // 
            listBoxService.FormattingEnabled = true;
            listBoxService.Location = new Point(123, 193);
            listBoxService.Name = "listBoxService";
            listBoxService.Size = new Size(177, 24);
            listBoxService.TabIndex = 11;
            // 
            // groupBoxAppts
            // 
            groupBoxAppts.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxAppts.Controls.Add(dataGridViewAppts);
            groupBoxAppts.Location = new Point(340, 12);
            groupBoxAppts.Name = "groupBoxAppts";
            groupBoxAppts.Size = new Size(738, 282);
            groupBoxAppts.TabIndex = 26;
            groupBoxAppts.TabStop = false;
            groupBoxAppts.Text = "Booked Appointments";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxSearch.Controls.Add(labelServiceSearch);
            groupBoxSearch.Controls.Add(labelBranchSearch);
            groupBoxSearch.Controls.Add(buttonSearchAppts);
            groupBoxSearch.Controls.Add(listBoxSearchService);
            groupBoxSearch.Controls.Add(listBoxSearchBranch);
            groupBoxSearch.Location = new Point(12, 300);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(322, 161);
            groupBoxSearch.TabIndex = 24;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search Bookings";
            // 
            // labelServiceSearch
            // 
            labelServiceSearch.AutoSize = true;
            labelServiceSearch.Location = new Point(123, 35);
            labelServiceSearch.Name = "labelServiceSearch";
            labelServiceSearch.Size = new Size(76, 20);
            labelServiceSearch.TabIndex = 17;
            labelServiceSearch.Text = "By Service";
            // 
            // labelBranchSearch
            // 
            labelBranchSearch.AutoSize = true;
            labelBranchSearch.Location = new Point(6, 35);
            labelBranchSearch.Name = "labelBranchSearch";
            labelBranchSearch.Size = new Size(74, 20);
            labelBranchSearch.TabIndex = 17;
            labelBranchSearch.Text = "By Branch";
            // 
            // buttonSearchAppts
            // 
            buttonSearchAppts.Location = new Point(95, 107);
            buttonSearchAppts.Name = "buttonSearchAppts";
            buttonSearchAppts.Size = new Size(122, 29);
            buttonSearchAppts.TabIndex = 18;
            buttonSearchAppts.Text = "Search";
            buttonSearchAppts.UseVisualStyleBackColor = true;
            buttonSearchAppts.Click += buttonSearchAppts_Click;
            // 
            // listBoxSearchService
            // 
            listBoxSearchService.FormattingEnabled = true;
            listBoxSearchService.Location = new Point(123, 61);
            listBoxSearchService.Name = "listBoxSearchService";
            listBoxSearchService.Size = new Size(177, 24);
            listBoxSearchService.TabIndex = 17;
            // 
            // listBoxSearchBranch
            // 
            listBoxSearchBranch.FormattingEnabled = true;
            listBoxSearchBranch.Location = new Point(6, 61);
            listBoxSearchBranch.Name = "listBoxSearchBranch";
            listBoxSearchBranch.Size = new Size(94, 24);
            listBoxSearchBranch.TabIndex = 17;
            listBoxSearchBranch.SelectedIndexChanged += loadServices;
            // 
            // groupBoxSearchResults
            // 
            groupBoxSearchResults.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxSearchResults.Controls.Add(dataGridViewSearchResults);
            groupBoxSearchResults.Location = new Point(340, 300);
            groupBoxSearchResults.Name = "groupBoxSearchResults";
            groupBoxSearchResults.Size = new Size(738, 161);
            groupBoxSearchResults.TabIndex = 27;
            groupBoxSearchResults.TabStop = false;
            groupBoxSearchResults.Text = "Search Results";
            // 
            // dataGridViewSearchResults
            // 
            dataGridViewSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResults.Location = new Point(17, 26);
            dataGridViewSearchResults.MultiSelect = false;
            dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            dataGridViewSearchResults.RowHeadersWidth = 51;
            dataGridViewSearchResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSearchResults.Size = new Size(701, 115);
            dataGridViewSearchResults.TabIndex = 16;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 465);
            Controls.Add(groupBoxSearchResults);
            Controls.Add(groupBoxSearch);
            Controls.Add(groupBoxAppts);
            Controls.Add(groupBoxAppt);
            Name = "FormMain";
            Text = "Lightening Car Services";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppts).EndInit();
            groupBoxAppt.ResumeLayout(false);
            groupBoxAppt.PerformLayout();
            groupBoxAppts.ResumeLayout(false);
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            groupBoxSearchResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private Label labelName;
        private Label labelPhone;
        private Label labelService;
        private Label labelBranch;
        private Button buttonNewAppt;
        private ListBox listBoxBranch;
        private ListView listView1;
        private DataGridView dataGridViewAppts;
        private GroupBox groupBoxAppt;
        private ListBox listBoxService;
        private Button buttonCancelAppt;
        private Button buttonUpdateAppt;
        private Label labelApptDate;
        private DateTimePicker dateTimePickerAppt;
        private GroupBox groupBoxAppts;
        private GroupBox groupBoxSearch;
        private Button buttonSearchAppts;
        private ListBox listBoxSearchService;
        private ListBox listBoxSearchBranch;
        private Label labelServiceSearch;
        private Label labelBranchSearch;
        private GroupBox groupBoxSearchResults;
        private DataGridView dataGridViewSearchResults;
    }
}
