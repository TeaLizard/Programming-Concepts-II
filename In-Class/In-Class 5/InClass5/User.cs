using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Asst5_PROG1965_W24
{
    internal class User
    {
        public int ID;
        public string UserName;
        public string Password;
        public DateTime DateCreated;

        public User() { }

        public User(int id, string userName, string password, DateTime dateCreated)
        {
            ID = id;
            UserName = userName;
            Password = password;
            DateCreated = dateCreated;
        }

        public override string ToString()
        {
            return $"{ID},{UserName},{Password},{DateCreated.ToString()}";
        }


    }
}
