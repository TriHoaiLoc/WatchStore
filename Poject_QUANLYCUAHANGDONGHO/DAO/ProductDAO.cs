using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.Modify;

namespace Project_QUANLYCUAHANGDONGHO.DAO
{
    internal class ProductDAO
    {
        private DBConnection conn;
        public ProductDAO()
        {
            conn = new DBConnection();
        }
        public DataTable ShowProduct()
        {
            string query = "SHOW_PRODUCT";
            return conn.ExecuteReader(query);
        }
    }
}
