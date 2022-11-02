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
    internal class ProductColorDAO
    {
        private DBConnection conn;
        public ProductColorDAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetProductColor()
        {
            string query = "GET_PRODUCTCOLOR";
            return conn.ExecuteReader(query);
        }
    }
}
