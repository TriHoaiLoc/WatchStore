using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.Modify;
using System.Diagnostics;
using System.Drawing;
using System.Xml.Linq;

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

        public void AddProduct(string name, string categoryID, int quanity, int price, string colorID, string sizeID, string brandID)
        {
            string query = "ADD_PRODUCT";
            SqlParameter[] parameters =
              {
            new SqlParameter("@NAME", SqlDbType.NVarChar, 10) { Value = name },
            new SqlParameter("@CATEGORYID", SqlDbType.NVarChar, 10) { Value = categoryID },
            new SqlParameter("@QUANTITY", SqlDbType.Int, 10) { Value = quanity },
            new SqlParameter("@PRICE", SqlDbType.Int, 10) { Value = price },
            new SqlParameter("@COLORID", SqlDbType.NVarChar, 10) { Value = colorID },
            new SqlParameter("@SIZEID", SqlDbType.NVarChar, 10) { Value = sizeID },
            new SqlParameter("@BRANDID", SqlDbType.NVarChar, 10) { Value = brandID },
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public void UpdateProduct(string id, string name, string categoryID, int quanity, int price, string colorID, string sizeID, string brandID)
        {
            string query = "UPDATE_PRODUCT";
            SqlParameter[] parameters =
              {
            new SqlParameter("@PRODUCTID", SqlDbType.NVarChar, 10) { Value = id },
            new SqlParameter("@NAME", SqlDbType.NVarChar, 10) { Value = name },
            new SqlParameter("@CATEGORYID", SqlDbType.NVarChar, 10) { Value = categoryID },
            new SqlParameter("@QUANTITY", SqlDbType.Int, 10) { Value = quanity },
            new SqlParameter("@PRICE", SqlDbType.Int, 10) { Value = price },
            new SqlParameter("@COLORID", SqlDbType.NVarChar, 10) { Value = colorID },
            new SqlParameter("@SIZEID", SqlDbType.NVarChar, 10) { Value = sizeID },
            new SqlParameter("@BRANDID", SqlDbType.NVarChar, 10) { Value = brandID },
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public void DeleteProduct(string id)
        {
            string query = "DELETE_PRODUCT";
            SqlParameter[] parameters =
            {
            new SqlParameter("@PRODUCTID", SqlDbType.NVarChar, 10) { Value = id },
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public DataTable SearchProductName(string nameCol, string value)
        {
            string query = "SEARCH_PRODUCT";
            SqlParameter[] parameters =
            {
            new SqlParameter("@nameCol", SqlDbType.NVarChar, 50) { Value = nameCol },
            new SqlParameter("@value", SqlDbType.NVarChar, 50) { Value = value },
                };
            return conn.ExecuteReader(query, parameters);
        }
    }
}
