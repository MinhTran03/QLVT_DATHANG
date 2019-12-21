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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsDeliveryNote));
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gbDeliveryNote = new DevExpress.XtraEditors.GroupControl();
            this.lkeMaKho = new DevExpress.XtraEditors.SearchLookUpEdit();
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
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkeEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtPX = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.gbCTPX = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveDataRow = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDateRow = new DevExpress.XtraEditors.SimpleButton();
            this.gcCTPX = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPX = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taPX = new QLVT_DATHANG.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
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
            this.bdsDSVT = new System.Windows.Forms.BindingSource(this.components);
            this.taDSVT = new QLVT_DATHANG.DataSetTableAdapters.DSVTTableAdapter();
            this.taDSKHO = new QLVT_DATHANG.DataSetTableAdapters.DSKHOTableAdapter();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbDeliveryNote)).BeginInit();
            this.gbDeliveryNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPX)).BeginInit();
            this.gbCTPX.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
            this.pnPickDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(97, 52);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(50, 19);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "MAPX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(97, 82);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(48, 19);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(97, 111);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(74, 19);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(97, 141);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(53, 19);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(97, 171);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(63, 19);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 760);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1040, 6);
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.TabStop = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 766);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.splitContainerControl1.Panel1.Controls.Add(this.gbDeliveryNote);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.splitContainerControl1.Panel2.Controls.Add(this.gbCTPX);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1040, 301);
            this.splitContainerControl1.SplitterPosition = 488;
            this.splitContainerControl1.TabIndex = 7;
            // 
            // gbDeliveryNote
            // 
            this.gbDeliveryNote.Controls.Add(this.lkeMaKho);
            this.gbDeliveryNote.Controls.Add(mAKHOLabel);
            this.gbDeliveryNote.Controls.Add(this.lkeEmployee);
            this.gbDeliveryNote.Controls.Add(mAPXLabel);
            this.gbDeliveryNote.Controls.Add(this.txtPX);
            this.gbDeliveryNote.Controls.Add(nGAYLabel);
            this.gbDeliveryNote.Controls.Add(this.txtDate);
            this.gbDeliveryNote.Controls.Add(hOTENKHLabel);
            this.gbDeliveryNote.Controls.Add(this.txtName);
            this.gbDeliveryNote.Controls.Add(mANVLabel);
            this.gbDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDeliveryNote.Location = new System.Drawing.Point(0, 0);
            this.gbDeliveryNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDeliveryNote.Name = "gbDeliveryNote";
            this.gbDeliveryNote.Size = new System.Drawing.Size(484, 297);
            this.gbDeliveryNote.TabIndex = 0;
            this.gbDeliveryNote.Text = "Thông tin Phiếu Xuất";
            // 
            // lkeMaKho
            // 
            this.lkeMaKho.EditValue = "";
            this.lkeMaKho.Location = new System.Drawing.Point(177, 169);
            this.lkeMaKho.MenuManager = this.bmPN;
            this.lkeMaKho.Name = "lkeMaKho";
            this.lkeMaKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeMaKho.Properties.DataSource = this.bdsDSKHO;
            this.lkeMaKho.Properties.DisplayMember = "TENKHO";
            this.lkeMaKho.Properties.NullText = "";
            this.lkeMaKho.Properties.PopupView = this.gridView2;
            this.lkeMaKho.Properties.ValueMember = "MAKHO";
            this.lkeMaKho.Size = new System.Drawing.Size(125, 24);
            this.lkeMaKho.TabIndex = 9;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1040, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1067);
            this.barDockControlBottom.Manager = this.bmPN;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1040, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.bmPN;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1037);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1040, 30);
            this.barDockControlRight.Manager = this.bmPN;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1037);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "XÓA";
            this.btnDel.Id = 1;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "SỬA";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // lkeEmployee
            // 
            this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MANV", true));
            this.lkeEmployee.Enabled = false;
            this.lkeEmployee.Location = new System.Drawing.Point(177, 139);
            this.lkeEmployee.MenuManager = this.bmPN;
            this.lkeEmployee.Name = "lkeEmployee";
            this.lkeEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeEmployee.Properties.DataSource = this.bdsDSNV;
            this.lkeEmployee.Properties.DisplayMember = "HOTEN";
            this.lkeEmployee.Properties.NullText = "";
            this.lkeEmployee.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkeEmployee.Properties.ValueMember = "MANV";
            this.lkeEmployee.Size = new System.Drawing.Size(125, 24);
            this.lkeEmployee.TabIndex = 7;
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
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtPX
            // 
            this.txtPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.txtPX.Location = new System.Drawing.Point(177, 48);
            this.txtPX.MenuManager = this.bmPN;
            this.txtPX.Name = "txtPX";
            this.txtPX.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPX.Properties.MaxLength = 8;
            this.txtPX.Size = new System.Drawing.Size(125, 24);
            this.txtPX.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.txtDate.EditValue = null;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(177, 78);
            this.txtDate.MenuManager = this.bmPN;
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Size = new System.Drawing.Size(125, 24);
            this.txtDate.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
            this.txtName.Location = new System.Drawing.Point(177, 109);
            this.txtName.MenuManager = this.bmPN;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 24);
            this.txtName.TabIndex = 5;
            // 
            // gbCTPX
            // 
            this.gbCTPX.Controls.Add(this.panel1);
            this.gbCTPX.Controls.Add(this.gcCTPX);
            this.gbCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPX.Location = new System.Drawing.Point(0, 0);
            this.gbCTPX.Name = "gbCTPX";
            this.gbCTPX.Size = new System.Drawing.Size(542, 297);
            this.gbCTPX.TabIndex = 0;
            this.gbCTPX.Text = "Chi tiết Phiếu Xuất";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoveDataRow);
            this.panel1.Controls.Add(this.btnAddDateRow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnRemoveDataRow
            // 
            this.btnRemoveDataRow.Location = new System.Drawing.Point(103, 6);
            this.btnRemoveDataRow.Name = "btnRemoveDataRow";
            this.btnRemoveDataRow.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveDataRow.TabIndex = 1;
            this.btnRemoveDataRow.Text = "Xóa Dòng";
            this.btnRemoveDataRow.Click += new System.EventHandler(this.btnRemoveDataRow_Click);
            // 
            // btnAddDateRow
            // 
            this.btnAddDateRow.Location = new System.Drawing.Point(3, 6);
            this.btnAddDateRow.Name = "btnAddDateRow";
            this.btnAddDateRow.Size = new System.Drawing.Size(94, 29);
            this.btnAddDateRow.TabIndex = 0;
            this.btnAddDateRow.Text = "Thêm Dòng";
            this.btnAddDateRow.Click += new System.EventHandler(this.btnAddDateRow_Click);
            // 
            // gcCTPX
            // 
            this.gcCTPX.DataSource = this.bdsCTPX;
            this.gcCTPX.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCTPX.Location = new System.Drawing.Point(2, 26);
            this.gcCTPX.MainView = this.gvCTPX;
            this.gcCTPX.MenuManager = this.bmPN;
            this.gcCTPX.Name = "gcCTPX";
            this.gcCTPX.Size = new System.Drawing.Size(538, 220);
            this.gcCTPX.TabIndex = 0;
            this.gcCTPX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPX});
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // gvCTPX
            // 
            this.gvCTPX.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTPX.GridControl = this.gcCTPX;
            this.gvCTPX.Name = "gvCTPX";
            this.gvCTPX.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvCTPX.OptionsView.ShowGroupPanel = false;
            // 
            // colMAPX1
            // 
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 25;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 1;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 94;
            // 
            // taPX
            // 
            this.taPX.ClearBeforeFill = true;
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
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.taPX;
            this.tableAdapterManager.UpdateOrder = QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gvDeliveryNote
            // 
            this.gvDeliveryNote.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gvDeliveryNote.DetailHeight = 458;
            this.gvDeliveryNote.FixedLineWidth = 3;
            this.gvDeliveryNote.GridControl = this.gcDeliveryNote;
            this.gvDeliveryNote.Name = "gvDeliveryNote";
            this.gvDeliveryNote.OptionsBehavior.Editable = false;
            this.gvDeliveryNote.OptionsView.ShowGroupPanel = false;
            this.gvDeliveryNote.OptionsView.ShowViewCaption = true;
            this.gvDeliveryNote.ViewCaption = "Danh sách Phiếu Xuất";
            // 
            // colMAPX
            // 
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 23;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 87;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 23;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 87;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 23;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 87;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 23;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 87;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 23;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 87;
            // 
            // gcDeliveryNote
            // 
            this.gcDeliveryNote.DataSource = this.bdsPX;
            this.gcDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDeliveryNote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDeliveryNote.Location = new System.Drawing.Point(0, 69);
            this.gcDeliveryNote.MainView = this.gvDeliveryNote;
            this.gcDeliveryNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcDeliveryNote.MenuManager = this.bmPN;
            this.gcDeliveryNote.Name = "gcDeliveryNote";
            this.gcDeliveryNote.Size = new System.Drawing.Size(1040, 691);
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
            this.cboDeployment.Location = new System.Drawing.Point(115, 7);
            this.cboDeployment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDeployment.Name = "cboDeployment";
            this.cboDeployment.Size = new System.Drawing.Size(224, 25);
            this.cboDeployment.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 12);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 19);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Chọn Chi Nhánh:";
            // 
            // pnPickDepartment
            // 
            this.pnPickDepartment.Controls.Add(this.labelControl1);
            this.pnPickDepartment.Controls.Add(this.cboDeployment);
            this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPickDepartment.Location = new System.Drawing.Point(0, 30);
            this.pnPickDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnPickDepartment.Name = "pnPickDepartment";
            this.pnPickDepartment.Size = new System.Drawing.Size(1040, 39);
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
            this.barDockControl4.Location = new System.Drawing.Point(1040, 30);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 1037);
            // 
            // bdsDSVT
            // 
            this.bdsDSVT.DataMember = "DSVT";
            this.bdsDSVT.DataSource = this.dataSet;
            // 
            // taDSVT
            // 
            this.taDSVT.ClearBeforeFill = true;
            // 
            // taDSKHO
            // 
            this.taDSKHO.ClearBeforeFill = true;
            // 
            // frmGoodsDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1040, 1067);
            this.Controls.Add(this.gcDeliveryNote);
            this.Controls.Add(this.pnPickDepartment);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoodsDeliveryNote";
            this.Text = "QUẢN LÝ PHIẾU XUẤT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGoodsDeliveryNote_FormClosing);
            this.Load += new System.EventHandler(this.frmGoodsDeliveryNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbDeliveryNote)).EndInit();
            this.gbDeliveryNote.ResumeLayout(false);
            this.gbDeliveryNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPX)).EndInit();
            this.gbCTPX.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeliveryNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
            this.pnPickDepartment.ResumeLayout(false);
            this.pnPickDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private DataSet dataSet;
      private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
      private DevExpress.XtraEditors.SplitterControl splitterControl1;
      private DevExpress.XtraEditors.GroupControl gbDeliveryNote;
      private DevExpress.XtraBars.BarManager bmPN;
      private DevExpress.XtraBars.Bar bar2;
      private DevExpress.XtraBars.BarButtonItem btnAdd;
      private DevExpress.XtraBars.BarButtonItem btnDel;
      private DevExpress.XtraBars.BarButtonItem btnEdit;
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
      private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private DevExpress.XtraGrid.GridControl gcDeliveryNote;
      private DevExpress.XtraGrid.Views.Grid.GridView gvDeliveryNote;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DevExpress.XtraBars.Bar bar3;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DataSetTableAdapters.DSNVTableAdepter taDSNV;
        private DevExpress.XtraEditors.GroupControl gbCTPX;
        private DevExpress.XtraEditors.SearchLookUpEdit lkeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtPX;
        private DevExpress.XtraEditors.DateEdit txtDate;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DataSetTableAdapters.CTPXTableAdapter taCTPX;
      private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnRemoveDataRow;
        private DevExpress.XtraEditors.SimpleButton btnAddDateRow;
        private DevExpress.XtraGrid.GridControl gcCTPX;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPX;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraEditors.SearchLookUpEdit lkeMaKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource bdsDSVT;
        private DataSetTableAdapters.DSVTTableAdapter taDSVT;
        private System.Windows.Forms.BindingSource bdsDSKHO;
        private DataSetTableAdapters.DSKHOTableAdapter taDSKHO;
    }
}