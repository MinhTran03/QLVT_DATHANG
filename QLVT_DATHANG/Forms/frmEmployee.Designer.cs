namespace QLVT_DATHANG.Forms
{
   partial class frmEmployee
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
         this.bmNV = new DevExpress.XtraBars.BarManager(this.components);
         this.barNV = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnDel = new DevExpress.XtraBars.BarButtonItem();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
         this.btnSwitchDepartment = new DevExpress.XtraBars.BarButtonItem();
         this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
         this.taNV = new QLVT_DATHANG.DataSetTableAdapters.NhanVienTableAdapter();
         this.txtEmpDepartment = new DevExpress.XtraEditors.TextEdit();
         this.lcEmplyee = new DevExpress.XtraLayout.LayoutControl();
         this.txtEmpAddr = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpDelStatus = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpId = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpFirstName = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpLastName = new DevExpress.XtraEditors.TextEdit();
         this.dtpEmpBirth = new DevExpress.XtraEditors.DateEdit();
         this.spiEmpSalary = new DevExpress.XtraEditors.SpinEdit();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
         this.gvNV = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gcEmployee = new DevExpress.XtraGrid.GridControl();
         this.cmsEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.btnCreateLogin = new System.Windows.Forms.ToolStripMenuItem();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
         this.taPX = new QLVT_DATHANG.DataSetTableAdapters.PhieuXuatTableAdapter();
         this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
         this.taPN = new QLVT_DATHANG.DataSetTableAdapters.PhieuNhapTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.gbEmployee = new DevExpress.XtraEditors.GroupControl();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
         this.taDH = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
         this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
         this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
         ((System.ComponentModel.ISupportInitialize)(this.bmNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lcEmplyee)).BeginInit();
         this.lcEmplyee.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpAddr.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDelStatus.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpFirstName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpLastName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiEmpSalary.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
         this.cmsEmployee.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbEmployee)).BeginInit();
         this.gbEmployee.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
         this.SuspendLayout();
         // 
         // bmNV
         // 
         this.bmNV.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barNV});
         this.bmNV.DockControls.Add(this.barDockControlTop);
         this.bmNV.DockControls.Add(this.barDockControlBottom);
         this.bmNV.DockControls.Add(this.barDockControlLeft);
         this.bmNV.DockControls.Add(this.barDockControlRight);
         this.bmNV.Form = this;
         this.bmNV.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDel,
            this.btnEdit,
            this.btnSave,
            this.btnUndo,
            this.btnRefresh,
            this.btnExit,
            this.btnCancelEdit,
            this.btnSwitchDepartment});
         this.bmNV.MainMenu = this.barNV;
         this.bmNV.MaxItemId = 29;
         // 
         // barNV
         // 
         this.barNV.BarName = "Main menu";
         this.barNV.DockCol = 0;
         this.barNV.DockRow = 0;
         this.barNV.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.barNV.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSwitchDepartment),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
         this.barNV.OptionsBar.MultiLine = true;
         this.barNV.OptionsBar.UseWholeRow = true;
         this.barNV.Text = "Main menu";
         // 
         // btnAdd
         // 
         this.btnAdd.Caption = "THÊM";
         this.btnAdd.Id = 0;
         this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
         // 
         // btnEdit
         // 
         this.btnEdit.Caption = "SỬA";
         this.btnEdit.Id = 2;
         this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
         this.btnEdit.Name = "btnEdit";
         this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
         // 
         // btnDel
         // 
         this.btnDel.Caption = "XÓA";
         this.btnDel.Id = 1;
         this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
         this.btnDel.Name = "btnDel";
         this.btnDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
         // 
         // btnUndo
         // 
         this.btnUndo.Caption = "PHỤC HỒI";
         this.btnUndo.Enabled = false;
         this.btnUndo.Id = 4;
         this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
         // 
         // btnSwitchDepartment
         // 
         this.btnSwitchDepartment.Caption = "CHUYỂN CHI NHÁNH";
         this.btnSwitchDepartment.Id = 28;
         this.btnSwitchDepartment.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_switch_16;
         this.btnSwitchDepartment.Name = "btnSwitchDepartment";
         this.btnSwitchDepartment.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnSwitchDepartment.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSwitchDepartment_ItemClick);
         // 
         // btnRefresh
         // 
         this.btnRefresh.Caption = "LÀM MỚI";
         this.btnRefresh.Id = 5;
         this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
         // 
         // btnSave
         // 
         this.btnSave.Caption = "GHI";
         this.btnSave.Enabled = false;
         this.btnSave.Id = 3;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Enabled = false;
         this.btnCancelEdit.Id = 9;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelEdit_ItemClick);
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 7;
         this.btnExit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.btnExit.Name = "btnExit";
         this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.bmNV;
         this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlTop.Size = new System.Drawing.Size(984, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 444);
         this.barDockControlBottom.Manager = this.bmNV;
         this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlBottom.Size = new System.Drawing.Size(984, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmNV;
         this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 420);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(984, 24);
         this.barDockControlRight.Manager = this.bmNV;
         this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlRight.Size = new System.Drawing.Size(0, 420);
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.Locale = new System.Globalization.CultureInfo("en-US");
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bdsNV
         // 
         this.bdsNV.DataMember = "NhanVien";
         this.bdsNV.DataSource = this.dataSet;
         // 
         // taNV
         // 
         this.taNV.ClearBeforeFill = true;
         // 
         // txtEmpDepartment
         // 
         this.txtEmpDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
         this.txtEmpDepartment.EditValue = "";
         this.txtEmpDepartment.Location = new System.Drawing.Point(91, 90);
         this.txtEmpDepartment.MenuManager = this.bmNV;
         this.txtEmpDepartment.Name = "txtEmpDepartment";
         this.txtEmpDepartment.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpDepartment.Properties.Appearance.Options.UseFont = true;
         this.txtEmpDepartment.Size = new System.Drawing.Size(168, 22);
         this.txtEmpDepartment.StyleController = this.lcEmplyee;
         this.txtEmpDepartment.TabIndex = 13;
         // 
         // lcEmplyee
         // 
         this.lcEmplyee.Controls.Add(this.txtEmpAddr);
         this.lcEmplyee.Controls.Add(this.txtEmpDelStatus);
         this.lcEmplyee.Controls.Add(this.txtEmpDepartment);
         this.lcEmplyee.Controls.Add(this.txtEmpId);
         this.lcEmplyee.Controls.Add(this.txtEmpFirstName);
         this.lcEmplyee.Controls.Add(this.txtEmpLastName);
         this.lcEmplyee.Controls.Add(this.dtpEmpBirth);
         this.lcEmplyee.Controls.Add(this.spiEmpSalary);
         this.lcEmplyee.Dock = System.Windows.Forms.DockStyle.Left;
         this.lcEmplyee.Location = new System.Drawing.Point(2, 20);
         this.lcEmplyee.Name = "lcEmplyee";
         this.lcEmplyee.Root = this.Root;
         this.lcEmplyee.Size = new System.Drawing.Size(688, 125);
         this.lcEmplyee.TabIndex = 17;
         this.lcEmplyee.Text = "layoutControl1";
         // 
         // txtEmpAddr
         // 
         this.txtEmpAddr.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
         this.txtEmpAddr.EditValue = "";
         this.dxErrorProvider.SetIconAlignment(this.txtEmpAddr, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.txtEmpAddr.Location = new System.Drawing.Point(91, 64);
         this.txtEmpAddr.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpAddr.MenuManager = this.bmNV;
         this.txtEmpAddr.Name = "txtEmpAddr";
         this.txtEmpAddr.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpAddr.Properties.Appearance.Options.UseFont = true;
         this.txtEmpAddr.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpAddr.Size = new System.Drawing.Size(585, 22);
         this.txtEmpAddr.StyleController = this.lcEmplyee;
         this.txtEmpAddr.TabIndex = 11;
         // 
         // txtEmpDelStatus
         // 
         this.txtEmpDelStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TrangThaiXoa", true));
         this.txtEmpDelStatus.Location = new System.Drawing.Point(342, 90);
         this.txtEmpDelStatus.MenuManager = this.bmNV;
         this.txtEmpDelStatus.Name = "txtEmpDelStatus";
         this.txtEmpDelStatus.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpDelStatus.Properties.Appearance.Options.UseFont = true;
         this.txtEmpDelStatus.Size = new System.Drawing.Size(334, 22);
         this.txtEmpDelStatus.StyleController = this.lcEmplyee;
         this.txtEmpDelStatus.TabIndex = 15;
         // 
         // txtEmpId
         // 
         this.txtEmpId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
         this.txtEmpId.EditValue = "";
         this.dxErrorProvider.SetIconAlignment(this.txtEmpId, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.txtEmpId.Location = new System.Drawing.Point(91, 12);
         this.txtEmpId.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpId.MenuManager = this.bmNV;
         this.txtEmpId.Name = "txtEmpId";
         this.txtEmpId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
         this.txtEmpId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpId.Properties.Appearance.Options.UseFont = true;
         this.txtEmpId.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
         this.txtEmpId.Properties.Mask.ShowPlaceHolders = false;
         this.txtEmpId.Size = new System.Drawing.Size(168, 22);
         this.txtEmpId.StyleController = this.lcEmplyee;
         this.txtEmpId.TabIndex = 1;
         // 
         // txtEmpFirstName
         // 
         this.txtEmpFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
         this.txtEmpFirstName.EditValue = "";
         this.dxErrorProvider.SetIconAlignment(this.txtEmpFirstName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.txtEmpFirstName.Location = new System.Drawing.Point(342, 12);
         this.txtEmpFirstName.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpFirstName.MenuManager = this.bmNV;
         this.txtEmpFirstName.Name = "txtEmpFirstName";
         this.txtEmpFirstName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
         this.txtEmpFirstName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpFirstName.Properties.Appearance.Options.UseFont = true;
         this.txtEmpFirstName.Properties.Mask.EditMask = "[\\u0000-\\u001F\\007F-\\u009F]+(\\\\s{1}[\\u0000-\\u001F\\007F-\\u009F]+)*";
         this.txtEmpFirstName.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpFirstName.Properties.Mask.ShowPlaceHolders = false;
         this.txtEmpFirstName.Size = new System.Drawing.Size(120, 22);
         this.txtEmpFirstName.StyleController = this.lcEmplyee;
         this.txtEmpFirstName.TabIndex = 3;
         this.txtEmpFirstName.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.txtEmpFirstName_CustomDisplayText);
         // 
         // txtEmpLastName
         // 
         this.txtEmpLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
         this.txtEmpLastName.EditValue = "";
         this.dxErrorProvider.SetIconAlignment(this.txtEmpLastName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.txtEmpLastName.Location = new System.Drawing.Point(545, 12);
         this.txtEmpLastName.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpLastName.MenuManager = this.bmNV;
         this.txtEmpLastName.Name = "txtEmpLastName";
         this.txtEmpLastName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpLastName.Properties.Appearance.Options.UseFont = true;
         this.txtEmpLastName.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpLastName.Properties.Mask.ShowPlaceHolders = false;
         this.txtEmpLastName.Size = new System.Drawing.Size(131, 22);
         this.txtEmpLastName.StyleController = this.lcEmplyee;
         this.txtEmpLastName.TabIndex = 5;
         this.txtEmpLastName.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.txtEmpLastName_CustomDisplayText);
         // 
         // dtpEmpBirth
         // 
         this.dtpEmpBirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
         this.dtpEmpBirth.EditValue = new System.DateTime(2019, 11, 23, 16, 47, 55, 0);
         this.dxErrorProvider.SetIconAlignment(this.dtpEmpBirth, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.dtpEmpBirth.Location = new System.Drawing.Point(91, 38);
         this.dtpEmpBirth.Margin = new System.Windows.Forms.Padding(4);
         this.dtpEmpBirth.MenuManager = this.bmNV;
         this.dtpEmpBirth.Name = "dtpEmpBirth";
         this.dtpEmpBirth.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtpEmpBirth.Properties.Appearance.Options.UseFont = true;
         this.dtpEmpBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpEmpBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpEmpBirth.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.dtpEmpBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpEmpBirth.Properties.EditFormat.FormatString = "dd/MM/yyyy";
         this.dtpEmpBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpEmpBirth.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
         this.dtpEmpBirth.Properties.Mask.EditMask = "dd/MM/yyyy";
         this.dtpEmpBirth.Properties.Mask.IgnoreMaskBlank = false;
         this.dtpEmpBirth.Properties.Mask.ShowPlaceHolders = false;
         this.dtpEmpBirth.Properties.MaxValue = new System.DateTime(2019, 10, 28, 0, 0, 0, 0);
         this.dtpEmpBirth.Size = new System.Drawing.Size(168, 22);
         this.dtpEmpBirth.StyleController = this.lcEmplyee;
         this.dtpEmpBirth.TabIndex = 7;
         // 
         // spiEmpSalary
         // 
         this.spiEmpSalary.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "LUONG", true));
         this.spiEmpSalary.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.dxErrorProvider.SetIconAlignment(this.spiEmpSalary, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.spiEmpSalary.Location = new System.Drawing.Point(342, 38);
         this.spiEmpSalary.Margin = new System.Windows.Forms.Padding(4);
         this.spiEmpSalary.MenuManager = this.bmNV;
         this.spiEmpSalary.Name = "spiEmpSalary";
         this.spiEmpSalary.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.spiEmpSalary.Properties.Appearance.Options.UseFont = true;
         this.spiEmpSalary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spiEmpSalary.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
         this.spiEmpSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
         this.spiEmpSalary.Size = new System.Drawing.Size(334, 22);
         this.spiEmpSalary.StyleController = this.lcEmplyee;
         this.spiEmpSalary.TabIndex = 9;
         this.spiEmpSalary.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.spiEmpSalary_CustomDisplayText);
         // 
         // Root
         // 
         this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.Root.GroupBordersVisible = false;
         this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
         this.Root.Name = "Root";
         this.Root.Size = new System.Drawing.Size(688, 125);
         this.Root.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.txtEmpId;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(251, 26);
         this.layoutControlItem1.Text = "Mã nhân viên:";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.txtEmpFirstName;
         this.layoutControlItem2.Location = new System.Drawing.Point(251, 0);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(203, 26);
         this.layoutControlItem2.Text = "Họ:";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.txtEmpLastName;
         this.layoutControlItem3.Location = new System.Drawing.Point(454, 0);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(214, 26);
         this.layoutControlItem3.Text = "Tên:";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem5
         // 
         this.layoutControlItem5.Control = this.spiEmpSalary;
         this.layoutControlItem5.Location = new System.Drawing.Point(251, 26);
         this.layoutControlItem5.Name = "layoutControlItem5";
         this.layoutControlItem5.Size = new System.Drawing.Size(417, 26);
         this.layoutControlItem5.Text = "Lương:";
         this.layoutControlItem5.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.dtpEmpBirth;
         this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(251, 26);
         this.layoutControlItem4.Text = "Ngày sinh:";
         this.layoutControlItem4.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem6
         // 
         this.layoutControlItem6.Control = this.txtEmpDepartment;
         this.layoutControlItem6.Location = new System.Drawing.Point(0, 78);
         this.layoutControlItem6.Name = "layoutControlItem6";
         this.layoutControlItem6.Size = new System.Drawing.Size(251, 27);
         this.layoutControlItem6.Text = "Mã chi nhánh:";
         this.layoutControlItem6.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem7
         // 
         this.layoutControlItem7.Control = this.txtEmpDelStatus;
         this.layoutControlItem7.Location = new System.Drawing.Point(251, 78);
         this.layoutControlItem7.Name = "layoutControlItem7";
         this.layoutControlItem7.Size = new System.Drawing.Size(417, 27);
         this.layoutControlItem7.Text = "Trạng thái xóa:";
         this.layoutControlItem7.TextSize = new System.Drawing.Size(76, 13);
         // 
         // layoutControlItem8
         // 
         this.layoutControlItem8.Control = this.txtEmpAddr;
         this.layoutControlItem8.Location = new System.Drawing.Point(0, 52);
         this.layoutControlItem8.Name = "layoutControlItem8";
         this.layoutControlItem8.Size = new System.Drawing.Size(668, 26);
         this.layoutControlItem8.Text = "Địa chỉ:";
         this.layoutControlItem8.TextSize = new System.Drawing.Size(76, 13);
         // 
         // gvNV
         // 
         this.gvNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
         this.gvNV.DetailHeight = 404;
         this.gvNV.GridControl = this.gcEmployee;
         this.gvNV.Name = "gvNV";
         this.gvNV.OptionsBehavior.Editable = false;
         this.gvNV.OptionsBehavior.ReadOnly = true;
         this.gvNV.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
         this.gvNV.OptionsView.ShowGroupPanel = false;
         this.gvNV.OptionsView.ShowViewCaption = true;
         this.gvNV.ViewCaption = "Danh sách Nhân Viên";
         this.gvNV.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvNV_CustomColumnDisplayText);
         // 
         // colMANV
         // 
         this.colMANV.Caption = "MÃ NHÂN VIÊN";
         this.colMANV.FieldName = "MANV";
         this.colMANV.Name = "colMANV";
         this.colMANV.Visible = true;
         this.colMANV.VisibleIndex = 0;
         // 
         // colHO
         // 
         this.colHO.Caption = "HỌ";
         this.colHO.FieldName = "HO";
         this.colHO.Name = "colHO";
         this.colHO.Visible = true;
         this.colHO.VisibleIndex = 1;
         // 
         // colTEN
         // 
         this.colTEN.Caption = "TÊN";
         this.colTEN.FieldName = "TEN";
         this.colTEN.Name = "colTEN";
         this.colTEN.Visible = true;
         this.colTEN.VisibleIndex = 2;
         // 
         // colDIACHI
         // 
         this.colDIACHI.Caption = "ĐỊA CHỈ";
         this.colDIACHI.FieldName = "DIACHI";
         this.colDIACHI.Name = "colDIACHI";
         this.colDIACHI.Visible = true;
         this.colDIACHI.VisibleIndex = 3;
         // 
         // colNGAYSINH
         // 
         this.colNGAYSINH.Caption = "NGÀY SINH";
         this.colNGAYSINH.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.colNGAYSINH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colNGAYSINH.FieldName = "NGAYSINH";
         this.colNGAYSINH.Name = "colNGAYSINH";
         this.colNGAYSINH.Visible = true;
         this.colNGAYSINH.VisibleIndex = 4;
         // 
         // colLUONG
         // 
         this.colLUONG.Caption = "LƯƠNG";
         this.colLUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
         this.colLUONG.FieldName = "LUONG";
         this.colLUONG.Name = "colLUONG";
         this.colLUONG.Visible = true;
         this.colLUONG.VisibleIndex = 5;
         // 
         // colMACN
         // 
         this.colMACN.Caption = "MÃ CHI NHÁNH";
         this.colMACN.FieldName = "MACN";
         this.colMACN.Name = "colMACN";
         this.colMACN.Visible = true;
         this.colMACN.VisibleIndex = 6;
         // 
         // colTrangThaiXoa
         // 
         this.colTrangThaiXoa.Caption = "TRẠNG THÁI XÓA";
         this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
         this.colTrangThaiXoa.Name = "colTrangThaiXoa";
         this.colTrangThaiXoa.Visible = true;
         this.colTrangThaiXoa.VisibleIndex = 7;
         // 
         // gcEmployee
         // 
         this.gcEmployee.ContextMenuStrip = this.cmsEmployee;
         this.gcEmployee.DataSource = this.bdsNV;
         this.gcEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcEmployee.Location = new System.Drawing.Point(0, 206);
         this.gcEmployee.MainView = this.gvNV;
         this.gcEmployee.Margin = new System.Windows.Forms.Padding(4);
         this.gcEmployee.MenuManager = this.bmNV;
         this.gcEmployee.Name = "gcEmployee";
         this.gcEmployee.Size = new System.Drawing.Size(984, 238);
         this.gcEmployee.TabIndex = 0;
         this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNV});
         this.gcEmployee.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gcNV_MouseDoubleClick);
         // 
         // cmsEmployee
         // 
         this.cmsEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreateLogin});
         this.cmsEmployee.Name = "cmsEmployee";
         this.cmsEmployee.Size = new System.Drawing.Size(146, 26);
         // 
         // btnCreateLogin
         // 
         this.btnCreateLogin.Image = global::QLVT_DATHANG.Properties.Resources.icons8_add_user_male_16;
         this.btnCreateLogin.Name = "btnCreateLogin";
         this.btnCreateLogin.Size = new System.Drawing.Size(145, 22);
         this.btnCreateLogin.Text = "Tạo tài khoản";
         this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
         // 
         // cboDeployment
         // 
         this.cboDeployment.BackColor = System.Drawing.SystemColors.Window;
         this.cboDeployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDeployment.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.cboDeployment.FormattingEnabled = true;
         this.cboDeployment.Location = new System.Drawing.Point(107, 5);
         this.cboDeployment.Name = "cboDeployment";
         this.cboDeployment.Size = new System.Drawing.Size(193, 21);
         this.cboDeployment.TabIndex = 1;
         // 
         // bdsPX
         // 
         this.bdsPX.DataMember = "FK_PX_NhanVien";
         this.bdsPX.DataSource = this.bdsNV;
         // 
         // taPX
         // 
         this.taPX.ClearBeforeFill = true;
         // 
         // bdsPN
         // 
         this.bdsPN.DataMember = "FK_PhieuNhap_NhanVien";
         this.bdsPN.DataSource = this.bdsNV;
         // 
         // taPN
         // 
         this.taPN.ClearBeforeFill = true;
         // 
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // gbEmployee
         // 
         this.gbEmployee.Controls.Add(this.lcEmplyee);
         this.gbEmployee.Dock = System.Windows.Forms.DockStyle.Top;
         this.gbEmployee.Location = new System.Drawing.Point(0, 54);
         this.gbEmployee.MinimumSize = new System.Drawing.Size(0, 10);
         this.gbEmployee.Name = "gbEmployee";
         this.gbEmployee.Size = new System.Drawing.Size(984, 147);
         this.gbEmployee.TabIndex = 16;
         this.gbEmployee.Text = "Thông tin Nhân Viên";
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.splitterControl1.Location = new System.Drawing.Point(0, 201);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(984, 5);
         this.splitterControl1.TabIndex = 17;
         this.splitterControl1.TabStop = false;
         this.splitterControl1.Visible = false;
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(984, 30);
         this.pnPickDepartment.TabIndex = 22;
         this.pnPickDepartment.Visible = false;
         // 
         // labelControl1
         // 
         this.labelControl1.Location = new System.Drawing.Point(12, 9);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(89, 13);
         this.labelControl1.TabIndex = 2;
         this.labelControl1.Text = "Chọn Chi Nhánh:";
         // 
         // bdsDH
         // 
         this.bdsDH.DataMember = "FK_DatHang_NhanVien";
         this.bdsDH.DataSource = this.bdsNV;
         // 
         // taDH
         // 
         this.taDH.ClearBeforeFill = true;
         // 
         // simpleButton2
         // 
         this.simpleButton2.Location = new System.Drawing.Point(608, 12);
         this.simpleButton2.Name = "simpleButton2";
         this.simpleButton2.Size = new System.Drawing.Size(100, 101);
         this.simpleButton2.TabIndex = 19;
         this.simpleButton2.Text = "simpleButton2";
         // 
         // layoutControlItem10
         // 
         this.layoutControlItem10.Control = this.simpleButton2;
         this.layoutControlItem10.Location = new System.Drawing.Point(596, 0);
         this.layoutControlItem10.Name = "layoutControlItem10";
         this.layoutControlItem10.Size = new System.Drawing.Size(104, 105);
         this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
         this.layoutControlItem10.TextVisible = false;
         // 
         // frmEmployee
         // 
         this.Appearance.Options.UseFont = true;
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(984, 444);
         this.Controls.Add(this.gcEmployee);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.gbEmployee);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmEmployee";
         this.Text = "QUẢN LÝ NHÂN VIÊN";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployee_FormClosing);
         this.Load += new System.EventHandler(this.frmEmployee_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bmNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lcEmplyee)).EndInit();
         this.lcEmplyee.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpAddr.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDelStatus.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpFirstName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpLastName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiEmpSalary.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
         this.cmsEmployee.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbEmployee)).EndInit();
         this.gbEmployee.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager bmNV;
      private DevExpress.XtraBars.Bar barNV;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnDel;
      private DevExpress.XtraBars.BarButtonItem btnEdit;
      private System.Windows.Forms.BindingSource bdsNV;
      private DataSet dataSet;
      private DataSetTableAdapters.NhanVienTableAdapter taNV;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarButtonItem btnUndo;
      private DevExpress.XtraBars.BarButtonItem btnRefresh;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraEditors.DateEdit dtpEmpBirth;
      private DevExpress.XtraEditors.TextEdit txtEmpAddr;
      private DevExpress.XtraEditors.TextEdit txtEmpLastName;
      private DevExpress.XtraEditors.TextEdit txtEmpFirstName;
      private DevExpress.XtraEditors.TextEdit txtEmpId;
      private DevExpress.XtraEditors.SpinEdit spiEmpSalary;
      private DevExpress.XtraGrid.GridControl gcEmployee;
      private DevExpress.XtraGrid.Views.Grid.GridView gvNV;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colHO;
      private DevExpress.XtraGrid.Columns.GridColumn colTEN;
      private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
      private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
      private DevExpress.XtraGrid.Columns.GridColumn colMACN;
      private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DevExpress.XtraEditors.TextEdit txtEmpDepartment;
      private System.Windows.Forms.BindingSource bdsPX;
      private DataSetTableAdapters.PhieuXuatTableAdapter taPX;
      private System.Windows.Forms.BindingSource bdsPN;
      private DataSetTableAdapters.PhieuNhapTableAdapter taPN;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private DevExpress.XtraEditors.TextEdit txtEmpDelStatus;
      private DevExpress.XtraEditors.GroupControl gbEmployee;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ContextMenuStrip cmsEmployee;
      private System.Windows.Forms.ToolStripMenuItem btnCreateLogin;
      private DevExpress.XtraBars.BarButtonItem btnSwitchDepartment;
      private System.Windows.Forms.BindingSource bdsDH;
      private DataSetTableAdapters.DatHangTableAdapter taDH;
      private DevExpress.XtraLayout.LayoutControl lcEmplyee;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
      private DevExpress.XtraEditors.SimpleButton simpleButton2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
   }
}