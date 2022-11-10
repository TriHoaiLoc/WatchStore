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
        public FormMain formMain;
        public FormLogin formLogin;
        public FormEmployee formEmployee;
        public FormProduct formProduct;
        public FormCustomer formCustomer;
        public FormInfo formInfo;
        public FormOrder formOrder;
        public FormAccount formAccount;
        public FormSales formSales;

        private Account accountMain;
        private Job jobMain;
        private Employee employeeMain;
        private ProductDAO productDAO = new ProductDAO();
        private OrderDAO orderDAO = new OrderDAO();

        internal Job JobMain { get => jobMain; set => jobMain = value; }
        internal Account AccountMain { get => accountMain; set => accountMain = value; }
        internal Employee EmployeeMain { get => employeeMain; set => employeeMain = value; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void ShowProduct()
        {
            ProductDAO productDAO = new ProductDAO();
            dataGridView1.DataSource = productDAO.ShowProduct();
        }
        private void MainNoEnable()
        {
            adminToolStripMenuItem.Enabled = false;
        }
        private void MainEnabled()
        {
            adminToolStripMenuItem.Enabled = true;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            MainNoEnable();
            formLogin = new FormLogin();
            formLogin.formMain = this;
            formLogin.ShowDialog();
            MessageBox.Show(JobMain.JobName);
            if (JobMain.JobName == "Admin")
            {
                MainEnabled();
            }
            else
            {
                MainNoEnable();
            }
            if(AccountMain != null) 
                txt_empId.Text = employeeMain.Name;
            ShowProduct();
            loadAllComboBox();
        }

        private void btn_FindCus_Click(object sender, EventArgs e)
        {
            CustomerDAO customerDAO = new CustomerDAO();
           
            DataTable reader = customerDAO.SearchCustomer(txt_FindCus.Text);
            foreach (DataRow row in reader.Rows)
            {
                txt_CusID.Text = row["Mã khách hàng"].ToString();
                txt_NameCus.Text = row["Tên khách hàng"].ToString();
                txt_phone.Text = row["Số điện thoại"].ToString();
            }

            orderDAO.createOrder(txt_CusID.Text, employeeMain.Id);
            object reader2 = orderDAO.showLastOrder();
            txt_OrderID.Text=reader2.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_IDproductDetail.Text = row.Cells["Mã sản phẩm"].Value.ToString();
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
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            orderDAO.cancelOrder(txt_OrderID.Text);
            formMain = new FormMain();
            this.Close();
            formMain.ShowDialog();
            this.Show();
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
            dataGridView1.DataSource = productDAO.SearchProductName(cb_search.Text, tb_search.Text);
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productDAO.SearchProductName(cb_search.Text, tb_search.Text);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formSales = new FormSales();
            formSales.ShowDialog();
        }

        private void nhanVienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formEmployee = new FormEmployee();
            formEmployee.ShowDialog();
        }

        private void taiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formAccount = new FormAccount();
            formAccount.ShowDialog();
        }
        private void sanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formProduct = new FormProduct();
            formProduct.ShowDialog();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCustomer = new FormCustomer();
            formCustomer.ShowDialog();
        }

        private void thongTinCaNhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInfo = new FormInfo();
            formInfo.ShowDialog();
        }
        //restart when logout
        private void đangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void danhSachHoaĐonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOrder = new FormOrder();
            formOrder.ShowDialog();
        }

    }
}
