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
    internal class ProductSizeDAO
    {
        private DBConnection conn;
        public ProductSizeDAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetProductSize()
        {
            string query = "SP_Show_ProductSize";   //GET_PRODUCTSIZE
            return conn.ExecuteReader(query);
        }
    }
}
