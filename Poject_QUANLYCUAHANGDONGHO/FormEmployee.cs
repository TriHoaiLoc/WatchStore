using Project_QUANLYCUAHANGDONGHO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            ShowEmployee();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.AddEmployee(txtboxnameempl.Text, comboxgenderempl.Text, txtboxdobempl.Text, txtboxphoneempl.Text,txtboxaddrempl.Text, txtemplid.Text,txtboxjobid.Text);
            ShowEmployee();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowEmployee()
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            dataGridView3.DataSource = employeeDAO.ShowEmployee();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView3.CurrentRow.Index;
            txtemplid.Text = dataGridView3.Rows[i].Cells[1].Value.ToString();
            txtboxnameempl.Text = dataGridView3.Rows[i].Cells[2].Value.ToString();
            comboxgenderempl.Text = dataGridView3.Rows[i].Cells[3].Value.ToString();
            txtboxdobempl.Text = dataGridView3.Rows[i].Cells[4].Value.ToString();
            txtboxphoneempl.Text = dataGridView3.Rows[i].Cells[5].Value.ToString();
            txtboxaddrempl.Text = dataGridView3.Rows[i].Cells[6].Value.ToString();
            txtboxemailempl.Text = dataGridView3.Rows[i].Cells[7].Value.ToString();
            txtboxjobid.Text = dataGridView3.Rows[i].Cells[8].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.EditEmployee(txtemplid.Text, txtboxnameempl.Text, comboxgenderempl.Text, txtboxdobempl.Text, txtboxphoneempl.Text, txtboxaddrempl.Text, txtemplid.Text, txtboxjobid.Text);
            ShowEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.DelEmployee(txtemplid.Text);
            ShowEmployee();
        }
    }
   
}
