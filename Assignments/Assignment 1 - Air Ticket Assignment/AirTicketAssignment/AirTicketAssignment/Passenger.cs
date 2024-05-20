using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTicketAssignment
{
    public class Passenger : Form1
    {
        private string? FirstName;
        private string? LastName;
        private Int64 PhoneNumber;
        private string? EMail;
        public string? Seat;
        public Passenger() { }
        public Passenger(string firstName, string lastName, Int64 phoneNumber, string eMail)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EMail = eMail;
        }

        public Passenger(string firstName, string lastName, Int64 phoneNumber, string eMail, string seat)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            EMail = eMail;
            Seat = seat;
        }

        new public string ToString()
        {
            return $"{FirstName} {LastName} {PhoneNumber} {EMail}";
        }

        new public string ToString(string _)
        {
            return $"{Seat} {FirstName} {LastName} {PhoneNumber} {EMail}";
        }

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
