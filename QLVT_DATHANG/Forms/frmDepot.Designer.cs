namespace QLVT_DATHANG.Forms
{
   partial class frmDepot
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepot));
         this.bmOrder = new DevExpress.XtraBars.BarManager(this.components);
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnDel = new DevExpress.XtraBars.BarButtonItem();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
         this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.bdsDepot = new System.Windows.Forms.BindingSource(this.components);
         this.taDepot = new QLVT_DATHANG.DataSetTableAdapters.KhoTableAdapter();
         this.taDepotManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
         this.gcDepot = new DevExpress.XtraGrid.GridControl();
         this.gvDepot = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gbDepot = new DevExpress.XtraEditors.GroupControl();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.txtEmpDepartment = new DevExpress.XtraEditors.TextEdit();
         this.txtDepotAddress = new DevExpress.XtraEditors.TextEdit();
         this.txtDepotId = new DevExpress.XtraEditors.TextEdit();
         this.txtDepotName = new DevExpress.XtraEditors.TextEdit();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
         this.taCN = new QLVT_DATHANG.DataSetTableAdapters.ChiNhanhTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.bmOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDepot)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDepot)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvDepot)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbDepot)).BeginInit();
         this.gbDepot.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotAddress.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // bmOrder
         // 
         this.bmOrder.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
         this.bmOrder.DockControls.Add(this.barDockControl1);
         this.bmOrder.DockControls.Add(this.barDockControl2);
         this.bmOrder.DockControls.Add(this.barDockControl3);
         this.bmOrder.DockControls.Add(this.barDockControl4);
         this.bmOrder.Form = this;
         this.bmOrder.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel,
            this.btnRefresh,
            this.btnExit,
            this.btnSave,
            this.btnUndo,
            this.btnCancelEdit});
         this.bmOrder.MainMenu = this.bar3;
         this.bmOrder.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
         this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
         // 
         // btnDel
         // 
         this.btnDel.Caption = "XÓA";
         this.btnDel.Id = 2;
         this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
         this.btnDel.Name = "btnDel";
         this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
         // 
         // btnUndo
         // 
         this.btnUndo.Caption = "PHỤC HỒI";
         this.btnUndo.Id = 6;
         this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
         // 
         // btnRefresh
         // 
         this.btnRefresh.Caption = "LÀM MỚI";
         this.btnRefresh.Id = 3;
         this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
         // 
         // btnSave
         // 
         this.btnSave.Caption = "GHI";
         this.btnSave.Id = 5;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Id = 7;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
         this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelEdit_ItemClick);
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 4;
         this.btnExit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.btnExit.Name = "btnExit";
         this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
         // 
         // barDockControl1
         // 
         this.barDockControl1.CausesValidation = false;
         this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.barDockControl1.Location = new System.Drawing.Point(0, 0);
         this.barDockControl1.Manager = this.bmOrder;
         this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.barDockControl1.Size = new System.Drawing.Size(800, 24);
         // 
         // barDockControl2
         // 
         this.barDockControl2.CausesValidation = false;
         this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControl2.Location = new System.Drawing.Point(0, 450);
         this.barDockControl2.Manager = this.bmOrder;
         this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.barDockControl2.Size = new System.Drawing.Size(800, 0);
         // 
         // barDockControl3
         // 
         this.barDockControl3.CausesValidation = false;
         this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControl3.Location = new System.Drawing.Point(0, 24);
         this.barDockControl3.Manager = this.bmOrder;
         this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.barDockControl3.Size = new System.Drawing.Size(0, 426);
         // 
         // barDockControl4
         // 
         this.barDockControl4.CausesValidation = false;
         this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControl4.Location = new System.Drawing.Point(800, 24);
         this.barDockControl4.Manager = this.bmOrder;
         this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
         this.barDockControl4.Size = new System.Drawing.Size(0, 426);
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bdsDepot
         // 
         this.bdsDepot.DataMember = "Kho";
         this.bdsDepot.DataSource = this.dataSet;
         // 
         // taDepot
         // 
         this.taDepot.ClearBeforeFill = true;
         // 
         // taDepotManager
         // 
         this.taDepotManager.BackupDataSetBeforeUpdate = false;
         this.taDepotManager.ChiNhanhTableAdapter = null;
         this.taDepotManager.CTDDHTableAdapter = null;
         this.taDepotManager.CTPNTableAdapter = null;
         this.taDepotManager.CTPXTableAdapter = null;
         this.taDepotManager.DatHangTableAdapter = null;
         this.taDepotManager.KhoTableAdapter = this.taDepot;
         this.taDepotManager.NhanVienTableAdapter = null;
         this.taDepotManager.PhieuNhapTableAdapter = null;
         this.taDepotManager.PhieuXuatTableAdapter = null;
         this.taDepotManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.taDepotManager.VattuTableAdapter = null;
         // 
         // gcDepot
         // 
         this.gcDepot.DataSource = this.bdsDepot;
         this.gcDepot.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcDepot.Location = new System.Drawing.Point(0, 149);
         this.gcDepot.MainView = this.gvDepot;
         this.gcDepot.MenuManager = this.bmOrder;
         this.gcDepot.Name = "gcDepot";
         this.gcDepot.Size = new System.Drawing.Size(800, 301);
         this.gcDepot.TabIndex = 5;
         this.gcDepot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepot});
         // 
         // gvDepot
         // 
         this.gvDepot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
         this.gvDepot.GridControl = this.gcDepot;
         this.gvDepot.Name = "gvDepot";
         this.gvDepot.OptionsBehavior.Editable = false;
         this.gvDepot.OptionsView.ShowGroupPanel = false;
         this.gvDepot.OptionsView.ShowViewCaption = true;
         this.gvDepot.ViewCaption = "Danh sách Kho";
         // 
         // colMAKHO
         // 
         this.colMAKHO.Caption = "MÃ KHO";
         this.colMAKHO.FieldName = "MAKHO";
         this.colMAKHO.Name = "colMAKHO";
         this.colMAKHO.Visible = true;
         this.colMAKHO.VisibleIndex = 0;
         // 
         // colTENKHO
         // 
         this.colTENKHO.Caption = "TÊN KHO";
         this.colTENKHO.FieldName = "TENKHO";
         this.colTENKHO.Name = "colTENKHO";
         this.colTENKHO.Visible = true;
         this.colTENKHO.VisibleIndex = 1;
         // 
         // colDIACHI
         // 
         this.colDIACHI.Caption = "ĐỊA CHỈ";
         this.colDIACHI.FieldName = "DIACHI";
         this.colDIACHI.Name = "colDIACHI";
         this.colDIACHI.Visible = true;
         this.colDIACHI.VisibleIndex = 2;
         // 
         // colMACN
         // 
         this.colMACN.Caption = "MÃ CHI NHÁNH";
         this.colMACN.FieldName = "MACN";
         this.colMACN.Name = "colMACN";
         this.colMACN.Visible = true;
         this.colMACN.VisibleIndex = 3;
         // 
         // gbDepot
         // 
         this.gbDepot.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbDepot.AppearanceCaption.Options.UseFont = true;
         this.gbDepot.Controls.Add(this.layoutControl1);
         this.gbDepot.Dock = System.Windows.Forms.DockStyle.Top;
         this.gbDepot.Location = new System.Drawing.Point(0, 54);
         this.gbDepot.Name = "gbDepot";
         this.gbDepot.Size = new System.Drawing.Size(800, 90);
         this.gbDepot.TabIndex = 6;
         this.gbDepot.Text = "Thông Tin Kho";
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.txtEmpDepartment);
         this.layoutControl1.Controls.Add(this.txtDepotAddress);
         this.layoutControl1.Controls.Add(this.txtDepotId);
         this.layoutControl1.Controls.Add(this.txtDepotName);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
         this.layoutControl1.Location = new System.Drawing.Point(2, 20);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(672, 30, 650, 400);
         this.layoutControl1.Root = this.Root;
         this.layoutControl1.Size = new System.Drawing.Size(618, 68);
         this.layoutControl1.TabIndex = 8;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // txtEmpDepartment
         // 
         this.txtEmpDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "MACN", true));
         this.txtEmpDepartment.Location = new System.Drawing.Point(366, 36);
         this.txtEmpDepartment.MenuManager = this.bmOrder;
         this.txtEmpDepartment.Name = "txtEmpDepartment";
         this.txtEmpDepartment.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpDepartment.Properties.Appearance.Options.UseFont = true;
         this.txtEmpDepartment.Size = new System.Drawing.Size(240, 20);
         this.txtEmpDepartment.StyleController = this.layoutControl1;
         this.txtEmpDepartment.TabIndex = 7;
         // 
         // txtDepotAddress
         // 
         this.txtDepotAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "DIACHI", true));
         this.txtDepotAddress.Location = new System.Drawing.Point(72, 36);
         this.txtDepotAddress.MenuManager = this.bmOrder;
         this.txtDepotAddress.Name = "txtDepotAddress";
         this.txtDepotAddress.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDepotAddress.Properties.Appearance.Options.UseFont = true;
         this.txtDepotAddress.Size = new System.Drawing.Size(230, 20);
         this.txtDepotAddress.StyleController = this.layoutControl1;
         this.txtDepotAddress.TabIndex = 5;
         // 
         // txtDepotId
         // 
         this.txtDepotId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "MAKHO", true));
         this.txtDepotId.Location = new System.Drawing.Point(72, 12);
         this.txtDepotId.MenuManager = this.bmOrder;
         this.txtDepotId.Name = "txtDepotId";
         this.txtDepotId.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDepotId.Properties.Appearance.Options.UseFont = true;
         this.txtDepotId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtDepotId.Properties.MaxLength = 4;
         this.txtDepotId.Size = new System.Drawing.Size(230, 20);
         this.txtDepotId.StyleController = this.layoutControl1;
         this.txtDepotId.TabIndex = 1;
         // 
         // txtDepotName
         // 
         this.txtDepotName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "TENKHO", true));
         this.txtDepotName.Location = new System.Drawing.Point(366, 12);
         this.txtDepotName.MenuManager = this.bmOrder;
         this.txtDepotName.Name = "txtDepotName";
         this.txtDepotName.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDepotName.Properties.Appearance.Options.UseFont = true;
         this.txtDepotName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtDepotName.Size = new System.Drawing.Size(240, 20);
         this.txtDepotName.StyleController = this.layoutControl1;
         this.txtDepotName.TabIndex = 3;
         // 
         // Root
         // 
         this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.Root.GroupBordersVisible = false;
         this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
         this.Root.Name = "Root";
         this.Root.Size = new System.Drawing.Size(618, 68);
         this.Root.TextVisible = false;
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.txtDepotId;
         this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(294, 24);
         this.layoutControlItem1.Text = "Mã kho:";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.txtDepotName;
         this.layoutControlItem2.Location = new System.Drawing.Point(294, 0);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(304, 24);
         this.layoutControlItem2.Text = "Tên kho:";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.txtDepotAddress;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(294, 24);
         this.layoutControlItem3.Text = "Địa chỉ:";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.txtEmpDepartment;
         this.layoutControlItem4.Location = new System.Drawing.Point(294, 24);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(304, 24);
         this.layoutControlItem4.Text = "Chi nhánh:";
         this.layoutControlItem4.TextSize = new System.Drawing.Size(57, 13);
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(800, 30);
         this.pnPickDepartment.TabIndex = 23;
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
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.splitterControl1.Location = new System.Drawing.Point(0, 144);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(800, 5);
         this.splitterControl1.TabIndex = 24;
         this.splitterControl1.TabStop = false;
         this.splitterControl1.Visible = false;
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
         // frmDepot
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.gcDepot);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.gbDepot);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.barDockControl3);
         this.Controls.Add(this.barDockControl4);
         this.Controls.Add(this.barDockControl2);
         this.Controls.Add(this.barDockControl1);
         this.Name = "frmDepot";
         this.Text = "QUẢN LÝ KHO";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDepot_FormClosing);
         this.Load += new System.EventHandler(this.frmDepot_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bmOrder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDepot)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDepot)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvDepot)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbDepot)).EndInit();
         this.gbDepot.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotAddress.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.BarManager bmOrder;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnEdit;
      private DevExpress.XtraBars.BarButtonItem btnDel;
      private DevExpress.XtraBars.BarButtonItem btnRefresh;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarButtonItem btnUndo;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private DevExpress.XtraBars.BarDockControl barDockControl1;
      private DevExpress.XtraBars.BarDockControl barDockControl2;
      private DevExpress.XtraBars.BarDockControl barDockControl3;
      private DevExpress.XtraBars.BarDockControl barDockControl4;
      private System.Windows.Forms.BindingSource bdsDepot;
      private DataSet dataSet;
      private DataSetTableAdapters.KhoTableAdapter taDepot;
      private DataSetTableAdapters.TableAdapterManager taDepotManager;
      private DevExpress.XtraGrid.GridControl gcDepot;
      private DevExpress.XtraGrid.Views.Grid.GridView gvDepot;
      private DevExpress.XtraEditors.GroupControl gbDepot;
      private DevExpress.XtraEditors.TextEdit txtDepotId;
      private DevExpress.XtraEditors.TextEdit txtDepotName;
      private DevExpress.XtraEditors.TextEdit txtDepotAddress;
      private DevExpress.XtraEditors.TextEdit txtEmpDepartment;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
      private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
      private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
      private DevExpress.XtraGrid.Columns.GridColumn colMACN;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private System.Windows.Forms.BindingSource bdsCN;
      private DataSetTableAdapters.ChiNhanhTableAdapter taCN;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
   }
}