using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Project_QUANLYCUAHANGDONGHO.Modify
{
    internal class DBConnection
    {
        private SqlConnection connection;
        private string conString = @"Data Source=.;Initial Catalog=WatchStore;Integrated Security=True";  //Connection String

        public string ConString { get => conString; set => conString = value; }

        public DBConnection()
        {
            connection = new SqlConnection(ConString);
        }
        private SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }
        //Executable function does not return a value
        public void ExecuteNonQuery(string query, SqlParameter[] sqlParameter = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameter != null)
                    sqlCommand.Parameters.AddRange(sqlParameter);
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        
        public object ExecuteScalar(String query, SqlParameter[] sqlParameter = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameter != null)
                    sqlCommand.Parameters.AddRange(sqlParameter);
                object result = new object();
                try
                {
                    result = sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return result;
            }
        }
        public DataTable ExecuteReader(String query, SqlParameter[] sqlParameter = null)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if(sqlParameter != null)
                    sqlCommand.Parameters.AddRange(sqlParameter);
                DataTable dt = new DataTable();
                try
                {
                    SqlDataReader dataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    dt.Load(dataReader);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
    }
}
