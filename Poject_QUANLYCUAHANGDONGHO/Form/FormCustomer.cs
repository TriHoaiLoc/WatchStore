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
using System.Configuration;
using System.Data.SqlClient;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
            ShowCustomer();
            
        }
        private void ShowCustomer()
        {
            CustomerDAO customerDAO = new CustomerDAO();
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

        }
        
        private void butaddcus_Click(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            customerDAO.AddCustomer(txtnamecus.Text,comboxgendercus.Text, txtaddrcus.Text, txtphonecus.Text, txtemailcus.Text);
            ShowCustomer();
        }

        private void buteditcus_Click(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            customerDAO.EditCustomer(txtcusid.Text,txtnamecus.Text, comboxgendercus.Text, txtaddrcus.Text, txtphonecus.Text, txtemailcus.Text);
            ShowCustomer();
        }

        private void butdelcus_Click(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
            customerDAO.DelCustomer(txtcusid.Text);
            ShowCustomer();
        }
    }
}
