namespace QLVT_DATHANG.Forms
{
   partial class frmMaterials
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterials));
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
         this.taVT = new QLVT_DATHANG.DataSetTableAdapters.VattuTableAdapter();
         this.taVTManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
         this.gcVT = new DevExpress.XtraGrid.GridControl();
         this.gvMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
         this.txtMaterialId = new DevExpress.XtraEditors.TextEdit();
         this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
         this.cboDVT = new System.Windows.Forms.ComboBox();
         this.txtMaterialName = new DevExpress.XtraEditors.TextEdit();
         this.spiSLT = new DevExpress.XtraEditors.SpinEdit();
         this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
         this.bmVT = new DevExpress.XtraBars.BarManager(this.components);
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnDel = new DevExpress.XtraBars.BarButtonItem();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
         this.btnReload = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
         this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
         this.bar2 = new DevExpress.XtraBars.Bar();
         this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
         this.gbVT = new DevExpress.XtraEditors.GroupControl();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
         this.taCTPX = new QLVT_DATHANG.DataSetTableAdapters.CTPXTableAdapter();
         this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
         this.taCTPN = new QLVT_DATHANG.DataSetTableAdapters.CTPNTableAdapter();
         this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
         this.taCTDDH = new QLVT_DATHANG.DataSetTableAdapters.CTDDHTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
         this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
         this.layoutControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiSLT.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbVT)).BeginInit();
         this.gbVT.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
         this.SuspendLayout();
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // bdsVT
         // 
         this.bdsVT.DataMember = "Vattu";
         this.bdsVT.DataSource = this.dataSet;
         // 
         // taVT
         // 
         this.taVT.ClearBeforeFill = true;
         // 
         // taVTManager
         // 
         this.taVTManager.BackupDataSetBeforeUpdate = false;
         this.taVTManager.ChiNhanhTableAdapter = null;
         this.taVTManager.CTDDHTableAdapter = null;
         this.taVTManager.CTPNTableAdapter = null;
         this.taVTManager.CTPXTableAdapter = null;
         this.taVTManager.DatHangTableAdapter = null;
         this.taVTManager.KhoTableAdapter = null;
         this.taVTManager.NhanVienTableAdapter = null;
         this.taVTManager.PhieuNhapTableAdapter = null;
         this.taVTManager.PhieuXuatTableAdapter = null;
         this.taVTManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
         this.taVTManager.VattuTableAdapter = this.taVT;
         // 
         // gcVT
         // 
         this.gcVT.DataSource = this.bdsVT;
         this.gcVT.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcVT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
         this.gcVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gcVT.Location = new System.Drawing.Point(0, 128);
         this.gcVT.MainView = this.gvMaterial;
         this.gcVT.Margin = new System.Windows.Forms.Padding(2);
         this.gcVT.Name = "gcVT";
         this.gcVT.Size = new System.Drawing.Size(873, 330);
         this.gcVT.TabIndex = 0;
         this.gcVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterial});
         // 
         // gvMaterial
         // 
         this.gvMaterial.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvMaterial.Appearance.HeaderPanel.Options.UseFont = true;
         this.gvMaterial.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvMaterial.Appearance.Row.Options.UseFont = true;
         this.gvMaterial.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvMaterial.Appearance.SelectedRow.Options.UseFont = true;
         this.gvMaterial.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gvMaterial.Appearance.ViewCaption.Options.UseFont = true;
         this.gvMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
         this.gvMaterial.DetailHeight = 284;
         this.gvMaterial.GridControl = this.gcVT;
         this.gvMaterial.Name = "gvMaterial";
         this.gvMaterial.OptionsBehavior.Editable = false;
         this.gvMaterial.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
         this.gvMaterial.OptionsView.ShowGroupPanel = false;
         this.gvMaterial.OptionsView.ShowViewCaption = true;
         this.gvMaterial.ViewCaption = "Danh Sách Vật Tư";
         // 
         // colMAVT
         // 
         this.colMAVT.Caption = "MÃ VẬT TƯ";
         this.colMAVT.FieldName = "MAVT";
         this.colMAVT.MinWidth = 19;
         this.colMAVT.Name = "colMAVT";
         this.colMAVT.Visible = true;
         this.colMAVT.VisibleIndex = 0;
         this.colMAVT.Width = 70;
         // 
         // colTENVT
         // 
         this.colTENVT.Caption = "TÊN VẬT TƯ";
         this.colTENVT.FieldName = "TENVT";
         this.colTENVT.MinWidth = 19;
         this.colTENVT.Name = "colTENVT";
         this.colTENVT.Visible = true;
         this.colTENVT.VisibleIndex = 1;
         this.colTENVT.Width = 70;
         // 
         // colDVT
         // 
         this.colDVT.Caption = "ĐƠN VỊ TÍNH";
         this.colDVT.FieldName = "DVT";
         this.colDVT.MinWidth = 19;
         this.colDVT.Name = "colDVT";
         this.colDVT.Visible = true;
         this.colDVT.VisibleIndex = 2;
         this.colDVT.Width = 70;
         // 
         // colSOLUONGTON
         // 
         this.colSOLUONGTON.Caption = "SỐ LƯỢNG TỒN";
         this.colSOLUONGTON.FieldName = "SOLUONGTON";
         this.colSOLUONGTON.MinWidth = 19;
         this.colSOLUONGTON.Name = "colSOLUONGTON";
         this.colSOLUONGTON.Visible = true;
         this.colSOLUONGTON.VisibleIndex = 3;
         this.colSOLUONGTON.Width = 70;
         // 
         // txtMaterialId
         // 
         this.txtMaterialId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "MAVT", true));
         this.txtMaterialId.Location = new System.Drawing.Point(86, 12);
         this.txtMaterialId.Margin = new System.Windows.Forms.Padding(2);
         this.txtMaterialId.Name = "txtMaterialId";
         this.txtMaterialId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMaterialId.Properties.Appearance.Options.UseFont = true;
         this.txtMaterialId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtMaterialId.Properties.MaxLength = 4;
         this.txtMaterialId.Size = new System.Drawing.Size(209, 22);
         this.txtMaterialId.StyleController = this.layoutControl1;
         this.txtMaterialId.TabIndex = 2;
         // 
         // layoutControl1
         // 
         this.layoutControl1.Controls.Add(this.spiSLT);
         this.layoutControl1.Controls.Add(this.cboDVT);
         this.layoutControl1.Controls.Add(this.txtMaterialName);
         this.layoutControl1.Controls.Add(this.txtMaterialId);
         this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
         this.layoutControl1.Location = new System.Drawing.Point(2, 24);
         this.layoutControl1.Name = "layoutControl1";
         this.layoutControl1.Root = this.Root;
         this.layoutControl1.Size = new System.Drawing.Size(596, 73);
         this.layoutControl1.TabIndex = 9;
         this.layoutControl1.Text = "layoutControl1";
         // 
         // cboDVT
         // 
         this.cboDVT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsVT, "DVT", true));
         this.cboDVT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cboDVT.FormattingEnabled = true;
         this.cboDVT.Location = new System.Drawing.Point(86, 38);
         this.cboDVT.Name = "cboDVT";
         this.cboDVT.Size = new System.Drawing.Size(209, 23);
         this.cboDVT.TabIndex = 6;
         // 
         // txtMaterialName
         // 
         this.txtMaterialName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "TENVT", true));
         this.txtMaterialName.Location = new System.Drawing.Point(373, 12);
         this.txtMaterialName.Margin = new System.Windows.Forms.Padding(2);
         this.txtMaterialName.Name = "txtMaterialName";
         this.txtMaterialName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMaterialName.Properties.Appearance.Options.UseFont = true;
         this.txtMaterialName.Size = new System.Drawing.Size(211, 22);
         this.txtMaterialName.StyleController = this.layoutControl1;
         this.txtMaterialName.TabIndex = 4;
         // 
         // spiSLT
         // 
         this.spiSLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "SOLUONGTON", true));
         this.spiSLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.spiSLT.Location = new System.Drawing.Point(373, 38);
         this.spiSLT.Margin = new System.Windows.Forms.Padding(2);
         this.spiSLT.Name = "spiSLT";
         this.spiSLT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.spiSLT.Properties.Appearance.Options.UseFont = true;
         this.spiSLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spiSLT.Properties.IsFloatValue = false;
         this.spiSLT.Properties.Mask.EditMask = "N00";
         this.spiSLT.Size = new System.Drawing.Size(211, 22);
         this.spiSLT.StyleController = this.layoutControl1;
         this.spiSLT.TabIndex = 8;
         // 
         // Root
         // 
         this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
         this.Root.GroupBordersVisible = false;
         this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4});
         this.Root.Name = "Root";
         this.Root.Size = new System.Drawing.Size(596, 73);
         this.Root.TextVisible = false;
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
            this.btnDel,
            this.btnReload,
            this.btnExit,
            this.btnSave,
            this.btnUndo,
            this.btnCancelEdit});
         this.bmVT.MainMenu = this.bar3;
         this.bmVT.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
         this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
         // 
         // btnUndo
         // 
         this.btnUndo.Caption = "PHỤC HỒI";
         this.btnUndo.Id = 6;
         this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
         // 
         // btnReload
         // 
         this.btnReload.Caption = "LÀM MỚI";
         this.btnReload.Id = 3;
         this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
         this.btnReload.Name = "btnReload";
         this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
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
         this.barDockControl1.Manager = this.bmVT;
         this.barDockControl1.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl1.Size = new System.Drawing.Size(873, 24);
         // 
         // barDockControl2
         // 
         this.barDockControl2.CausesValidation = false;
         this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControl2.Location = new System.Drawing.Point(0, 458);
         this.barDockControl2.Manager = this.bmVT;
         this.barDockControl2.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl2.Size = new System.Drawing.Size(873, 0);
         // 
         // barDockControl3
         // 
         this.barDockControl3.CausesValidation = false;
         this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControl3.Location = new System.Drawing.Point(0, 24);
         this.barDockControl3.Manager = this.bmVT;
         this.barDockControl3.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl3.Size = new System.Drawing.Size(0, 434);
         // 
         // barDockControl4
         // 
         this.barDockControl4.CausesValidation = false;
         this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControl4.Location = new System.Drawing.Point(873, 24);
         this.barDockControl4.Manager = this.bmVT;
         this.barDockControl4.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl4.Size = new System.Drawing.Size(0, 434);
         // 
         // bar2
         // 
         this.bar2.BarName = "Main menu";
         this.bar2.DockCol = 0;
         this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
         this.bar2.OptionsBar.MultiLine = true;
         this.bar2.OptionsBar.UseWholeRow = true;
         this.bar2.Text = "Main menu";
         // 
         // barButtonItem2
         // 
         this.barButtonItem2.Caption = "barButtonItem2";
         this.barButtonItem2.Id = 9;
         this.barButtonItem2.Name = "barButtonItem2";
         // 
         // gbVT
         // 
         this.gbVT.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbVT.AppearanceCaption.Options.UseFont = true;
         this.gbVT.Controls.Add(this.layoutControl1);
         this.gbVT.Dock = System.Windows.Forms.DockStyle.Top;
         this.gbVT.Location = new System.Drawing.Point(0, 24);
         this.gbVT.Name = "gbVT";
         this.gbVT.Size = new System.Drawing.Size(873, 99);
         this.gbVT.TabIndex = 2;
         this.gbVT.Text = "Thông tin Vật Tư";
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.splitterControl1.Location = new System.Drawing.Point(0, 123);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(873, 5);
         this.splitterControl1.TabIndex = 1;
         this.splitterControl1.TabStop = false;
         this.splitterControl1.Visible = false;
         // 
         // bdsCTPX
         // 
         this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
         this.bdsCTPX.DataSource = this.bdsVT;
         // 
         // taCTPX
         // 
         this.taCTPX.ClearBeforeFill = true;
         // 
         // bdsCTPN
         // 
         this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
         this.bdsCTPN.DataSource = this.bdsVT;
         // 
         // taCTPN
         // 
         this.taCTPN.ClearBeforeFill = true;
         // 
         // bdsCTDDH
         // 
         this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
         this.bdsCTDDH.DataSource = this.bdsVT;
         // 
         // taCTDDH
         // 
         this.taCTDDH.ClearBeforeFill = true;
         // 
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // layoutControlItem2
         // 
         this.layoutControlItem2.Control = this.txtMaterialId;
         this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
         this.layoutControlItem2.Name = "layoutControlItem2";
         this.layoutControlItem2.Size = new System.Drawing.Size(287, 26);
         this.layoutControlItem2.Text = "Mã vật tư:";
         this.layoutControlItem2.TextSize = new System.Drawing.Size(71, 13);
         // 
         // layoutControlItem1
         // 
         this.layoutControlItem1.Control = this.txtMaterialName;
         this.layoutControlItem1.Location = new System.Drawing.Point(287, 0);
         this.layoutControlItem1.Name = "layoutControlItem1";
         this.layoutControlItem1.Size = new System.Drawing.Size(289, 26);
         this.layoutControlItem1.Text = "Tên vật tư:";
         this.layoutControlItem1.TextSize = new System.Drawing.Size(71, 13);
         // 
         // layoutControlItem3
         // 
         this.layoutControlItem3.Control = this.cboDVT;
         this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
         this.layoutControlItem3.Name = "layoutControlItem3";
         this.layoutControlItem3.Size = new System.Drawing.Size(287, 27);
         this.layoutControlItem3.Text = "Đơn vị tính:";
         this.layoutControlItem3.TextSize = new System.Drawing.Size(71, 13);
         // 
         // layoutControlItem4
         // 
         this.layoutControlItem4.Control = this.spiSLT;
         this.layoutControlItem4.Location = new System.Drawing.Point(287, 26);
         this.layoutControlItem4.Name = "layoutControlItem4";
         this.layoutControlItem4.Size = new System.Drawing.Size(289, 27);
         this.layoutControlItem4.Text = "Số lượng tồn:";
         this.layoutControlItem4.TextSize = new System.Drawing.Size(71, 13);
         // 
         // frmMaterials
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(873, 458);
         this.Controls.Add(this.gcVT);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.gbVT);
         this.Controls.Add(this.barDockControl3);
         this.Controls.Add(this.barDockControl4);
         this.Controls.Add(this.barDockControl2);
         this.Controls.Add(this.barDockControl1);
         this.Margin = new System.Windows.Forms.Padding(2);
         this.Name = "frmMaterials";
         this.Text = "QUẢN LÝ VẬT TƯ";
         this.Load += new System.EventHandler(this.frmMaterials_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
         this.layoutControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiSLT.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbVT)).EndInit();
         this.gbVT.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.BindingSource bdsVT;
      private DataSet dataSet;
      private DataSetTableAdapters.VattuTableAdapter taVT;
      private DataSetTableAdapters.TableAdapterManager taVTManager;
      private DevExpress.XtraGrid.GridControl gcVT;
      private DevExpress.XtraGrid.Views.Grid.GridView gvMaterial;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
      private DevExpress.XtraGrid.Columns.GridColumn colDVT;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
      private DevExpress.XtraEditors.TextEdit txtMaterialId;
      private DevExpress.XtraEditors.TextEdit txtMaterialName;
      private DevExpress.XtraEditors.SpinEdit spiSLT;
      private DevExpress.XtraBars.BarManager bmVT;
      private DevExpress.XtraBars.Bar bar3;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnEdit;
      private DevExpress.XtraBars.BarButtonItem btnDel;
      private DevExpress.XtraBars.BarButtonItem btnReload;
      private DevExpress.XtraBars.BarButtonItem btnExit;
      private DevExpress.XtraBars.BarButtonItem btnSave;
      private DevExpress.XtraBars.BarButtonItem btnUndo;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private DevExpress.XtraBars.BarDockControl barDockControl1;
      private DevExpress.XtraBars.BarDockControl barDockControl2;
      private DevExpress.XtraBars.BarDockControl barDockControl3;
      private DevExpress.XtraBars.BarDockControl barDockControl4;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarButtonItem barButtonItem2;
      private DevExpress.XtraEditors.GroupControl gbVT;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private System.Windows.Forms.BindingSource bdsCTPX;
      private DataSetTableAdapters.CTPXTableAdapter taCTPX;
      private System.Windows.Forms.BindingSource bdsCTPN;
      private DataSetTableAdapters.CTPNTableAdapter taCTPN;
      private System.Windows.Forms.BindingSource bdsCTDDH;
      private DataSetTableAdapters.CTDDHTableAdapter taCTDDH;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private System.Windows.Forms.ComboBox cboDVT;
      private DevExpress.XtraLayout.LayoutControl layoutControl1;
      private DevExpress.XtraLayout.LayoutControlGroup Root;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
      private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
   }
}