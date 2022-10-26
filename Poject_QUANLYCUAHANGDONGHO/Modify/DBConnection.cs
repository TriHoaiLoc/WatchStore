using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Project_QUANLYCUAHANGDONGHO
{
    public class ConnectDB                      
    {
      
        public static SqlConnection Connect()
        {
            string strconn = @"Data Source=KE-INIZUKO\SQLEXPRESS;Initial Catalog=WatchStore;Integrated Security=True";
            SqlConnection conn= new SqlConnection(strconn);
            return conn;
        }
    //    public void Dataconect()
    //     {
    //        str = @"Data Source=KE-INIZUKO\SQLEXPRESS;Initial Catalog=WatchStore;Integrated Security=True";
    //    }
    //public SqlConnection getconnect()
    //{
    //    return new SqlConnection(str);
    //}
       }
}
