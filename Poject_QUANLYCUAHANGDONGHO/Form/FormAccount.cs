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
    public partial class FormAccount : Form
    {
        private AccountDAO accountDAO;
        private Account account;
        public FormAccount()
        {
            InitializeComponent();
            accountDAO = new AccountDAO();
            account = new Account();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            showView();
            clearText();
            bt_cancel.Text = "Clear";
            bt_edit.Text = "Chỉnh sửa";
            tbUsername.ReadOnly = true;
            tbPassword.ReadOnly = true;
            checkEnable.Enabled = false;
            checkDisable.Enabled = false;
        }
        private void showView()
        {
            dgv_Account.DataSource = accountDAO.ShowAccount();
        }

        private void clearText()
        {
            tbUsername.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbEmpName.Text = string.Empty;
            checkEnable.Checked = false;
            checkDisable.Checked = false;
        }

        private void dgv_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow ViewRow = dgv_Account.Rows[e.RowIndex];
                    tbUsername.Text = ViewRow.Cells["Tên đăng nhập"].Value.ToString();
                    tbPassword.Text = ViewRow.Cells["Mật khẩu"].Value.ToString();
                    tbEmpName.Text = ViewRow.Cells["Tên nhân viên"].Value.ToString();

                    if (Convert.ToInt32(ViewRow.Cells["Tình trạng"].Value) == 1)
                    {
                        checkEnable.Checked = true;
                    }
                    else
                    {
                        checkDisable.Checked = true;
                    }

                    account = accountDAO.GetAccount(tbUsername.Text, tbPassword.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbUsername.Text) || !string.IsNullOrEmpty(tbPassword.Text))
            {
                if (bt_edit.Text == "Chỉnh sửa")
                {

                    tbUsername.ReadOnly = false;
                    tbPassword.ReadOnly = false;
                    checkEnable.Enabled = true;
                    checkDisable.Enabled = true;
                    bt_cancel.Text = "Hủy bỏ";
                    bt_edit.Text = "Lưu";
                }
                else
                {
                    // chức năng luu chỉnh sửa
                    account.Username = tbUsername.Text;
                    account.Password = tbPassword.Text;
                    account.Active = (checkEnable.Checked ? 1 : 0);
                    accountDAO.UpdateAccount(account);
                    FormAccount_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            FormAccount_Load(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_Account.DataSource = accountDAO.SearchAccount(tbSearch.Text);
        }
    }
}
