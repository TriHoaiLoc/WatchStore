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

        private void btn_FindCus_Click(object sender, EventArgs e)
        {
            //01919331
            CustomerDAO customerDAO = new CustomerDAO();
            
            DataTable reader=customerDAO.findCus(txt_FindCus.Text);

            foreach (DataRow row in reader.Rows)
            {
                txt_CusID.Text = row["CustomerID"].ToString();
                txt_NameCus.Text = row["CustomerName"].ToString();
                txt_phone.Text = row["CustomerPhone"].ToString();
            }

        }

        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            //01919331
            OrderDAO orderDAO = new OrderDAO();

            orderDAO.createOrder(txt_CusID.Text,label1.Text);
            
            DataTable reader = orderDAO.showLastOrder();

            foreach (DataRow row in reader.Rows)
            {
                txt_OrderID.Text = row["OrderID"].ToString();
                txt_empId.Text = row["EmployeeID"].ToString();
                txt_CusIDORder.Text = row["CustomerID"].ToString();
            }
            labelOrder.Text = txt_OrderID.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_IDproductDetail.Text = row.Cells["ProductID"].Value.ToString();

            }
        }
            
        private void btn_addOrderDetail_Click(object sender, EventArgs e)
        {
            OrderDetailDAO orderDetailDAO = new OrderDetailDAO();
            orderDetailDAO.addOrderDetail(labelOrder.Text,txt_IDproductDetail.Text,(int)num_quantity.Value);

            dtg_OrderDetail.DataSource=orderDetailDAO.showOrderDetail(txt_OrderID.Text);

        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            OrderDAO orderDAO = new OrderDAO();
            orderDAO.ThanhToan(txt_OrderID.Text);
            FormMain formMain = new FormMain();


            this.Close();

            formMain.ShowDialog();
            this.Show();

        }

        private void danhSáchHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrder formOrder = new FormOrder();


            this.Hide();

            formOrder.ShowDialog();
            this.Show();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            OrderDAO order = new OrderDAO();
            order.cancelOrder(txt_OrderID.Text);
            FormMain formMain = new FormMain();
            this.Close();

            formMain.ShowDialog();
            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployee formEmployee = new FormEmployee();
            formEmployee.ShowDialog();
        }
        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }
    }
}
