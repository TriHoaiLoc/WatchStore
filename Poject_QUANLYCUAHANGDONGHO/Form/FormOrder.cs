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

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormOrder : Form
    {
        private OrderDAO orderDAO = new OrderDAO();
        private OrderDetailDAO orderDetail = new OrderDetailDAO();
        public FormOrder()
        {
            InitializeComponent();
            ShowAllOrder();

        }
        public void ShowAllOrder()
        {
            dtg_Order.DataSource= orderDAO.showAllOrder();
        }

        private void dtg_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtg_Order.Rows[e.RowIndex];
                txt_Order.Text = row.Cells["OrderID"].Value.ToString();
            }

            dtg_OrderDetail.DataSource = orderDetail.showOrderDetail(txt_Order.Text);
        }

        private void btn_findOrder_Click(object sender, EventArgs e)
        {
            dtg_OrderDetail.DataSource = orderDetail.showOrderDetail(txt_Order.Text);
        }
    }
}
