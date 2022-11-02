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
            this.dtg_Order.Location = new System.Drawing.Point(12, 130);
            this.dtg_Order.Name = "dtg_Order";
            this.dtg_Order.RowHeadersWidth = 51;
            this.dtg_Order.RowTemplate.Height = 24;
            this.dtg_Order.Size = new System.Drawing.Size(658, 298);
            this.dtg_Order.TabIndex = 0;
            this.dtg_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Order_CellContentClick);
            // 
            // dtg_OrderDetail
            // 
            this.dtg_OrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_OrderDetail.Location = new System.Drawing.Point(702, 130);
            this.dtg_OrderDetail.Name = "dtg_OrderDetail";
            this.dtg_OrderDetail.RowHeadersWidth = 51;
            this.dtg_OrderDetail.RowTemplate.Height = 24;
            this.dtg_OrderDetail.Size = new System.Drawing.Size(650, 298);
            this.dtg_OrderDetail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1000, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi tiết hóa đơn";
            // 
            // txt_Order
            // 
            this.txt_Order.Location = new System.Drawing.Point(99, 75);
            this.txt_Order.Name = "txt_Order";
            this.txt_Order.Size = new System.Drawing.Size(167, 22);
            this.txt_Order.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hóa đơn: ";
            // 
            // btn_findOrder
            // 
            this.btn_findOrder.Location = new System.Drawing.Point(286, 75);
            this.btn_findOrder.Name = "btn_findOrder";
            this.btn_findOrder.Size = new System.Drawing.Size(75, 23);
            this.btn_findOrder.TabIndex = 3;
            this.btn_findOrder.Text = "Tìm";
            this.btn_findOrder.UseVisualStyleBackColor = true;
            this.btn_findOrder.Click += new System.EventHandler(this.btn_findOrder_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 570);
            this.Controls.Add(this.btn_findOrder);
            this.Controls.Add(this.txt_Order);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_OrderDetail);
            this.Controls.Add(this.dtg_Order);
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