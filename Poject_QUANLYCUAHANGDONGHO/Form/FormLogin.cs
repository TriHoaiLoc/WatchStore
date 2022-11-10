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
        private AccountDAO accountDAO = new AccountDAO();
        private JobDAO jobDAO = new JobDAO();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            formMain.Account = accountDAO.GetAccount(tb_username.Text, tb_password.Text);
            if (formMain.Account != null)
            {

                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                formMain.Job = jobDAO.GetJob(formMain.Account.EmployeeID);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu của bạn không chính xác.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            else if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.Close();
            Application.Exit();
        }
    }
}
