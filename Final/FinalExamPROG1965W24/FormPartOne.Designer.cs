namespace FinalExamPROG1965W24
{
    partial class FormPartOne
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
            groupBoxNewBook = new GroupBox();
            textBoxAuthor3 = new TextBox();
            textBoxAuthor2 = new TextBox();
            textBoxAuthor1 = new TextBox();
            buttonAddBook = new Button();
            textBoxDateOfPublication = new TextBox();
            textBoxPublisher = new TextBox();
            textBoxISBN = new TextBox();
            textBoxTitle = new TextBox();
            labelAuthors = new Label();
            labelDate = new Label();
            labelPublisher = new Label();
            labelISBN = new Label();
            labelTitle = new Label();
            buttonAddBooksFromFile = new Button();
            groupBoxBooksFromFile = new GroupBox();
            labellabelNumberOfBooksRejected = new Label();
            labelNumberOfBooksRecorded = new Label();
            groupBoxShowRecords = new GroupBox();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            labelBooksResults = new Label();
            buttonAllBooks = new Button();
            groupBoxSearchResults = new GroupBox();
            richTextBoxResults = new RichTextBox();
            groupBoxNewBook.SuspendLayout();
            groupBoxBooksFromFile.SuspendLayout();
            groupBoxShowRecords.SuspendLayout();
            groupBoxSearchResults.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxNewBook
            // 
            groupBoxNewBook.BackColor = SystemColors.GradientInactiveCaption;
            groupBoxNewBook.Controls.Add(textBoxAuthor3);
            groupBoxNewBook.Controls.Add(textBoxAuthor2);
            groupBoxNewBook.Controls.Add(textBoxAuthor1);
            groupBoxNewBook.Controls.Add(buttonAddBook);
            groupBoxNewBook.Controls.Add(textBoxDateOfPublication);
            groupBoxNewBook.Controls.Add(textBoxPublisher);
            groupBoxNewBook.Controls.Add(textBoxISBN);
            groupBoxNewBook.Controls.Add(textBoxTitle);
            groupBoxNewBook.Controls.Add(labelAuthors);
            groupBoxNewBook.Controls.Add(labelDate);
            groupBoxNewBook.Controls.Add(labelPublisher);
            groupBoxNewBook.Controls.Add(labelISBN);
            groupBoxNewBook.Controls.Add(labelTitle);
            groupBoxNewBook.Location = new Point(35, 34);
            groupBoxNewBook.Margin = new Padding(4);
            groupBoxNewBook.Name = "groupBoxNewBook";
            groupBoxNewBook.Padding = new Padding(4);
            groupBoxNewBook.Size = new Size(574, 514);
            groupBoxNewBook.TabIndex = 0;
            groupBoxNewBook.TabStop = false;
            groupBoxNewBook.Text = "Add New Book";
            // 
            // textBoxAuthor3
            // 
            textBoxAuthor3.Location = new Point(128, 352);
            textBoxAuthor3.Margin = new Padding(4);
            textBoxAuthor3.Name = "textBoxAuthor3";
            textBoxAuthor3.Size = new Size(403, 31);
            textBoxAuthor3.TabIndex = 13;
            // 
            // textBoxAuthor2
            // 
            textBoxAuthor2.Location = new Point(128, 311);
            textBoxAuthor2.Margin = new Padding(4);
            textBoxAuthor2.Name = "textBoxAuthor2";
            textBoxAuthor2.Size = new Size(403, 31);
            textBoxAuthor2.TabIndex = 12;
            // 
            // textBoxAuthor1
            // 
            textBoxAuthor1.Location = new Point(128, 270);
            textBoxAuthor1.Margin = new Padding(4);
            textBoxAuthor1.Name = "textBoxAuthor1";
            textBoxAuthor1.Size = new Size(403, 31);
            textBoxAuthor1.TabIndex = 11;
            // 
            // buttonAddBook
            // 
            buttonAddBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddBook.Location = new Point(128, 421);
            buttonAddBook.Margin = new Padding(4);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(404, 61);
            buttonAddBook.TabIndex = 10;
            buttonAddBook.Text = "Add New Book";
            buttonAddBook.UseVisualStyleBackColor = true;
            buttonAddBook.Click += AddBook;
            // 
            // textBoxDateOfPublication
            // 
            textBoxDateOfPublication.Location = new Point(311, 202);
            textBoxDateOfPublication.Margin = new Padding(4);
            textBoxDateOfPublication.Name = "textBoxDateOfPublication";
            textBoxDateOfPublication.Size = new Size(219, 31);
            textBoxDateOfPublication.TabIndex = 8;
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(116, 149);
            textBoxPublisher.Margin = new Padding(4);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(414, 31);
            textBoxPublisher.TabIndex = 7;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(90, 95);
            textBoxISBN.Margin = new Padding(4);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(440, 31);
            textBoxISBN.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(90, 45);
            textBoxTitle.Margin = new Padding(4);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(440, 31);
            textBoxTitle.TabIndex = 5;
            // 
            // labelAuthors
            // 
            labelAuthors.AutoSize = true;
            labelAuthors.Location = new Point(24, 315);
            labelAuthors.Margin = new Padding(4, 0, 4, 0);
            labelAuthors.Name = "labelAuthors";
            labelAuthors.Size = new Size(85, 25);
            labelAuthors.TabIndex = 4;
            labelAuthors.Text = "Author(s)";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(22, 209);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(268, 25);
            labelDate.TabIndex = 3;
            labelDate.Text = "Publication Date (DD-MM-YYYY)";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(22, 154);
            labelPublisher.Margin = new Padding(4, 0, 4, 0);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(84, 25);
            labelPublisher.TabIndex = 2;
            labelPublisher.Text = "Publisher";
            // 
            // labelISBN
            // 
            labelISBN.AutoSize = true;
            labelISBN.Location = new Point(22, 100);
            labelISBN.Margin = new Padding(4, 0, 4, 0);
            labelISBN.Name = "labelISBN";
            labelISBN.Size = new Size(50, 25);
            labelISBN.TabIndex = 1;
            labelISBN.Text = "ISBN";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(22, 49);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(44, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Title";
            // 
            // buttonAddBooksFromFile
            // 
            buttonAddBooksFromFile.BackColor = SystemColors.GrayText;
            buttonAddBooksFromFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddBooksFromFile.ForeColor = SystemColors.Control;
            buttonAddBooksFromFile.Location = new Point(122, 32);
            buttonAddBooksFromFile.Margin = new Padding(4);
            buttonAddBooksFromFile.Name = "buttonAddBooksFromFile";
            buttonAddBooksFromFile.Size = new Size(404, 58);
            buttonAddBooksFromFile.TabIndex = 1;
            buttonAddBooksFromFile.Text = "Add Books";
            buttonAddBooksFromFile.UseVisualStyleBackColor = false;
            buttonAddBooksFromFile.Click += AddBooksFromFile;
            // 
            // groupBoxBooksFromFile
            // 
            groupBoxBooksFromFile.BackColor = SystemColors.ActiveCaption;
            groupBoxBooksFromFile.Controls.Add(labellabelNumberOfBooksRejected);
            groupBoxBooksFromFile.Controls.Add(labelNumberOfBooksRecorded);
            groupBoxBooksFromFile.Controls.Add(buttonAddBooksFromFile);
            groupBoxBooksFromFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxBooksFromFile.Location = new Point(40, 564);
            groupBoxBooksFromFile.Margin = new Padding(4);
            groupBoxBooksFromFile.Name = "groupBoxBooksFromFile";
            groupBoxBooksFromFile.Padding = new Padding(4);
            groupBoxBooksFromFile.Size = new Size(569, 156);
            groupBoxBooksFromFile.TabIndex = 2;
            groupBoxBooksFromFile.TabStop = false;
            groupBoxBooksFromFile.Text = "Read Records From Input File";
            // 
            // labellabelNumberOfBooksRejected
            // 
            labellabelNumberOfBooksRejected.AutoSize = true;
            labellabelNumberOfBooksRejected.Location = new Point(279, 114);
            labellabelNumberOfBooksRejected.Margin = new Padding(4, 0, 4, 0);
            labellabelNumberOfBooksRejected.Name = "labellabelNumberOfBooksRejected";
            labellabelNumberOfBooksRejected.Size = new Size(187, 25);
            labellabelNumberOfBooksRejected.TabIndex = 3;
            labellabelNumberOfBooksRejected.Text = "Records rejected = 0";
            // 
            // labelNumberOfBooksRecorded
            // 
            labelNumberOfBooksRecorded.AutoSize = true;
            labelNumberOfBooksRecorded.Location = new Point(19, 114);
            labelNumberOfBooksRecorded.Margin = new Padding(4, 0, 4, 0);
            labelNumberOfBooksRecorded.Name = "labelNumberOfBooksRecorded";
            labelNumberOfBooksRecorded.Size = new Size(178, 25);
            labelNumberOfBooksRecorded.TabIndex = 2;
            labelNumberOfBooksRecorded.Text = "Books recorded = 0";
            // 
            // groupBoxShowRecords
            // 
            groupBoxShowRecords.BackColor = SystemColors.ActiveCaption;
            groupBoxShowRecords.Controls.Add(buttonSearch);
            groupBoxShowRecords.Controls.Add(textBoxSearch);
            groupBoxShowRecords.Controls.Add(labelSearch);
            groupBoxShowRecords.Controls.Add(labelBooksResults);
            groupBoxShowRecords.Controls.Add(buttonAllBooks);
            groupBoxShowRecords.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxShowRecords.Location = new Point(630, 34);
            groupBoxShowRecords.Margin = new Padding(4);
            groupBoxShowRecords.Name = "groupBoxShowRecords";
            groupBoxShowRecords.Padding = new Padding(4);
            groupBoxShowRecords.Size = new Size(889, 156);
            groupBoxShowRecords.TabIndex = 4;
            groupBoxShowRecords.TabStop = false;
            groupBoxShowRecords.Text = "Book Records";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = SystemColors.GrayText;
            buttonSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = SystemColors.Control;
            buttonSearch.Location = new Point(729, 34);
            buttonSearch.Margin = new Padding(4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(130, 58);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += Search;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(315, 58);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(384, 31);
            textBoxSearch.TabIndex = 4;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(361, 30);
            labelSearch.Margin = new Padding(4, 0, 4, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(150, 25);
            labelSearch.TabIndex = 3;
            labelSearch.Text = "Search for Titles";
            // 
            // labelBooksResults
            // 
            labelBooksResults.AutoSize = true;
            labelBooksResults.Location = new Point(19, 114);
            labelBooksResults.Margin = new Padding(4, 0, 4, 0);
            labelBooksResults.Name = "labelBooksResults";
            labelBooksResults.Size = new Size(164, 25);
            labelBooksResults.TabIndex = 2;
            labelBooksResults.Text = "Results Found = 0";
            // 
            // buttonAllBooks
            // 
            buttonAllBooks.BackColor = SystemColors.GrayText;
            buttonAllBooks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAllBooks.ForeColor = SystemColors.Control;
            buttonAllBooks.Location = new Point(19, 32);
            buttonAllBooks.Margin = new Padding(4);
            buttonAllBooks.Name = "buttonAllBooks";
            buttonAllBooks.Size = new Size(130, 58);
            buttonAllBooks.TabIndex = 1;
            buttonAllBooks.Text = "All Books";
            buttonAllBooks.UseVisualStyleBackColor = false;
            buttonAllBooks.Click += DisplayAllBooks;
            // 
            // groupBoxSearchResults
            // 
            groupBoxSearchResults.Controls.Add(richTextBoxResults);
            groupBoxSearchResults.Location = new Point(635, 218);
            groupBoxSearchResults.Margin = new Padding(4);
            groupBoxSearchResults.Name = "groupBoxSearchResults";
            groupBoxSearchResults.Padding = new Padding(4);
            groupBoxSearchResults.Size = new Size(884, 502);
            groupBoxSearchResults.TabIndex = 5;
            groupBoxSearchResults.TabStop = false;
            groupBoxSearchResults.Text = "Search Results";
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.Location = new Point(15, 35);
            richTextBoxResults.Margin = new Padding(4);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(860, 459);
            richTextBoxResults.TabIndex = 0;
            richTextBoxResults.Text = "";
            // 
            // FormPartOne
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 754);
            Controls.Add(groupBoxSearchResults);
            Controls.Add(groupBoxShowRecords);
            Controls.Add(groupBoxBooksFromFile);
            Controls.Add(groupBoxNewBook);
            Margin = new Padding(4);
            Name = "FormPartOne";
            Text = "FormPartOne";
            Load += FormPartOne_Load;
            groupBoxNewBook.ResumeLayout(false);
            groupBoxNewBook.PerformLayout();
            groupBoxBooksFromFile.ResumeLayout(false);
            groupBoxBooksFromFile.PerformLayout();
            groupBoxShowRecords.ResumeLayout(false);
            groupBoxShowRecords.PerformLayout();
            groupBoxSearchResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxNewBook;
        private TextBox textBoxDateOfPublication;
        private TextBox textBoxPublisher;
        private TextBox textBoxISBN;
        private TextBox textBoxTitle;
        private Label labelAuthors;
        private Label labelDate;
        private Label labelPublisher;
        private Label labelISBN;
        private Label labelTitle;
        private Button buttonAddBook;
        private Button buttonAddBooksFromFile;
        private GroupBox groupBoxBooksFromFile;
        private Label labellabelNumberOfBooksRejected;
        private Label labelNumberOfBooksRecorded;
        private TextBox textBoxAuthor1;
        private TextBox textBoxAuthor3;
        private TextBox textBoxAuthor2;
        private GroupBox groupBoxShowRecords;
        private Label label1;
        private Label labelBooksResults;
        private Button buttonAllBooks;
        private GroupBox groupBoxSearchResults;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private RichTextBox richTextBoxResults;
    }
}