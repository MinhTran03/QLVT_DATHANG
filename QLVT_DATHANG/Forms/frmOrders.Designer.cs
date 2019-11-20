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
         System.Windows.Forms.Label masoDDHLabel;
         System.Windows.Forms.Label nGAYLabel;
         System.Windows.Forms.Label nhaCCLabel;
         System.Windows.Forms.Label mANVLabel;
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.bmPN = new DevExpress.XtraBars.BarManager(this.components);
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnDel = new DevExpress.XtraBars.BarButtonItem();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
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
         this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
         this.gcOrder = new DevExpress.XtraGrid.GridControl();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.sccOrder = new DevExpress.XtraEditors.SplitContainerControl();
         this.gbOrder = new DevExpress.XtraEditors.GroupControl();
         this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
         this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
         this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.txtOrderId = new DevExpress.XtraEditors.TextEdit();
         this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
         this.dtpProvider = new DevExpress.XtraEditors.TextEdit();
         this.gbOrderDetail = new DevExpress.XtraEditors.GroupControl();
         this.gcOrderDetail = new System.Windows.Forms.DataGridView();
         this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.taCTDDH = new QLVT_DATHANG.DataSetTableAdapters.CTDDHTableAdapter();
         this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
         this.taVT = new QLVT_DATHANG.DataSetTableAdapters.VattuTableAdapter();
         masoDDHLabel = new System.Windows.Forms.Label();
         nGAYLabel = new System.Windows.Forms.Label();
         nhaCCLabel = new System.Windows.Forms.Label();
         mANVLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.sccOrder)).BeginInit();
         this.sccOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).BeginInit();
         this.gbOrder.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpProvider.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).BeginInit();
         this.gbOrderDetail.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         this.SuspendLayout();
         // 
         // masoDDHLabel
         // 
         masoDDHLabel.AutoSize = true;
         masoDDHLabel.Location = new System.Drawing.Point(17, 26);
         masoDDHLabel.Name = "masoDDHLabel";
         masoDDHLabel.Size = new System.Drawing.Size(112, 13);
         masoDDHLabel.TabIndex = 0;
         masoDDHLabel.Text = "Mã Số Đơn Đặt Hàng:";
         // 
         // nGAYLabel
         // 
         nGAYLabel.AutoSize = true;
         nGAYLabel.Location = new System.Drawing.Point(17, 52);
         nGAYLabel.Name = "nGAYLabel";
         nGAYLabel.Size = new System.Drawing.Size(57, 13);
         nGAYLabel.TabIndex = 2;
         nGAYLabel.Text = "Ngày Đặt:";
         // 
         // nhaCCLabel
         // 
         nhaCCLabel.AutoSize = true;
         nhaCCLabel.Location = new System.Drawing.Point(17, 78);
         nhaCCLabel.Name = "nhaCCLabel";
         nhaCCLabel.Size = new System.Drawing.Size(80, 13);
         nhaCCLabel.TabIndex = 4;
         nhaCCLabel.Text = "Nhà Cung Cấp:";
         // 
         // mANVLabel
         // 
         mANVLabel.AutoSize = true;
         mANVLabel.Location = new System.Drawing.Point(17, 104);
         mANVLabel.Name = "mANVLabel";
         mANVLabel.Size = new System.Drawing.Size(59, 13);
         mANVLabel.TabIndex = 6;
         mANVLabel.Text = "Nhân Viên:";
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
            this.btnDel,
            this.btnEdit,
            this.btnSave,
            this.btnUndo,
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
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
         // 
         // btnEdit
         // 
         this.btnEdit.Caption = "SỬA";
         this.btnEdit.Id = 2;
         this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
         this.btnEdit.Name = "btnEdit";
         this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // btnDel
         // 
         this.btnDel.Caption = "XÓA";
         this.btnDel.Id = 1;
         this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
         this.btnDel.Name = "btnDel";
         this.btnDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // btnUndo
         // 
         this.btnUndo.Caption = "PHỤC HỒI";
         this.btnUndo.Id = 4;
         this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // btnRefresh
         // 
         this.btnRefresh.Caption = "LÀM MỚI";
         this.btnRefresh.Id = 5;
         this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // btnSave
         // 
         this.btnSave.Caption = "GHI";
         this.btnSave.Id = 3;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Id = 7;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 6;
         this.btnExit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.btnExit.Name = "btnExit";
         this.btnExit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         // 
         // barDockControlTop
         // 
         this.barDockControlTop.CausesValidation = false;
         this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
         this.barDockControlTop.Manager = this.bmPN;
         this.barDockControlTop.Size = new System.Drawing.Size(853, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 476);
         this.barDockControlBottom.Manager = this.bmPN;
         this.barDockControlBottom.Size = new System.Drawing.Size(853, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmPN;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 452);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(853, 24);
         this.barDockControlRight.Manager = this.bmPN;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 452);
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
         // tableAdapterManager
         // 
         this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
         this.tableAdapterManager.ChiNhanhTableAdapter = null;
         this.tableAdapterManager.CTDDHTableAdapter = null;
         this.tableAdapterManager.CTPNTableAdapter = null;
         this.tableAdapterManager.CTPXTableAdapter = null;
         this.tableAdapterManager.DatHangTableAdapter = this.taDDH;
         this.tableAdapterManager.KhoTableAdapter = null;
         this.tableAdapterManager.NhanVienTableAdapter = null;
         this.tableAdapterManager.PhieuNhapTableAdapter = null;
         this.tableAdapterManager.PhieuXuatTableAdapter = null;
         this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.tableAdapterManager.VattuTableAdapter = null;
         // 
         // gcOrder
         // 
         this.gcOrder.DataSource = this.bdsDDH;
         this.gcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrder.Location = new System.Drawing.Point(0, 54);
         this.gcOrder.LookAndFeel.SkinName = "DevExpress Dark Style";
         this.gcOrder.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
         this.gcOrder.MainView = this.gridView1;
         this.gcOrder.MenuManager = this.bmPN;
         this.gcOrder.Name = "gcOrder";
         this.gcOrder.Size = new System.Drawing.Size(853, 214);
         this.gcOrder.TabIndex = 5;
         this.gcOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV});
         this.gridView1.GridControl = this.gcOrder;
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsBehavior.Editable = false;
         this.gridView1.OptionsView.ShowGroupPanel = false;
         this.gridView1.OptionsView.ShowViewCaption = true;
         this.gridView1.ViewCaption = "Danh sách Đơn Đặt Hàng";
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
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitterControl1.Location = new System.Drawing.Point(0, 268);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(853, 5);
         this.splitterControl1.TabIndex = 6;
         this.splitterControl1.TabStop = false;
         // 
         // sccOrder
         // 
         this.sccOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.sccOrder.Location = new System.Drawing.Point(0, 273);
         this.sccOrder.Name = "sccOrder";
         this.sccOrder.Panel1.Controls.Add(this.gbOrder);
         this.sccOrder.Panel1.Text = "Panel1";
         this.sccOrder.Panel2.Controls.Add(this.gbOrderDetail);
         this.sccOrder.Panel2.Text = "Panel2";
         this.sccOrder.Size = new System.Drawing.Size(853, 203);
         this.sccOrder.SplitterPosition = 442;
         this.sccOrder.TabIndex = 7;
         // 
         // gbOrder
         // 
         this.gbOrder.Controls.Add(this.searchLookUpEdit1);
         this.gbOrder.Controls.Add(masoDDHLabel);
         this.gbOrder.Controls.Add(this.txtOrderId);
         this.gbOrder.Controls.Add(nGAYLabel);
         this.gbOrder.Controls.Add(this.dtpOrderDate);
         this.gbOrder.Controls.Add(nhaCCLabel);
         this.gbOrder.Controls.Add(this.dtpProvider);
         this.gbOrder.Controls.Add(mANVLabel);
         this.gbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbOrder.Location = new System.Drawing.Point(0, 0);
         this.gbOrder.Name = "gbOrder";
         this.gbOrder.Size = new System.Drawing.Size(442, 203);
         this.gbOrder.TabIndex = 0;
         this.gbOrder.Text = "Thông tin Đơn Đặt Hàng";
         // 
         // searchLookUpEdit1
         // 
         this.searchLookUpEdit1.CausesValidation = false;
         this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MANV", true));
         this.searchLookUpEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDSNV, "MANV", true));
         this.searchLookUpEdit1.Location = new System.Drawing.Point(135, 101);
         this.searchLookUpEdit1.MenuManager = this.bmPN;
         this.searchLookUpEdit1.Name = "searchLookUpEdit1";
         this.searchLookUpEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
         this.searchLookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
         this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)});
         this.searchLookUpEdit1.Properties.DataSource = this.bdsDSNV;
         this.searchLookUpEdit1.Properties.DisplayMember = "HOTEN";
         this.searchLookUpEdit1.Properties.NullText = "";
         this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
         this.searchLookUpEdit1.Properties.ValueMember = "MANV";
         this.searchLookUpEdit1.Size = new System.Drawing.Size(157, 20);
         this.searchLookUpEdit1.TabIndex = 12;
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
         this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
         this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
         // 
         // txtOrderId
         // 
         this.txtOrderId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MasoDDH", true));
         this.txtOrderId.Location = new System.Drawing.Point(135, 23);
         this.txtOrderId.MenuManager = this.bmPN;
         this.txtOrderId.Name = "txtOrderId";
         this.txtOrderId.Size = new System.Drawing.Size(157, 20);
         this.txtOrderId.TabIndex = 1;
         // 
         // dtpOrderDate
         // 
         this.dtpOrderDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAY", true));
         this.dtpOrderDate.EditValue = null;
         this.dtpOrderDate.Location = new System.Drawing.Point(135, 49);
         this.dtpOrderDate.MenuManager = this.bmPN;
         this.dtpOrderDate.Name = "dtpOrderDate";
         this.dtpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.dtpOrderDate.Size = new System.Drawing.Size(157, 20);
         this.dtpOrderDate.TabIndex = 3;
         // 
         // dtpProvider
         // 
         this.dtpProvider.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NhaCC", true));
         this.dtpProvider.Location = new System.Drawing.Point(135, 75);
         this.dtpProvider.MenuManager = this.bmPN;
         this.dtpProvider.Name = "dtpProvider";
         this.dtpProvider.Size = new System.Drawing.Size(157, 20);
         this.dtpProvider.TabIndex = 5;
         // 
         // gbOrderDetail
         // 
         this.gbOrderDetail.CaptionImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_edit_property_16;
         this.gbOrderDetail.CaptionLocation = DevExpress.Utils.Locations.Top;
         this.gbOrderDetail.Controls.Add(this.gcOrderDetail);
         this.gbOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbOrderDetail.Location = new System.Drawing.Point(0, 0);
         this.gbOrderDetail.Name = "gbOrderDetail";
         this.gbOrderDetail.Size = new System.Drawing.Size(406, 203);
         this.gbOrderDetail.TabIndex = 2;
         this.gbOrderDetail.Text = "Chi tiết Đơn Đặt Hàng";
         // 
         // gcOrderDetail
         // 
         this.gcOrderDetail.AllowUserToAddRows = false;
         this.gcOrderDetail.AllowUserToDeleteRows = false;
         this.gcOrderDetail.AutoGenerateColumns = false;
         this.gcOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.gcOrderDetail.BackgroundColor = System.Drawing.Color.White;
         this.gcOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.gcOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
         this.gcOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSlateGray;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gcOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.gcOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gcOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.gcOrderDetail.DataSource = this.bdsCTDDH;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.gcOrderDetail.DefaultCellStyle = dataGridViewCellStyle2;
         this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrderDetail.EnableHeadersVisualStyles = false;
         this.gcOrderDetail.GridColor = System.Drawing.Color.White;
         this.gcOrderDetail.Location = new System.Drawing.Point(2, 23);
         this.gcOrderDetail.Name = "gcOrderDetail";
         this.gcOrderDetail.RowHeadersVisible = false;
         this.gcOrderDetail.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.gcOrderDetail.Size = new System.Drawing.Size(402, 178);
         this.gcOrderDetail.TabIndex = 0;
         // 
         // dataGridViewTextBoxColumn1
         // 
         this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
         this.dataGridViewTextBoxColumn1.FillWeight = 121.8274F;
         this.dataGridViewTextBoxColumn1.HeaderText = "MÃ SỐ ĐƠN ĐẶT HÀNG";
         this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
         // 
         // dataGridViewTextBoxColumn2
         // 
         this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
         this.dataGridViewTextBoxColumn2.DataSource = this.bdsVT;
         this.dataGridViewTextBoxColumn2.DisplayMember = "TENVT";
         this.dataGridViewTextBoxColumn2.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn2.HeaderText = "MÃ VẬT TƯ";
         this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
         this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.dataGridViewTextBoxColumn2.ValueMember = "MAVT";
         // 
         // bdsVT
         // 
         this.bdsVT.DataMember = "Vattu";
         this.bdsVT.DataSource = this.dataSet;
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
         this.dataGridViewTextBoxColumn3.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn3.HeaderText = "SỐ LƯỢNG";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
         this.dataGridViewTextBoxColumn4.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn4.HeaderText = "ĐƠN GIÁ";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         // 
         // bdsCTDDH
         // 
         this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
         this.bdsCTDDH.DataSource = this.bdsDDH;
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(853, 30);
         this.pnPickDepartment.TabIndex = 23;
         this.pnPickDepartment.Visible = false;
         // 
         // labelControl1
         // 
         this.labelControl1.Location = new System.Drawing.Point(12, 9);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(81, 13);
         this.labelControl1.TabIndex = 2;
         this.labelControl1.Text = "Chọn Chi Nhánh:";
         // 
         // cboDeployment
         // 
         this.cboDeployment.BackColor = System.Drawing.SystemColors.Window;
         this.cboDeployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cboDeployment.FlatStyle = System.Windows.Forms.FlatStyle.System;
         this.cboDeployment.FormattingEnabled = true;
         this.cboDeployment.Location = new System.Drawing.Point(99, 5);
         this.cboDeployment.Name = "cboDeployment";
         this.cboDeployment.Size = new System.Drawing.Size(193, 21);
         this.cboDeployment.TabIndex = 1;
         // 
         // taCTDDH
         // 
         this.taCTDDH.ClearBeforeFill = true;
         // 
         // taDSNV
         // 
         this.taDSNV.ClearBeforeFill = true;
         // 
         // taVT
         // 
         this.taVT.ClearBeforeFill = true;
         // 
         // frmOrders
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(853, 476);
         this.Controls.Add(this.gcOrder);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.sccOrder);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmOrders";
         this.Text = "QUẢN LÝ ĐƠN ĐẶT HÀNG";
         this.Load += new System.EventHandler(this.frmOrders_Load);
         this.Resize += new System.EventHandler(this.frmOrders_Resize);
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.sccOrder)).EndInit();
         this.sccOrder.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).EndInit();
         this.gbOrder.ResumeLayout(false);
         this.gbOrder.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dtpProvider.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).EndInit();
         this.gbOrderDetail.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager bmPN;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnEdit;
      private DevExpress.XtraBars.BarButtonItem btnDel;
      private DevExpress.XtraBars.BarButtonItem btnUndo;
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
      private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private DevExpress.XtraGrid.GridControl gcOrder;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraEditors.SplitContainerControl sccOrder;
      private DevExpress.XtraEditors.GroupControl gbOrder;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private System.Windows.Forms.BindingSource bdsCTDDH;
      private DataSetTableAdapters.CTDDHTableAdapter taCTDDH;
      private System.Windows.Forms.DataGridView gcOrderDetail;
      private DevExpress.XtraEditors.TextEdit txtOrderId;
      private DevExpress.XtraEditors.DateEdit dtpOrderDate;
      private DevExpress.XtraEditors.TextEdit dtpProvider;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private DevExpress.XtraEditors.GroupControl gbOrderDetail;
      private System.Windows.Forms.BindingSource bdsVT;
      private DataSetTableAdapters.VattuTableAdapter taVT;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
      private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
      private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
   }
}