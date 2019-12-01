namespace QLVT_DATHANG.Forms
{
   partial class frmAddOrder
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrder));
         this.bmVT = new DevExpress.XtraBars.BarManager(this.components);
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
         this.gbOrder = new DevExpress.XtraEditors.GroupControl();
         this.lcOrder = new DevExpress.XtraLayout.LayoutControl();
         this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
         this.cboNCC = new System.Windows.Forms.ComboBox();
         this.bdsDSNCC = new System.Windows.Forms.BindingSource(this.components);
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.txtOrderId = new DevExpress.XtraEditors.TextEdit();
         this.lkeDepot = new DevExpress.XtraEditors.LookUpEdit();
         this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
         this.lkeEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
         this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
         this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.panel1 = new System.Windows.Forms.Panel();
         this.pageOrderDetail = new DevExpress.XtraTab.XtraTabPage();
         this.gcOrderDetail = new DevExpress.XtraGrid.GridControl();
         this.gvOrderDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
         this.bdsDSVT = new System.Windows.Forms.BindingSource(this.components);
         this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gbOrderDetail = new DevExpress.XtraTab.XtraTabControl();
         this.taDSKHO = new QLVT_DATHANG.DataSetTableAdapters.DSKHOTableAdapter();
         this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
         this.taDSNCC = new QLVT_DATHANG.DataSetTableAdapters.DSNCCTableAdapter();
         this.taDSVT = new QLVT_DATHANG.DataSetTableAdapters.DSVTTableAdapter();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         ((System.ComponentModel.ISupportInitialize)(this.bmVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).BeginInit();
         this.gbOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.lcOrder)).BeginInit();
         this.lcOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNCC)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         this.pageOrderDetail.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).BeginInit();
         this.gbOrderDetail.SuspendLayout();
         this.SuspendLayout();
         // 
         // bmVT
         // 
         this.bmVT.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
         this.bmVT.DockControls.Add(this.barDockControl1);
         this.bmVT.DockControls.Add(this.barDockControl2);
         this.bmVT.DockControls.Add(this.barDockControl3);
         this.bmVT.DockControls.Add(this.barDockControl4);
         this.bmVT.Form = this;
         this.bmVT.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnExit,
            this.btnSave,
            this.btnCancelEdit});
         this.bmVT.MainMenu = this.bar3;
         this.bmVT.MaxItemId = 9;
         // 
         // bar3
         // 
         this.bar3.BarName = "Main menu";
         this.bar3.DockCol = 0;
         this.bar3.DockRow = 0;
         this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelEdit),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
         this.bar3.OptionsBar.MultiLine = true;
         this.bar3.OptionsBar.UseWholeRow = true;
         this.bar3.Text = "Main menu";
         // 
         // btnAdd
         // 
         this.btnAdd.Caption = "THÊM";
         this.btnAdd.Id = 0;
         this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
         // 
         // btnEdit
         // 
         this.btnEdit.Caption = "SỬA";
         this.btnEdit.Id = 1;
         this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
         this.btnEdit.Name = "btnEdit";
         // 
         // btnSave
         // 
         this.btnSave.Caption = "LƯU";
         this.btnSave.Id = 5;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 4;
         this.btnExit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.btnExit.Name = "btnExit";
         // 
         // barDockControl1
         // 
         this.barDockControl1.CausesValidation = false;
         this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControl1.Location = new System.Drawing.Point(0, 0);
         this.barDockControl1.Manager = this.bmVT;
         this.barDockControl1.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl1.Size = new System.Drawing.Size(845, 24);
         // 
         // barDockControl2
         // 
         this.barDockControl2.CausesValidation = false;
         this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControl2.Location = new System.Drawing.Point(0, 481);
         this.barDockControl2.Manager = this.bmVT;
         this.barDockControl2.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl2.Size = new System.Drawing.Size(845, 0);
         // 
         // barDockControl3
         // 
         this.barDockControl3.CausesValidation = false;
         this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControl3.Location = new System.Drawing.Point(0, 24);
         this.barDockControl3.Manager = this.bmVT;
         this.barDockControl3.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl3.Size = new System.Drawing.Size(0, 457);
         // 
         // barDockControl4
         // 
         this.barDockControl4.CausesValidation = false;
         this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControl4.Location = new System.Drawing.Point(845, 24);
         this.barDockControl4.Manager = this.bmVT;
         this.barDockControl4.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl4.Size = new System.Drawing.Size(0, 457);
         // 
         // gbOrder
         // 
         this.gbOrder.Controls.Add(this.lcOrder);
         this.gbOrder.Dock = System.Windows.Forms.DockStyle.Top;
         this.gbOrder.Location = new System.Drawing.Point(0, 24);
         this.gbOrder.Name = "gbOrder";
         this.gbOrder.Size = new System.Drawing.Size(845, 171);
         this.gbOrder.TabIndex = 0;
         this.gbOrder.Text = "Thông tin đơn đặt hàng";
         // 
         // lcOrder
         // 
         this.lcOrder.Controls.Add(this.dtpOrderDate);
         this.lcOrder.Controls.Add(this.cboNCC);
         this.lcOrder.Controls.Add(this.txtOrderId);
         this.lcOrder.Controls.Add(this.lkeDepot);
         this.lcOrder.Controls.Add(this.lkeEmployee);
         this.lcOrder.Dock = System.Windows.Forms.DockStyle.Left;
         this.lcOrder.Location = new System.Drawing.Point(2, 20);
         this.lcOrder.Name = "lcOrder";
         this.lcOrder.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(529, 30, 650, 400);
         this.lcOrder.Root = this.Root;
         this.lcOrder.Size = new System.Drawing.Size(475, 149);
         this.lcOrder.TabIndex = 0;
         this.lcOrder.Text = "layoutControl1";
         // 
         // dtpOrderDate
         // 
         this.dtpOrderDate.EditValue = null;
         this.dtpOrderDate.Location = new System.Drawing.Point(123, 63);
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
         this.dtpOrderDate.Properties.ReadOnly = true;
         this.dtpOrderDate.Size = new System.Drawing.Size(340, 22);
         this.dtpOrderDate.StyleController = this.lcOrder;
         this.dtpOrderDate.TabIndex = 2;
         this.dtpOrderDate.Tag = "1";
         // 
         // cboNCC
         // 
         this.cboNCC.DataSource = this.bdsDSNCC;
         this.cboNCC.DisplayMember = "NhaCC";
         this.cboNCC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboNCC.FormattingEnabled = true;
         this.cboNCC.Location = new System.Drawing.Point(123, 38);
         this.cboNCC.Name = "cboNCC";
         this.cboNCC.Size = new System.Drawing.Size(340, 23);
         this.cboNCC.TabIndex = 1;
         this.cboNCC.Tag = "2";
         // 
         // bdsDSNCC
         // 
         this.bdsDSNCC.DataMember = "DSNCC";
         this.bdsDSNCC.DataSource = this.dataSet;
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // txtOrderId
         // 
         this.txtOrderId.Location = new System.Drawing.Point(123, 12);
         this.txtOrderId.Name = "txtOrderId";
         this.txtOrderId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtOrderId.Properties.Appearance.Options.UseFont = true;
         this.txtOrderId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtOrderId.Properties.MaxLength = 8;
         this.txtOrderId.Size = new System.Drawing.Size(340, 22);
         this.txtOrderId.StyleController = this.lcOrder;
         this.txtOrderId.TabIndex = 0;
         this.txtOrderId.Tag = "0";
         // 
         // lkeDepot
         // 
         this.lkeDepot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSKHO, "TENKHO", true));
         this.lkeDepot.Location = new System.Drawing.Point(123, 115);
         this.lkeDepot.Name = "lkeDepot";
         this.lkeDepot.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lkeDepot.Properties.Appearance.Options.UseFont = true;
         this.lkeDepot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.lkeDepot.Properties.DataSource = this.bdsDSKHO;
         this.lkeDepot.Properties.DisplayMember = "TENKHO";
         this.lkeDepot.Properties.NullText = "";
         this.lkeDepot.Properties.ValueMember = "MAKHO";
         this.lkeDepot.Size = new System.Drawing.Size(340, 22);
         this.lkeDepot.StyleController = this.lcOrder;
         this.lkeDepot.TabIndex = 4;
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
         this.lkeEmployee.Location = new System.Drawing.Point(123, 89);
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
         this.lkeEmployee.Properties.PopupView = this.searchLookUpEdit1View;
         this.lkeEmployee.Properties.ValueMember = "MANV";
         this.lkeEmployee.Size = new System.Drawing.Size(340, 22);
         this.lkeEmployee.StyleController = this.lcOrder;
         this.lkeEmployee.TabIndex = 3;
         this.lkeEmployee.Tag = "3";
         // 
         // bdsDSNV
         // 
         this.bdsDSNV.DataMember = "DSNV";
         this.bdsDSNV.DataSource = this.dataSet;
         // 
         // searchLookUpEdit1View
         // 
         this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
         this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
         this.searchLookUpEdit1View.OptionsFilter.ColumnFilterPopupRowCount = 10;
         this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
         this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
         // 
         // Root
         // 
         this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.Root.GroupBordersVisible = false;
         this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3});
         this.Root.Name = "Root";
         this.Root.Size = new System.Drawing.Size(475, 149);
         this.Root.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.txtOrderId;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(455, 26);
         this.layoutControlItem1.Text = "Mã số đơn đặt hàng:";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 13);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.cboNCC;
         this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(455, 25);
         this.layoutControlItem2.Text = "Nhà cung cấp:";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.lkeEmployee;
         this.layoutControlItem4.Location = new System.Drawing.Point(0, 77);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(455, 26);
         this.layoutControlItem4.Text = "Nhân viên đặt:";
         this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 13);
         // 
         // layoutControlItem5
         // 
         this.layoutControlItem5.Control = this.lkeDepot;
         this.layoutControlItem5.Location = new System.Drawing.Point(0, 103);
         this.layoutControlItem5.Name = "layoutControlItem5";
         this.layoutControlItem5.Size = new System.Drawing.Size(455, 26);
         this.layoutControlItem5.Text = "Kho:";
         this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.dtpOrderDate;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 51);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(455, 26);
         this.layoutControlItem3.Text = "Ngày đặt:";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 13);
         // 
         // panel1
         // 
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 435);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(845, 46);
         this.panel1.TabIndex = 1;
         // 
         // pageOrderDetail
         // 
         this.pageOrderDetail.AutoScroll = true;
         this.pageOrderDetail.Controls.Add(this.gcOrderDetail);
         this.pageOrderDetail.Name = "pageOrderDetail";
         this.pageOrderDetail.Size = new System.Drawing.Size(839, 258);
         this.pageOrderDetail.Text = "Chi tiết";
         // 
         // gcOrderDetail
         // 
         this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrderDetail.Location = new System.Drawing.Point(0, 0);
         this.gcOrderDetail.MainView = this.gvOrderDetail;
         this.gcOrderDetail.MenuManager = this.bmVT;
         this.gcOrderDetail.Name = "gcOrderDetail";
         this.gcOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
         this.gcOrderDetail.Size = new System.Drawing.Size(839, 258);
         this.gcOrderDetail.TabIndex = 5;
         this.gcOrderDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrderDetail});
         // 
         // gvOrderDetail
         // 
         this.gvOrderDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvOrderDetail.Appearance.HeaderPanel.Options.UseFont = true;
         this.gvOrderDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
         this.gvOrderDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
         this.gvOrderDetail.GridControl = this.gcOrderDetail;
         this.gvOrderDetail.Name = "gvOrderDetail";
         this.gvOrderDetail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
         this.gvOrderDetail.OptionsView.ShowGroupPanel = false;
         this.gvOrderDetail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvOrderDetail_CustomColumnDisplayText);
         // 
         // colMasoDDH
         // 
         this.colMasoDDH.FieldName = "MasoDDH";
         this.colMasoDDH.Name = "colMasoDDH";
         this.colMasoDDH.UnboundType = DevExpress.Data.UnboundColumnType.String;
         // 
         // colMAVT
         // 
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
         // bdsDSVT
         // 
         this.bdsDSVT.DataMember = "DSVT";
         this.bdsDSVT.DataSource = this.dataSet;
         // 
         // colSOLUONG
         // 
         this.colSOLUONG.FieldName = "SOLUONG";
         this.colSOLUONG.Name = "colSOLUONG";
         this.colSOLUONG.Visible = true;
         this.colSOLUONG.VisibleIndex = 1;
         // 
         // colDONGIA
         // 
         this.colDONGIA.FieldName = "DONGIA";
         this.colDONGIA.Name = "colDONGIA";
         this.colDONGIA.Visible = true;
         this.colDONGIA.VisibleIndex = 2;
         // 
         // gbOrderDetail
         // 
         this.gbOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbOrderDetail.Location = new System.Drawing.Point(0, 195);
         this.gbOrderDetail.Name = "gbOrderDetail";
         this.gbOrderDetail.SelectedTabPage = this.pageOrderDetail;
         this.gbOrderDetail.Size = new System.Drawing.Size(845, 286);
         this.gbOrderDetail.TabIndex = 3;
         this.gbOrderDetail.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageOrderDetail});
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
         // taDSVT
         // 
         this.taDSVT.ClearBeforeFill = true;
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Id = 8;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelEdit_ItemClick);
         // 
         // frmAddOrder
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(845, 481);
         this.Controls.Add(this.panel1);
         this.Controls.Add(this.gbOrderDetail);
         this.Controls.Add(this.gbOrder);
         this.Controls.Add(this.barDockControl3);
         this.Controls.Add(this.barDockControl4);
         this.Controls.Add(this.barDockControl2);
         this.Controls.Add(this.barDockControl1);
         this.Name = "frmAddOrder";
         this.Text = "frmAddOrder";
         this.Load += new System.EventHandler(this.frmAddOrder_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bmVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).EndInit();
         this.gbOrder.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.lcOrder)).EndInit();
         this.lcOrder.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNCC)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         this.pageOrderDetail.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).EndInit();
         this.gbOrderDetail.ResumeLayout(false);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager bmVT;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnEdit;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraBars.BarDockControl barDockControl1;
      private DevExpress.XtraBars.BarDockControl barDockControl2;
      private DevExpress.XtraBars.BarDockControl barDockControl3;
      private DevExpress.XtraBars.BarDockControl barDockControl4;
      private System.Windows.Forms.Panel panel1;
      private DevExpress.XtraTab.XtraTabControl gbOrderDetail;
      private DevExpress.XtraTab.XtraTabPage pageOrderDetail;
      private DevExpress.XtraEditors.GroupControl gbOrder;
      private DevExpress.XtraLayout.LayoutControl lcOrder;
      private System.Windows.Forms.ComboBox cboNCC;
      private DevExpress.XtraEditors.TextEdit txtOrderId;
      private DevExpress.XtraEditors.LookUpEdit lkeDepot;
      private DevExpress.XtraEditors.DateEdit dtpOrderDate;
      private DevExpress.XtraEditors.SearchLookUpEdit lkeEmployee;
      private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
      private System.Windows.Forms.BindingSource bdsDSKHO;
      private DataSetTableAdapters.DSKHOTableAdapter taDSKHO;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private System.Windows.Forms.BindingSource bdsDSNCC;
      private DataSetTableAdapters.DSNCCTableAdapter taDSNCC;
      private System.Windows.Forms.BindingSource bdsDSVT;
      private DataSetTableAdapters.DSVTTableAdapter taDSVT;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DataSet dataSet;
      private DevExpress.XtraGrid.GridControl gcOrderDetail;
      private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetail;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
      private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
   }
}