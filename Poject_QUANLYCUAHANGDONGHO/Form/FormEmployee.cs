﻿using System;
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
        private EmployeeDAO employeeDAO = new EmployeeDAO();
        private Employee employee = new Employee();
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*employee.Name = txtboxnameempl.Text;
            employee.Gender = comboxgenderempl.Text;
            employee.Dob = null; //txtboxdobempl.Text; chú ý*/
            employeeDAO.AddEmployee(employee);
            ShowEmployee();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowEmployee();
        }

        private void ShowEmployee()
        {
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
            employeeDAO.EditEmployee(employee);
            ShowEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeDAO.DelEmployee(txtemplid.Text);
            ShowEmployee();
        }

        private void butsearchempl_Click(object sender, EventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            dataGridView3.DataSource = employeeDAO.SearchEmployee(txtboxempl.Text);
        }
    }
   
}
