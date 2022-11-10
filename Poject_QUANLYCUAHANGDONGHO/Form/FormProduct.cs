using Project_QUANLYCUAHANGDONGHO.Class;
using Project_QUANLYCUAHANGDONGHO.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_QUANLYCUAHANGDONGHO
{
    public partial class FormProduct : Form
    {
        DataGridViewRow r = new DataGridViewRow();
        DataTable dt_Category = new DataTable();
        DataTable dt_Color = new DataTable();
        DataTable dt_Size = new DataTable();
        DataTable dt_Brand = new DataTable();
        private ProductDAO productDao = new ProductDAO();

        string selectedID = "";


        public FormProduct()
        {
            InitializeComponent();
            ShowProduct1();
            LoadAllCombo();
            tabControl1.TabPages.Remove(editTab);

            cb_search.Items.Add("Name");
            cb_search.Items.Add("Category");
            cb_search.Items.Add("Color");
            cb_search.Items.Add("Brand");
            cb_search.Items.Add("Size");
        }

        private void LoadAllCombo()
        {
            ComboCategoryLoad();
            ComboColorLoad();
            ComboSizeLoad();
            ComboBrandLoad();
        }

        public void ComboCategoryLoad()
        {
            CategoryDAO categoryDAO = new CategoryDAO();
            dt_Category = categoryDAO.GetCategory();
            cb_category.DataSource = dt_Category;
            cb_category.ValueMember = "Tên loại";
        }

        public void ComboColorLoad()
        {
            ProductColorDAO productColorDAO = new ProductColorDAO();

            dt_Color = productColorDAO.GetProductColor();
            cb_color.DataSource = dt_Color;
            cb_color.ValueMember = "Tên màu";
        }

        public void ComboSizeLoad()
        {
            ProductSizeDAO productSizeDAO = new ProductSizeDAO();
            dt_Size = productSizeDAO.GetProductSize();
            cb_size.DataSource = dt_Size;
            cb_size.ValueMember = "Tên kích cỡ";
        }

        public void ComboBrandLoad()
        {
            ProductBrandDAO productBrandDAO = new ProductBrandDAO();
            dt_Brand = productBrandDAO.GetProductBrand();
            cb_brand.DataSource = dt_Brand;
            cb_brand.ValueMember = "Tên hãng";
        }

        private void ShowProduct1()
        {
            dataGridView1.DataSource = productDao.ShowProduct();
        }

        private void bt_addProduct_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(listTab);
            tabControl1.TabPages.Add(editTab);
            editTab.Text = "Thêm";
            bt_edit.Text = "Thêm";
            resetTextBoxes();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(editTab);
            tabControl1.TabPages.Add(listTab);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(editTab);
            tabControl1.TabPages.Add(listTab);
        }

        private void bt_editProduct_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(listTab);
            tabControl1.TabPages.Add(editTab);
            editTab.Text = "Sửa";
            bt_edit.Text = "Sửa";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    r = dataGridView1.Rows[e.RowIndex];
                    if (r != null)
                    {
                        selectedID = r.Cells[0].Value.ToString();
                        tb_name.Text = r.Cells[1].Value.ToString();
                        cb_category.Text = r.Cells[2].Value.ToString();
                        tb_quantity.Text = r.Cells[3].Value.ToString();
                        tb_price.Text = r.Cells[4].Value.ToString();
                        cb_color.Text = r.Cells[5].Value.ToString();
                        cb_size.Text = r.Cells[6].Value.ToString();
                        cb_brand.Text = r.Cells[7].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resetTextBoxes()
        {
            tb_name.Text = "";
            tb_quantity.Text = "";
            tb_price.Text = "";
            cb_color.Text = "";
            cb_size.Text = "";
            cb_category.Text = "";
            cb_brand.Text = "";
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = tb_name.Text;
            product.Quantity = int.Parse(tb_quantity.Text);
            product.Price = int.Parse(tb_price.Text);

            for (int i = 0; i < dt_Category.Rows.Count; i++)
            {
                if (dt_Category.Rows[i][2].ToString() == cb_category.Text)
                {
                    product.Categoryid = dt_Category.Rows[i][1].ToString();
                    break;
                }
            }

            for (int i = 0; i < dt_Color.Rows.Count; i++)
            {
                if (dt_Color.Rows[i][2].ToString() == cb_color.Text)
                {
                    product.Colorid = dt_Color.Rows[i][1].ToString();
                    break;
                }
            }

            for (int i = 0; i < dt_Size.Rows.Count; i++)
            {
                if (dt_Size.Rows[i][2].ToString() == cb_size.Text)
                {
                    product.Sizeid = dt_Size.Rows[i][1].ToString();
                    break;
                }
            }

            for (int i = 0; i < dt_Brand.Rows.Count; i++)
            {
                if (dt_Brand.Rows[i][2].ToString() == cb_brand.Text)
                {
                    product.Brandid = dt_Brand.Rows[i][1].ToString();
                    break;
                }
            }

            if (bt_edit.Text == "Thêm")
            {
                productDao.AddProduct(product);
            }
            else if (bt_edit.Text == "Sửa")
            {
                product.Id = selectedID;
                productDao.UpdateProduct(product);
            }
            tabControl1.TabPages.Remove(editTab);
            tabControl1.TabPages.Add(listTab);
            ShowProduct1();
        }

        private void bt_deleteProduct_Click(object sender, EventArgs e)
        {
            productDao.DeleteProduct(r.Cells[0].Value.ToString());
            ShowProduct1();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productDao.SearchProductName(cb_search.Text, tb_search.Text);
        }

        private void cb_search_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productDao.SearchProductName(cb_search.Text, tb_search.Text);
        }
    }
}
