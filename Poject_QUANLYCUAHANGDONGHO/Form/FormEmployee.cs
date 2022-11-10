using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_QUANLYCUAHANGDONGHO.DAO;
using Project_QUANLYCUAHANGDONGHO.Class;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormEmployee : Form
    {
        public DataGridViewRow ViewRow;
        public DataTable table_Job;
        private EmployeeDAO employeeDAO = new EmployeeDAO();
        private JobDAO jobDAO = new JobDAO();
        private Employee employee;
        
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployee();
            LoadComboBox();
            clearTextBox();
        }
        private void LoadComboBox()
        {
            cbJob.DataSource = jobDAO.ShowJob();
            cbJob.ValueMember = "Tên công việc";
            cbJob.DropDownStyle = ComboBoxStyle.DropDownList;

            comboxgenderempl.Items.Add("Nam");
            comboxgenderempl.Items.Add("Nữ");
            comboxgenderempl.SelectedIndex = 0;
            comboxgenderempl.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void clearTextBox()
        {
            txtIDemp.Text = string.Empty;
            txtboxnameempl.Text = string.Empty;
            dobTime.Value = DateTime.Now;
            txtboxphoneempl.Text = string.Empty;
            txtboxaddrempl.Text = string.Empty;
            txtboxemailempl.Text = string.Empty;
        }

        private void ShowEmployee()
        {
            dataGridView3.DataSource = employeeDAO.ShowEmployee();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            table_Job = jobDAO.ShowJob();
            employee = new Employee();
            employee.Name = txtboxnameempl.Text;
            employee.Gender = comboxgenderempl.Text;
            employee.Dob = dobTime.Value;
            employee.Phone = txtboxphoneempl.Text;
            employee.Address = txtboxaddrempl.Text;
            if(cbJob.Text == table_Job.Rows[cbJob.SelectedIndex]["Tên công việc"].ToString())
                employee.Jobid = table_Job.Rows[cbJob.SelectedIndex]["Mã công việc"].ToString();
            employee.Email = txtboxemailempl.Text;
            employeeDAO.AddEmployee(employee);
            Form1_Load(sender, e);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            table_Job = jobDAO.ShowJob();
            employee = new Employee();
            employee.Id = txtIDemp.Text;
            employee.Name = txtboxnameempl.Text;
            employee.Gender = comboxgenderempl.Text;
            employee.Dob = dobTime.Value;
            employee.Phone = txtboxphoneempl.Text;
            employee.Address = txtboxaddrempl.Text;
            if (cbJob.Text == table_Job.Rows[cbJob.SelectedIndex]["Tên công việc"].ToString())
                employee.Jobid = table_Job.Rows[cbJob.SelectedIndex]["Mã công việc"].ToString();
            employee.Email = txtboxemailempl.Text;
            employeeDAO.EditEmployee(employee);
            Form1_Load(sender, e);
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            employeeDAO.DelEmployee(txtIDemp.Text);
            Form1_Load(sender, e);
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    ViewRow = dataGridView3.Rows[e.RowIndex];
                    txtIDemp.Text = ViewRow.Cells["Mã nhân viên"].Value.ToString();
                    txtboxnameempl.Text = ViewRow.Cells["Tên nhân viên"].Value.ToString();
                    comboxgenderempl.Text = ViewRow.Cells["Giới tính"].Value.ToString();
                    dobTime.Value = Convert.ToDateTime(ViewRow.Cells["Ngày sinh"].Value);
                    txtboxphoneempl.Text = ViewRow.Cells["Số điện thoại"].Value.ToString();
                    txtboxaddrempl.Text = ViewRow.Cells["Địa chỉ"].Value.ToString();
                    cbJob.Text = ViewRow.Cells["Tên công việc"].Value.ToString();
                    txtboxemailempl.Text = ViewRow.Cells["Email"].Value.ToString();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtboxempl_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = employeeDAO.SearchEmployee(txtboxempl.Text);

        }

    }
   
}
