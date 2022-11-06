using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.Modify;

namespace Project_QUANLYCUAHANGDONGHO.DAO
{
    internal class AccountDAO
    {
        private DBConnection conn;

        public AccountDAO()
        {
            conn = new DBConnection();
        }
        //update account
        public void UpdateAccount(Account account)
        {
            string query = "UPDATE_ACCOUNT";
            SqlParameter[] parameters = 
                {
                    new SqlParameter("@passwd", SqlDbType.NVarChar, 50) { Value = account.Password},
                    new SqlParameter("@empID",SqlDbType.NVarChar, 10) {Value = account.EmployeeID}
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        //get account when login
        public Account GetAccount(string username, string passwd)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwd))
            {
                return null;
            }
            string query = "GET_ACCOUNT";
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", SqlDbType.NVarChar, 50) {Value = username},
                new SqlParameter("@passwd", SqlDbType.VarChar, 50) {Value = passwd}
            };
            try
            {

                DataTable data = conn.ExecuteReader(query, parameters);
                Account account = new Account();
                account.Username = data.Rows[0][0].ToString();
                account.Password = data.Rows[0][1].ToString();
                account.EmployeeID = data.Rows[0][2].ToString();
                return account;
            }
            catch
            {
                return null;
            }
        }

        public object GetOffice(string empID)
        {
            string query = "GET_OFFICE";
            SqlParameter[] sqlParameters = {new SqlParameter("@empID", SqlDbType.NVarChar, 10) { Value = empID }};
            return conn.ExecuteScalar(query, sqlParameters);
        }
    }
}
