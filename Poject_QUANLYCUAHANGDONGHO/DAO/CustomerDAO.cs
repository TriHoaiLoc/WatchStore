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

        public void AddCustomer(Customer customer)
        {
            string query = "SP_Add_Customer"; //ADD_CUSTOMER
            SqlParameter[] parameters =
                {
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = customer.Name},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = customer.Gender},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = customer.Address},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = customer.Phone},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = customer.Email}
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        public void EditCustomer(Customer customer)
        {
            string query = "SP_Update_Customer"; //UPDATE_CUSTOMER
            SqlParameter[] parameters =
                {
                new SqlParameter("@CUSID", SqlDbType.NVarChar, 10) { Value = customer.Id},
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = customer.Name},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = customer.Gender},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = customer.Address},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = customer.Phone},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = customer.Email}
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        public void DelCustomer(string id)
        {
            string query = "SP_Delete_Customer "; //DELETE_CUSTOMER
            SqlParameter[] parameters =
                {
                new SqlParameter("@ID", SqlDbType.NVarChar, 10) { Value = id},
                };
            conn.ExecuteNonQuery(query, parameters);
        }

        public Customer GetCustomer(string id)
        {
            string query = "SP_Get_Customer";
            SqlParameter[] parameters =
                {
                new SqlParameter("@id", SqlDbType.NVarChar, 10) { Value = id},
                };
            try
            {
                DataTable data = conn.ExecuteReader(query, parameters);
                Customer customer = new Customer {
                    Id = data.Rows[0][1].ToString(),
                    Name = data.Rows[0][2].ToString(),
                    Gender = data.Rows[0][3].ToString(),
                    Address = data.Rows[0][4].ToString(),
                    Phone = data.Rows[0][5].ToString(),
                    Email = data.Rows[0][6].ToString()
                };
                return customer;
            }
            catch
            {
                return null;
            }
            
        }

        public DataTable SearchCustomer(string phone)
        {
            string query = "SP_Search_Customer";
            SqlParameter[] parameter = { new SqlParameter("@phone", SqlDbType.NVarChar, 20) { Value = phone } };

            return conn.ExecuteReader(query,parameter);
        }

        public DataTable ShowCustomer()
        {
            string query = "SP_Show_Customer"; //SHOW_CUSTOMERS
            return conn.ExecuteReader(query);
        }
    }
}
