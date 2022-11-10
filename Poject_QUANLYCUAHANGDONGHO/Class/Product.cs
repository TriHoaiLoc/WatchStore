using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Product
    {
        private string id;
        private string name;
        private string categoryid;
        private int quantity;
        private int price;
        private string colorid;
        private string sizeid;
        private string brandid;

        public Product()
        {
        }

        public Product(string id, string name, string categoryid, int quantity,
            int price, string colorid, string sizeid, string brandid)
        {
            this.id = id;
            this.name = name;
            this.categoryid = categoryid;
            this.quantity = quantity;
            this.price = price;
            this.colorid = colorid;
            this.sizeid = sizeid;
            this.brandid = brandid;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Categoryid { get => categoryid; set => categoryid = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string Colorid { get => colorid; set => colorid = value; }
        public string Sizeid { get => sizeid; set => sizeid = value; }
        public string Brandid { get => brandid; set => brandid = value; }
    }
}
