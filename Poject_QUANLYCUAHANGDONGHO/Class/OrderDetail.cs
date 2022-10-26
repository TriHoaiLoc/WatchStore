using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class OrderDetail
    {
        private string orderid;
        private string productid;
        private int quantity;
        private int price;

        public OrderDetail()
        {
        }

        public OrderDetail(string orderid, string productid, int quantity, int price)
        {
            this.orderid = orderid;
            this.productid = productid;
            this.quantity = quantity;
            this.price = price;
        }

        public string Orderid { get => orderid; set => orderid = value; }
        public string Productid { get => productid; set => productid = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
    }
}
