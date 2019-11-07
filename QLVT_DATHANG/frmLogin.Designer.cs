namespace QLVT_DATHANG
{
    partial class frmLogin
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
         this.grbLogin = new System.Windows.Forms.GroupBox();
         this.lblServerPM = new System.Windows.Forms.Label();
         this.btnDangNhap = new System.Windows.Forms.Button();
         this.txtMK = new System.Windows.Forms.TextBox();
         this.txtTK = new System.Windows.Forms.TextBox();
         this.cboChiNhanh = new System.Windows.Forms.ComboBox();
         this.lblMatKhau = new System.Windows.Forms.Label();
         this.lblTK = new System.Windows.Forms.Label();
         this.lblChiNhanh = new System.Windows.Forms.Label();
         this.grbLogin.SuspendLayout();
         this.SuspendLayout();
         // 
         // grbLogin
         // 
         this.grbLogin.Controls.Add(this.lblServerPM);
         this.grbLogin.Controls.Add(this.btnDangNhap);
         this.grbLogin.Controls.Add(this.txtMK);
         this.grbLogin.Controls.Add(this.txtTK);
         this.grbLogin.Controls.Add(this.cboChiNhanh);
         this.grbLogin.Controls.Add(this.lblMatKhau);
         this.grbLogin.Controls.Add(this.lblTK);
         this.grbLogin.Controls.Add(this.lblChiNhanh);
         this.grbLogin.Dock = System.Windows.Forms.DockStyle.Fill;
         this.grbLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.grbLogin.Location = new System.Drawing.Point(0, 0);
         this.grbLogin.Name = "grbLogin";
         this.grbLogin.Size = new System.Drawing.Size(462, 303);
         this.grbLogin.TabIndex = 0;
         this.grbLogin.TabStop = false;
         this.grbLogin.Text = "Login";
         // 
         // lblServerPM
         // 
         this.lblServerPM.AutoSize = true;
         this.lblServerPM.Location = new System.Drawing.Point(134, 46);
         this.lblServerPM.Name = "lblServerPM";
         this.lblServerPM.Size = new System.Drawing.Size(188, 18);
         this.lblServerPM.TabIndex = 0;
         this.lblServerPM.Text = "tên server phân mảnh";
         // 
         // btnDangNhap
         // 
         this.btnDangNhap.Location = new System.Drawing.Point(163, 221);
         this.btnDangNhap.Name = "btnDangNhap";
         this.btnDangNhap.Size = new System.Drawing.Size(137, 34);
         this.btnDangNhap.TabIndex = 7;
         this.btnDangNhap.Text = "Đăng nhập";
         this.btnDangNhap.UseVisualStyleBackColor = true;
         this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
         // 
         // txtMK
         // 
         this.txtMK.Location = new System.Drawing.Point(137, 170);
         this.txtMK.Name = "txtMK";
         this.txtMK.Size = new System.Drawing.Size(292, 27);
         this.txtMK.TabIndex = 6;
         this.txtMK.Text = "123456";
         // 
         // txtTK
         // 
         this.txtTK.Location = new System.Drawing.Point(137, 118);
         this.txtTK.Name = "txtTK";
         this.txtTK.Size = new System.Drawing.Size(292, 27);
         this.txtTK.TabIndex = 4;
         this.txtTK.Text = "ltrang";
         // 
         // cboChiNhanh
         // 
         this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboChiNhanh.FormattingEnabled = true;
         this.cboChiNhanh.Location = new System.Drawing.Point(137, 67);
         this.cboChiNhanh.Name = "cboChiNhanh";
         this.cboChiNhanh.Size = new System.Drawing.Size(292, 26);
         this.cboChiNhanh.TabIndex = 2;
         this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
         // 
         // lblMatKhau
         // 
         this.lblMatKhau.AutoSize = true;
         this.lblMatKhau.Location = new System.Drawing.Point(34, 173);
         this.lblMatKhau.Name = "lblMatKhau";
         this.lblMatKhau.Size = new System.Drawing.Size(90, 18);
         this.lblMatKhau.TabIndex = 5;
         this.lblMatKhau.Text = "Mật khẩu:";
         // 
         // lblTK
         // 
         this.lblTK.AutoSize = true;
         this.lblTK.Location = new System.Drawing.Point(34, 121);
         this.lblTK.Name = "lblTK";
         this.lblTK.Size = new System.Drawing.Size(95, 18);
         this.lblTK.TabIndex = 3;
         this.lblTK.Text = "Tài khoản:";
         // 
         // lblChiNhanh
         // 
         this.lblChiNhanh.AutoSize = true;
         this.lblChiNhanh.Location = new System.Drawing.Point(34, 70);
         this.lblChiNhanh.Name = "lblChiNhanh";
         this.lblChiNhanh.Size = new System.Drawing.Size(97, 18);
         this.lblChiNhanh.TabIndex = 1;
         this.lblChiNhanh.Text = "Chi nhánh:";
         // 
         // frmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(462, 303);
         this.Controls.Add(this.grbLogin);
         this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.MaximizeBox = false;
         this.Name = "frmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.frmLogin_Load);
         this.grbLogin.ResumeLayout(false);
         this.grbLogin.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLogin;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.ComboBox cboChiNhanh;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Label lblChiNhanh;
        private System.Windows.Forms.Label lblServerPM;
    }
}