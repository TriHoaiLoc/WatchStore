﻿using System;
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
    internal class OrderDetailDAO
    {
        private DBConnection conn;
        public OrderDetailDAO()
        {
            conn = new DBConnection();
        }
        public void addOrderDetail(string orderID,string productID,int quanity)
        {
            string query = "ADD_OrderDetails";
            SqlParameter[] parameters =
              {
            new SqlParameter("@ORDER_ID", SqlDbType.NVarChar, 10) { Value = orderID },
            new SqlParameter("@PRODUCT_ID", SqlDbType.NVarChar, 10) { Value = productID },
            new SqlParameter("@QUANTITY", SqlDbType.Int, 10) { Value = quanity }
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        public DataTable showOrderDetail(string orderID)
        {
            string query = "SHOW_OrderDetails";
            SqlParameter[] parameters =
             {
            new SqlParameter("@ORDERID", SqlDbType.NVarChar, 10) { Value = orderID } };
            return conn.ExecuteReader(query, parameters);
        }
        
    }
}
