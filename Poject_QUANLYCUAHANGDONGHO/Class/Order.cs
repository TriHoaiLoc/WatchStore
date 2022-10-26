using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Order
    {
<<<<<<< HEAD
        private string id;
        private string empid;
        private string cusid;
        private DateTime date;
        private int total;

        public Order()
        {
        }

        public Order(string id, string empid, string cusid, DateTime date, int total)
        {
            this.id = id;
            this.empid = empid;
            this.cusid = cusid;
            this.date = date;
            this.total = total;
        }

        public string Id { get => id; set => id = value; }
        public string Empid { get => empid; set => empid = value; }
        public string Cusid { get => cusid; set => cusid = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Total { get => total; set => total = value; }
=======
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int EmployeeID { get; set; }
        public int CustomerID { get; set; }
        public int OrderDate { get; set; }
        public int Total { get; set; }

>>>>>>> e37f5c34c636489248faf6a4decc1a69d33b3dc8
    }
}
