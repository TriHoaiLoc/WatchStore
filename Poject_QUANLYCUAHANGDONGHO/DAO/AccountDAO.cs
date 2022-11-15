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
            string query = "SP_Update_Account";
            SqlParameter[] parameters =
                {
                    new SqlParameter("@username", SqlDbType.NVarChar, 50) { Value = account.Username},
                    new SqlParameter("@passwd", SqlDbType.NVarChar, 50) { Value = account.Password},
                    new SqlParameter("@empID",SqlDbType.NVarChar, 10) {Value = account.EmployeeID},
                    new SqlParameter("@active", SqlDbType.Bit){Value = account.Active}
                };
            conn.ExecuteNonQuery(query, parameters);
        }
        //get account by username/password
        public Account GetAccount(string username, string passwd)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(passwd))
            {
                return null;
            }
            string query = "SP_Get_Account";
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", SqlDbType.NVarChar, 50) {Value = username},
                new SqlParameter("@passwd", SqlDbType.NVarChar, 50) {Value = passwd}
            };
            try
            {
                DataTable data = conn.ExecuteReader(query, parameters);
                Account account = new Account
                {
                    Username = data.Rows[0][0].ToString(),
                    Password = data.Rows[0][1].ToString(),
                    EmployeeID = data.Rows[0][2].ToString(),
                    Active = Convert.ToInt32(data.Rows[0][3])
                };
                return account;
            }
            catch
            {
                return null;
            }
        }
        //get account by empid
        public Account GetAccountByID(string id)
        {
            string query = "SP_Get_AccountByID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.NVarChar, 10) {Value = id}
            };
            try
            {
                DataTable data = conn.ExecuteReader(query, parameters);
                Account account = new Account
                {
                    Username = data.Rows[0][0].ToString(),
                    Password = data.Rows[0][1].ToString(),
                    EmployeeID = data.Rows[0][2].ToString(),
                    Active = Convert.ToInt32(data.Rows[0][3])
                };
                return account;
            }
            catch
            {
                return null;
            }
        }
        //Show list account
        public DataTable ShowAccount()
        {
            string query = "SP_Show_Account";
            return conn.ExecuteReader(query);
        }

        //Search account
        public DataTable SearchAccount(string phone)
        {
            string query = "SP_Search_Account";
            SqlParameter[] sqlParameters = { new SqlParameter("@phone", SqlDbType.NVarChar, 20) { Value = phone } };
            return conn.ExecuteReader(query, sqlParameters);
        }
    }
}
