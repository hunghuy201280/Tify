using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tify
{
    public class Account
    {
        private string username;
        private int userID;
        private string phone;

        public string Username { get => username; set => username = value; }
        public int UserID { get => userID; set => userID = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
