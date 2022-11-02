namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.listTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_deleteProduct = new System.Windows.Forms.Button();
            this.bt_updateProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.editTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.cb_brand = new System.Windows.Forms.ComboBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.bt_edit = new System.Windows.Forms.Button();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.listTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.editTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.listTab);
            this.tabControl1.Controls.Add(this.editTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1050, 591);
            this.tabControl1.TabIndex = 0;
            // 
            // listTab
            // 
            this.listTab.Controls.Add(this.panel1);
            this.listTab.Controls.Add(this.bt_deleteProduct);
            this.listTab.Controls.Add(this.bt_updateProduct);
            this.listTab.Controls.Add(this.btn_addProduct);
            this.listTab.Location = new System.Drawing.Point(4, 25);
            this.listTab.Name = "listTab";
            this.listTab.Padding = new System.Windows.Forms.Padding(3);
            this.listTab.Size = new System.Drawing.Size(1042, 562);
            this.listTab.TabIndex = 0;
            this.listTab.Text = "Danh sách";
            this.listTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 556);
            this.panel1.TabIndex = 7;
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(17, 20);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(334, 36);
            this.tb_search.TabIndex = 8;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 478);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bt_deleteProduct
            // 
            this.bt_deleteProduct.Location = new System.Drawing.Point(785, 191);
            this.bt_deleteProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_deleteProduct.Name = "bt_deleteProduct";
            this.bt_deleteProduct.Size = new System.Drawing.Size(114, 44);
            this.bt_deleteProduct.TabIndex = 6;
            this.bt_deleteProduct.Text = "Xóa";
            this.bt_deleteProduct.UseVisualStyleBackColor = true;
            this.bt_deleteProduct.Click += new System.EventHandler(this.bt_deleteProduct_Click);
            // 
            // bt_updateProduct
            // 
            this.bt_updateProduct.Location = new System.Drawing.Point(785, 118);
            this.bt_updateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.bt_updateProduct.Name = "bt_updateProduct";
            this.bt_updateProduct.Size = new System.Drawing.Size(114, 44);
            this.bt_updateProduct.TabIndex = 5;
            this.bt_updateProduct.Text = "Sửa";
            this.bt_updateProduct.UseVisualStyleBackColor = true;
            this.bt_updateProduct.Click += new System.EventHandler(this.bt_editProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(785, 46);
            this.btn_addProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(114, 44);
            this.btn_addProduct.TabIndex = 4;
            this.btn_addProduct.Text = "Thêm";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.bt_addProduct_Click);
            // 
            // editTab
            // 
            this.editTab.Controls.Add(this.label6);
            this.editTab.Controls.Add(this.label5);
            this.editTab.Controls.Add(this.label4);
            this.editTab.Controls.Add(this.label3);
            this.editTab.Controls.Add(this.label2);
            this.editTab.Controls.Add(this.label1);
            this.editTab.Controls.Add(this.lb_name);
            this.editTab.Controls.Add(this.cb_brand);
            this.editTab.Controls.Add(this.tb_price);
            this.editTab.Controls.Add(this.button1);
            this.editTab.Controls.Add(this.cb_category);
            this.editTab.Controls.Add(this.cb_size);
            this.editTab.Controls.Add(this.cb_color);
            this.editTab.Controls.Add(this.tb_name);
            this.editTab.Controls.Add(this.tb_quantity);
            this.editTab.Controls.Add(this.bt_edit);
            this.editTab.Location = new System.Drawing.Point(4, 25);
            this.editTab.Name = "editTab";
            this.editTab.Padding = new System.Windows.Forms.Padding(3);
            this.editTab.Size = new System.Drawing.Size(1042, 562);
            this.editTab.TabIndex = 1;
            this.editTab.Text = "tabPage2";
            this.editTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 406);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Brand:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Size:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "Màu:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loại:";
            // 
            // lb_name
            // 
            this.lb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(27, 23);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(54, 29);
            this.lb_name.TabIndex = 14;
            this.lb_name.Text = "Tên:";
            // 
            // cb_brand
            // 
            this.cb_brand.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cb_brand.FormattingEnabled = true;
            this.cb_brand.Location = new System.Drawing.Point(224, 398);
            this.cb_brand.Name = "cb_brand";
            this.cb_brand.Size = new System.Drawing.Size(334, 37);
            this.cb_brand.TabIndex = 13;
            // 
            // tb_price
            // 
            this.tb_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_price.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(224, 204);
            this.tb_price.Margin = new System.Windows.Forms.Padding(4);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(334, 36);
            this.tb_price.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cb_category
            // 
            this.cb_category.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(224, 84);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(334, 37);
            this.cb_category.TabIndex = 10;
            // 
            // cb_size
            // 
            this.cb_size.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Location = new System.Drawing.Point(224, 332);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(334, 37);
            this.cb_size.TabIndex = 9;
            this.cb_size.SelectedIndexChanged += new System.EventHandler(this.cb_size_SelectedIndexChanged);
            // 
            // cb_color
            // 
            this.cb_color.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(224, 263);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(334, 37);
            this.cb_color.TabIndex = 8;
            // 
            // tb_name
            // 
            this.tb_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(224, 20);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(334, 36);
            this.tb_name.TabIndex = 7;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_quantity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(224, 141);
            this.tb_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(334, 36);
            this.tb_quantity.TabIndex = 6;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(224, 468);
            this.bt_edit.Margin = new System.Windows.Forms.Padding(4);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(114, 44);
            this.bt_edit.TabIndex = 5;
            this.bt_edit.Text = "Thêm";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(439, 19);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(121, 37);
            this.cb_search.TabIndex = 9;
            this.cb_search.SelectedValueChanged += new System.EventHandler(this.cb_search_SelectedValueChanged);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.tabControl1.ResumeLayout(false);
            this.listTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.editTab.ResumeLayout(false);
            this.editTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage listTab;
        private System.Windows.Forms.TabPage editTab;
        private System.Windows.Forms.Button bt_deleteProduct;
        private System.Windows.Forms.Button bt_updateProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.ComboBox cb_brand;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cb_search;
    }
}