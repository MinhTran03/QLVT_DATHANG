namespace QLVT_DATHANG.UserControls
{
   partial class frmSwitchDepartment
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.cboDepartment = new System.Windows.Forms.ComboBox();
         this.btnExit = new DevExpress.XtraEditors.SimpleButton();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.btnSwitch = new DevExpress.XtraEditors.SimpleButton();
         this.txtEmployeeName = new DevExpress.XtraEditors.TextEdit();
         this.txtEmployeeId = new DevExpress.XtraEditors.TextEdit();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::QLVT_DATHANG.UserControls.WaitFormCustom), true, true, typeof(System.Windows.Forms.UserControl));
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         this.SuspendLayout();
         // 
         // cboDepartment
         // 
         this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDepartment.FormattingEnabled = true;
         this.cboDepartment.Location = new System.Drawing.Point(107, 36);
         this.cboDepartment.Name = "cboDepartment";
         this.cboDepartment.Size = new System.Drawing.Size(306, 21);
         this.cboDepartment.TabIndex = 1;
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(212, 61);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(201, 22);
         this.btnExit.StyleController = this.layoutControl1;
         this.btnExit.TabIndex = 2;
         this.btnExit.Text = "Thoát";
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.btnExit);
         this.layoutControl1.Controls.Add(this.btnSwitch);
         this.layoutControl1.Controls.Add(this.txtEmployeeName);
         this.layoutControl1.Controls.Add(this.cboDepartment);
         this.layoutControl1.Controls.Add(this.txtEmployeeId);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.layoutControl1.Location = new System.Drawing.Point(0, 0);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.Root = this.Root;
         this.layoutControl1.Size = new System.Drawing.Size(425, 96);
         this.layoutControl1.TabIndex = 6;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // btnSwitch
         // 
         this.btnSwitch.Location = new System.Drawing.Point(12, 61);
         this.btnSwitch.Name = "btnSwitch";
         this.btnSwitch.Size = new System.Drawing.Size(196, 22);
         this.btnSwitch.StyleController = this.layoutControl1;
         this.btnSwitch.TabIndex = 3;
         this.btnSwitch.Text = "Chuyển";
         this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
         // 
         // txtEmployeeName
         // 
         this.txtEmployeeName.Location = new System.Drawing.Point(257, 12);
         this.txtEmployeeName.Name = "txtEmployeeName";
         this.txtEmployeeName.Size = new System.Drawing.Size(156, 20);
         this.txtEmployeeName.StyleController = this.layoutControl1;
         this.txtEmployeeName.TabIndex = 5;
         // 
         // txtEmployeeId
         // 
         this.txtEmployeeId.Location = new System.Drawing.Point(107, 12);
         this.txtEmployeeId.Name = "txtEmployeeId";
         this.txtEmployeeId.Size = new System.Drawing.Size(51, 20);
         this.txtEmployeeId.StyleController = this.layoutControl1;
         this.txtEmployeeId.TabIndex = 4;
         // 
         // Root
         // 
         this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.Root.GroupBordersVisible = false;
         this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2});
         this.Root.Name = "Root";
         this.Root.Size = new System.Drawing.Size(425, 96);
         this.Root.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.txtEmployeeId;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(150, 24);
         this.layoutControlItem1.Text = "Mã nhân viên:";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(92, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.cboDepartment;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(405, 25);
         this.layoutControlItem3.Text = "Chi nhánh đích:";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(92, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.btnSwitch;
         this.layoutControlItem4.Location = new System.Drawing.Point(0, 49);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(200, 27);
         this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem4.TextVisible = false;
         // 
         // layoutControlItem5
         // 
         this.layoutControlItem5.Control = this.btnExit;
         this.layoutControlItem5.Location = new System.Drawing.Point(200, 49);
         this.layoutControlItem5.Name = "layoutControlItem5";
         this.layoutControlItem5.Size = new System.Drawing.Size(205, 27);
         this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem5.TextVisible = false;
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.txtEmployeeName;
         this.layoutControlItem2.Location = new System.Drawing.Point(150, 0);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(255, 24);
         this.layoutControlItem2.Text = "Họ tên nhân viên:";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
         // 
         // splashScreenManager
         // 
         this.splashScreenManager.ClosingDelay = 500;
         // 
         // frmSwitchDepartment
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.layoutControl1);
         this.Name = "frmSwitchDepartment";
         this.Size = new System.Drawing.Size(425, 96);
         this.Load += new System.EventHandler(this.SwitchDepartment_Load);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.ComboBox cboDepartment;
      private DevExpress.XtraEditors.SimpleButton btnExit;
      private DevExpress.XtraEditors.SimpleButton btnSwitch;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraEditors.TextEdit txtEmployeeName;
      private DevExpress.XtraEditors.TextEdit txtEmployeeId;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
   }
}
