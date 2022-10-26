using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Employee
    {
        private string id;
        private string name;
        private string gender;
        private DateTime dob;
        private string phone;
        private string address;
        private string email;
        private string jobid;

        public Employee()
        {
        }

        public Employee(string id, string name, string gender, DateTime dob, 
            string phone, string address, string email, string jobid)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.jobid = jobid;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Jobid { get => jobid; set => jobid = value; }
    }
}
