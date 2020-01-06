namespace QLVT_DATHANG.Forms
{
   partial class frmGoodsReceivedNote
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsReceivedNote));
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
            this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboDeployment = new System.Windows.Forms.ComboBox();
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.taPN = new QLVT_DATHANG.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.gcReceivedNote = new DevExpress.XtraGrid.GridControl();
            this.gvReceivedNote = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.sccReceived = new DevExpress.XtraEditors.SplitContainerControl();
            this.gbReceivedNote = new DevExpress.XtraEditors.GroupControl();
            this.lkeDepot = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkeEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkeMaDDH = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsDSDDHChuaCoPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.gbCTPN = new DevExpress.XtraEditors.GroupControl();
            this.btnRemoveDataRow = new DevExpress.XtraEditors.SimpleButton();
            this.gcCTPN = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.bdsDSVTDH = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.THANHTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDSVT = new System.Windows.Forms.BindingSource(this.components);
            this.cmsCTPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddCTPN = new System.Windows.Forms.ToolStripMenuItem();
            this.taCTPN = new QLVT_DATHANG.DataSetTableAdapters.CTPNTableAdapter();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.taDDH = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
            this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
            this.taDSVT = new QLVT_DATHANG.DataSetTableAdapters.DSVTTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            this.taDSKHO = new QLVT_DATHANG.DataSetTableAdapters.DSKHOTableAdapter();
            this.taDSVTDH = new QLVT_DATHANG.DataSetTableAdapters.DSVTDHTableAdapter();
            this.taDSDDHChuaCoPhieuNhap = new QLVT_DATHANG.DataSetTableAdapters.sp_dsddhchuacophieunhapTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
            this.pnPickDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceivedNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceivedNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccReceived)).BeginInit();
            this.sccReceived.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbReceivedNote)).BeginInit();
            this.gbReceivedNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDDHChuaCoPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPN)).BeginInit();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSVTDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).BeginInit();
            this.cmsCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAPNLabel.Location = new System.Drawing.Point(5, 37);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(111, 20);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "Mã phiếu nhập:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nGAYLabel.Location = new System.Drawing.Point(363, 37);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(73, 20);
            nGAYLabel.TabIndex = 4;
            nGAYLabel.Text = "Ngày đặt:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            masoDDHLabel.Location = new System.Drawing.Point(5, 72);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(145, 20);
            masoDDHLabel.TabIndex = 2;
            masoDDHLabel.Text = "Mã số đơn đặt hàng:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(295, 72);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(78, 20);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "Nhân viên:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(5, 104);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(59, 19);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã kho:";
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1171, 33);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 703);
            this.barDockControlBottom.Manager = this.bmPN;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1171, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 33);
            this.barDockControlLeft.Manager = this.bmPN;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 670);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1171, 33);
            this.barDockControlRight.Manager = this.bmPN;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 670);
            // 
            // pnPickDepartment
            // 
            this.pnPickDepartment.Controls.Add(this.labelControl1);
            this.pnPickDepartment.Controls.Add(this.cboDeployment);
            this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPickDepartment.Location = new System.Drawing.Point(0, 33);
            this.pnPickDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnPickDepartment.Name = "pnPickDepartment";
            this.pnPickDepartment.Size = new System.Drawing.Size(1171, 39);
            this.pnPickDepartment.TabIndex = 0;
            this.pnPickDepartment.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Chọn Chi Nhánh:";
            // 
            // cboDeployment
            // 
            this.cboDeployment.BackColor = System.Drawing.SystemColors.Window;
            this.cboDeployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeployment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDeployment.FormattingEnabled = true;
            this.cboDeployment.Location = new System.Drawing.Point(125, 7);
            this.cboDeployment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDeployment.Name = "cboDeployment";
            this.cboDeployment.Size = new System.Drawing.Size(224, 25);
            this.cboDeployment.TabIndex = 1;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.dataSet;
            // 
            // taPN
            // 
            this.taPN.ClearBeforeFill = true;
            // 
            // gcReceivedNote
            // 
            this.gcReceivedNote.DataSource = this.bdsPN;
            this.gcReceivedNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReceivedNote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcReceivedNote.Location = new System.Drawing.Point(0, 72);
            this.gcReceivedNote.MainView = this.gvReceivedNote;
            this.gcReceivedNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcReceivedNote.MenuManager = this.bmPN;
            this.gcReceivedNote.Name = "gcReceivedNote";
            this.gcReceivedNote.Size = new System.Drawing.Size(1171, 404);
            this.gcReceivedNote.TabIndex = 1;
            this.gcReceivedNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReceivedNote});
            // 
            // gvReceivedNote
            // 
            this.gvReceivedNote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gvReceivedNote.DetailHeight = 458;
            this.gvReceivedNote.FixedLineWidth = 3;
            this.gvReceivedNote.GridControl = this.gcReceivedNote;
            this.gvReceivedNote.Name = "gvReceivedNote";
            this.gvReceivedNote.OptionsBehavior.Editable = false;
            this.gvReceivedNote.OptionsView.ShowGroupPanel = false;
            this.gvReceivedNote.OptionsView.ShowViewCaption = true;
            this.gvReceivedNote.ViewCaption = "Danh sách Phiếu Nhập";
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "MÃ PHIẾU NHẬP";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 23;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 87;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "NGÀY";
            this.colNGAY.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 23;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 87;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "MÃ SÓ ĐƠN ĐẶT HÀNG";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 23;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 87;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MÃ NHÂN VIÊN";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 87;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "MÃ KHO";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 23;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 87;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 476);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1171, 12);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // sccReceived
            // 
            this.sccReceived.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sccReceived.Location = new System.Drawing.Point(0, 488);
            this.sccReceived.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sccReceived.Name = "sccReceived";
            this.sccReceived.Panel1.Controls.Add(this.gbReceivedNote);
            this.sccReceived.Panel1.Text = "Panel1";
            this.sccReceived.Panel2.Controls.Add(this.gbCTPN);
            this.sccReceived.Panel2.Text = "Panel2";
            this.sccReceived.Size = new System.Drawing.Size(1171, 215);
            this.sccReceived.SplitterPosition = 611;
            this.sccReceived.TabIndex = 28;
            // 
            // gbReceivedNote
            // 
            this.gbReceivedNote.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReceivedNote.AppearanceCaption.Options.UseFont = true;
            this.gbReceivedNote.Controls.Add(this.lkeDepot);
            this.gbReceivedNote.Controls.Add(mAKHOLabel);
            this.gbReceivedNote.Controls.Add(this.lkeEmployee);
            this.gbReceivedNote.Controls.Add(this.lkeMaDDH);
            this.gbReceivedNote.Controls.Add(mAPNLabel);
            this.gbReceivedNote.Controls.Add(this.txtMaPN);
            this.gbReceivedNote.Controls.Add(nGAYLabel);
            this.gbReceivedNote.Controls.Add(this.txtDate);
            this.gbReceivedNote.Controls.Add(masoDDHLabel);
            this.gbReceivedNote.Controls.Add(mANVLabel);
            this.gbReceivedNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbReceivedNote.Location = new System.Drawing.Point(0, 0);
            this.gbReceivedNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbReceivedNote.Name = "gbReceivedNote";
            this.gbReceivedNote.Size = new System.Drawing.Size(611, 215);
            this.gbReceivedNote.TabIndex = 0;
            this.gbReceivedNote.Text = "Thông tin Phiếu Nhập";
            // 
            // lkeDepot
            // 
            this.lkeDepot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAKHO", true));
            this.lkeDepot.EditValue = "";
            this.dxErrorProvider.SetIconAlignment(this.lkeDepot, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.lkeDepot.Location = new System.Drawing.Point(156, 101);
            this.lkeDepot.MenuManager = this.bmPN;
            this.lkeDepot.Name = "lkeDepot";
            this.lkeDepot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeDepot.Properties.DataSource = this.bdsDSKHO;
            this.lkeDepot.Properties.DisplayMember = "TENKHO";
            this.lkeDepot.Properties.NullText = "";
            this.lkeDepot.Properties.PopupView = this.gridView2;
            this.lkeDepot.Properties.ValueMember = "MAKHO";
            this.lkeDepot.Size = new System.Drawing.Size(201, 24);
            this.lkeDepot.TabIndex = 9;
            // 
            // bdsDSKHO
            // 
            this.bdsDSKHO.DataMember = "DSKHO";
            this.bdsDSKHO.DataSource = this.dataSet;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // lkeEmployee
            // 
            this.lkeEmployee.CausesValidation = false;
            this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "MANV", true));
            this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MANV", true));
            this.dxErrorProvider.SetIconAlignment(this.lkeEmployee, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.lkeEmployee.Location = new System.Drawing.Point(379, 69);
            this.lkeEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkeEmployee.MenuManager = this.bmPN;
            this.lkeEmployee.Name = "lkeEmployee";
            this.lkeEmployee.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lkeEmployee.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeEmployee.Properties.Appearance.Options.UseFont = true;
            this.lkeEmployee.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkeEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
            this.lkeEmployee.Properties.DataSource = this.bdsDSNV;
            this.lkeEmployee.Properties.DisplayMember = "HOTEN";
            this.lkeEmployee.Properties.NullText = "";
            this.lkeEmployee.Properties.PopupView = this.gridView1;
            this.lkeEmployee.Properties.ReadOnly = true;
            this.lkeEmployee.Properties.ValueMember = "MANV";
            this.lkeEmployee.Size = new System.Drawing.Size(227, 26);
            this.lkeEmployee.TabIndex = 7;
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.dataSet;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // lkeMaDDH
            // 
            this.lkeMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.lkeMaDDH.EditValue = "";
            this.dxErrorProvider.SetIconAlignment(this.lkeMaDDH, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.lkeMaDDH.Location = new System.Drawing.Point(156, 69);
            this.lkeMaDDH.MenuManager = this.bmPN;
            this.lkeMaDDH.Name = "lkeMaDDH";
            this.lkeMaDDH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeMaDDH.Properties.Appearance.Options.UseFont = true;
            this.lkeMaDDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeMaDDH.Properties.DataSource = this.bdsDSDDHChuaCoPhieuNhap;
            this.lkeMaDDH.Properties.DisplayMember = "Mã số DDH";
            this.lkeMaDDH.Properties.NullText = "";
            this.lkeMaDDH.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkeMaDDH.Properties.ValueMember = "Mã số DDH";
            this.lkeMaDDH.Size = new System.Drawing.Size(133, 26);
            this.lkeMaDDH.TabIndex = 3;
            this.lkeMaDDH.EditValueChanged += new System.EventHandler(this.lkeMaDDH_EditValueChanged);
            // 
            // bdsDSDDHChuaCoPhieuNhap
            // 
            this.bdsDSDDHChuaCoPhieuNhap.DataMember = "sp_dsddhchuacophieunhap";
            this.bdsDSDDHChuaCoPhieuNhap.DataSource = this.dataSet;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAPN", true));
            this.dxErrorProvider.SetIconAlignment(this.txtMaPN, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtMaPN.Location = new System.Drawing.Point(156, 34);
            this.txtMaPN.MenuManager = this.bmPN;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Properties.Appearance.Options.UseFont = true;
            this.txtMaPN.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaPN.Properties.MaxLength = 8;
            this.txtMaPN.Size = new System.Drawing.Size(201, 26);
            this.txtMaPN.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.txtDate.EditValue = null;
            this.dxErrorProvider.SetIconAlignment(this.txtDate, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.txtDate.Location = new System.Drawing.Point(442, 34);
            this.txtDate.MenuManager = this.bmPN;
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Properties.Appearance.Options.UseFont = true;
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.txtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.txtDate.Properties.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(164, 26);
            this.txtDate.TabIndex = 5;
            // 
            // gbCTPN
            // 
            this.gbCTPN.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCTPN.AppearanceCaption.Options.UseFont = true;
            this.gbCTPN.Controls.Add(this.btnRemoveDataRow);
            this.gbCTPN.Controls.Add(this.gcCTPN);
            this.gbCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPN.Location = new System.Drawing.Point(0, 0);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(548, 215);
            this.gbCTPN.TabIndex = 0;
            this.gbCTPN.Text = " Chi tiết Phiếu Nhập";
            // 
            // btnRemoveDataRow
            // 
            this.btnRemoveDataRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveDataRow.Location = new System.Drawing.Point(15, 181);
            this.btnRemoveDataRow.Name = "btnRemoveDataRow";
            this.btnRemoveDataRow.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveDataRow.TabIndex = 1;
            this.btnRemoveDataRow.Text = "Xóa Dòng";
            this.btnRemoveDataRow.Click += new System.EventHandler(this.btnRemoveDataRow_Click);
            // 
            // gcCTPN
            // 
            this.gcCTPN.DataSource = this.bdsCTPN;
            this.gcCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCTPN.Location = new System.Drawing.Point(2, 28);
            this.gcCTPN.MainView = this.gvCTPN;
            this.gcCTPN.MenuManager = this.bmPN;
            this.gcCTPN.Name = "gcCTPN";
            this.gcCTPN.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemTextEdit1});
            this.gcCTPN.Size = new System.Drawing.Size(544, 185);
            this.gcCTPN.TabIndex = 0;
            this.gcCTPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPN});
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // gvCTPN
            // 
            this.gvCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA,
            this.THANHTIEN});
            this.gvCTPN.GridControl = this.gcCTPN;
            this.gvCTPN.Name = "gvCTPN";
            this.gvCTPN.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvCTPN.OptionsView.ShowFooter = true;
            this.gvCTPN.OptionsView.ShowGroupPanel = false;
            this.gvCTPN.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvCTPN_ValidateRow);
            this.gvCTPN.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvCTPN_CustomColumnDisplayText);
            this.gvCTPN.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvCTPN_ValidatingEditor);
            // 
            // colMAPN1
            // 
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "VẬT TƯ";
            this.colMAVT.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.DataSource = this.bdsDSVTDH;
            this.repositoryItemSearchLookUpEdit1.DisplayMember = "TENVT";
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.NullText = "";
            this.repositoryItemSearchLookUpEdit1.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.repositoryItemSearchLookUpEdit1.ValueMember = "MAVT";
            // 
            // bdsDSVTDH
            // 
            this.bdsDSVTDH.DataMember = "DSVTDH";
            this.bdsDSVTDH.DataSource = this.dataSet;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "SỐ LƯỢNG";
            this.colSOLUONG.ColumnEdit = this.repositoryItemTextEdit1;
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 1;
            this.colSOLUONG.Width = 94;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "ĐƠN GIÁ";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 94;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.Caption = "THÀNH TIỀN";
            this.THANHTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.THANHTIEN.FieldName = "THANHTIEN";
            this.THANHTIEN.MinWidth = 25;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ShowUnboundExpressionMenu = true;
            this.THANHTIEN.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "THANHTIEN", "TỔNG TIỀN: {0:#,## đ}")});
            this.THANHTIEN.UnboundExpression = "[SOLUONG] * [DONGIA]";
            this.THANHTIEN.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.THANHTIEN.Visible = true;
            this.THANHTIEN.VisibleIndex = 3;
            this.THANHTIEN.Width = 94;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DatHang";
            this.bdsDDH.DataSource = this.dataSet;
            // 
            // bdsDSVT
            // 
            this.bdsDSVT.DataMember = "DSVT";
            this.bdsDSVT.DataSource = this.dataSet;
            // 
            // cmsCTPN
            // 
            this.cmsCTPN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCTPN});
            this.cmsCTPN.Name = "cmsCTPN";
            this.cmsCTPN.Size = new System.Drawing.Size(235, 28);
            // 
            // btnAddCTPN
            // 
            this.btnAddCTPN.Name = "btnAddCTPN";
            this.btnAddCTPN.Size = new System.Drawing.Size(234, 24);
            this.btnAddCTPN.Text = "Tạo Chi tiết Phiếu Nhập";
            this.btnAddCTPN.Click += new System.EventHandler(this.btnAddCTPN_Click);
            // 
            // taCTPN
            // 
            this.taCTPN.ClearBeforeFill = true;
            // 
            // dxErrorProvider
            // 
            this.dxErrorProvider.ContainerControl = this;
            // 
            // taDDH
            // 
            this.taDDH.ClearBeforeFill = true;
            // 
            // taDSNV
            // 
            this.taDSNV.ClearBeforeFill = true;
            // 
            // taDSVT
            // 
            this.taDSVT.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.taPN;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // taDSKHO
            // 
            this.taDSKHO.ClearBeforeFill = true;
            // 
            // taDSVTDH
            // 
            this.taDSVTDH.ClearBeforeFill = true;
            // 
            // taDSDDHChuaCoPhieuNhap
            // 
            this.taDSDDHChuaCoPhieuNhap.ClearBeforeFill = true;
            // 
            // frmGoodsReceivedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1171, 703);
            this.Controls.Add(this.gcReceivedNote);
            this.Controls.Add(this.pnPickDepartment);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.sccReceived);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoodsReceivedNote";
            this.Text = "QUẢN LÝ PHIẾU NHẬP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoodsReceivedNote_FormClosing);
            this.Load += new System.EventHandler(this.GoodsReceivedNote_Load);
            this.Resize += new System.EventHandler(this.frmGoodsReceivedNote_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
            this.pnPickDepartment.ResumeLayout(false);
            this.pnPickDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceivedNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReceivedNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccReceived)).EndInit();
            this.sccReceived.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbReceivedNote)).EndInit();
            this.gbReceivedNote.ResumeLayout(false);
            this.gbReceivedNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSDDHChuaCoPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPN)).EndInit();
            this.gbCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSVTDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).EndInit();
            this.cmsCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager bmPN;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnRefresh;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraBars.BarDockControl barDockControlTop;
      private DevExpress.XtraBars.BarDockControl barDockControlBottom;
      private DevExpress.XtraBars.BarDockControl barDockControlLeft;
      private DevExpress.XtraBars.BarDockControl barDockControlRight;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private System.Windows.Forms.BindingSource bdsPN;
      private DataSet dataSet;
      private DataSetTableAdapters.PhieuNhapTableAdapter taPN;
      private DevExpress.XtraGrid.GridControl gcReceivedNote;
      private DevExpress.XtraGrid.Views.Grid.GridView gvReceivedNote;
      private DevExpress.XtraEditors.SplitContainerControl sccReceived;
      private DevExpress.XtraEditors.GroupControl gbReceivedNote;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DataSetTableAdapters.CTPNTableAdapter taCTPN;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private DevExpress.XtraEditors.GroupControl gbCTPN;
        private System.Windows.Forms.BindingSource bdsDDH;
        private DataSetTableAdapters.DatHangTableAdapter taDDH;
        private DevExpress.XtraEditors.SearchLookUpEdit lkeMaDDH;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DataSetTableAdapters.DSNVTableAdepter taDSNV;
        private System.Windows.Forms.ContextMenuStrip cmsCTPN;
        private System.Windows.Forms.ToolStripMenuItem btnAddCTPN;
      private DevExpress.XtraEditors.SearchLookUpEdit lkeEmployee;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private System.Windows.Forms.BindingSource bdsDSVT;
      private DataSetTableAdapters.DSVTTableAdapter taDSVT;
      private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.GridControl gcCTPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraEditors.SearchLookUpEdit lkeDepot;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdsDSKHO;
        private DataSetTableAdapters.DSKHOTableAdapter taDSKHO;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private System.Windows.Forms.BindingSource bdsDSVTDH;
        private DataSetTableAdapters.DSVTDHTableAdapter taDSVTDH;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource bdsDSDDHChuaCoPhieuNhap;
        private DataSetTableAdapters.sp_dsddhchuacophieunhapTableAdapter taDSDDHChuaCoPhieuNhap;
        private DevExpress.XtraEditors.SimpleButton btnRemoveDataRow;
        private DevExpress.XtraGrid.Columns.GridColumn THANHTIEN;
    }
}