namespace QLVT_DATHANG.UserControls
{
   partial class frmRegister
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
            this.lcRegister = new DevExpress.XtraLayout.LayoutControl();
            this.slkEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radCongTy = new System.Windows.Forms.RadioButton();
            this.radChiNhanh = new System.Windows.Forms.RadioButton();
            this.radUser = new System.Windows.Forms.RadioButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.txtEmpoyeeId = new DevExpress.XtraEditors.TextEdit();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtLoginName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.errorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.lcRegister)).BeginInit();
            this.lcRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slkEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpoyeeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lcRegister
            // 
            this.lcRegister.Controls.Add(this.slkEmployee);
            this.lcRegister.Controls.Add(this.radCongTy);
            this.lcRegister.Controls.Add(this.radChiNhanh);
            this.lcRegister.Controls.Add(this.radUser);
            this.lcRegister.Controls.Add(this.btnExit);
            this.lcRegister.Controls.Add(this.btnRegister);
            this.lcRegister.Controls.Add(this.txtEmpoyeeId);
            this.lcRegister.Controls.Add(this.txtConfirmPassword);
            this.lcRegister.Controls.Add(this.txtPassword);
            this.lcRegister.Controls.Add(this.txtLoginName);
            this.lcRegister.Controls.Add(this.pictureEdit1);
            this.lcRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcRegister.Location = new System.Drawing.Point(0, 0);
            this.lcRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lcRegister.Name = "lcRegister";
            this.lcRegister.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(630, 175, 650, 400);
            this.lcRegister.Root = this.Root;
            this.lcRegister.Size = new System.Drawing.Size(393, 598);
            this.lcRegister.TabIndex = 0;
            this.lcRegister.Text = "layoutControl1";
            // 
            // slkEmployee
            // 
            this.slkEmployee.EditValue = "...";
            this.slkEmployee.Location = new System.Drawing.Point(238, 489);
            this.slkEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.slkEmployee.Name = "slkEmployee";
            this.slkEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkEmployee.Properties.DataSource = this.bdsDSNV;
            this.slkEmployee.Properties.DisplayMember = "HOTEN";
            this.slkEmployee.Properties.PopupView = this.searchLookUpEdit1View;
            this.slkEmployee.Properties.ValueMember = "MANV";
            this.slkEmployee.Size = new System.Drawing.Size(139, 22);
            this.slkEmployee.StyleController = this.lcRegister;
            this.slkEmployee.TabIndex = 13;
            this.slkEmployee.EditValueChanged += new System.EventHandler(this.slkEmployee_EditValueChanged);
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // radCongTy
            // 
            this.radCongTy.Enabled = false;
            this.radCongTy.Location = new System.Drawing.Point(16, 517);
            this.radCongTy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radCongTy.Name = "radCongTy";
            this.radCongTy.Size = new System.Drawing.Size(113, 32);
            this.radCongTy.TabIndex = 12;
            this.radCongTy.TabStop = true;
            this.radCongTy.Text = "Công Ty";
            this.radCongTy.UseVisualStyleBackColor = true;
            // 
            // radChiNhanh
            // 
            this.radChiNhanh.Enabled = false;
            this.radChiNhanh.Location = new System.Drawing.Point(135, 517);
            this.radChiNhanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radChiNhanh.Name = "radChiNhanh";
            this.radChiNhanh.Size = new System.Drawing.Size(134, 31);
            this.radChiNhanh.TabIndex = 11;
            this.radChiNhanh.TabStop = true;
            this.radChiNhanh.Text = "Chi Nhánh";
            this.radChiNhanh.UseVisualStyleBackColor = true;
            // 
            // radUser
            // 
            this.radUser.Enabled = false;
            this.radUser.Location = new System.Drawing.Point(275, 517);
            this.radUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radUser.Name = "radUser";
            this.radUser.Size = new System.Drawing.Size(102, 31);
            this.radUser.TabIndex = 10;
            this.radUser.TabStop = true;
            this.radUser.Text = "User";
            this.radUser.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(198, 555);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 27);
            this.btnExit.StyleController = this.lcRegister;
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(16, 555);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(176, 27);
            this.btnRegister.StyleController = this.lcRegister;
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Đăng Ký";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmpoyeeId
            // 
            this.txtEmpoyeeId.EditValue = "";
            this.txtEmpoyeeId.Enabled = false;
            this.errorProvider.SetIconAlignment(this.txtEmpoyeeId, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtEmpoyeeId.Location = new System.Drawing.Point(134, 489);
            this.txtEmpoyeeId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpoyeeId.Name = "txtEmpoyeeId";
            this.txtEmpoyeeId.Properties.Appearance.Options.UseBorderColor = true;
            this.txtEmpoyeeId.Properties.Mask.BeepOnError = true;
            this.txtEmpoyeeId.Properties.Mask.EditMask = "[0-9]+";
            this.txtEmpoyeeId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEmpoyeeId.Size = new System.Drawing.Size(98, 22);
            this.txtEmpoyeeId.StyleController = this.lcRegister;
            this.txtEmpoyeeId.TabIndex = 4;
            // 
            // txtConfirmPassword
            // 
            this.errorProvider.SetIconAlignment(this.txtConfirmPassword, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtConfirmPassword.Location = new System.Drawing.Point(134, 461);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtConfirmPassword.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(243, 22);
            this.txtConfirmPassword.StyleController = this.lcRegister;
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Leave += new System.EventHandler(this.textbox_Leave);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNotNull_Validating);
            // 
            // txtPassword
            // 
            this.errorProvider.SetIconAlignment(this.txtPassword, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtPassword.Location = new System.Drawing.Point(134, 433);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Options.UseBorderColor = true;
            this.txtPassword.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtPassword.Size = new System.Drawing.Size(243, 22);
            this.txtPassword.StyleController = this.lcRegister;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Leave += new System.EventHandler(this.textbox_Leave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNotNull_Validating);
            // 
            // txtLoginName
            // 
            this.errorProvider.SetIconAlignment(this.txtLoginName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtLoginName.Location = new System.Drawing.Point(134, 405);
            this.txtLoginName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.txtLoginName.Properties.Appearance.Options.UseBorderColor = true;
            this.txtLoginName.Properties.AppearanceFocused.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLoginName.Properties.AppearanceFocused.Options.UseBorderColor = true;
            this.txtLoginName.Properties.ShowNullValuePromptWhenFocused = true;
            this.txtLoginName.Size = new System.Drawing.Size(243, 22);
            this.txtLoginName.StyleController = this.lcRegister;
            this.txtLoginName.TabIndex = 1;
            this.txtLoginName.Leave += new System.EventHandler(this.textbox_Leave);
            this.txtLoginName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNotNull_Validating);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::QLVT_DATHANG.Properties.Resources._164_9_register_icon_iconbunny_removebg;
            this.pictureEdit1.Location = new System.Drawing.Point(16, 16);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(361, 383);
            this.pictureEdit1.StyleController = this.lcRegister;
            this.pictureEdit1.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem11});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(393, 598);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(367, 389);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtLoginName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 389);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem2.Text = "Tên đăng nhập:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(114, 17);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtPassword;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 417);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem3.Text = "Mật khẩu:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(114, 17);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtConfirmPassword;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 445);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(367, 28);
            this.layoutControlItem4.Text = "Nhập lại mật khẩu:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(114, 17);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtEmpoyeeId;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 473);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(222, 28);
            this.layoutControlItem5.Text = "Mã nhân viên:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(114, 16);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnRegister;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 539);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(182, 33);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnExit;
            this.layoutControlItem9.Location = new System.Drawing.Point(182, 539);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(185, 33);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.radChiNhanh;
            this.layoutControlItem8.Location = new System.Drawing.Point(119, 501);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(140, 38);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.radUser;
            this.layoutControlItem7.Location = new System.Drawing.Point(259, 501);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(108, 38);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.radCongTy;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 501);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(31, 38);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(119, 38);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.slkEmployee;
            this.layoutControlItem11.Location = new System.Drawing.Point(222, 473);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(145, 28);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // taDSNV
            // 
            this.taDSNV.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // frmRegister
            // 
            this.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lcRegister);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegister";
            this.Size = new System.Drawing.Size(393, 598);
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lcRegister)).EndInit();
            this.lcRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slkEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpoyeeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraLayout.LayoutControl lcRegister;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraEditors.SimpleButton btnRegister;
      private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
      private DevExpress.XtraEditors.TextEdit txtPassword;
      private DevExpress.XtraEditors.TextEdit txtLoginName;
      private DevExpress.XtraEditors.PictureEdit pictureEdit1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
      private DevExpress.XtraEditors.SimpleButton btnExit;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider errorProvider;
      private System.Windows.Forms.RadioButton radChiNhanh;
      private System.Windows.Forms.RadioButton radUser;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
      private System.Windows.Forms.RadioButton radCongTy;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
      private DevExpress.XtraEditors.TextEdit txtEmpoyeeId;
      private DataSet dataSet;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private DevExpress.XtraEditors.SearchLookUpEdit slkEmployee;
      private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
   }
}