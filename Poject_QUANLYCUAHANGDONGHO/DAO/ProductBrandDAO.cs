using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.Modify;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class ProductBrandDAO
    {
        private DBConnection conn;
        public ProductBrandDAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetProductBrand()
        {
            string query = "SP_Show_ProductBrand";  //GET_PRODUCTBRAND
            return conn.ExecuteReader(query);
        }
    }
}
