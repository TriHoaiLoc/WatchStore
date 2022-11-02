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
        public DataTable ShowCustomer()
        {
            string query = "SHOW_CUSTOMERS";
            return conn.ExecuteReader(query);
        }
        public void AddCustomer(string txtnamecus, string comboxgendercus, string txtaddrcus, string txtphonecus, string txtemailcus)
        {
            string query = "ADD_CUSTOMER";
            SqlParameter[] parameters =
                {
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = txtnamecus},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = comboxgendercus},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = txtaddrcus},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = txtphonecus},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = txtemailcus}
                };
            //cmd.Parameters.Add(new SqlParameter("@Name", TextBox1));
            conn.ExecuteNonQuery(query, parameters);
        }
        public void EditCustomer(string txtcusid, string txtnamecus, string comboxgendercus, string txtaddrcus, string txtphonecus, string txtemailcus)
        {
            string query = "UPDATE_CUSTOMER";
            SqlParameter[] parameters =
                {
                new SqlParameter("@CUSID", SqlDbType.NVarChar, 10) { Value = txtcusid},
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = txtnamecus},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = comboxgendercus},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = txtaddrcus},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = txtphonecus},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = txtemailcus}
                };
            //cmd.Parameters.Add(new SqlParameter("@Name", TextBox1));
            conn.ExecuteNonQuery(query, parameters);
        }
        public void DelCustomer(string txtcusid)
        {
            string query = "DELETE_CUSTOMER ";
            SqlParameter[] parameters =
                {
                new SqlParameter("@ID", SqlDbType.NVarChar, 10) { Value = txtcusid},
                };
            //cmd.Parameters.Add(new SqlParameter("@Name", TextBox1));
            conn.ExecuteNonQuery(query, parameters);
        }
    }
}
