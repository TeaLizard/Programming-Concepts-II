using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalExamPROG1965W24
{
    public partial class FormPartOne : Form
    {
        // Text file with all books records
        private string _FileBooks = Path.Combine(Environment.CurrentDirectory, @"books.txt");
        // Text file with to be added book records
        private string _FileInput = Path.Combine(Environment.CurrentDirectory, @"book_records_input_file.txt");
        // Text file with rejected books records
        private string _FileRejectedInput = Path.Combine(Environment.CurrentDirectory, @"rejected_book_records.txt");

        public FormPartOne()
        {
            InitializeComponent();
        }

        private void FormPartOne_Load(object sender, EventArgs e)
        {

        }

        private void AddBook(object sender, EventArgs e)
        {
            Regex stringOf30Format = new(@"^[A-Za-z ]{1,30}$");
            Regex publisherFormat = new(@"^[A-Za-z, ]{1,30}$");

            string title = textBoxTitle.Text.Trim();
            if (string.IsNullOrEmpty(title) || !stringOf30Format.IsMatch(title))
            {
                MessageBox.Show("Invalid book title");
                return;
            }
            string isbn = textBoxISBN.Text.Trim();
            if (!Utility.ValidateAndFormatISBN(ref isbn))
            {
                return;
            }
            string publisher = textBoxPublisher.Text.Trim();
            if (string.IsNullOrEmpty(publisher) || !publisherFormat.IsMatch(publisher))
            {
                MessageBox.Show("Invalid book publisher");
                return;
            }
            string date = textBoxDateOfPublication.Text.Trim();
            if (!Utility.ValidateAndFormatDate(ref date))
            {
                return;
            }
            string author1 = textBoxAuthor1.Text.Trim();
            string author2 = textBoxAuthor2.Text.Trim();
            string author3 = textBoxAuthor3.Text.Trim();
            if (string.IsNullOrEmpty(author1.Trim()))
            {
                MessageBox.Show("Enter at least one author");
                return;
            }
            else if (!stringOf30Format.IsMatch(author1))
            {
                MessageBox.Show("Invalid author");
                return;
            }
            List<string> authors = new List<string>();

            authors.Add(author1.Trim());
            if (!string.IsNullOrEmpty(author2.Trim()) && stringOf30Format.IsMatch(author2.Trim()))
            {
                authors.Add(author2.Trim());
            }
            if (!string.IsNullOrEmpty(author3.Trim()) && stringOf30Format.IsMatch(author3.Trim()))
            {
                authors.Add(author3.Trim());
            }

            Book book = new(title, publisher, isbn, date, authors);

            BookRecord record = new BookRecord(book);
            Utility.AddRecord(_FileBooks, record.RecordString());
        }

        private void AddBooksFromFile(object sender, EventArgs e)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(_FileInput);

                while (!sr.EndOfStream)
                {
                    bool recordIsValid = true;

                    string record = sr.ReadLine();
                    string[] fields = record.Split("|");

                    Regex stringOf30Format = new(@"^[A-Za-z ]{1,30}$");
                    Regex publisherFormat = new(@"^[A-Za-z, ]{1,30}$");

                    string title = fields[1];
                    if (string.IsNullOrEmpty(title) || !stringOf30Format.IsMatch(title))
                    {
                        recordIsValid = false;
                    }
                    string isbn = fields[0];
                    if (!Utility.ValidateAndFormatISBN(ref isbn))
                    {
                        recordIsValid = false;
                    }
                    string publisher = fields[2];
                    if (string.IsNullOrEmpty(publisher) || !publisherFormat.IsMatch(publisher))
                    {
                        recordIsValid = false;
                    }
                    string date = fields[3];
                    if (!Utility.ValidateAndFormatDate(ref date))
                    {
                        recordIsValid = false;
                    }

                    List<string> authors = new List<string>();

                    string author1 = fields[4];
                    if (string.IsNullOrEmpty(author1.Trim()))
                    {
                        recordIsValid = false;
                    }
                    else if (!stringOf30Format.IsMatch(author1))
                    {
                        recordIsValid = false;
                    }
                    authors.Add(author1.Trim());
                    if (fields.Length > 5)
                    {
                        string author2 = fields[5];
                        if (!string.IsNullOrEmpty(author2.Trim()) || !stringOf30Format.IsMatch(author2)) //
                        {
                            authors.Add(author2.Trim());
                        }
                    }
                    if (fields.Length > 6)
                    {
                        string author3 = fields[6];
                        if (!string.IsNullOrEmpty(author3.Trim()) || !stringOf30Format.IsMatch(author3))
                        {
                            authors.Add(author3.Trim());
                        }
                    }

                    if (recordIsValid)
                    {
                        Utility.AddRecord(_FileBooks, record);
                    }
                    else
                    {
                        Utility.AddRecord(_FileRejectedInput, record);
                    }
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); File.WriteAllText(_FileInput, ""); }
        }

        private void DisplayAllBooks(object sender, EventArgs e)
        {
            StreamReader sr = null;
            richTextBoxResults.Text = "";
            try
            {
                sr = new StreamReader(_FileBooks);

                int i = 1;
                while (!sr.EndOfStream)
                {
                    string record = sr.ReadLine();
                    string[] fields = record.Split(",");

                    richTextBoxResults.Text += $"({i}) {record}\n\n";
                    i++;
                }
            }
            catch (FileNotFoundException) { MessageBox.Show("File not found"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Directory not found"); }
            catch (IOException) { MessageBox.Show("Problem with file data"); }
            catch (Exception excep) { MessageBox.Show(excep.ToString()); }
            finally { sr.Dispose(); }
        }

        private void Search(object sender, EventArgs e)
        {
            Utility.RecordSearch(textBoxSearch.Text, _FileBooks, richTextBoxResults, out int i);
            labelBooksResults.Text = $"Results Found = {i - 1}";
        }
    }
}
