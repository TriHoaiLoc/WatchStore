using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.DAO;
using Project_QUANLYCUAHANGDONGHO.Modify;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormLogin : Form
    {
        public FormMain formMain;
        private AccountDAO accountDAO = new AccountDAO();
        private JobDAO jobDAO = new JobDAO();
        private EmployeeDAO employeeDAO = new EmployeeDAO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            formMain.AccountMain = accountDAO.GetAccount(tb_username.Text, tb_password.Text);
            if (formMain.AccountMain != null)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBConnection conn = new DBConnection();
                conn.ConString = @"Data Source=.;Initial Catalog=WatchStore;User ID=" + formMain.AccountMain.Username + ";Password=" + formMain.AccountMain.Password;
                formMain.JobMain = jobDAO.GetJob(formMain.AccountMain.EmployeeID);
                formMain.EmployeeMain = employeeDAO.GetEmployeeID(formMain.AccountMain.EmployeeID);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không chính xác.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_password.ResetText();
                tb_password.Focus();
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Close();
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            formMain.JobMain = new Job { JobID = "", JobName = "Guest", Salary = 0 };
            formMain.AccountMain = new Account { Username = "", Password = "", EmployeeID = "", Active = 1 };
        }
    }
}
