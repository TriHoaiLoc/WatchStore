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

        public void AddEmployee(Employee emp)
        {
            string query = "SP_Add_Employee"; //ADD_EMPLOYEE
            SqlParameter[] parameters =
                {
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = emp.Name},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = emp.Gender},
                new SqlParameter("@DOB", SqlDbType.DateTime) { Value = emp.Dob},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = emp.Phone},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = emp.Address},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = emp.Email},
                new SqlParameter("@JOBID", SqlDbType.NVarChar, 10) { Value = emp.Jobid}
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        public void EditEmployee(Employee emp)
        {
            string query = "SP_Update_Employee"; //UPDATE_EMPLOYEE

            SqlParameter[] parameters =
                {
                new SqlParameter("@EMPID", SqlDbType.NVarChar, 10) { Value = emp.Id},
                new SqlParameter("@NAME", SqlDbType.NVarChar, 50) { Value = emp.Name},
                new SqlParameter("@GENDER", SqlDbType.NVarChar, 10) { Value = emp.Gender},
                new SqlParameter("@DOB", SqlDbType.DateTime) { Value = emp.Dob},
                new SqlParameter("@PHONE", SqlDbType.NVarChar, 20) { Value = emp.Phone},
                new SqlParameter("@ADDRESS", SqlDbType.NVarChar, 50) { Value = emp.Address},
                new SqlParameter("@EMAIL", SqlDbType.NVarChar, 50) { Value = emp.Email},
                new SqlParameter("@JOBID", SqlDbType.NVarChar, 10) { Value = emp.Jobid}
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        public void DelEmployee(string id)
        {
            string query = "SP_Delete_Employee"; //DELETE_EMPLOYEE
            SqlParameter[] parameters =
                {
                new SqlParameter("@ID", SqlDbType.NVarChar, 10) { Value = id},
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        public DataTable ShowEmployee()
        {
            string query = "SP_Show_Employee"; //SHOW_EMPLOYEE
            return conn.ExecuteReader(query);
        }

        public DataTable SearchEmployee(string phone)
        {
            string query = "SP_Search_Employee"; //FIND_EMPLOYEE
            SqlParameter[] parameters =
            {
                new SqlParameter("@phone", SqlDbType.NVarChar, 50) { Value = phone}
        };
            return conn.ExecuteReader(query, parameters);
        }
        public Employee GetEmployeeID(string id)
        {
            string query = "SP_Get_Employee"; //FIND_EMPLOYEE_ID
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.NVarChar, 10) { Value = id}
            };
            try
            {
                DataTable data = conn.ExecuteReader(query, parameters);
                Employee employee = new Employee
                {
                    Id = data.Rows[0][1].ToString(),
                    Name = data.Rows[0][2].ToString(),
                    Gender = data.Rows[0][3].ToString(),
                    Dob = Convert.ToDateTime(data.Rows[0][4].ToString()),
                    Phone = data.Rows[0][5].ToString(),
                    Address = data.Rows[0][6].ToString(),
                    Email = data.Rows[0][7].ToString(),
                    Jobid = data.Rows[0][8].ToString(),
                };
                return employee;
            }
            catch
            {
                return null;
            }
        }
        public DataTable GetPersonalInfo(string id)
        {
            string query = "SP_Get_PersonalInfo";
            SqlParameter[] sqlParameters = { new SqlParameter("@id", SqlDbType.NVarChar, 10) };
            return conn.ExecuteReader(query, sqlParameters);
        }


    }
}
