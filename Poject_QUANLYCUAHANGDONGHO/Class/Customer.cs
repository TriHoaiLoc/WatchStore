using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Customer
    {
        private string id;
        private string name;
        private string gender;
        private string address;
        private string phone;
        private string email;

        public Customer()
        {
        }

        public Customer(string id, string name, string gender, string address, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.phone = phone;
            this.email = email;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}
