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
    public class OrderDAO
    {
        private DBConnection conn;
        public OrderDAO()
        {
            conn = new DBConnection();
        }
        public void createOrder(string idcus, string empid)
        {
            string query = "SP_Create_Receipt"; //CREATE_RECEIPT
            SqlParameter[] parameters =
                {
            new SqlParameter("@idcus", SqlDbType.NVarChar, 50) { Value = idcus },
            new SqlParameter("@EMPID", SqlDbType.NVarChar, 10) { Value = empid }
                };
            conn.ExecuteScalar(query, parameters);

        }
        public object showLastOrder()
        {
            string query = "SP_Select_NewOrder"; //SELECT_NEW_ORDER
            return conn.ExecuteScalar(query);
        }
        public void ThanhToan(string orderID)
        {
            string query = "SP_Pay"; //THANHTOAN
            SqlParameter[] parameters =
               {
            new SqlParameter("@ORDERID", SqlDbType.NVarChar, 10) { Value = orderID } };
            conn.ExecuteNonQuery(query, parameters);
        }
        public DataTable showAllOrder()
        {
            string query = "SP_Show_Order";  //SHOW_Order
            return conn.ExecuteReader(query);
        }
        public void cancelOrder(string orderID)
        {
            string query = "SP_Delete_Receipt"; //DELETE_RECEPIT
            SqlParameter[] parameters =
              {
            new SqlParameter("@ORDERID", SqlDbType.NVarChar, 10) { Value = orderID } };
            conn.ExecuteNonQuery(query, parameters);
        }
        

    }
}
