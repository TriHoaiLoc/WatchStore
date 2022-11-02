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
    internal class EmployeeDAO
    {
        private DBConnection conn;

        public EmployeeDAO()
        {
            conn = new DBConnection();
        }
        public DataTable ShowEmployee()
        {
            string query = "SHOW_EMPLOYEE";
            return conn.ExecuteReader(query);
        }

        public DataTable FindEmployee(string name)
        {
            string query = "FIND_EMPLOYEE";
            SqlParameter[] parameters =
            {
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = name}
        };
            return conn.ExecuteReader(query, parameters);
        }


        public void AddEmployee(string name, string gender, string dob, string phone, string addr, string email, string jobid)
        {
            string query = "ADD_EMPLOYEE";
            SqlParameter[] parameters =
                {
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = name},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = gender},
                new SqlParameter("@DOB", SqlDbType.DateTime) { Value = dob},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = phone},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = addr},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = email},
                new SqlParameter("@JOBID", SqlDbType.NVarChar, 10) { Value = jobid}
                };
            //cmd.Parameters.Add(new SqlParameter("@Name", TextBox1));
            conn.ExecuteNonQuery(query, parameters);
        }
        public void EditEmployee(string id, string name, string gender, string dob, string phone, string addr, string email, string jobid)
        {
            string query = "UPDATE_EMPLOYEE";
            SqlParameter[] parameters =
                {
                new SqlParameter("@EMPID", SqlDbType.NVarChar, 10) { Value = id},
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = name},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = gender},
                new SqlParameter("@DOB", SqlDbType.DateTime) { Value = dob},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = phone},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = addr},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = email},
                new SqlParameter("@JOBID", SqlDbType.NVarChar, 10) { Value = jobid}
                };
            //cmd.Parameters.Add(new SqlParameter("@Name", TextBox1));
            conn.ExecuteNonQuery(query, parameters);
        }
        public void DelEmployee(string txtcusid)
        {
            string query = "DELETE_EMPLOYEE";
            SqlParameter[] parameters =
                {
                new SqlParameter("@ID", SqlDbType.NVarChar, 10) { Value = txtcusid},
                };
            //cmd.Parameters.Add(new SqlParameter("@Name", TextBox1));
            conn.ExecuteNonQuery(query, parameters);
        }
    }
}
