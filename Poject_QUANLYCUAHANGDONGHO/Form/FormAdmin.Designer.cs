
namespace Project_QUANLYCUAHANGDONGHO
{
    partial class FormAdmin
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
            this.tabcontrolAdmin = new System.Windows.Forms.TabControl();
            this.tab_Order = new System.Windows.Forms.TabPage();
            this.tab_Emp = new System.Windows.Forms.TabPage();
            this.tab_Account = new System.Windows.Forms.TabPage();
            this.tabcontrolAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrolAdmin
            // 
            this.tabcontrolAdmin.Controls.Add(this.tab_Order);
            this.tabcontrolAdmin.Controls.Add(this.tab_Emp);
            this.tabcontrolAdmin.Controls.Add(this.tab_Account);
            this.tabcontrolAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabcontrolAdmin.Name = "tabcontrolAdmin";
            this.tabcontrolAdmin.SelectedIndex = 0;
            this.tabcontrolAdmin.Size = new System.Drawing.Size(661, 476);
            this.tabcontrolAdmin.TabIndex = 0;
            // 
            // tab_Order
            // 
            this.tab_Order.Location = new System.Drawing.Point(4, 22);
            this.tab_Order.Name = "tab_Order";
            this.tab_Order.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Order.Size = new System.Drawing.Size(653, 450);
            this.tab_Order.TabIndex = 0;
            this.tab_Order.Text = "Doanh thu";
            this.tab_Order.UseVisualStyleBackColor = true;
            // 
            // tab_Emp
            // 
            this.tab_Emp.Location = new System.Drawing.Point(4, 22);
            this.tab_Emp.Name = "tab_Emp";
            this.tab_Emp.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Emp.Size = new System.Drawing.Size(653, 450);
            this.tab_Emp.TabIndex = 1;
            this.tab_Emp.Text = "Nhân viên";
            this.tab_Emp.UseVisualStyleBackColor = true;
            // 
            // tab_Account
            // 
            this.tab_Account.Location = new System.Drawing.Point(4, 22);
            this.tab_Account.Name = "tab_Account";
            this.tab_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Account.Size = new System.Drawing.Size(653, 450);
            this.tab_Account.TabIndex = 2;
            this.tab_Account.Text = "Tài khoản";
            this.tab_Account.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 500);
            this.Controls.Add(this.tabcontrolAdmin);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.tabcontrolAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrolAdmin;
        private System.Windows.Forms.TabPage tab_Order;
        private System.Windows.Forms.TabPage tab_Emp;
        private System.Windows.Forms.TabPage tab_Account;
    }
}