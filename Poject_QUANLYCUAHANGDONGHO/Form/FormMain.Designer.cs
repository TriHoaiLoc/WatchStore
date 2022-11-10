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
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CusID = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_NameCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_FindCus = new System.Windows.Forms.Button();
            this.txt_FindCus = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_empId = new System.Windows.Forms.TextBox();
            this.txt_OrderID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtg_OrderDetail = new System.Windows.Forms.DataGridView();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_pay = new System.Windows.Forms.Button();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lb_TotalOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addOrderDetail = new System.Windows.Forms.Button();
            this.txt_IDproductDetail = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_deleteOrderDetails = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.danhSáchHóaĐơnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1133, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem,
            this.nhanVienToolStripMenuItem1,
            this.sanPhamToolStripMenuItem1,
            this.taiKhoanToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // nhanVienToolStripMenuItem1
            // 
            this.nhanVienToolStripMenuItem1.Name = "nhanVienToolStripMenuItem1";
            this.nhanVienToolStripMenuItem1.Size = new System.Drawing.Size(183, 28);
            this.nhanVienToolStripMenuItem1.Text = "Nhân viên";
            this.nhanVienToolStripMenuItem1.Click += new System.EventHandler(this.nhanVienToolStripMenuItem1_Click);
            // 
            // sanPhamToolStripMenuItem1
            // 
            this.sanPhamToolStripMenuItem1.Name = "sanPhamToolStripMenuItem1";
            this.sanPhamToolStripMenuItem1.Size = new System.Drawing.Size(183, 28);
            this.sanPhamToolStripMenuItem1.Text = "Sản phẩm";
            this.sanPhamToolStripMenuItem1.Click += new System.EventHandler(this.sanPhamToolStripMenuItem1_Click);
            // 
            // taiKhoanToolStripMenuItem
            // 
            this.taiKhoanToolStripMenuItem.Name = "taiKhoanToolStripMenuItem";
            this.taiKhoanToolStripMenuItem.Size = new System.Drawing.Size(183, 28);
            this.taiKhoanToolStripMenuItem.Text = "Tài khoản";
            this.taiKhoanToolStripMenuItem.Click += new System.EventHandler(this.taiKhoanToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(120, 28);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.khachHangToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(187, 28);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thongTinCaNhanToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(244, 28);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đangXuatToolStripMenuItem_Click);
            // 
            // danhSáchHóaĐơnToolStripMenuItem
            // 
            this.danhSáchHóaĐơnToolStripMenuItem.Name = "danhSáchHóaĐơnToolStripMenuItem";
            this.danhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(186, 28);
            this.danhSáchHóaĐơnToolStripMenuItem.Text = "Danh sách hóa đơn";
            this.danhSáchHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.danhSachHoaĐonToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 806);
            this.panel1.TabIndex = 1;
            // 
            // cb_search
            // 
            this.cb_search.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Location = new System.Drawing.Point(436, 158);
            this.cb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(121, 37);
            this.cb_search.TabIndex = 11;
            this.cb_search.SelectedValueChanged += new System.EventHandler(this.cb_search_SelectedValueChanged);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(28, 158);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(335, 36);
            this.tb_search.TabIndex = 10;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.txt_CusID);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_NameCus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_FindCus);
            this.groupBox1.Controls.Add(this.txt_FindCus);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(583, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_CusID
            // 
            this.txt_CusID.Location = new System.Drawing.Point(180, 98);
            this.txt_CusID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CusID.Name = "txt_CusID";
            this.txt_CusID.ReadOnly = true;
            this.txt_CusID.Size = new System.Drawing.Size(100, 22);
            this.txt_CusID.TabIndex = 3;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(407, 69);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ReadOnly = true;
            this.txt_phone.Size = new System.Drawing.Size(100, 22);
            this.txt_phone.TabIndex = 3;
            // 
            // txt_NameCus
            // 
            this.txt_NameCus.Location = new System.Drawing.Point(180, 66);
            this.txt_NameCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NameCus.Name = "txt_NameCus";
            this.txt_NameCus.ReadOnly = true;
            this.txt_NameCus.Size = new System.Drawing.Size(100, 22);
            this.txt_NameCus.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên: ";
            // 
            // btn_FindCus
            // 
            this.btn_FindCus.Location = new System.Drawing.Point(383, 27);
            this.btn_FindCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_FindCus.Name = "btn_FindCus";
            this.btn_FindCus.Size = new System.Drawing.Size(75, 23);
            this.btn_FindCus.TabIndex = 1;
            this.btn_FindCus.Text = "Tìm";
            this.btn_FindCus.UseVisualStyleBackColor = true;
            this.btn_FindCus.Click += new System.EventHandler(this.btn_FindCus_Click);
            // 
            // txt_FindCus
            // 
            this.txt_FindCus.Location = new System.Drawing.Point(180, 28);
            this.txt_FindCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FindCus.Name = "txt_FindCus";
            this.txt_FindCus.Size = new System.Drawing.Size(197, 22);
            this.txt_FindCus.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(584, 604);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_empId
            // 
            this.txt_empId.Location = new System.Drawing.Point(137, 26);
            this.txt_empId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_empId.Name = "txt_empId";
            this.txt_empId.ReadOnly = true;
            this.txt_empId.Size = new System.Drawing.Size(100, 22);
            this.txt_empId.TabIndex = 3;
            // 
            // txt_OrderID
            // 
            this.txt_OrderID.Location = new System.Drawing.Point(137, 70);
            this.txt_OrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_OrderID.Name = "txt_OrderID";
            this.txt_OrderID.ReadOnly = true;
            this.txt_OrderID.Size = new System.Drawing.Size(100, 22);
            this.txt_OrderID.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nhân viên bán: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã hóa đơn: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtg_OrderDetail);
            this.panel2.Location = new System.Drawing.Point(613, 164);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 438);
            this.panel2.TabIndex = 2;
            // 
            // dtg_OrderDetail
            // 
            this.dtg_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_OrderDetail.Location = new System.Drawing.Point(0, 2);
            this.dtg_OrderDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_OrderDetail.Name = "dtg_OrderDetail";
            this.dtg_OrderDetail.RowHeadersWidth = 51;
            this.dtg_OrderDetail.RowTemplate.Height = 24;
            this.dtg_OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_OrderDetail.Size = new System.Drawing.Size(505, 433);
            this.dtg_OrderDetail.TabIndex = 0;
            this.dtg_OrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_OrderDetail_CellClick);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(851, 788);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(115, 50);
            this.bt_cancel.TabIndex = 5;
            this.bt_cancel.Text = "Hủy bỏ";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_pay
            // 
            this.bt_pay.Location = new System.Drawing.Point(993, 788);
            this.bt_pay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_pay.Name = "bt_pay";
            this.bt_pay.Size = new System.Drawing.Size(115, 50);
            this.bt_pay.TabIndex = 5;
            this.bt_pay.Text = "Thanh toán";
            this.bt_pay.UseVisualStyleBackColor = true;
            this.bt_pay.Click += new System.EventHandler(this.bt_pay_Click);
            // 
            // num_quantity
            // 
            this.num_quantity.Location = new System.Drawing.Point(129, 30);
            this.num_quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_quantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(179, 22);
            this.num_quantity.TabIndex = 4;
            this.num_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.txt_OrderID);
            this.panel5.Controls.Add(this.lb_TotalOrder);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txt_empId);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(613, 609);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(508, 161);
            this.panel5.TabIndex = 5;
            // 
            // lb_TotalOrder
            // 
            this.lb_TotalOrder.AutoSize = true;
            this.lb_TotalOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalOrder.Location = new System.Drawing.Point(377, 119);
            this.lb_TotalOrder.Name = "lb_TotalOrder";
            this.lb_TotalOrder.Size = new System.Drawing.Size(26, 29);
            this.lb_TotalOrder.TabIndex = 2;
            this.lb_TotalOrder.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền: ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.btn_deleteOrderDetails);
            this.groupBox2.Controls.Add(this.btn_addOrderDetail);
            this.groupBox2.Controls.Add(this.num_quantity);
            this.groupBox2.Controls.Add(this.txt_IDproductDetail);
            this.groupBox2.Controls.Add(this.labelOrder);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(613, 37);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(508, 116);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sản phẩm";
            // 
            // btn_addOrderDetail
            // 
            this.btn_addOrderDetail.Location = new System.Drawing.Point(372, 12);
            this.btn_addOrderDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addOrderDetail.Name = "btn_addOrderDetail";
            this.btn_addOrderDetail.Size = new System.Drawing.Size(106, 40);
            this.btn_addOrderDetail.TabIndex = 5;
            this.btn_addOrderDetail.Text = "Thêm vào Hóa đơn";
            this.btn_addOrderDetail.UseVisualStyleBackColor = true;
            this.btn_addOrderDetail.Click += new System.EventHandler(this.btn_addOrderDetail_Click);
            // 
            // txt_IDproductDetail
            // 
            this.txt_IDproductDetail.Location = new System.Drawing.Point(129, 66);
            this.txt_IDproductDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_IDproductDetail.Name = "txt_IDproductDetail";
            this.txt_IDproductDetail.Size = new System.Drawing.Size(100, 22);
            this.txt_IDproductDetail.TabIndex = 3;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(263, 69);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(78, 16);
            this.labelOrder.TabIndex = 2;
            this.labelOrder.Text = "Mã hóa đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Mã sản phẩm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số lượng: ";
            // 
            // btn_deleteOrderDetails
            // 
            this.btn_deleteOrderDetails.Location = new System.Drawing.Point(372, 66);
            this.btn_deleteOrderDetails.Name = "btn_deleteOrderDetails";
            this.btn_deleteOrderDetails.Size = new System.Drawing.Size(106, 45);
            this.btn_deleteOrderDetails.TabIndex = 6;
            this.btn_deleteOrderDetails.Text = "Xóa khỏi Hóa đơn";
            this.btn_deleteOrderDetails.UseVisualStyleBackColor = true;
            this.btn_deleteOrderDetails.Click += new System.EventHandler(this.btn_deleteOrderDetails_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 849);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bt_pay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CỬA HÀNG ĐỒNG HỒ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_pay;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CusID;
        private System.Windows.Forms.TextBox txt_NameCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_FindCus;
        private System.Windows.Forms.TextBox txt_FindCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_empId;
        private System.Windows.Forms.TextBox txt_OrderID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtg_OrderDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_addOrderDetail;
        private System.Windows.Forms.TextBox txt_IDproductDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.Label lb_TotalOrder;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sanPhamToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taiKhoanToolStripMenuItem;
        private System.Windows.Forms.Button btn_deleteOrderDetails;
    }
}

