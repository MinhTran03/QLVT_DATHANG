namespace QLVT_DATHANG
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
         System.Windows.Forms.Label mANVLabel;
         System.Windows.Forms.Label hOLabel;
         System.Windows.Forms.Label dIACHILabel;
         System.Windows.Forms.Label nGAYSINHLabel;
         System.Windows.Forms.Label lUONGLabel;
         System.Windows.Forms.Label mACNLabel;
         System.Windows.Forms.Label label1;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
         this.bmNV = new DevExpress.XtraBars.BarManager(this.components);
         this.barNV = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnDel = new DevExpress.XtraBars.BarButtonItem();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
         this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
         this.taNV = new QLVT_DATHANG.DataSetTableAdapters.NhanVienTableAdapter();
         this.taNVManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
         this.txtEmpDepartment = new DevExpress.XtraEditors.TextEdit();
         this.spiEmpSalary = new DevExpress.XtraEditors.SpinEdit();
         this.dtpEmpBirth = new DevExpress.XtraEditors.DateEdit();
         this.txtEmpAddr = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpLastName = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpFirstName = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpId = new DevExpress.XtraEditors.TextEdit();
         this.gvNV = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gcNV = new DevExpress.XtraGrid.GridControl();
         this.cboEmpDep = new System.Windows.Forms.ComboBox();
         this.txtEmpDelStatus = new DevExpress.XtraEditors.TextEdit();
         this.lblTTX = new System.Windows.Forms.Label();
         this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
         this.taPX = new QLVT_DATHANG.DataSetTableAdapters.PhieuXuatTableAdapter();
         this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
         this.taPN = new QLVT_DATHANG.DataSetTableAdapters.PhieuNhapTableAdapter();
         this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
         this.taDH = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
         this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
         this.taCN = new QLVT_DATHANG.DataSetTableAdapters.ChiNhanhTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.gbNV = new DevExpress.XtraEditors.GroupControl();
         this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         mANVLabel = new System.Windows.Forms.Label();
         hOLabel = new System.Windows.Forms.Label();
         dIACHILabel = new System.Windows.Forms.Label();
         nGAYSINHLabel = new System.Windows.Forms.Label();
         lUONGLabel = new System.Windows.Forms.Label();
         mACNLabel = new System.Windows.Forms.Label();
         label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bmNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiEmpSalary.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpAddr.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpLastName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpFirstName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDelStatus.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbNV)).BeginInit();
         this.gbNV.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
         this.SuspendLayout();
         // 
         // mANVLabel
         // 
         mANVLabel.AutoSize = true;
         mANVLabel.Location = new System.Drawing.Point(215, 34);
         mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         mANVLabel.Name = "mANVLabel";
         mANVLabel.Size = new System.Drawing.Size(76, 13);
         mANVLabel.TabIndex = 0;
         mANVLabel.Text = "Mã Nhân Viên:";
         // 
         // hOLabel
         // 
         hOLabel.AutoSize = true;
         hOLabel.Location = new System.Drawing.Point(442, 34);
         hOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         hOLabel.Name = "hOLabel";
         hOLabel.Size = new System.Drawing.Size(24, 13);
         hOLabel.TabIndex = 2;
         hOLabel.Text = "Họ:";
         // 
         // dIACHILabel
         // 
         dIACHILabel.AutoSize = true;
         dIACHILabel.Location = new System.Drawing.Point(215, 120);
         dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         dIACHILabel.Name = "dIACHILabel";
         dIACHILabel.Size = new System.Drawing.Size(45, 13);
         dIACHILabel.TabIndex = 10;
         dIACHILabel.Text = "Địa Chỉ:";
         // 
         // nGAYSINHLabel
         // 
         nGAYSINHLabel.AutoSize = true;
         nGAYSINHLabel.Location = new System.Drawing.Point(215, 75);
         nGAYSINHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         nGAYSINHLabel.Name = "nGAYSINHLabel";
         nGAYSINHLabel.Size = new System.Drawing.Size(59, 13);
         nGAYSINHLabel.TabIndex = 6;
         nGAYSINHLabel.Text = "Ngày Sinh:";
         // 
         // lUONGLabel
         // 
         lUONGLabel.AutoSize = true;
         lUONGLabel.Location = new System.Drawing.Point(504, 75);
         lUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         lUONGLabel.Name = "lUONGLabel";
         lUONGLabel.Size = new System.Drawing.Size(41, 13);
         lUONGLabel.TabIndex = 8;
         lUONGLabel.Text = "Lương:";
         // 
         // mACNLabel
         // 
         mACNLabel.AutoSize = true;
         mACNLabel.Location = new System.Drawing.Point(215, 165);
         mACNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         mACNLabel.Name = "mACNLabel";
         mACNLabel.Size = new System.Drawing.Size(77, 13);
         mACNLabel.TabIndex = 12;
         mACNLabel.Text = "Mã Chi Nhánh:";
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Location = new System.Drawing.Point(594, 34);
         label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         label1.Name = "label1";
         label1.Size = new System.Drawing.Size(29, 13);
         label1.TabIndex = 4;
         label1.Text = "Tên:";
         // 
         // bmNV
         // 
         this.bmNV.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barNV});
         this.bmNV.DockControls.Add(this.barDockControlTop);
         this.bmNV.DockControls.Add(this.barDockControlBottom);
         this.bmNV.DockControls.Add(this.barDockControlLeft);
         this.bmNV.DockControls.Add(this.barDockControlRight);
         this.bmNV.DockManager = this.dockManager1;
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
            this.barButtonItem1,
            this.skinPaletteDropDownButtonItem1});
         this.bmNV.MainMenu = this.barNV;
         this.bmNV.MaxItemId = 22;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelEdit)});
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
         // btnRefresh
         // 
         this.btnRefresh.Caption = "LÀM MỚI";
         this.btnRefresh.Id = 5;
         this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
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
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.bmNV;
         this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlTop.Size = new System.Drawing.Size(982, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 483);
         this.barDockControlBottom.Manager = this.bmNV;
         this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlBottom.Size = new System.Drawing.Size(982, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmNV;
         this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(982, 24);
         this.barDockControlRight.Manager = this.bmNV;
         this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
         this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
         // 
         // dockManager1
         // 
         this.dockManager1.Form = this;
         this.dockManager1.MenuManager = this.bmNV;
         this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "barButtonItem1";
         this.barButtonItem1.Id = 10;
         this.barButtonItem1.Name = "barButtonItem1";
         // 
         // skinPaletteDropDownButtonItem1
         // 
         this.skinPaletteDropDownButtonItem1.Enabled = false;
         this.skinPaletteDropDownButtonItem1.Id = 21;
         this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
         this.skinPaletteDropDownButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
         // taNVManager
         // 
         this.taNVManager.BackupDataSetBeforeUpdate = false;
         this.taNVManager.ChiNhanhTableAdapter = null;
         this.taNVManager.CTDDHTableAdapter = null;
         this.taNVManager.CTPNTableAdapter = null;
         this.taNVManager.CTPXTableAdapter = null;
         this.taNVManager.DatHangTableAdapter = null;
         this.taNVManager.KhoTableAdapter = null;
         this.taNVManager.NhanVienTableAdapter = this.taNV;
         this.taNVManager.PhieuNhapTableAdapter = null;
         this.taNVManager.PhieuXuatTableAdapter = null;
         this.taNVManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.taNVManager.VattuTableAdapter = null;
         // 
         // txtEmpDepartment
         // 
         this.txtEmpDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
         this.txtEmpDepartment.EditValue = "";
         this.txtEmpDepartment.Location = new System.Drawing.Point(311, 162);
         this.txtEmpDepartment.MenuManager = this.bmNV;
         this.txtEmpDepartment.Name = "txtEmpDepartment";
         this.txtEmpDepartment.Size = new System.Drawing.Size(167, 20);
         this.txtEmpDepartment.TabIndex = 13;
         // 
         // spiEmpSalary
         // 
         this.spiEmpSalary.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "LUONG", true));
         this.spiEmpSalary.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.spiEmpSalary.Location = new System.Drawing.Point(557, 72);
         this.spiEmpSalary.Margin = new System.Windows.Forms.Padding(4);
         this.spiEmpSalary.MenuManager = this.bmNV;
         this.spiEmpSalary.Name = "spiEmpSalary";
         this.spiEmpSalary.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spiEmpSalary.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
         this.spiEmpSalary.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
         this.spiEmpSalary.Size = new System.Drawing.Size(155, 20);
         this.spiEmpSalary.TabIndex = 9;
         this.spiEmpSalary.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.spiEmpSalary_CustomDisplayText);
         // 
         // dtpEmpBirth
         // 
         this.dtpEmpBirth.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
         this.dtpEmpBirth.EditValue = new System.DateTime(2019, 10, 27, 0, 0, 0, 0);
         this.dtpEmpBirth.Location = new System.Drawing.Point(311, 72);
         this.dtpEmpBirth.Margin = new System.Windows.Forms.Padding(4);
         this.dtpEmpBirth.MenuManager = this.bmNV;
         this.dtpEmpBirth.Name = "dtpEmpBirth";
         this.dtpEmpBirth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpEmpBirth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpEmpBirth.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.dtpEmpBirth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpEmpBirth.Properties.EditFormat.FormatString = "dd/MM/yyyy";
         this.dtpEmpBirth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpEmpBirth.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
         this.dtpEmpBirth.Properties.Mask.EditMask = "";
         this.dtpEmpBirth.Properties.Mask.IgnoreMaskBlank = false;
         this.dtpEmpBirth.Properties.Mask.ShowPlaceHolders = false;
         this.dtpEmpBirth.Properties.MaxValue = new System.DateTime(2019, 10, 28, 0, 0, 0, 0);
         this.dtpEmpBirth.Size = new System.Drawing.Size(185, 20);
         this.dtpEmpBirth.TabIndex = 7;
         // 
         // txtEmpAddr
         // 
         this.txtEmpAddr.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
         this.txtEmpAddr.EditValue = "";
         this.txtEmpAddr.Location = new System.Drawing.Point(311, 117);
         this.txtEmpAddr.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpAddr.MenuManager = this.bmNV;
         this.txtEmpAddr.Name = "txtEmpAddr";
         this.txtEmpAddr.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpAddr.Size = new System.Drawing.Size(401, 20);
         this.txtEmpAddr.TabIndex = 11;
         // 
         // txtEmpLastName
         // 
         this.txtEmpLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TEN", true));
         this.txtEmpLastName.EditValue = "";
         this.txtEmpLastName.Location = new System.Drawing.Point(633, 31);
         this.txtEmpLastName.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpLastName.MenuManager = this.bmNV;
         this.txtEmpLastName.Name = "txtEmpLastName";
         this.txtEmpLastName.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpLastName.Properties.Mask.ShowPlaceHolders = false;
         this.txtEmpLastName.Size = new System.Drawing.Size(79, 20);
         this.txtEmpLastName.TabIndex = 5;
         this.txtEmpLastName.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.txtEmpLastName_CustomDisplayText);
         // 
         // txtEmpFirstName
         // 
         this.txtEmpFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HO", true));
         this.txtEmpFirstName.Location = new System.Drawing.Point(476, 31);
         this.txtEmpFirstName.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpFirstName.MenuManager = this.bmNV;
         this.txtEmpFirstName.Name = "txtEmpFirstName";
         this.txtEmpFirstName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
         this.txtEmpFirstName.Properties.Mask.EditMask = "[\\u0000-\\u001F\\007F-\\u009F]+(\\\\s{1}[\\u0000-\\u001F\\007F-\\u009F]+)*";
         this.txtEmpFirstName.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpFirstName.Properties.Mask.ShowPlaceHolders = false;
         this.txtEmpFirstName.Size = new System.Drawing.Size(110, 20);
         this.txtEmpFirstName.TabIndex = 3;
         this.txtEmpFirstName.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.txtEmpFirstName_CustomDisplayText);
         // 
         // txtEmpId
         // 
         this.txtEmpId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MANV", true));
         this.txtEmpId.Location = new System.Drawing.Point(311, 31);
         this.txtEmpId.Margin = new System.Windows.Forms.Padding(4);
         this.txtEmpId.MenuManager = this.bmNV;
         this.txtEmpId.Name = "txtEmpId";
         this.txtEmpId.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
         this.txtEmpId.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
         this.txtEmpId.Properties.Mask.IgnoreMaskBlank = false;
         this.txtEmpId.Properties.Mask.ShowPlaceHolders = false;
         this.txtEmpId.Size = new System.Drawing.Size(123, 20);
         this.txtEmpId.TabIndex = 1;
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
         this.gvNV.GridControl = this.gcNV;
         this.gvNV.Name = "gvNV";
         this.gvNV.OptionsBehavior.Editable = false;
         this.gvNV.OptionsBehavior.ReadOnly = true;
         this.gvNV.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
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
         // gcNV
         // 
         this.gcNV.DataSource = this.bdsNV;
         this.gcNV.Dock = System.Windows.Forms.DockStyle.Top;
         this.gcNV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
         this.gcNV.Location = new System.Drawing.Point(0, 24);
         this.gcNV.MainView = this.gvNV;
         this.gcNV.Margin = new System.Windows.Forms.Padding(4);
         this.gcNV.MenuManager = this.bmNV;
         this.gcNV.Name = "gcNV";
         this.gcNV.Size = new System.Drawing.Size(982, 248);
         this.gcNV.TabIndex = 0;
         this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNV});
         this.gcNV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gcNV_MouseDoubleClick);
         // 
         // cboEmpDep
         // 
         this.cboEmpDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboEmpDep.FormattingEnabled = true;
         this.cboEmpDep.Location = new System.Drawing.Point(4, 29);
         this.cboEmpDep.Name = "cboEmpDep";
         this.cboEmpDep.Size = new System.Drawing.Size(261, 23);
         this.cboEmpDep.TabIndex = 1;
         this.cboEmpDep.Visible = false;
         this.cboEmpDep.SelectedIndexChanged += new System.EventHandler(this.cboEmpDep_SelectedIndexChanged);
         // 
         // txtEmpDelStatus
         // 
         this.txtEmpDelStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "TrangThaiXoa", true));
         this.txtEmpDelStatus.Location = new System.Drawing.Point(584, 162);
         this.txtEmpDelStatus.MenuManager = this.bmNV;
         this.txtEmpDelStatus.Name = "txtEmpDelStatus";
         this.txtEmpDelStatus.Size = new System.Drawing.Size(128, 20);
         this.txtEmpDelStatus.TabIndex = 15;
         // 
         // lblTTX
         // 
         this.lblTTX.AutoSize = true;
         this.lblTTX.Location = new System.Drawing.Point(484, 165);
         this.lblTTX.Name = "lblTTX";
         this.lblTTX.Size = new System.Drawing.Size(83, 13);
         this.lblTTX.TabIndex = 14;
         this.lblTTX.Text = "Trạng Thái Xóa:";
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
         // bdsDH
         // 
         this.bdsDH.DataMember = "FK_DatHang_NhanVien";
         this.bdsDH.DataSource = this.bdsNV;
         // 
         // taDH
         // 
         this.taDH.ClearBeforeFill = true;
         // 
         // bdsCN
         // 
         this.bdsCN.DataMember = "ChiNhanh";
         this.bdsCN.DataSource = this.dataSet;
         // 
         // taCN
         // 
         this.taCN.ClearBeforeFill = true;
         // 
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // gbNV
         // 
         this.gbNV.Controls.Add(this.pictureEdit1);
         this.gbNV.Controls.Add(this.txtEmpId);
         this.gbNV.Controls.Add(this.txtEmpDelStatus);
         this.gbNV.Controls.Add(mANVLabel);
         this.gbNV.Controls.Add(this.lblTTX);
         this.gbNV.Controls.Add(this.txtEmpFirstName);
         this.gbNV.Controls.Add(this.txtEmpDepartment);
         this.gbNV.Controls.Add(hOLabel);
         this.gbNV.Controls.Add(mACNLabel);
         this.gbNV.Controls.Add(label1);
         this.gbNV.Controls.Add(lUONGLabel);
         this.gbNV.Controls.Add(this.txtEmpLastName);
         this.gbNV.Controls.Add(this.spiEmpSalary);
         this.gbNV.Controls.Add(this.txtEmpAddr);
         this.gbNV.Controls.Add(nGAYSINHLabel);
         this.gbNV.Controls.Add(dIACHILabel);
         this.gbNV.Controls.Add(this.dtpEmpBirth);
         this.gbNV.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbNV.Location = new System.Drawing.Point(0, 272);
         this.gbNV.Name = "gbNV";
         this.gbNV.Size = new System.Drawing.Size(982, 211);
         this.gbNV.TabIndex = 16;
         this.gbNV.Text = "Thông tin Nhân Viên";
         // 
         // pictureEdit1
         // 
         this.pictureEdit1.EditValue = global::QLVT_DATHANG.Properties.Resources.id_card_96px;
         this.pictureEdit1.Location = new System.Drawing.Point(12, 34);
         this.pictureEdit1.MenuManager = this.bmNV;
         this.pictureEdit1.Name = "pictureEdit1";
         this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
         this.pictureEdit1.Size = new System.Drawing.Size(196, 144);
         this.pictureEdit1.TabIndex = 16;
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.splitterControl1.Location = new System.Drawing.Point(0, 272);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(982, 5);
         this.splitterControl1.TabIndex = 17;
         this.splitterControl1.TabStop = false;
         // 
         // frmEmployee
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(982, 483);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.cboEmpDep);
         this.Controls.Add(this.gbNV);
         this.Controls.Add(this.gcNV);
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
         ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiEmpSalary.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpEmpBirth.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpAddr.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpLastName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpFirstName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDelStatus.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbNV)).EndInit();
         this.gbNV.ResumeLayout(false);
         this.gbNV.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
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
        private DataSetTableAdapters.TableAdapterManager taNVManager;
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
        private DevExpress.XtraGrid.GridControl gcNV;
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
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ComboBox cboEmpDep;
        private DevExpress.XtraEditors.TextEdit txtEmpDepartment;
      private System.Windows.Forms.BindingSource bdsPX;
      private DataSetTableAdapters.PhieuXuatTableAdapter taPX;
      private System.Windows.Forms.BindingSource bdsPN;
      private DataSetTableAdapters.PhieuNhapTableAdapter taPN;
      private System.Windows.Forms.BindingSource bdsDH;
      private DataSetTableAdapters.DatHangTableAdapter taDH;
      private System.Windows.Forms.BindingSource bdsCN;
      private DataSetTableAdapters.ChiNhanhTableAdapter taCN;
      private System.Windows.Forms.Label lblTTX;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private DevExpress.XtraEditors.TextEdit txtEmpDelStatus;
      private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
      private DevExpress.XtraBars.Docking.DockManager dockManager1;
      private DevExpress.XtraEditors.GroupControl gbNV;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraEditors.PictureEdit pictureEdit1;
   }
}