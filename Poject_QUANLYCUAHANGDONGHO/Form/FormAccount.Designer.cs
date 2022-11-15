
namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormAccount
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
            this.dgv_Account = new System.Windows.Forms.DataGridView();
            this.lb_timkiem = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tbEmpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_active = new System.Windows.Forms.Label();
            this.checkEnable = new System.Windows.Forms.RadioButton();
            this.checkDisable = new System.Windows.Forms.RadioButton();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Account
            // 
            this.dgv_Account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Account.Location = new System.Drawing.Point(381, 58);
            this.dgv_Account.Name = "dgv_Account";
            this.dgv_Account.ReadOnly = true;
            this.dgv_Account.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Account.Size = new System.Drawing.Size(476, 433);
            this.dgv_Account.TabIndex = 1;
            this.dgv_Account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Account_CellClick);
            // 
            // lb_timkiem
            // 
            this.lb_timkiem.AutoSize = true;
            this.lb_timkiem.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timkiem.Location = new System.Drawing.Point(381, 15);
            this.lb_timkiem.Name = "lb_timkiem";
            this.lb_timkiem.Size = new System.Drawing.Size(145, 23);
            this.lb_timkiem.TabIndex = 2;
            this.lb_timkiem.Text = "Tìm số điện thoại:";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(532, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(299, 31);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Calibri", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(79, 43);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(188, 45);
            this.lb_title.TabIndex = 4;
            this.lb_title.Text = "TÀI KHOẢN";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(12, 124);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(94, 23);
            this.lb_Username.TabIndex = 5;
            this.lb_Username.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(168, 121);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(187, 31);
            this.tbUsername.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(168, 168);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(187, 31);
            this.tbPassword.TabIndex = 8;
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(12, 171);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(91, 23);
            this.lb_password.TabIndex = 7;
            this.lb_password.Text = "Password:";
            // 
            // tbEmpName
            // 
            this.tbEmpName.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmpName.Location = new System.Drawing.Point(168, 219);
            this.tbEmpName.Name = "tbEmpName";
            this.tbEmpName.ReadOnly = true;
            this.tbEmpName.Size = new System.Drawing.Size(187, 31);
            this.tbEmpName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên nhân viên:";
            // 
            // lb_active
            // 
            this.lb_active.AutoSize = true;
            this.lb_active.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_active.Location = new System.Drawing.Point(12, 275);
            this.lb_active.Name = "lb_active";
            this.lb_active.Size = new System.Drawing.Size(175, 23);
            this.lb_active.TabIndex = 11;
            this.lb_active.Text = "Tình trạng hoạt động:";
            // 
            // checkEnable
            // 
            this.checkEnable.AutoSize = true;
            this.checkEnable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEnable.Location = new System.Drawing.Point(47, 322);
            this.checkEnable.Name = "checkEnable";
            this.checkEnable.Size = new System.Drawing.Size(122, 22);
            this.checkEnable.TabIndex = 12;
            this.checkEnable.TabStop = true;
            this.checkEnable.Text = "Đang hoạt động";
            this.checkEnable.UseVisualStyleBackColor = true;
            // 
            // checkDisable
            // 
            this.checkDisable.AutoSize = true;
            this.checkDisable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDisable.Location = new System.Drawing.Point(197, 322);
            this.checkDisable.Name = "checkDisable";
            this.checkDisable.Size = new System.Drawing.Size(132, 22);
            this.checkDisable.TabIndex = 13;
            this.checkDisable.TabStop = true;
            this.checkDisable.Text = "Ngưng hoạt động";
            this.checkDisable.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_edit.Location = new System.Drawing.Point(217, 422);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(112, 42);
            this.bt_edit.TabIndex = 14;
            this.bt_edit.Text = "Chỉnh sửa";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(35, 422);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 42);
            this.bt_cancel.TabIndex = 15;
            this.bt_cancel.Text = "Hủy bỏ";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // FormAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 503);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.checkDisable);
            this.Controls.Add(this.checkEnable);
            this.Controls.Add(this.lb_active);
            this.Controls.Add(this.tbEmpName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lb_timkiem);
            this.Controls.Add(this.dgv_Account);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAccount";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Account;
        private System.Windows.Forms.Label lb_timkiem;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tbEmpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_active;
        private System.Windows.Forms.RadioButton checkEnable;
        private System.Windows.Forms.RadioButton checkDisable;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_cancel;
    }
}