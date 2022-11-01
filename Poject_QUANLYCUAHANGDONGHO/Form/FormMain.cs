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
    
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            ShowProduct();
        }
        private void ShowProduct()
        {
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.ShowProduct();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAccount formAccount = new FormAccount();
            formAccount.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.ShowDialog();
        }
    }
}
