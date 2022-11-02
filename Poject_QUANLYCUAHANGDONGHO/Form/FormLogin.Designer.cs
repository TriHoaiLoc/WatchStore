namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormLogin
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.radio_Emp = new System.Windows.Forms.RadioButton();
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5F));
            this.tableLayoutPanel1.Controls.Add(this.tb_password, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_password, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_username, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_username, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(51, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(499, 143);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(161, 89);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(334, 36);
            this.tb_password.TabIndex = 6;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // lb_username
            // 
            this.lb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(4, 21);
            this.lb_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(149, 29);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Tài khoản:";
            // 
            // lb_password
            // 
            this.lb_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(4, 92);
            this.lb_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(149, 29);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Mật khẩu:";
            // 
            // tb_username
            // 
            this.tb_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(161, 17);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(334, 36);
            this.tb_username.TabIndex = 5;
            // 
            // radio_Emp
            // 
            this.radio_Emp.AutoSize = true;
            this.radio_Emp.Checked = true;
            this.radio_Emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_Emp.Location = new System.Drawing.Point(587, 69);
            this.radio_Emp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_Emp.Name = "radio_Emp";
            this.radio_Emp.Size = new System.Drawing.Size(104, 24);
            this.radio_Emp.TabIndex = 3;
            this.radio_Emp.TabStop = true;
            this.radio_Emp.Text = "Nhân viên";
            this.radio_Emp.UseVisualStyleBackColor = true;
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_admin.Location = new System.Drawing.Point(587, 116);
            this.radio_admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(87, 24);
            this.radio_admin.TabIndex = 4;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Quản lý";
            this.radio_admin.UseVisualStyleBackColor = true;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(393, 226);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(152, 53);
            this.bt_login.TabIndex = 5;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Exit.Location = new System.Drawing.Point(156, 226);
            this.bt_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(152, 53);
            this.bt_Exit.TabIndex = 6;
            this.bt_Exit.Text = "Thoát";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.bt_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Exit;
            this.ClientSize = new System.Drawing.Size(792, 320);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.radio_admin);
            this.Controls.Add(this.radio_Emp);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.RadioButton radio_Emp;
        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_Exit;
    }
}