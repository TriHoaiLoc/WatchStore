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

        private void bt_login_Click(object sender, EventArgs e)
        {
            AccountDAO accountDAO = new AccountDAO();
            Account account = new Account();
            account = accountDAO.GetAccount(tb_username.Text, tb_password.Text);

            if (account != null)
            {
                formMain.office = accountDAO.GetOffice(account.EmployeeID).ToString();
                formMain.Username = account.Username;
                formMain.empID = account.EmployeeID;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không chính xác.", "Error");
                tb_password.ResetText();
                tb_password.Focus();
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bt_login.Enabled)
            {
                e.Cancel = false;
            }
            else if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
