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
    internal class CustomerDAO
    {
        private DBConnection conn;

        public CustomerDAO()
        {
            conn = new DBConnection();
        }
        public DataTable findCus(string phone)
        {

            string query = "FIND_CUS";
            SqlParameter[] parameter = { new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = phone } };

            return conn.ExecuteReader(query,parameter);
        }
    }
}
