using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Order
    {
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
    }
}
