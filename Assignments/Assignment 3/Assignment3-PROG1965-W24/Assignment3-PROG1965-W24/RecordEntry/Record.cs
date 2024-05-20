using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_PROG1965_W24.RecordEntry
{
    public abstract class Record
    {
        // Label or Title of the log record to identify the nature of event
        protected string? label;             
        // String entrie to go after label
        protected List<string>? entries = new List<string>();
        // String to separate the entries
        protected string? delimeter;
        //Method to return a logbook entry
        public abstract string RecordEntry();
    }
}
