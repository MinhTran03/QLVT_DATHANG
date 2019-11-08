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
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
         this.txtTK = new DevExpress.XtraEditors.TextEdit();
         this.txtMK = new DevExpress.XtraEditors.TextEdit();
         this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
         this.lblServerPM = new DevExpress.XtraEditors.LabelControl();
         this.cboChiNhanh = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.Location = new System.Drawing.Point(38, 58);
         this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(108, 16);
         this.labelControl1.TabIndex = 8;
         this.labelControl1.Text = "Chọn chi nhánh:";
         // 
         // labelControl2
         // 
         this.labelControl2.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl2.Appearance.Options.UseFont = true;
         this.labelControl2.Location = new System.Drawing.Point(38, 103);
         this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(105, 16);
         this.labelControl2.TabIndex = 9;
         this.labelControl2.Text = "Tên đăng nhập:";
         // 
         // labelControl3
         // 
         this.labelControl3.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl3.Appearance.Options.UseFont = true;
         this.labelControl3.Location = new System.Drawing.Point(38, 150);
         this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.labelControl3.Name = "labelControl3";
         this.labelControl3.Size = new System.Drawing.Size(61, 16);
         this.labelControl3.TabIndex = 10;
         this.labelControl3.Text = "Mật khẩu";
         // 
         // txtTK
         // 
         this.txtTK.EditValue = "ltrang";
         this.txtTK.Location = new System.Drawing.Point(150, 100);
         this.txtTK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.txtTK.Name = "txtTK";
         this.txtTK.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtTK.Properties.Appearance.Options.UseFont = true;
         this.txtTK.Size = new System.Drawing.Size(190, 22);
         this.txtTK.TabIndex = 12;
         // 
         // txtMK
         // 
         this.txtMK.EditValue = "123456";
         this.txtMK.Location = new System.Drawing.Point(150, 147);
         this.txtMK.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.txtMK.Name = "txtMK";
         this.txtMK.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMK.Properties.Appearance.Options.UseFont = true;
         this.txtMK.Properties.Appearance.Options.UseImage = true;
         this.txtMK.Size = new System.Drawing.Size(190, 22);
         this.txtMK.TabIndex = 13;
         // 
         // btnLogin
         // 
         this.btnLogin.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogin.Appearance.Options.UseFont = true;
         this.btnLogin.Location = new System.Drawing.Point(149, 188);
         this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(111, 23);
         this.btnLogin.TabIndex = 14;
         this.btnLogin.Text = "Đăng Nhập";
         this.btnLogin.Click += new System.EventHandler(this.btnDangNhap_Click);
         // 
         // lblServerPM
         // 
         this.lblServerPM.Appearance.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblServerPM.Appearance.Options.UseFont = true;
         this.lblServerPM.Location = new System.Drawing.Point(150, 31);
         this.lblServerPM.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.lblServerPM.Name = "lblServerPM";
         this.lblServerPM.Size = new System.Drawing.Size(142, 16);
         this.lblServerPM.TabIndex = 15;
         this.lblServerPM.Text = "tên server đăng nhập";
         // 
         // cboChiNhanh
         // 
         this.cboChiNhanh.BackColor = System.Drawing.Color.White;
         this.cboChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboChiNhanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboChiNhanh.FormattingEnabled = true;
         this.cboChiNhanh.Location = new System.Drawing.Point(150, 55);
         this.cboChiNhanh.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
         this.cboChiNhanh.Name = "cboChiNhanh";
         this.cboChiNhanh.Size = new System.Drawing.Size(189, 24);
         this.cboChiNhanh.TabIndex = 16;
         this.cboChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cboChiNhanh_SelectedIndexChanged);
         // 
         // frmLogin
         // 
         this.Appearance.BorderColor = System.Drawing.Color.Gray;
         this.Appearance.Options.UseBorderColor = true;
         this.Appearance.Options.UseFont = true;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(409, 240);
         this.Controls.Add(this.cboChiNhanh);
         this.Controls.Add(this.lblServerPM);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.txtMK);
         this.Controls.Add(this.txtTK);
         this.Controls.Add(this.labelControl3);
         this.Controls.Add(this.labelControl2);
         this.Controls.Add(this.labelControl1);
         this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
         this.MaximizeBox = false;
         this.Name = "frmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.Load += new System.EventHandler(this.frmLogin_Load);
         ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
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
      private DevExpress.XtraEditors.LabelControl lblServerPM;
      private System.Windows.Forms.ComboBox cboChiNhanh;
   }
}