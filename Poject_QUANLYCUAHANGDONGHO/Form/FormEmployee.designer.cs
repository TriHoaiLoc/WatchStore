
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
            this.txtemplid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxemailempl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtboxjobid = new System.Windows.Forms.TextBox();
            this.comboxgenderempl = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxaddrempl = new System.Windows.Forms.TextBox();
            this.txtboxphoneempl = new System.Windows.Forms.TextBox();
            this.txtboxdobempl = new System.Windows.Forms.TextBox();
            this.txtboxnameempl = new System.Windows.Forms.TextBox();
            this.txtboxempl = new System.Windows.Forms.TextBox();
            this.butsearchempl = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(487, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm nhân viên:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtemplid);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtboxemailempl);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtboxjobid);
            this.groupBox1.Controls.Add(this.comboxgenderempl);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtboxaddrempl);
            this.groupBox1.Controls.Add(this.txtboxphoneempl);
            this.groupBox1.Controls.Add(this.txtboxdobempl);
            this.groupBox1.Controls.Add(this.txtboxnameempl);
            this.groupBox1.Location = new System.Drawing.Point(493, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 354);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtemplid
            // 
            this.txtemplid.Location = new System.Drawing.Point(130, 32);
            this.txtemplid.Name = "txtemplid";
            this.txtemplid.Size = new System.Drawing.Size(251, 22);
            this.txtemplid.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Mã nhân viên:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 34);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxemailempl
            // 
            this.txtboxemailempl.Location = new System.Drawing.Point(130, 230);
            this.txtboxemailempl.Name = "txtboxemailempl";
            this.txtboxemailempl.Size = new System.Drawing.Size(251, 22);
            this.txtboxemailempl.TabIndex = 12;
            this.txtboxemailempl.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mã công việc:";
            // 
            // txtboxjobid
            // 
            this.txtboxjobid.Location = new System.Drawing.Point(130, 202);
            this.txtboxjobid.Name = "txtboxjobid";
            this.txtboxjobid.Size = new System.Drawing.Size(173, 22);
            this.txtboxjobid.TabIndex = 5;
            // 
            // comboxgenderempl
            // 
            this.comboxgenderempl.FormattingEnabled = true;
            this.comboxgenderempl.Location = new System.Drawing.Point(130, 88);
            this.comboxgenderempl.Name = "comboxgenderempl";
            this.comboxgenderempl.Size = new System.Drawing.Size(173, 24);
            this.comboxgenderempl.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ và tên:";
            // 
            // txtboxaddrempl
            // 
            this.txtboxaddrempl.Location = new System.Drawing.Point(130, 174);
            this.txtboxaddrempl.Name = "txtboxaddrempl";
            this.txtboxaddrempl.Size = new System.Drawing.Size(251, 22);
            this.txtboxaddrempl.TabIndex = 3;
            // 
            // txtboxphoneempl
            // 
            this.txtboxphoneempl.Location = new System.Drawing.Point(130, 146);
            this.txtboxphoneempl.Name = "txtboxphoneempl";
            this.txtboxphoneempl.Size = new System.Drawing.Size(251, 22);
            this.txtboxphoneempl.TabIndex = 2;
            // 
            // txtboxdobempl
            // 
            this.txtboxdobempl.Location = new System.Drawing.Point(130, 118);
            this.txtboxdobempl.Name = "txtboxdobempl";
            this.txtboxdobempl.Size = new System.Drawing.Size(251, 22);
            this.txtboxdobempl.TabIndex = 1;
            // 
            // txtboxnameempl
            // 
            this.txtboxnameempl.Location = new System.Drawing.Point(130, 60);
            this.txtboxnameempl.Name = "txtboxnameempl";
            this.txtboxnameempl.Size = new System.Drawing.Size(251, 22);
            this.txtboxnameempl.TabIndex = 0;
            // 
            // txtboxempl
            // 
            this.txtboxempl.Location = new System.Drawing.Point(609, 26);
            this.txtboxempl.Name = "txtboxempl";
            this.txtboxempl.Size = new System.Drawing.Size(205, 22);
            this.txtboxempl.TabIndex = 4;
            // 
            // butsearchempl
            // 
            this.butsearchempl.Location = new System.Drawing.Point(838, 19);
            this.butsearchempl.Name = "butsearchempl";
            this.butsearchempl.Size = new System.Drawing.Size(90, 29);
            this.butsearchempl.TabIndex = 5;
            this.butsearchempl.Text = "Tìm";
            this.butsearchempl.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 67);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(459, 390);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 469);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.butsearchempl);
            this.Controls.Add(this.txtboxempl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployee";
            this.Text = "Nhân viên";
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
        private System.Windows.Forms.TextBox txtboxjobid;
        private System.Windows.Forms.ComboBox comboxgenderempl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxaddrempl;
        private System.Windows.Forms.TextBox txtboxphoneempl;
        private System.Windows.Forms.TextBox txtboxdobempl;
        private System.Windows.Forms.TextBox txtboxnameempl;
        private System.Windows.Forms.TextBox txtboxempl;
        private System.Windows.Forms.Button butsearchempl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtemplid;
        private System.Windows.Forms.Label label10;
    }
}