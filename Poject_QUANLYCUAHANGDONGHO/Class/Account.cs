using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Account
    {
        private string username;
        private string password;
        private string employeeID;
        private int active = 0;

        public Account()
        {
        }

        public Account(string username, string password, string employeeID, int active)
        {
            this.username = username;
            this.password = password;
            this.employeeID = employeeID;
            this.active = active;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public int Active { get => active; set => active = value; }
    }
}
