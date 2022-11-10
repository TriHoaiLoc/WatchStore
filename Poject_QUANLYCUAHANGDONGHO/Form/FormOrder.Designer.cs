namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormOrder
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
            this.dtg_Order = new System.Windows.Forms.DataGridView();
            this.dtg_OrderDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Order = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_findOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Order
            // 
            this.dtg_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Order.Location = new System.Drawing.Point(9, 106);
            this.dtg_Order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtg_Order.Name = "dtg_Order";
            this.dtg_Order.RowHeadersWidth = 51;
            this.dtg_Order.RowTemplate.Height = 24;
            this.dtg_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Order.Size = new System.Drawing.Size(494, 242);
            this.dtg_Order.TabIndex = 0;
            this.dtg_Order.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Order_CellClick);
            // 
            // dtg_OrderDetail
            // 
            this.dtg_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_OrderDetail.Location = new System.Drawing.Point(526, 106);
            this.dtg_OrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtg_OrderDetail.Name = "dtg_OrderDetail";
            this.dtg_OrderDetail.RowHeadersWidth = 51;
            this.dtg_OrderDetail.RowTemplate.Height = 24;
            this.dtg_OrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_OrderDetail.Size = new System.Drawing.Size(488, 242);
            this.dtg_OrderDetail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi tiết hóa đơn";
            // 
            // txt_Order
            // 
            this.txt_Order.Location = new System.Drawing.Point(74, 61);
            this.txt_Order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Size = new System.Drawing.Size(126, 20);
            this.txt_Order.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hóa đơn: ";
            // 
            // btn_findOrder
            // 
            this.btn_findOrder.Location = new System.Drawing.Point(214, 61);
            this.btn_findOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_findOrder.Name = "btn_findOrder";
            this.btn_findOrder.Size = new System.Drawing.Size(56, 19);
            this.btn_findOrder.TabIndex = 3;
            this.btn_findOrder.Text = "Tìm";
            this.btn_findOrder.UseVisualStyleBackColor = true;
            this.btn_findOrder.Click += new System.EventHandler(this.btn_findOrder_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 463);
            this.Controls.Add(this.btn_findOrder);
            this.Controls.Add(this.txt_Order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_OrderDetail);
            this.Controls.Add(this.dtg_Order);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormOrder";
            this.Text = "Danh sách hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_OrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Order;
        private System.Windows.Forms.DataGridView dtg_OrderDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Order;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_findOrder;
    }
}