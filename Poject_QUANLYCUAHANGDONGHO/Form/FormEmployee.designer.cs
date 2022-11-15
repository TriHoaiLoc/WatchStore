
namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDemp = new System.Windows.Forms.TextBox();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.dobTime = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxemailempl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboxgenderempl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxaddrempl = new System.Windows.Forms.TextBox();
            this.txtboxphoneempl = new System.Windows.Forms.TextBox();
            this.txtboxnameempl = new System.Windows.Forms.TextBox();
            this.txtboxempl = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(459, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm số điện thoại:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Clear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtIDemp);
            this.groupBox1.Controls.Add(this.cbJob);
            this.groupBox1.Controls.Add(this.dobTime);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtboxemailempl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboxgenderempl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxaddrempl);
            this.groupBox1.Controls.Add(this.txtboxphoneempl);
            this.groupBox1.Controls.Add(this.txtboxnameempl);
            this.groupBox1.Location = new System.Drawing.Point(370, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(350, 288);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(280, 242);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(57, 28);
            this.bt_Clear.TabIndex = 20;
            this.bt_Clear.Text = "Làm mới";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã nhân viên";
            // 
            // txtIDemp
            // 
            this.txtIDemp.Enabled = false;
            this.txtIDemp.Location = new System.Drawing.Point(148, 30);
            this.txtIDemp.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDemp.Name = "txtIDemp";
            this.txtIDemp.ReadOnly = true;
            this.txtIDemp.Size = new System.Drawing.Size(155, 20);
            this.txtIDemp.TabIndex = 18;
            // 
            // cbJob
            // 
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(148, 175);
            this.cbJob.Margin = new System.Windows.Forms.Padding(2);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(155, 21);
            this.cbJob.TabIndex = 17;
            // 
            // dobTime
            // 
            this.dobTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobTime.Location = new System.Drawing.Point(148, 104);
            this.dobTime.Name = "dobTime";
            this.dobTime.Size = new System.Drawing.Size(155, 20);
            this.dobTime.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(199, 242);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 242);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txtboxemailempl
            // 
            this.txtboxemailempl.Location = new System.Drawing.Point(148, 200);
            this.txtboxemailempl.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxemailempl.Name = "txtboxemailempl";
            this.txtboxemailempl.Size = new System.Drawing.Size(155, 20);
            this.txtboxemailempl.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 203);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên công việc:";
            // 
            // comboxgenderempl
            // 
            this.comboxgenderempl.FormattingEnabled = true;
            this.comboxgenderempl.Location = new System.Drawing.Point(148, 78);
            this.comboxgenderempl.Margin = new System.Windows.Forms.Padding(2);
            this.comboxgenderempl.Name = "comboxgenderempl";
            this.comboxgenderempl.Size = new System.Drawing.Size(155, 21);
            this.comboxgenderempl.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ và tên:";
            // 
            // txtboxaddrempl
            // 
            this.txtboxaddrempl.Location = new System.Drawing.Point(148, 151);
            this.txtboxaddrempl.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxaddrempl.Name = "txtboxaddrempl";
            this.txtboxaddrempl.Size = new System.Drawing.Size(155, 20);
            this.txtboxaddrempl.TabIndex = 3;
            // 
            // txtboxphoneempl
            // 
            this.txtboxphoneempl.Location = new System.Drawing.Point(148, 127);
            this.txtboxphoneempl.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxphoneempl.Name = "txtboxphoneempl";
            this.txtboxphoneempl.Size = new System.Drawing.Size(155, 20);
            this.txtboxphoneempl.TabIndex = 2;
            // 
            // txtboxnameempl
            // 
            this.txtboxnameempl.Location = new System.Drawing.Point(148, 54);
            this.txtboxnameempl.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxnameempl.Name = "txtboxnameempl";
            this.txtboxnameempl.Size = new System.Drawing.Size(155, 20);
            this.txtboxnameempl.TabIndex = 0;
            // 
            // txtboxempl
            // 
            this.txtboxempl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxempl.Location = new System.Drawing.Point(106, 15);
            this.txtboxempl.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxempl.Name = "txtboxempl";
            this.txtboxempl.Size = new System.Drawing.Size(247, 27);
            this.txtboxempl.TabIndex = 4;
            this.txtboxempl.TextChanged += new System.EventHandler(this.txtboxempl_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(9, 54);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(344, 317);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 381);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txtboxempl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxemailempl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboxgenderempl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxaddrempl;
        private System.Windows.Forms.TextBox txtboxphoneempl;
        private System.Windows.Forms.TextBox txtboxnameempl;
        private System.Windows.Forms.TextBox txtboxempl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DateTimePicker dobTime;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDemp;
        private System.Windows.Forms.Button bt_Clear;
    }
}