
namespace QLVT_DATHANG.Forms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.cboChiNhanh = new System.Windows.Forms.ComboBox();
            this.pbHienPW = new DevExpress.XtraEditors.PictureEdit();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHienPW.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(38, 54);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(143, 20);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn chi nhánh:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 99);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(137, 20);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên đăng nhập:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(38, 146);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 20);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mật khẩu:";
            // 
            // txtTK
            // 
            this.txtTK.EditValue = "trang";
            this.errorProvider.SetIconAlignment(this.txtTK, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtTK.Location = new System.Drawing.Point(185, 96);
            this.txtTK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Properties.Appearance.Options.UseFont = true;
            this.txtTK.Size = new System.Drawing.Size(223, 24);
            this.txtTK.TabIndex = 4;
            this.txtTK.Validating += new System.ComponentModel.CancelEventHandler(this.txtTK_Validating);
            // 
            // txtMK
            // 
            this.txtMK.EditValue = "123456";
            this.errorProvider.SetIconAlignment(this.txtMK, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtMK.Location = new System.Drawing.Point(185, 143);
            this.txtMK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Properties.Appearance.Options.UseFont = true;
            this.txtMK.Properties.Appearance.Options.UseImage = true;
            this.txtMK.Size = new System.Drawing.Size(223, 24);
            this.txtMK.TabIndex = 6;
            this.txtMK.Validating += new System.ComponentModel.CancelEventHandler(this.txtMK_Validating);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Location = new System.Drawing.Point(185, 184);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 33);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // cboChiNhanh
            // 
            this.cboChiNhanh.BackColor = System.Drawing.Color.White;
            this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChiNhanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboChiNhanh.FormattingEnabled = true;
            this.cboChiNhanh.Location = new System.Drawing.Point(185, 51);
            this.cboChiNhanh.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cboChiNhanh.Name = "cboChiNhanh";
            this.cboChiNhanh.Size = new System.Drawing.Size(223, 26);
            this.cboChiNhanh.TabIndex = 2;
            this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
            // 
            // pbHienPW
            // 
            this.pbHienPW.EditValue = global::QLVT_DATHANG.Properties.Resources.icons8_show_password_16;
            this.pbHienPW.Location = new System.Drawing.Point(385, 144);
            this.pbHienPW.Name = "pbHienPW";
            this.pbHienPW.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.White;
            this.pbHienPW.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.pbHienPW.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pbHienPW.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pbHienPW.Size = new System.Drawing.Size(20, 20);
            this.pbHienPW.TabIndex = 8;
            this.pbHienPW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbHienPW_MouseDown);
            this.pbHienPW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbHienPW_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Location = new System.Drawing.Point(304, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.Appearance.BorderColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 276);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbHienPW);
            this.Controls.Add(this.cboChiNhanh);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHienPW.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.TextEdit txtTK;
      private DevExpress.XtraEditors.TextEdit txtMK;
      private DevExpress.XtraEditors.SimpleButton btnLogin;
      private System.Windows.Forms.ComboBox cboChiNhanh;
      private DevExpress.XtraEditors.PictureEdit pbHienPW;
      private DevExpress.XtraEditors.SimpleButton btnExit;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
   }
}