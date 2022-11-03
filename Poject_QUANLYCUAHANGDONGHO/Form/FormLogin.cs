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

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormLogin : Form
    {
        public FormMain formMain;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            AccountDAO accountDAO = new AccountDAO();
            Account account = new Account();
            account = accountDAO.GetAccount(tb_username.Text, tb_password.Text);
            if (account != null)
            {
                formMain.office = (radio_admin.Checked ? radio_admin.Text : radio_Emp.Text);
                formMain.Username = account.Username;
                formMain.empID = account.EmployeeID;
                MessageBox.Show(account.Username + account.Password + account.EmployeeID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không chính xác.", "Error");
                tb_password.ResetText();
                tb_password.Focus();
            }
        }
    }
}
