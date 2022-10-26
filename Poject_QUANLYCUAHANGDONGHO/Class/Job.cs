using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QUANLYCUAHANGDONGHO.Class
{
    internal class Job
    {
        private string jobID;
        private string jobName;
        private int salary;

        public Job()
        {
        }

        public Job(string jobID, string jobName, int salary)
        {
            this.jobID = jobID;
            this.jobName = jobName;
            this.salary = salary;
        }

        public string JobID { get => jobID; set => jobID = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public int Salary { get => salary; set => salary = value; }
    }
}
