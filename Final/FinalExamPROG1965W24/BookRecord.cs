using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalExamPROG1965W24.Record;

namespace FinalExamPROG1965W24
{
    internal class BookRecord : Record
    {
        private Book _Book;

        public BookRecord(Book book)
        {
            _Book = book;
        }

        public override string RecordString()
        {
            string authorListString = "";
            foreach (string author in _Book.GetAuthors())
            {
                authorListString += $"{author}|";
            }
            authorListString = authorListString.Remove(authorListString.Length - 1);

            string record = $"{_Book.GetISBN()}|{_Book.GetTitle()}|{_Book.GetPublisher()}|{_Book.GetPublicationDate()}|{authorListString}";

            return record;
        }
    }
}
