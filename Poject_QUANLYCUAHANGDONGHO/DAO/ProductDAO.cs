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

        public void AddProduct(Product product)
        {
            string query = "SP_Add_Product"; //ADD_PRODUCT
            SqlParameter[] parameters =
              {
            new SqlParameter("@NAME", SqlDbType.NVarChar, 10) { Value = product.Name },
            new SqlParameter("@CATEGORYID", SqlDbType.NVarChar, 10) { Value = product.Categoryid },
            new SqlParameter("@QUANTITY", SqlDbType.Int, 10) { Value = product.Quantity },
            new SqlParameter("@PRICE", SqlDbType.Int, 10) { Value = product.Price },
            new SqlParameter("@COLORID", SqlDbType.NVarChar, 10) { Value = product.Colorid },
            new SqlParameter("@SIZEID", SqlDbType.NVarChar, 10) { Value = product.Sizeid },
            new SqlParameter("@BRANDID", SqlDbType.NVarChar, 10) { Value = product.Brandid },
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public void UpdateProduct(Product product)
        {
            string query = "SP_Update_Product";    //UPDATE_PRODUCT
            SqlParameter[] parameters =
              {
            new SqlParameter("@PRODUCTID", SqlDbType.NVarChar, 10) { Value = product.Id },
            new SqlParameter("@NAME", SqlDbType.NVarChar, 10) { Value = product.Name },
            new SqlParameter("@CATEGORYID", SqlDbType.NVarChar, 10) { Value = product.Categoryid },
            new SqlParameter("@QUANTITY", SqlDbType.Int, 10) { Value = product.Quantity },
            new SqlParameter("@PRICE", SqlDbType.Int, 10) { Value = product.Price },
            new SqlParameter("@COLORID", SqlDbType.NVarChar, 10) { Value = product.Colorid },
            new SqlParameter("@SIZEID", SqlDbType.NVarChar, 10) { Value = product.Sizeid },
            new SqlParameter("@BRANDID", SqlDbType.NVarChar, 10) { Value = product.Brandid },
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public void DeleteProduct(string id)
        {
            string query = "SP_Delete_Product";    //DELETE_PRODUCT
            SqlParameter[] parameters =
            {
            new SqlParameter("@PRODUCTID", SqlDbType.NVarChar, 10) { Value = id },
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public DataTable ShowProduct()
        {
            string query = "SP_Show_Product";  //SHOW_PRODUCT
            return conn.ExecuteReader(query);
        }

        public DataTable SearchProductName(string nameCol, string value)
        {
            string query = "SP_Search_Product";    //SEARCH_PRODUCT
            SqlParameter[] parameters =
            {
            new SqlParameter("@nameCol", SqlDbType.NVarChar, 50) { Value = nameCol },
            new SqlParameter("@value", SqlDbType.NVarChar, 50) { Value = value },
                };
            return conn.ExecuteReader(query, parameters);
        }
    }
}
