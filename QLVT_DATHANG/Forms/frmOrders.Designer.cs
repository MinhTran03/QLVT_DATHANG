namespace QLVT_DATHANG.Forms
{
   partial class frmOrders
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
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
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
         this.taDDH = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
         this.gcOrder = new DevExpress.XtraGrid.GridControl();
         this.gvOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.bdsDSVT = new System.Windows.Forms.BindingSource(this.components);
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.taCTDDH = new QLVT_DATHANG.DataSetTableAdapters.CTDDHTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.taDSVT = new QLVT_DATHANG.DataSetTableAdapters.DSVTTableAdapter();
         this.pnSubform = new System.Windows.Forms.Panel();
         this.gbDetails = new DevExpress.XtraEditors.GroupControl();
         this.gcOrderDetail = new DevExpress.XtraGrid.GridControl();
         this.gvOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
         this.pnBtnOrderDetail = new System.Windows.Forms.Panel();
         this.btnRemoveLine = new DevExpress.XtraEditors.SimpleButton();
         this.btnAddMaterials = new DevExpress.XtraEditors.SimpleButton();
         this.gbOrder = new DevExpress.XtraEditors.GroupControl();
         this.txtEmployeeId = new DevExpress.XtraEditors.TextEdit();
         this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
         this.txtOrderId = new DevExpress.XtraEditors.TextEdit();
         this.cboNCC = new System.Windows.Forms.ComboBox();
         this.bdsDSNCC = new System.Windows.Forms.BindingSource(this.components);
         this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
         this.lkeDepot = new DevExpress.XtraEditors.LookUpEdit();
         this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
         this.lkeEmployee = new DevExpress.XtraEditors.LookUpEdit();
         this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
         this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         this.taDSKHO = new QLVT_DATHANG.DataSetTableAdapters.DSKHOTableAdapter();
         this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
         this.taDSNCC = new QLVT_DATHANG.DataSetTableAdapters.DSNCCTableAdapter();
         this.dsvtTableAdapter1 = new QLVT_DATHANG.DataSetTableAdapters.DSVTTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         this.pnSubform.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).BeginInit();
         this.gbDetails.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
         this.pnBtnOrderDetail.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).BeginInit();
         this.gbOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNCC)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
         this.SuspendLayout();
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
         this.bmPN.MaxItemId = 30;
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
         this.barDockControlTop.Size = new System.Drawing.Size(987, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
         this.barDockControlBottom.Manager = this.bmPN;
         this.barDockControlBottom.Size = new System.Drawing.Size(987, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmPN;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(987, 24);
         this.barDockControlRight.Manager = this.bmPN;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bdsDDH
         // 
         this.bdsDDH.DataMember = "DatHang";
         this.bdsDDH.DataSource = this.dataSet;
         // 
         // taDDH
         // 
         this.taDDH.ClearBeforeFill = true;
         // 
         // gcOrder
         // 
         this.gcOrder.DataSource = this.bdsDDH;
         this.gcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gcOrder.Location = new System.Drawing.Point(0, 54);
         this.gcOrder.LookAndFeel.SkinName = "DevExpress Dark Style";
         this.gcOrder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
         this.gcOrder.MainView = this.gvOrder;
         this.gcOrder.MenuManager = this.bmPN;
         this.gcOrder.Name = "gcOrder";
         this.gcOrder.Size = new System.Drawing.Size(987, 204);
         this.gcOrder.TabIndex = 1;
         this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrder});
         // 
         // gvOrder
         // 
         this.gvOrder.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.HeaderPanel.Options.UseFont = true;
         this.gvOrder.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.Row.Options.UseFont = true;
         this.gvOrder.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.SelectedRow.Options.UseFont = true;
         this.gvOrder.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrder.Appearance.ViewCaption.Options.UseFont = true;
         this.gvOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
         this.gvOrder.GridControl = this.gcOrder;
         this.gvOrder.Name = "gvOrder";
         this.gvOrder.OptionsBehavior.Editable = false;
         this.gvOrder.OptionsView.ShowGroupPanel = false;
         this.gvOrder.OptionsView.ShowViewCaption = true;
         this.gvOrder.ViewCaption = "Danh sách Đơn Đặt Hàng";
         // 
         // colMasoDDH
         // 
         this.colMasoDDH.Caption = "MÃ SỐ ĐƠN ĐẶT HÀNG";
         this.colMasoDDH.FieldName = "MasoDDH";
         this.colMasoDDH.Name = "colMasoDDH";
         this.colMasoDDH.Visible = true;
         this.colMasoDDH.VisibleIndex = 0;
         // 
         // colNGAY
         // 
         this.colNGAY.Caption = "NGÀY ĐẶT";
         this.colNGAY.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.colNGAY.FieldName = "NGAY";
         this.colNGAY.Name = "colNGAY";
         this.colNGAY.Visible = true;
         this.colNGAY.VisibleIndex = 1;
         // 
         // colNhaCC
         // 
         this.colNhaCC.Caption = "NHÀ CUNG CẤP";
         this.colNhaCC.FieldName = "NhaCC";
         this.colNhaCC.Name = "colNhaCC";
         this.colNhaCC.Visible = true;
         this.colNhaCC.VisibleIndex = 2;
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
         // bdsDSVT
         // 
         this.bdsDSVT.DataMember = "DSVT";
         this.bdsDSVT.DataSource = this.dataSet;
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitterControl1.Location = new System.Drawing.Point(0, 258);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(987, 5);
         this.splitterControl1.TabIndex = 2;
         this.splitterControl1.TabStop = false;
         // 
         // bdsCTDDH
         // 
         this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
         this.bdsCTDDH.DataSource = this.bdsDDH;
         this.bdsCTDDH.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bdsCTDDH_ListChanged);
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(987, 30);
         this.pnPickDepartment.TabIndex = 0;
         this.pnPickDepartment.Visible = false;
         // 
         // labelControl1
         // 
         this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl1.Appearance.Options.UseFont = true;
         this.labelControl1.Location = new System.Drawing.Point(12, 8);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(92, 15);
         this.labelControl1.TabIndex = 0;
         this.labelControl1.Text = "Chọn Chi Nhánh:";
         // 
         // cboDeployment
         // 
         this.cboDeployment.BackColor = System.Drawing.SystemColors.Window;
         this.cboDeployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDeployment.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.cboDeployment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboDeployment.FormattingEnabled = true;
         this.cboDeployment.Location = new System.Drawing.Point(110, 4);
         this.cboDeployment.Name = "cboDeployment";
         this.cboDeployment.Size = new System.Drawing.Size(193, 23);
         this.cboDeployment.TabIndex = 1;
         // 
         // taCTDDH
         // 
         this.taCTDDH.ClearBeforeFill = true;
         // 
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // taDSVT
         // 
         this.taDSVT.ClearBeforeFill = true;
         // 
         // pnSubform
         // 
         this.pnSubform.Controls.Add(this.gbDetails);
         this.pnSubform.Controls.Add(this.gbOrder);
         this.pnSubform.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.pnSubform.Location = new System.Drawing.Point(0, 263);
         this.pnSubform.Name = "pnSubform";
         this.pnSubform.Size = new System.Drawing.Size(987, 205);
         this.pnSubform.TabIndex = 17;
         // 
         // gbDetails
         // 
         this.gbDetails.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbDetails.AppearanceCaption.Options.UseFont = true;
         this.gbDetails.Controls.Add(this.gcOrderDetail);
         this.gbDetails.Controls.Add(this.pnBtnOrderDetail);
         this.gbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbDetails.Location = new System.Drawing.Point(459, 0);
         this.gbDetails.Name = "gbDetails";
         this.gbDetails.Size = new System.Drawing.Size(528, 205);
         this.gbDetails.TabIndex = 1;
         this.gbDetails.Text = "Chi tiết đơn đặt hàng";
         // 
         // gcOrderDetail
         // 
         this.gcOrderDetail.DataSource = this.bdsCTDDH;
         this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrderDetail.Location = new System.Drawing.Point(2, 22);
         this.gcOrderDetail.MainView = this.gvOrderDetail;
         this.gcOrderDetail.Name = "gcOrderDetail";
         this.gcOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
         this.gcOrderDetail.Size = new System.Drawing.Size(524, 154);
         this.gcOrderDetail.TabIndex = 0;
         this.gcOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetail});
         // 
         // gvOrderDetail
         // 
         this.gvOrderDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrderDetail.Appearance.HeaderPanel.Options.UseFont = true;
         this.gvOrderDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.gvOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
         this.gvOrderDetail.GridControl = this.gcOrderDetail;
         this.gvOrderDetail.Name = "gvOrderDetail";
         this.gvOrderDetail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
         this.gvOrderDetail.OptionsView.ShowGroupPanel = false;
         this.gvOrderDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvOrderDetail_ValidateRow);
         this.gvOrderDetail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvOrderDetail_CustomColumnDisplayText);
         this.gvOrderDetail.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvOrderDetail_ValidatingEditor);
         // 
         // gridColumn1
         // 
         this.gridColumn1.FieldName = "MasoDDH";
         this.gridColumn1.Name = "gridColumn1";
         this.gridColumn1.UnboundType = DevExpress.Data.UnboundColumnType.String;
         // 
         // colMAVT
         // 
         this.colMAVT.Caption = "VẬT TƯ";
         this.colMAVT.ColumnEdit = this.repositoryItemLookUpEdit1;
         this.colMAVT.FieldName = "MAVT";
         this.colMAVT.Name = "colMAVT";
         this.colMAVT.Visible = true;
         this.colMAVT.VisibleIndex = 0;
         // 
         // repositoryItemLookUpEdit1
         // 
         this.repositoryItemLookUpEdit1.AutoHeight = false;
         this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.repositoryItemLookUpEdit1.DataSource = this.bdsDSVT;
         this.repositoryItemLookUpEdit1.DisplayMember = "TENVT";
         this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
         this.repositoryItemLookUpEdit1.NullText = "";
         this.repositoryItemLookUpEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
         this.repositoryItemLookUpEdit1.ValueMember = "MAVT";
         // 
         // colSOLUONG
         // 
         this.colSOLUONG.Caption = "SỐ LƯỢNG";
         this.colSOLUONG.FieldName = "SOLUONG";
         this.colSOLUONG.Name = "colSOLUONG";
         this.colSOLUONG.Visible = true;
         this.colSOLUONG.VisibleIndex = 1;
         // 
         // colDONGIA
         // 
         this.colDONGIA.Caption = "ĐƠN GIÁ";
         this.colDONGIA.FieldName = "DONGIA";
         this.colDONGIA.Name = "colDONGIA";
         this.colDONGIA.Visible = true;
         this.colDONGIA.VisibleIndex = 2;
         // 
         // pnBtnOrderDetail
         // 
         this.pnBtnOrderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.pnBtnOrderDetail.Controls.Add(this.btnRemoveLine);
         this.pnBtnOrderDetail.Controls.Add(this.btnAddMaterials);
         this.pnBtnOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.pnBtnOrderDetail.Location = new System.Drawing.Point(2, 176);
         this.pnBtnOrderDetail.Name = "pnBtnOrderDetail";
         this.pnBtnOrderDetail.Size = new System.Drawing.Size(524, 27);
         this.pnBtnOrderDetail.TabIndex = 1;
         // 
         // btnRemoveLine
         // 
         this.btnRemoveLine.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRemoveLine.Appearance.Options.UseFont = true;
         this.btnRemoveLine.Enabled = false;
         this.btnRemoveLine.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_delete_sign_16;
         this.btnRemoveLine.Location = new System.Drawing.Point(109, 3);
         this.btnRemoveLine.Name = "btnRemoveLine";
         this.btnRemoveLine.Size = new System.Drawing.Size(100, 20);
         this.btnRemoveLine.TabIndex = 1;
         this.btnRemoveLine.Text = "Xóa dòng";
         this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveLine_Click);
         // 
         // btnAddMaterials
         // 
         this.btnAddMaterials.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnAddMaterials.Appearance.Options.UseFont = true;
         this.btnAddMaterials.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_add_list_16;
         this.btnAddMaterials.Location = new System.Drawing.Point(3, 3);
         this.btnAddMaterials.Name = "btnAddMaterials";
         this.btnAddMaterials.Size = new System.Drawing.Size(100, 20);
         this.btnAddMaterials.TabIndex = 0;
         this.btnAddMaterials.Text = "Thêm nhiều";
         this.btnAddMaterials.Click += new System.EventHandler(this.btnAddMaterials_Click);
         // 
         // gbOrder
         // 
         this.gbOrder.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbOrder.AppearanceCaption.Options.UseFont = true;
         this.gbOrder.Controls.Add(this.txtEmployeeId);
         this.gbOrder.Controls.Add(this.labelControl4);
         this.gbOrder.Controls.Add(this.labelControl3);
         this.gbOrder.Controls.Add(this.labelControl2);
         this.gbOrder.Controls.Add(this.labelControl5);
         this.gbOrder.Controls.Add(this.labelControl6);
         this.gbOrder.Controls.Add(this.txtOrderId);
         this.gbOrder.Controls.Add(this.cboNCC);
         this.gbOrder.Controls.Add(this.dtpOrderDate);
         this.gbOrder.Controls.Add(this.lkeDepot);
         this.gbOrder.Controls.Add(this.lkeEmployee);
         this.gbOrder.Dock = System.Windows.Forms.DockStyle.Left;
         this.gbOrder.Location = new System.Drawing.Point(0, 0);
         this.gbOrder.Name = "gbOrder";
         this.gbOrder.Size = new System.Drawing.Size(459, 205);
         this.gbOrder.TabIndex = 0;
         this.gbOrder.Text = "Thông tin đơn đặt hàng";
         // 
         // txtEmployeeId
         // 
         this.txtEmployeeId.Location = new System.Drawing.Point(108, 87);
         this.txtEmployeeId.Name = "txtEmployeeId";
         this.txtEmployeeId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmployeeId.Properties.Appearance.Options.UseFont = true;
         this.txtEmployeeId.Properties.ReadOnly = true;
         this.txtEmployeeId.Size = new System.Drawing.Size(105, 22);
         this.txtEmployeeId.TabIndex = 9;
         // 
         // labelControl4
         // 
         this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl4.Appearance.Options.UseFont = true;
         this.labelControl4.Location = new System.Drawing.Point(287, 61);
         this.labelControl4.Name = "labelControl4";
         this.labelControl4.Size = new System.Drawing.Size(24, 15);
         this.labelControl4.TabIndex = 6;
         this.labelControl4.Text = "Kho:";
         // 
         // labelControl3
         // 
         this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl3.Appearance.Options.UseFont = true;
         this.labelControl3.Location = new System.Drawing.Point(247, 35);
         this.labelControl3.Name = "labelControl3";
         this.labelControl3.Size = new System.Drawing.Size(51, 15);
         this.labelControl3.TabIndex = 2;
         this.labelControl3.Text = "Ngày đặt:";
         // 
         // labelControl2
         // 
         this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl2.Appearance.Options.UseFont = true;
         this.labelControl2.Location = new System.Drawing.Point(12, 61);
         this.labelControl2.Name = "labelControl2";
         this.labelControl2.Size = new System.Drawing.Size(77, 15);
         this.labelControl2.TabIndex = 4;
         this.labelControl2.Text = "Nhà cung cấp:";
         // 
         // labelControl5
         // 
         this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl5.Appearance.Options.UseFont = true;
         this.labelControl5.Location = new System.Drawing.Point(12, 90);
         this.labelControl5.Name = "labelControl5";
         this.labelControl5.Size = new System.Drawing.Size(77, 15);
         this.labelControl5.TabIndex = 8;
         this.labelControl5.Text = "Nhân viên đặt:";
         // 
         // labelControl6
         // 
         this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl6.Appearance.Options.UseFont = true;
         this.labelControl6.Location = new System.Drawing.Point(12, 35);
         this.labelControl6.Name = "labelControl6";
         this.labelControl6.Size = new System.Drawing.Size(70, 15);
         this.labelControl6.TabIndex = 0;
         this.labelControl6.Text = "Số đơn hàng:";
         // 
         // txtOrderId
         // 
         this.txtOrderId.Location = new System.Drawing.Point(108, 32);
         this.txtOrderId.Name = "txtOrderId";
         this.txtOrderId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtOrderId.Properties.Appearance.Options.UseFont = true;
         this.txtOrderId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtOrderId.Properties.MaxLength = 8;
         this.txtOrderId.Size = new System.Drawing.Size(133, 22);
         this.txtOrderId.TabIndex = 1;
         this.txtOrderId.Tag = "0";
         // 
         // cboNCC
         // 
         this.cboNCC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
         this.cboNCC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
         this.cboNCC.DataSource = this.bdsDSNCC;
         this.cboNCC.DisplayMember = "NhaCC";
         this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboNCC.FormattingEnabled = true;
         this.cboNCC.Location = new System.Drawing.Point(108, 58);
         this.cboNCC.Name = "cboNCC";
         this.cboNCC.Size = new System.Drawing.Size(173, 23);
         this.cboNCC.TabIndex = 5;
         this.cboNCC.Tag = "2";
         // 
         // bdsDSNCC
         // 
         this.bdsDSNCC.DataMember = "DSNCC";
         this.bdsDSNCC.DataSource = this.dataSet;
         // 
         // dtpOrderDate
         // 
         this.dtpOrderDate.EditValue = null;
         this.dtpOrderDate.Location = new System.Drawing.Point(304, 32);
         this.dtpOrderDate.Name = "dtpOrderDate";
         this.dtpOrderDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtpOrderDate.Properties.Appearance.Options.UseFont = true;
         this.dtpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpOrderDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.dtpOrderDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpOrderDate.Properties.EditFormat.FormatString = "dd/MM/yyyy";
         this.dtpOrderDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.dtpOrderDate.Properties.Mask.EditMask = "dd/MM/yyyy";
         this.dtpOrderDate.Size = new System.Drawing.Size(144, 22);
         this.dtpOrderDate.TabIndex = 3;
         this.dtpOrderDate.Tag = "1";
         // 
         // lkeDepot
         // 
         this.lkeDepot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSKHO, "TENKHO", true));
         this.lkeDepot.Location = new System.Drawing.Point(317, 58);
         this.lkeDepot.Name = "lkeDepot";
         this.lkeDepot.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lkeDepot.Properties.Appearance.Options.UseFont = true;
         this.lkeDepot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.lkeDepot.Properties.DataSource = this.bdsDSKHO;
         this.lkeDepot.Properties.DisplayMember = "TENKHO";
         this.lkeDepot.Properties.NullText = "";
         this.lkeDepot.Properties.ValueMember = "MAKHO";
         this.lkeDepot.Size = new System.Drawing.Size(131, 22);
         this.lkeDepot.TabIndex = 7;
         this.lkeDepot.Tag = "4";
         // 
         // bdsDSKHO
         // 
         this.bdsDSKHO.DataMember = "DSKHO";
         this.bdsDSKHO.DataSource = this.dataSet;
         // 
         // lkeEmployee
         // 
         this.lkeEmployee.CausesValidation = false;
         this.lkeEmployee.Location = new System.Drawing.Point(219, 87);
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
         this.lkeEmployee.Properties.ValueMember = "MANV";
         this.lkeEmployee.Size = new System.Drawing.Size(229, 22);
         this.lkeEmployee.TabIndex = 10;
         this.lkeEmployee.Tag = "3";
         this.lkeEmployee.EditValueChanged += new System.EventHandler(this.lkeEmployee_EditValueChanged);
         // 
         // bdsDSNV
         // 
         this.bdsDSNV.DataMember = "DSNV";
         this.bdsDSNV.DataSource = this.dataSet;
         // 
         // bindingSource1
         // 
         this.bindingSource1.DataMember = "DSVT";
         this.bindingSource1.DataSource = this.dataSet;
         // 
         // taDSKHO
         // 
         this.taDSKHO.ClearBeforeFill = true;
         // 
         // taDSNV
         // 
         this.taDSNV.ClearBeforeFill = true;
         // 
         // taDSNCC
         // 
         this.taDSNCC.ClearBeforeFill = true;
         // 
         // dsvtTableAdapter1
         // 
         this.dsvtTableAdapter1.ClearBeforeFill = true;
         // 
         // frmOrders
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(987, 468);
         this.Controls.Add(this.gcOrder);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.pnSubform);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmOrders";
         this.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrders_FormClosing);
         this.Load += new System.EventHandler(this.frmOrders_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         this.pnSubform.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gbDetails)).EndInit();
         this.gbDetails.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
         this.pnBtnOrderDetail.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).EndInit();
         this.gbOrder.ResumeLayout(false);
         this.gbOrder.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNCC)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
      private System.Windows.Forms.BindingSource bdsDDH;
      private DataSet dataSet;
      private DataSetTableAdapters.DatHangTableAdapter taDDH;
      private DevExpress.XtraGrid.GridControl gcOrder;
      private DevExpress.XtraGrid.Views.Grid.GridView gvOrder;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DataSetTableAdapters.CTDDHTableAdapter taCTDDH;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private System.Windows.Forms.BindingSource bdsCTDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
      private System.Windows.Forms.BindingSource bdsDSVT;
      private DataSetTableAdapters.DSVTTableAdapter taDSVT;
      private System.Windows.Forms.Panel pnSubform;
      private DevExpress.XtraEditors.GroupControl gbOrder;
      private DevExpress.XtraEditors.GroupControl gbDetails;
      private System.Windows.Forms.Panel pnBtnOrderDetail;
      private DevExpress.XtraEditors.SimpleButton btnRemoveLine;
      private DevExpress.XtraEditors.SimpleButton btnAddMaterials;
      private DevExpress.XtraGrid.GridControl gcOrderDetail;
      private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetail;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
      private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
      private System.Windows.Forms.BindingSource bdsDSNCC;
      private System.Windows.Forms.BindingSource bdsDSKHO;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private System.Windows.Forms.BindingSource bindingSource1;
      private DataSetTableAdapters.DSKHOTableAdapter taDSKHO;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private DataSetTableAdapters.DSNCCTableAdapter taDSNCC;
      private DataSetTableAdapters.DSVTTableAdapter dsvtTableAdapter1;
      private DevExpress.XtraEditors.TextEdit txtEmployeeId;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private DevExpress.XtraEditors.LabelControl labelControl6;
      private DevExpress.XtraEditors.TextEdit txtOrderId;
      private System.Windows.Forms.ComboBox cboNCC;
      private DevExpress.XtraEditors.DateEdit dtpOrderDate;
      private DevExpress.XtraEditors.LookUpEdit lkeDepot;
      private DevExpress.XtraEditors.LookUpEdit lkeEmployee;
   }
}