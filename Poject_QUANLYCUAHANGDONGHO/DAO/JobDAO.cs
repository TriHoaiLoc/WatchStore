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
    internal class JobDAO
    {
        private DBConnection conn;
        public JobDAO()
        {
            conn = new DBConnection();
        }
        public DataTable ShowJobs()
        {
            string query = "SP_Show_JOBS";
            return conn.ExecuteReader(query);
        }
        public Job GetJob(string id)
        {
            string query = "SP_Get_Job";
            SqlParameter[] parameters =
            {
                new SqlParameter("@empid", SqlDbType.NVarChar, 10) {Value = id}
            };
            try
            {
                DataTable data = conn.ExecuteReader(query, parameters);
                Job job = new Job
                {
                    JobID = data.Rows[0][1].ToString(),
                    JobName = data.Rows[0][2].ToString(),
                    Salary = Convert.ToInt32(data.Rows[0][3])
                };
                return job;
            }
            catch
            {
                return null;
            }
        }

        public DataTable ShowJob()
        {
            string query = "SP_Show_JOB";
            return conn.ExecuteReader(query);
        }
    }
}
