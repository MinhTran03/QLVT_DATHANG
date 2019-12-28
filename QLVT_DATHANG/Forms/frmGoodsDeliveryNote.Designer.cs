namespace QLVT_DATHANG.Forms
{
   partial class frmGoodsDeliveryNote
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsDeliveryNote));
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.bmPN = new DevExpress.XtraBars.BarManager(this.components);
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
         this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
         this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
         this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
         this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
         this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
         this.taPX = new QLVT_DATHANG.DataSetTableAdapters.PhieuXuatTableAdapter();
         this.gvDeliveryNote = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gcDeliveryNote = new DevExpress.XtraGrid.GridControl();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.taCTPX = new QLVT_DATHANG.DataSetTableAdapters.CTPXTableAdapter();
         this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
         this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
         this.taDSKHO = new QLVT_DATHANG.DataSetTableAdapters.DSKHOTableAdapter();
         this.gbCTPX = new DevExpress.XtraEditors.GroupControl();
         this.btnRemoveLine = new DevExpress.XtraEditors.SimpleButton();
         this.btnAddDataRow = new DevExpress.XtraEditors.SimpleButton();
         this.gcCTPX = new DevExpress.XtraGrid.GridControl();
         this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.bdsDSVTCH = new System.Windows.Forms.BindingSource(this.components);
         this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTHANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gbDeliveryNote = new DevExpress.XtraEditors.GroupControl();
         this.txtId = new DevExpress.XtraEditors.TextEdit();
         this.dtpDate = new DevExpress.XtraEditors.DateEdit();
         this.txtCustomerName = new DevExpress.XtraEditors.TextEdit();
         this.lkeEmployee = new DevExpress.XtraEditors.LookUpEdit();
         this.lkeMaKho = new DevExpress.XtraEditors.LookUpEdit();
         this.pnSub = new DevExpress.XtraEditors.PanelControl();
         this.taDSVTCH = new QLVT_DATHANG.DataSetTableAdapters.DSVTCONHANGTableAdapter();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbCTPX)).BeginInit();
         this.gbCTPX.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVTCH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbDeliveryNote)).BeginInit();
         this.gbDeliveryNote.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeMaKho.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnSub)).BeginInit();
         this.pnSub.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitterControl1.Location = new System.Drawing.Point(0, 252);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(969, 5);
         this.splitterControl1.TabIndex = 6;
         this.splitterControl1.TabStop = false;
         // 
         // bmPN
         // 
         this.bmPN.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
         this.bmPN.DockControls.Add(this.barDockControlTop);
         this.bmPN.DockControls.Add(this.barDockControlBottom);
         this.bmPN.DockControls.Add(this.barDockControlLeft);
         this.bmPN.DockControls.Add(this.barDockControlRight);
         this.bmPN.Form = this;
         this.bmPN.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnSave,
            this.btnUndo,
            this.btnRefresh,
            this.btnExit,
            this.btnCancelEdit});
         this.bmPN.MainMenu = this.bar2;
         this.bmPN.MaxItemId = 8;
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockRow = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
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
         this.btnSave.Id = 3;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Id = 7;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelEdit_ItemClick);
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 6;
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
         this.barDockControlTop.Manager = this.bmPN;
         this.barDockControlTop.Size = new System.Drawing.Size(969, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 457);
         this.barDockControlBottom.Manager = this.bmPN;
         this.barDockControlBottom.Size = new System.Drawing.Size(969, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmPN;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(969, 24);
         this.barDockControlRight.Manager = this.bmPN;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
         // 
         // btnUndo
         // 
         this.btnUndo.Caption = "PHỤC HỒI";
         this.btnUndo.Id = 4;
         this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // bdsDSKHO
         // 
         this.bdsDSKHO.DataMember = "DSKHO";
         this.bdsDSKHO.DataSource = this.dataSet;
         // 
         // bdsPX
         // 
         this.bdsPX.DataMember = "PhieuXuat";
         this.bdsPX.DataSource = this.dataSet;
         // 
         // bdsDSNV
         // 
         this.bdsDSNV.DataMember = "DSNV";
         this.bdsDSNV.DataSource = this.dataSet;
         // 
         // bdsCTPX
         // 
         this.bdsCTPX.DataMember = "FK_CTPX_PX";
         this.bdsCTPX.DataSource = this.bdsPX;
         this.bdsCTPX.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bdsCTPX_ListChanged);
         // 
         // taPX
         // 
         this.taPX.ClearBeforeFill = true;
         // 
         // gvDeliveryNote
         // 
         this.gvDeliveryNote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
         this.gvDeliveryNote.GridControl = this.gcDeliveryNote;
         this.gvDeliveryNote.Name = "gvDeliveryNote";
         this.gvDeliveryNote.OptionsBehavior.Editable = false;
         this.gvDeliveryNote.OptionsView.ShowGroupPanel = false;
         this.gvDeliveryNote.OptionsView.ShowViewCaption = true;
         this.gvDeliveryNote.ViewCaption = "Danh sách Phiếu Xuất";
         // 
         // colMAPX
         // 
         this.colMAPX.Caption = "MÃ PHIẾU XUẤT";
         this.colMAPX.FieldName = "MAPX";
         this.colMAPX.Name = "colMAPX";
         this.colMAPX.Visible = true;
         this.colMAPX.VisibleIndex = 0;
         // 
         // colNGAY
         // 
         this.colNGAY.Caption = "NGÀY";
         this.colNGAY.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colNGAY.FieldName = "NGAY";
         this.colNGAY.GroupFormat.FormatString = "dd/MM/yyyy";
         this.colNGAY.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colNGAY.Name = "colNGAY";
         this.colNGAY.OptionsEditForm.Caption = "NGÀY XUẤT:";
         this.colNGAY.Visible = true;
         this.colNGAY.VisibleIndex = 1;
         // 
         // colHOTENKH
         // 
         this.colHOTENKH.Caption = "HỌ TÊN KHÁCH HÀNG";
         this.colHOTENKH.FieldName = "HOTENKH";
         this.colHOTENKH.Name = "colHOTENKH";
         this.colHOTENKH.Visible = true;
         this.colHOTENKH.VisibleIndex = 2;
         // 
         // colMANV
         // 
         this.colMANV.Caption = "MÃ NHÂN VIÊN";
         this.colMANV.FieldName = "MANV";
         this.colMANV.Name = "colMANV";
         this.colMANV.Visible = true;
         this.colMANV.VisibleIndex = 3;
         // 
         // colMAKHO
         // 
         this.colMAKHO.Caption = "MÃ KHO";
         this.colMAKHO.FieldName = "MAKHO";
         this.colMAKHO.Name = "colMAKHO";
         this.colMAKHO.Visible = true;
         this.colMAKHO.VisibleIndex = 4;
         // 
         // gcDeliveryNote
         // 
         this.gcDeliveryNote.DataSource = this.bdsPX;
         this.gcDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcDeliveryNote.Location = new System.Drawing.Point(0, 54);
         this.gcDeliveryNote.MainView = this.gvDeliveryNote;
         this.gcDeliveryNote.MenuManager = this.bmPN;
         this.gcDeliveryNote.Name = "gcDeliveryNote";
         this.gcDeliveryNote.Size = new System.Drawing.Size(969, 198);
         this.gcDeliveryNote.TabIndex = 0;
         this.gcDeliveryNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeliveryNote});
         // 
         // bar3
         // 
         this.bar3.BarName = "Status bar";
         this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
         this.bar3.DockCol = 0;
         this.bar3.DockRow = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
         this.bar3.OptionsBar.AllowQuickCustomization = false;
         this.bar3.OptionsBar.DrawDragBorder = false;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Status bar";
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
         // labelControl1
         // 
         this.labelControl1.Location = new System.Drawing.Point(12, 9);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(89, 13);
         this.labelControl1.TabIndex = 2;
         this.labelControl1.Text = "Chọn Chi Nhánh:";
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(969, 30);
         this.pnPickDepartment.TabIndex = 24;
         this.pnPickDepartment.Visible = false;
         // 
         // taDSNV
         // 
         this.taDSNV.ClearBeforeFill = true;
         // 
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // taCTPX
         // 
         this.taCTPX.ClearBeforeFill = true;
         // 
         // barButtonItem1
         // 
         this.barButtonItem1.Caption = "THÊM";
         this.barButtonItem1.Id = 0;
         this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
         this.barButtonItem1.Name = "barButtonItem1";
         this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // barButtonItem3
         // 
         this.barButtonItem3.Caption = "GHI";
         this.barButtonItem3.Id = 3;
         this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
         this.barButtonItem3.Name = "barButtonItem3";
         this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // barButtonItem2
         // 
         this.barButtonItem2.Caption = "LÀM MỚI";
         this.barButtonItem2.Id = 5;
         this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
         this.barButtonItem2.Name = "barButtonItem2";
         this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // barButtonItem5
         // 
         this.barButtonItem5.Caption = "THOÁT";
         this.barButtonItem5.Id = 6;
         this.barButtonItem5.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.barButtonItem5.Name = "barButtonItem5";
         this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // barButtonItem4
         // 
         this.barButtonItem4.Caption = "HỦY";
         this.barButtonItem4.Id = 7;
         this.barButtonItem4.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.barButtonItem4.Name = "barButtonItem4";
         this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // barDockControl4
         // 
         this.barDockControl4.CausesValidation = false;
         this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControl4.Location = new System.Drawing.Point(969, 24);
         this.barDockControl4.Manager = null;
         this.barDockControl4.Size = new System.Drawing.Size(0, 433);
         // 
         // taDSKHO
         // 
         this.taDSKHO.ClearBeforeFill = true;
         // 
         // gbCTPX
         // 
         this.gbCTPX.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbCTPX.AppearanceCaption.Options.UseFont = true;
         this.gbCTPX.Controls.Add(this.btnRemoveLine);
         this.gbCTPX.Controls.Add(this.btnAddDataRow);
         this.gbCTPX.Controls.Add(this.gcCTPX);
         this.gbCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbCTPX.Location = new System.Drawing.Point(385, 2);
         this.gbCTPX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.gbCTPX.Name = "gbCTPX";
         this.gbCTPX.Size = new System.Drawing.Size(582, 196);
         this.gbCTPX.TabIndex = 0;
         this.gbCTPX.Text = "Chi tiết Phiếu Xuất";
         // 
         // btnRemoveLine
         // 
         this.btnRemoveLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnRemoveLine.Location = new System.Drawing.Point(93, 170);
         this.btnRemoveLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.btnRemoveLine.Name = "btnRemoveLine";
         this.btnRemoveLine.Size = new System.Drawing.Size(81, 22);
         this.btnRemoveLine.TabIndex = 1;
         this.btnRemoveLine.Text = "Xóa Dòng";
         this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveDataRow_Click);
         // 
         // btnAddDataRow
         // 
         this.btnAddDataRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.btnAddDataRow.Location = new System.Drawing.Point(6, 170);
         this.btnAddDataRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.btnAddDataRow.Name = "btnAddDataRow";
         this.btnAddDataRow.Size = new System.Drawing.Size(81, 22);
         this.btnAddDataRow.TabIndex = 0;
         this.btnAddDataRow.Text = "Thêm Dòng";
         this.btnAddDataRow.Click += new System.EventHandler(this.btnAddDateRow_Click);
         // 
         // gcCTPX
         // 
         this.gcCTPX.DataSource = this.bdsCTPX;
         this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcCTPX.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.gcCTPX.Location = new System.Drawing.Point(2, 22);
         this.gcCTPX.MainView = this.gvCTPX;
         this.gcCTPX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.gcCTPX.MenuManager = this.bmPN;
         this.gcCTPX.Name = "gcCTPX";
         this.gcCTPX.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit});
         this.gcCTPX.Size = new System.Drawing.Size(578, 172);
         this.gcCTPX.TabIndex = 0;
         this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX,
            this.gridView1});
         // 
         // gvCTPX
         // 
         this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA,
            this.colTHANHTIEN});
         this.gvCTPX.DetailHeight = 268;
         this.gvCTPX.GridControl = this.gcCTPX;
         this.gvCTPX.Name = "gvCTPX";
         this.gvCTPX.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
         this.gvCTPX.OptionsView.ShowFooter = true;
         this.gvCTPX.OptionsView.ShowGroupPanel = false;
         this.gvCTPX.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvCTPX_ValidateRow);
         this.gvCTPX.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvCTPX_CustomColumnDisplayText);
         this.gvCTPX.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvCTPX_ValidatingEditor);
         // 
         // colMAPX1
         // 
         this.colMAPX1.FieldName = "MAPX";
         this.colMAPX1.MinWidth = 21;
         this.colMAPX1.Name = "colMAPX1";
         this.colMAPX1.Width = 81;
         // 
         // colMAVT
         // 
         this.colMAVT.Caption = "VẬT TƯ";
         this.colMAVT.ColumnEdit = this.repositoryItemLookUpEdit;
         this.colMAVT.FieldName = "MAVT";
         this.colMAVT.MinWidth = 21;
         this.colMAVT.Name = "colMAVT";
         this.colMAVT.Visible = true;
         this.colMAVT.VisibleIndex = 0;
         this.colMAVT.Width = 81;
         // 
         // repositoryItemLookUpEdit
         // 
         this.repositoryItemLookUpEdit.AutoHeight = false;
         this.repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.repositoryItemLookUpEdit.DataSource = this.bdsDSVTCH;
         this.repositoryItemLookUpEdit.DisplayMember = "TENVT";
         this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
         this.repositoryItemLookUpEdit.NullText = "Chọn 1 vật tư";
         this.repositoryItemLookUpEdit.ValueMember = "MAVT";
         // 
         // bdsDSVTCH
         // 
         this.bdsDSVTCH.DataMember = "DSVTCONHANG";
         this.bdsDSVTCH.DataSource = this.dataSet;
         // 
         // colSOLUONG
         // 
         this.colSOLUONG.Caption = "SỐ LƯỢNG";
         this.colSOLUONG.FieldName = "SOLUONG";
         this.colSOLUONG.MinWidth = 21;
         this.colSOLUONG.Name = "colSOLUONG";
         this.colSOLUONG.Visible = true;
         this.colSOLUONG.VisibleIndex = 1;
         this.colSOLUONG.Width = 81;
         // 
         // colDONGIA
         // 
         this.colDONGIA.Caption = "ĐƠN GIÁ";
         this.colDONGIA.FieldName = "DONGIA";
         this.colDONGIA.MinWidth = 21;
         this.colDONGIA.Name = "colDONGIA";
         this.colDONGIA.Visible = true;
         this.colDONGIA.VisibleIndex = 2;
         this.colDONGIA.Width = 81;
         // 
         // colTHANHTIEN
         // 
         this.colTHANHTIEN.Caption = "THÀNH TIỀN";
         this.colTHANHTIEN.FieldName = "THANHTIEN";
         this.colTHANHTIEN.Name = "colTHANHTIEN";
         this.colTHANHTIEN.OptionsColumn.AllowFocus = false;
         this.colTHANHTIEN.OptionsColumn.ReadOnly = true;
         this.colTHANHTIEN.ShowUnboundExpressionMenu = true;
         this.colTHANHTIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANHTIEN", "TỔNG TIỀN: {0:#,## đ}")});
         this.colTHANHTIEN.UnboundExpression = "[SOLUONG] * [DONGIA]";
         this.colTHANHTIEN.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
         this.colTHANHTIEN.Visible = true;
         this.colTHANHTIEN.VisibleIndex = 3;
         // 
         // gridView1
         // 
         this.gridView1.GridControl = this.gcCTPX;
         this.gridView1.Name = "gridView1";
         // 
         // gbDeliveryNote
         // 
         this.gbDeliveryNote.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbDeliveryNote.AppearanceCaption.Options.UseFont = true;
         this.gbDeliveryNote.Controls.Add(this.labelControl6);
         this.gbDeliveryNote.Controls.Add(this.labelControl5);
         this.gbDeliveryNote.Controls.Add(this.labelControl4);
         this.gbDeliveryNote.Controls.Add(this.labelControl3);
         this.gbDeliveryNote.Controls.Add(this.labelControl2);
         this.gbDeliveryNote.Controls.Add(this.txtId);
         this.gbDeliveryNote.Controls.Add(this.dtpDate);
         this.gbDeliveryNote.Controls.Add(this.txtCustomerName);
         this.gbDeliveryNote.Controls.Add(this.lkeEmployee);
         this.gbDeliveryNote.Controls.Add(this.lkeMaKho);
         this.gbDeliveryNote.Dock = System.Windows.Forms.DockStyle.Left;
         this.gbDeliveryNote.Location = new System.Drawing.Point(2, 2);
         this.gbDeliveryNote.Name = "gbDeliveryNote";
         this.gbDeliveryNote.Size = new System.Drawing.Size(383, 196);
         this.gbDeliveryNote.TabIndex = 0;
         this.gbDeliveryNote.Text = "Thông tin Phiếu Xuất";
         // 
         // txtId
         // 
         this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
         this.txtId.Location = new System.Drawing.Point(95, 26);
         this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.txtId.MenuManager = this.bmPN;
         this.txtId.Name = "txtId";
         this.txtId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtId.Properties.MaxLength = 8;
         this.txtId.Size = new System.Drawing.Size(92, 20);
         this.txtId.TabIndex = 1;
         // 
         // dtpDate
         // 
         this.dtpDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
         this.dtpDate.EditValue = null;
         this.dtpDate.Location = new System.Drawing.Point(253, 26);
         this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.dtpDate.MenuManager = this.bmPN;
         this.dtpDate.Name = "dtpDate";
         this.dtpDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.dtpDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
         this.dtpDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpDate.Properties.Mask.EditMask = "dd/MM/yyyy";
         this.dtpDate.Size = new System.Drawing.Size(110, 20);
         this.dtpDate.TabIndex = 3;
         // 
         // txtCustomerName
         // 
         this.txtCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
         this.txtCustomerName.Location = new System.Drawing.Point(120, 50);
         this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.txtCustomerName.MenuManager = this.bmPN;
         this.txtCustomerName.Name = "txtCustomerName";
         this.txtCustomerName.Size = new System.Drawing.Size(243, 20);
         this.txtCustomerName.TabIndex = 5;
         // 
         // lkeEmployee
         // 
         this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MANV", true));
         this.lkeEmployee.Location = new System.Drawing.Point(88, 74);
         this.lkeEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.lkeEmployee.MenuManager = this.bmPN;
         this.lkeEmployee.Name = "lkeEmployee";
         this.lkeEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.lkeEmployee.Properties.DataSource = this.bdsDSNV;
         this.lkeEmployee.Properties.DisplayMember = "HOTEN";
         this.lkeEmployee.Properties.NullText = "";
         this.lkeEmployee.Properties.ValueMember = "MANV";
         this.lkeEmployee.Size = new System.Drawing.Size(97, 20);
         this.lkeEmployee.TabIndex = 7;
         // 
         // lkeMaKho
         // 
         this.lkeMaKho.EditValue = "";
         this.lkeMaKho.Location = new System.Drawing.Point(246, 74);
         this.lkeMaKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.lkeMaKho.MenuManager = this.bmPN;
         this.lkeMaKho.Name = "lkeMaKho";
         this.lkeMaKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.lkeMaKho.Properties.DataSource = this.bdsDSKHO;
         this.lkeMaKho.Properties.DisplayMember = "TENKHO";
         this.lkeMaKho.Properties.NullText = "";
         this.lkeMaKho.Properties.ValueMember = "MAKHO";
         this.lkeMaKho.Size = new System.Drawing.Size(117, 20);
         this.lkeMaKho.TabIndex = 9;
         // 
         // pnSub
         // 
         this.pnSub.Controls.Add(this.gbCTPX);
         this.pnSub.Controls.Add(this.gbDeliveryNote);
         this.pnSub.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.pnSub.Location = new System.Drawing.Point(0, 257);
         this.pnSub.Name = "pnSub";
         this.pnSub.Size = new System.Drawing.Size(969, 200);
         this.pnSub.TabIndex = 30;
         // 
         // taDSVTCH
         // 
         this.taDSVTCH.ClearBeforeFill = true;
         // 
         // labelControl2
         // 
         this.labelControl2.Location = new System.Drawing.Point(8, 29);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(77, 13);
         this.labelControl2.TabIndex = 10;
         this.labelControl2.Text = "Mã phiếu xuất:";
         // 
         // labelControl3
         // 
         this.labelControl3.Location = new System.Drawing.Point(193, 29);
         this.labelControl3.Name = "labelControl3";
         this.labelControl3.Size = new System.Drawing.Size(54, 13);
         this.labelControl3.TabIndex = 10;
         this.labelControl3.Text = "Ngày xuất:";
         // 
         // labelControl4
         // 
         this.labelControl4.Location = new System.Drawing.Point(8, 53);
         this.labelControl4.Name = "labelControl4";
         this.labelControl4.Size = new System.Drawing.Size(102, 13);
         this.labelControl4.TabIndex = 10;
         this.labelControl4.Text = "Họ tên khách hàng:";
         // 
         // labelControl5
         // 
         this.labelControl5.Location = new System.Drawing.Point(8, 77);
         this.labelControl5.Name = "labelControl5";
         this.labelControl5.Size = new System.Drawing.Size(73, 13);
         this.labelControl5.TabIndex = 10;
         this.labelControl5.Text = "Mã nhân viên:";
         // 
         // labelControl6
         // 
         this.labelControl6.Location = new System.Drawing.Point(193, 77);
         this.labelControl6.Name = "labelControl6";
         this.labelControl6.Size = new System.Drawing.Size(42, 13);
         this.labelControl6.TabIndex = 10;
         this.labelControl6.Text = "Mã kho:";
         // 
         // frmGoodsDeliveryNote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(969, 457);
         this.Controls.Add(this.gcDeliveryNote);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.pnSub);
         this.Controls.Add(this.barDockControl4);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmGoodsDeliveryNote";
         this.Text = "QUẢN LÝ PHIẾU XUẤT";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoodsDeliveryNote_FormClosing);
         this.Load += new System.EventHandler(this.frmGoodsDeliveryNote_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbCTPX)).EndInit();
         this.gbCTPX.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVTCH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbDeliveryNote)).EndInit();
         this.gbDeliveryNote.ResumeLayout(false);
         this.gbDeliveryNote.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpDate.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeMaKho.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnSub)).EndInit();
         this.pnSub.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private DataSet dataSet;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraBars.BarManager bmPN;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraBars.BarButtonItem btnUndo;
      private DevExpress.XtraBars.BarButtonItem btnRefresh;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private System.Windows.Forms.BindingSource bdsPX;
      private DataSetTableAdapters.PhieuXuatTableAdapter taPX;
      private DevExpress.XtraGrid.GridControl gcDeliveryNote;
      private DevExpress.XtraGrid.Views.Grid.GridView gvDeliveryNote;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DevExpress.XtraBars.Bar bar3;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private System.Windows.Forms.BindingSource bdsCTPX;
      private DataSetTableAdapters.CTPXTableAdapter taCTPX;
      private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
      private DevExpress.XtraBars.BarDockControl barDockControl4;
      private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      private DevExpress.XtraBars.BarButtonItem barButtonItem3;
      private DevExpress.XtraBars.BarButtonItem barButtonItem2;
      private DevExpress.XtraBars.BarButtonItem barButtonItem5;
      private DevExpress.XtraBars.BarButtonItem barButtonItem4;
      private System.Windows.Forms.BindingSource bdsDSKHO;
      private DataSetTableAdapters.DSKHOTableAdapter taDSKHO;
      private DevExpress.XtraEditors.GroupControl gbDeliveryNote;
      private DevExpress.XtraEditors.TextEdit txtId;
      private DevExpress.XtraEditors.DateEdit dtpDate;
      private DevExpress.XtraEditors.TextEdit txtCustomerName;
      private DevExpress.XtraEditors.GroupControl gbCTPX;
      private DevExpress.XtraEditors.SimpleButton btnRemoveLine;
      private DevExpress.XtraEditors.SimpleButton btnAddDataRow;
      private DevExpress.XtraGrid.GridControl gcCTPX;
      private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
      private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
      private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraEditors.PanelControl pnSub;
      private DevExpress.XtraEditors.LookUpEdit lkeEmployee;
      private DevExpress.XtraEditors.LookUpEdit lkeMaKho;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
      private DevExpress.XtraGrid.Columns.GridColumn colTHANHTIEN;
      private System.Windows.Forms.BindingSource bdsDSVTCH;
      private DataSetTableAdapters.DSVTCONHANGTableAdapter taDSVTCH;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private DevExpress.XtraEditors.LabelControl labelControl6;
   }
}