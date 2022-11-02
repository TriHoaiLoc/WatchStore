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
    internal class CategoryDAO
    {
        private DBConnection conn;

        public CategoryDAO()
        {
            conn = new DBConnection();
        }

        public DataTable GetCategory()
        {
            string query = "GET_CATEGORY";
            return conn.ExecuteReader(query);
        }
    }
}
