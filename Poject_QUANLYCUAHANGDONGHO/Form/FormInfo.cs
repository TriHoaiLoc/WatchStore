using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.DAO;
using System;
using System.Windows.Forms;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormInfo : Form
    {
        public FormMain fmain;
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            FillTextBox();
        }
        private void FillTextBox()
        {
            tbId.Text = fmain.EmployeeMain.Id;
            tbName.Text = fmain.EmployeeMain.Name;
            tbGender.Text = fmain.EmployeeMain.Gender;
            tbphone.Text = fmain.EmployeeMain.Phone;
            DobDate.Value = fmain.EmployeeMain.Dob;
            tbAddress.Text = fmain.EmployeeMain.Address;
            tbEmail.Text = fmain.EmployeeMain.Email;

            tbJobID.Text = fmain.JobMain.JobID;
            tbJobName.Text = fmain.JobMain.JobName;
            tbSalary.Text = fmain.JobMain.Salary.ToString();

            tbUsername.Text = fmain.AccountMain.Username;
            tbPasswd.Text = fmain.AccountMain.Password;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            if (tbPassNew.Text != tbPassReply.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu nhập lại chưa đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EmployeeDAO employeeDAO = new EmployeeDAO();
                AccountDAO accountDAO = new AccountDAO();

                Employee employee = new Employee
                {
                    Id = tbId.Text,
                    Name = tbName.Text,
                    Gender = tbGender.Text,
                    Phone = tbphone.Text,
                    Address = tbAddress.Text,
                    Dob = DobDate.Value,
                    Email = tbEmail.Text,
                    Jobid = tbJobID.Text
                };

                Account account = fmain.AccountMain;
                account.Username = tbUsername.Text;
                if (!string.IsNullOrEmpty(tbPassNew.Text))
                {
                    account.Password = tbPassNew.Text;
                }

                if (MessageBox.Show("Ứng dụng sẽ khởi động lại!\nBạn vẫn muốn thay đổi thông tin?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                {
                    if (fmain.EmployeeMain != employee || fmain.AccountMain != account)
                    {
                        employeeDAO.EditEmployee(employee);
                        accountDAO.UpdateAccount(account);
                    }    

                    Application.Restart();
                }
            }
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCancel_Click_1(object sender, EventArgs e)
        {
            FillTextBox();
        }
    }
}
