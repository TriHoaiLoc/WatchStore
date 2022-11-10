
namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.txtcusid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.butdelcus = new System.Windows.Forms.Button();
            this.buteditcus = new System.Windows.Forms.Button();
            this.butaddcus = new System.Windows.Forms.Button();
            this.comboxgendercus = new System.Windows.Forms.ComboBox();
            this.txtemailcus = new System.Windows.Forms.TextBox();
            this.txtphonecus = new System.Windows.Forms.TextBox();
            this.txtaddrcus = new System.Windows.Forms.TextBox();
            this.txtnamecus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(472, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(9, 49);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(374, 390);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm số điện thoại:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Clear);
            this.groupBox1.Controls.Add(this.txtcusid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.butdelcus);
            this.groupBox1.Controls.Add(this.buteditcus);
            this.groupBox1.Controls.Add(this.butaddcus);
            this.groupBox1.Controls.Add(this.comboxgendercus);
            this.groupBox1.Controls.Add(this.txtemailcus);
            this.groupBox1.Controls.Add(this.txtphonecus);
            this.groupBox1.Controls.Add(this.txtaddrcus);
            this.groupBox1.Controls.Add(this.txtnamecus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(405, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(351, 367);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(278, 295);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(64, 31);
            this.bt_Clear.TabIndex = 15;
            this.bt_Clear.Text = "Làm mới";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // txtcusid
            // 
            this.txtcusid.Enabled = false;
            this.txtcusid.Location = new System.Drawing.Point(151, 39);
            this.txtcusid.Margin = new System.Windows.Forms.Padding(2);
            this.txtcusid.Name = "txtcusid";
            this.txtcusid.ReadOnly = true;
            this.txtcusid.Size = new System.Drawing.Size(155, 20);
            this.txtcusid.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Mã khách hàng:";
            // 
            // butdelcus
            // 
            this.butdelcus.Location = new System.Drawing.Point(187, 295);
            this.butdelcus.Margin = new System.Windows.Forms.Padding(2);
            this.butdelcus.Name = "butdelcus";
            this.butdelcus.Size = new System.Drawing.Size(64, 31);
            this.butdelcus.TabIndex = 12;
            this.butdelcus.Text = "Xóa";
            this.butdelcus.UseVisualStyleBackColor = true;
            this.butdelcus.Click += new System.EventHandler(this.butdelcus_Click);
            // 
            // buteditcus
            // 
            this.buteditcus.Location = new System.Drawing.Point(100, 295);
            this.buteditcus.Margin = new System.Windows.Forms.Padding(2);
            this.buteditcus.Name = "buteditcus";
            this.buteditcus.Size = new System.Drawing.Size(64, 31);
            this.buteditcus.TabIndex = 11;
            this.buteditcus.Text = "Sửa";
            this.buteditcus.UseVisualStyleBackColor = true;
            this.buteditcus.Click += new System.EventHandler(this.buteditcus_Click);
            // 
            // butaddcus
            // 
            this.butaddcus.Location = new System.Drawing.Point(15, 295);
            this.butaddcus.Margin = new System.Windows.Forms.Padding(2);
            this.butaddcus.Name = "butaddcus";
            this.butaddcus.Size = new System.Drawing.Size(64, 31);
            this.butaddcus.TabIndex = 10;
            this.butaddcus.Text = "Thêm";
            this.butaddcus.UseVisualStyleBackColor = true;
            this.butaddcus.Click += new System.EventHandler(this.butaddcus_Click);
            // 
            // comboxgendercus
            // 
            this.comboxgendercus.FormattingEnabled = true;
            this.comboxgendercus.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.comboxgendercus.Location = new System.Drawing.Point(151, 101);
            this.comboxgendercus.Margin = new System.Windows.Forms.Padding(2);
            this.comboxgendercus.Name = "comboxgendercus";
            this.comboxgendercus.Size = new System.Drawing.Size(155, 21);
            this.comboxgendercus.TabIndex = 9;
            // 
            // txtemailcus
            // 
            this.txtemailcus.Location = new System.Drawing.Point(151, 203);
            this.txtemailcus.Margin = new System.Windows.Forms.Padding(2);
            this.txtemailcus.Name = "txtemailcus";
            this.txtemailcus.Size = new System.Drawing.Size(155, 20);
            this.txtemailcus.TabIndex = 8;
            // 
            // txtphonecus
            // 
            this.txtphonecus.Location = new System.Drawing.Point(151, 169);
            this.txtphonecus.Margin = new System.Windows.Forms.Padding(2);
            this.txtphonecus.Name = "txtphonecus";
            this.txtphonecus.Size = new System.Drawing.Size(155, 20);
            this.txtphonecus.TabIndex = 7;
            // 
            // txtaddrcus
            // 
            this.txtaddrcus.Location = new System.Drawing.Point(151, 135);
            this.txtaddrcus.Margin = new System.Windows.Forms.Padding(2);
            this.txtaddrcus.Name = "txtaddrcus";
            this.txtaddrcus.Size = new System.Drawing.Size(155, 20);
            this.txtaddrcus.TabIndex = 6;
            // 
            // txtnamecus
            // 
            this.txtnamecus.Location = new System.Drawing.Point(151, 68);
            this.txtnamecus.Margin = new System.Windows.Forms.Padding(2);
            this.txtnamecus.Name = "txtnamecus";
            this.txtnamecus.Size = new System.Drawing.Size(155, 20);
            this.txtnamecus.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 210);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 180);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(106, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 27);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butdelcus;
        private System.Windows.Forms.Button buteditcus;
        private System.Windows.Forms.Button butaddcus;
        private System.Windows.Forms.ComboBox comboxgendercus;
        private System.Windows.Forms.TextBox txtemailcus;
        private System.Windows.Forms.TextBox txtphonecus;
        private System.Windows.Forms.TextBox txtaddrcus;
        private System.Windows.Forms.TextBox txtnamecus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtcusid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bt_Clear;
    }
}