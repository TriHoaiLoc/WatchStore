using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Project_QUANLYCUAHANGDONGHO.DAO;
using Project_QUANLYCUAHANGDONGHO.Class;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormCustomer : Form
    {
        private CustomerDAO customerDAO = new CustomerDAO();
        private Customer customer;
        public FormCustomer()
        {
            InitializeComponent();
            
        }
        private void ShowCustomer()
        {
            dataGridView2.DataSource = customerDAO.ShowCustomer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView2.CurrentRow.Index;
            txtcusid.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            txtnamecus.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
            comboxgendercus.Text = dataGridView2.Rows[i].Cells[3].Value.ToString();
            txtaddrcus.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            txtphonecus.Text = dataGridView2.Rows[i].Cells[5].Value.ToString();
            txtemailcus.Text = dataGridView2.Rows[i].Cells[6].Value.ToString();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            ShowCustomer();
        }
        
        private void butaddcus_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.Name = txtnamecus.Text;
            customer.Gender = comboxgendercus.Text;
            customer.Address = txtaddrcus.Text;
            customer.Phone = txtphonecus.Text;
            customer.Email = txtemailcus.Text;
            customerDAO.AddCustomer(customer);
            ShowCustomer();
        }

        private void buteditcus_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            customer.Id = txtcusid.Text;
            customer.Name = txtnamecus.Text;
            customer.Gender = comboxgendercus.Text;
            customer.Address = txtaddrcus.Text;
            customer.Phone = txtphonecus.Text;
            customer.Email = txtemailcus.Text;
            customerDAO.EditCustomer(customer);
            ShowCustomer();
        }

        private void butdelcus_Click(object sender, EventArgs e)
        {
            customerDAO.DelCustomer(txtcusid.Text);
            ShowCustomer();
        }

        private void butsearchcus_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = customerDAO.SearchCustomer(textBox1.Text);
           
          
        }
    }
}
