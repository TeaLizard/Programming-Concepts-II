using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamPROG1965W24
{
    internal class Book
    {
        string _Title;
        string _Publisher;
        string _ISBN;
        string _PublicationDate;
        List<string> _Authors;

        public Book(string title, string publisher, string isbn, string date, List<string> authors)
        {
            try
            {
                if (Utility.ValidateAndFormatDate(ref date) && Utility.ValidateAndFormatISBN(ref isbn))
                {
                    _Title = title;
                    _Publisher = publisher;
                    _ISBN = $"ISBN-13: {isbn}";
                    _PublicationDate = date;
                    _Authors = authors;
                }
                else
                {
                    throw new Exception("Unable to finish book setup");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public string GetTitle()
        {
            return _Title;
        }
        public string GetPublisher()
        {
            return _Publisher;
        }
        public string GetISBN()
        {
            return _ISBN;
        }
        public string GetPublicationDate()
        {
            return _PublicationDate;
        }
        public List<string> GetAuthors()
        {
            return _Authors;
        }
    }
}
