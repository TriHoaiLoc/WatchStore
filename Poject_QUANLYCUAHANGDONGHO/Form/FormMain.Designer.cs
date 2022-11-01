namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listCart = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.bt_addCart = new System.Windows.Forms.Button();
            this.cb_color = new System.Windows.Forms.ComboBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1083, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 826);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listCart);
            this.panel2.Location = new System.Drawing.Point(613, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 368);
            this.panel2.TabIndex = 2;
            // 
            // listCart
            // 
            this.listCart.HideSelection = false;
            this.listCart.Location = new System.Drawing.Point(4, 4);
            this.listCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCart.Name = "listCart";
            this.listCart.Size = new System.Drawing.Size(444, 360);
            this.listCart.TabIndex = 0;
            this.listCart.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_cancel);
            this.panel3.Controls.Add(this.bt_pay);
            this.panel3.Location = new System.Drawing.Point(613, 747);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 111);
            this.panel3.TabIndex = 3;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(16, 18);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(135, 73);
            this.bt_cancel.TabIndex = 5;
            this.bt_cancel.Text = "Hủy bỏ";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_pay
            // 
            this.bt_pay.Location = new System.Drawing.Point(315, 18);
            this.bt_pay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(135, 73);
            this.bt_pay.TabIndex = 5;
            this.bt_pay.Text = "Thanh toán";
            this.bt_pay.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.num_quantity);
            this.panel4.Controls.Add(this.bt_addCart);
            this.panel4.Controls.Add(this.cb_color);
            this.panel4.Controls.Add(this.cb_size);
            this.panel4.Controls.Add(this.cb_Category);
            this.panel4.Location = new System.Drawing.Point(613, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 103);
            this.panel4.TabIndex = 4;
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(389, 38);
            this.num_quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(48, 22);
            this.num_quantity.TabIndex = 4;
            this.num_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_addCart
            // 
            this.bt_addCart.Location = new System.Drawing.Point(247, 12);
            this.bt_addCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_addCart.Name = "bt_addCart";
            this.bt_addCart.Size = new System.Drawing.Size(135, 73);
            this.bt_addCart.TabIndex = 3;
            this.bt_addCart.Text = "Thêm";
            this.bt_addCart.UseVisualStyleBackColor = true;
            // 
            // cb_color
            // 
            this.cb_color.FormattingEnabled = true;
            this.cb_color.Location = new System.Drawing.Point(4, 70);
            this.cb_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_color.Name = "cb_color";
            this.cb_color.Size = new System.Drawing.Size(233, 24);
            this.cb_color.TabIndex = 2;
            this.cb_color.Text = "Màu";
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Location = new System.Drawing.Point(4, 37);
            this.cb_size.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(233, 24);
            this.cb_size.TabIndex = 1;
            this.cb_size.Text = "Size";
            // 
            // cb_Category
            // 
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(4, 4);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(233, 24);
            this.cb_Category.TabIndex = 0;
            this.cb_Category.Text = "Loại";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(613, 519);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 220);
            this.panel5.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(583, 811);
            this.dataGridView1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 874);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CỬA HÀNG ĐỒNG HỒ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listCart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.Button bt_addCart;
        private System.Windows.Forms.ComboBox cb_color;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_pay;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

