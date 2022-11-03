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
        public FormLogin formLogin;

        public string empID = null;
        public string Username = null;
        public string office = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowProduct()
        {
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.ShowProduct();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //MainNoEnable();
            
            formLogin = new FormLogin();
            formLogin.formMain = this;
            formLogin.ShowDialog();
            if (office == "Admin")
            {
                //MainEnabled();
            }
            else
            {
                //MainNoEnable();
            }
            lb_username.Text = Username;
            ShowProduct();
            loadAllComboBox();
            ShowIDofEmployee();
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
            //0999999991
            CustomerDAO customerDAO = new CustomerDAO();
            OrderDAO orderDAO = new OrderDAO();
           
            DataTable reader = customerDAO.findCus(txt_FindCus.Text);
            foreach (DataRow row in reader.Rows)
            {
                txt_CusID.Text = row["CustomerID"].ToString();
                txt_NameCus.Text = row["CustomerName"].ToString();
                txt_phone.Text = row["CustomerPhone"].ToString();
            }

            orderDAO.createOrder(txt_CusID.Text, txt_empId.Text);

            object reader2 = orderDAO.showLastOrder();

          txt_OrderID.Text=reader2.ToString();
        }

        public void ShowIDofEmployee()
        {
            EmployeeDAO employee = new EmployeeDAO();
           
            object reader = employee.FindEmployeeID(lb_username.Text);

           txt_empId.Text=reader.ToString();
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
            orderDetailDAO.addOrderDetail(txt_OrderID.Text,txt_IDproductDetail.Text,(int)num_quantity.Value);
            object reader=orderDetailDAO.countToalTemp(txt_OrderID.Text);
            dtg_OrderDetail.DataSource=orderDetailDAO.showOrderDetail(txt_OrderID.Text);
            lb_TotalOrder.Text=reader.ToString();
            

        }

        private void bt_pay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thanh toán?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                OrderDAO orderDAO = new OrderDAO();

                orderDAO.ThanhToan(txt_OrderID.Text);
                resetForm();
            }

            

           

        }
        public void resetForm()
        {
            dtg_OrderDetail.DataSource = null; 
            txt_FindCus.Text="";
            txt_NameCus.Text = "";
            txt_CusID.Text = "";
            txt_phone.Text = "";
            txt_IDproductDetail.Text = "";
            txt_OrderID.Text = "";
            lb_TotalOrder.Text = "0";
            lb_username.Text = Username;
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

        public void loadAllComboBox()
        {
            cb_search.Items.Add("Name");
            cb_search.Items.Add("Category");
            cb_search.Items.Add("Color");
            cb_search.Items.Add("Brand");
            cb_search.Items.Add("Size");
        }


        private void cb_search_SelectedValueChanged(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.SearchProductName(cb_search.Text, tb_search.Text);
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.SearchProductName(cb_search.Text, tb_search.Text);
        }
    }
}
