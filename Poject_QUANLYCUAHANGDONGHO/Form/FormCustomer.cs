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
        public DataGridViewRow ViewRow;
        public FormCustomer()
        {
            InitializeComponent();

        }
        private void ShowCustomer()
        {
            dataGridView2.DataSource = customerDAO.ShowCustomer();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            ShowCustomer();
            LoadComboBox();
            clearTextBox();
        }
        private void LoadComboBox()
        {
            comboxgendercus.Items.Add("Nam");
            comboxgendercus.Items.Add("Nữ");
            comboxgendercus.SelectedIndex = 0;
            comboxgendercus.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void clearTextBox()
        {
            txtcusid.Text = string.Empty;
            txtnamecus.Text = string.Empty;
            txtaddrcus.Text = string.Empty;
            txtemailcus.Text = string.Empty;
            txtphonecus.Text = string.Empty;
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
            FormCustomer_Load(sender, e);
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
            FormCustomer_Load(sender, e);
        }

        private void butdelcus_Click(object sender, EventArgs e)
        {
            customerDAO.DelCustomer(txtcusid.Text);
            FormCustomer_Load(sender, e);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    ViewRow = dataGridView2.Rows[e.RowIndex];
                    txtcusid.Text = ViewRow.Cells["Mã khách hàng"].Value.ToString();
                    txtnamecus.Text = ViewRow.Cells["Tên khách hàng"].Value.ToString();
                    comboxgendercus.Text = ViewRow.Cells["Giới tính"].Value.ToString();
                    txtaddrcus.Text = ViewRow.Cells["Địa chỉ"].Value.ToString();
                    txtphonecus.Text = ViewRow.Cells["Số điện thoại"].Value.ToString();
                    txtemailcus.Text = ViewRow.Cells["Email"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = customerDAO.SearchCustomer(txtSearch.Text);
        }
    }
}
