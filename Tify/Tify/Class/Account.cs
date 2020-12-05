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
        private string name;
        private string dob;
        public Account (string username,int userID,string phone,string name,string dob)
        {
            this.username = username;
            this.userID = userID;
            this.phone = phone;
            this.name = name;
            this.dob = dob;
        }
        
        public string Username { get => username; set => username = value; }
        public int UserID { get => userID; set => userID = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
    }
}
