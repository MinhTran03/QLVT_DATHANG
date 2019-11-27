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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsReceivedNote));
            this.bmPN = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cboDeployment = new System.Windows.Forms.ComboBox();
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.taPN = new QLVT_DATHANG.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
            this.gcReceivedNote = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gbReceivedNote = new DevExpress.XtraEditors.GroupControl();
            this.lkeEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lkeMaDDH = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.txtDate = new DevExpress.XtraEditors.DateEdit();
            this.gbCTPN = new DevExpress.XtraEditors.GroupControl();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.taCTPN = new QLVT_DATHANG.DataSetTableAdapters.CTPNTableAdapter();
            this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.taDDH = new QLVT_DATHANG.DataSetTableAdapters.DatHangTableAdapter();
            this.taDSNV = new QLVT_DATHANG.DataSetTableAdapters.DSNVTableAdepter();
            this.cmsCTPN = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddCTPN = new System.Windows.Forms.ToolStripMenuItem();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
            this.pnPickDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceivedNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbReceivedNote)).BeginInit();
            this.gbReceivedNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMaDDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPN)).BeginInit();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
            this.cmsCTPN.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(41, 51);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(48, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(41, 79);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(41, 107);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(77, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(41, 135);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // bmPN
            // 
            this.bmPN.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
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
            this.bmPN.StatusBar = this.bar3;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.bmPN;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(871, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1043);
            this.barDockControlBottom.Manager = this.bmPN;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(871, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.bmPN;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1013);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(871, 30);
            this.barDockControlRight.Manager = this.bmPN;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1013);
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
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "PHỤC HỒI";
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // pnPickDepartment
            // 
            this.pnPickDepartment.Controls.Add(this.labelControl1);
            this.pnPickDepartment.Controls.Add(this.cboDeployment);
            this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPickDepartment.Location = new System.Drawing.Point(0, 30);
            this.pnPickDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnPickDepartment.Name = "pnPickDepartment";
            this.pnPickDepartment.Size = new System.Drawing.Size(871, 37);
            this.pnPickDepartment.TabIndex = 25;
            this.pnPickDepartment.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Chọn Chi Nhánh:";
            // 
            // cboDeployment
            // 
            this.cboDeployment.BackColor = System.Drawing.SystemColors.Window;
            this.cboDeployment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeployment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboDeployment.FormattingEnabled = true;
            this.cboDeployment.Location = new System.Drawing.Point(115, 6);
            this.cboDeployment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDeployment.Name = "cboDeployment";
            this.cboDeployment.Size = new System.Drawing.Size(224, 24);
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
            // gcReceivedNote
            // 
            this.gcReceivedNote.DataSource = this.bdsPN;
            this.gcReceivedNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcReceivedNote.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcReceivedNote.Location = new System.Drawing.Point(0, 67);
            this.gcReceivedNote.MainView = this.gridView1;
            this.gcReceivedNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcReceivedNote.MenuManager = this.bmPN;
            this.gcReceivedNote.Name = "gcReceivedNote";
            this.gcReceivedNote.Size = new System.Drawing.Size(871, 795);
            this.gcReceivedNote.TabIndex = 26;
            this.gcReceivedNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gcReceivedNote;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowViewCaption = true;
            this.gridView1.ViewCaption = "Danh sách Phiếu Nhập";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 23;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 87;
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
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 23;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 87;
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
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 862);
            this.splitterControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(871, 6);
            this.splitterControl1.TabIndex = 27;
            this.splitterControl1.TabStop = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 868);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gbReceivedNote);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gbCTPN);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(871, 175);
            this.splitContainerControl1.SplitterPosition = 394;
            this.splitContainerControl1.TabIndex = 28;
            // 
            // gbReceivedNote
            // 
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
            this.gbReceivedNote.Size = new System.Drawing.Size(394, 175);
            this.gbReceivedNote.TabIndex = 0;
            this.gbReceivedNote.Text = "Thông tin Phiếu Nhập";
            // 
            // lkeEmployee
            // 
            this.lkeEmployee.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MANV", true));
            this.lkeEmployee.Enabled = false;
            this.lkeEmployee.Location = new System.Drawing.Point(124, 133);
            this.lkeEmployee.MenuManager = this.bmPN;
            this.lkeEmployee.Name = "lkeEmployee";
            this.lkeEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeEmployee.Properties.DataSource = this.bdsDSNV;
            this.lkeEmployee.Properties.DisplayMember = "HOTEN";
            this.lkeEmployee.Properties.PopupView = this.searchLookUpEdit2View;
            this.lkeEmployee.Properties.ValueMember = "MANV";
            this.lkeEmployee.Size = new System.Drawing.Size(125, 22);
            this.lkeEmployee.TabIndex = 11;
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.dataSet;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // lkeMaDDH
            // 
            this.lkeMaDDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.lkeMaDDH.Location = new System.Drawing.Point(124, 104);
            this.lkeMaDDH.MenuManager = this.bmPN;
            this.lkeMaDDH.Name = "lkeMaDDH";
            this.lkeMaDDH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeMaDDH.Properties.DataSource = this.bdsDDH;
            this.lkeMaDDH.Properties.DisplayMember = "MasoDDH";
            this.lkeMaDDH.Properties.PopupView = this.searchLookUpEdit1View;
            this.lkeMaDDH.Properties.ValueMember = "MasoDDH";
            this.lkeMaDDH.Size = new System.Drawing.Size(125, 22);
            this.lkeMaDDH.TabIndex = 10;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DatHang";
            this.bdsDDH.DataSource = this.dataSet;
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
            this.txtMaPN.Location = new System.Drawing.Point(124, 48);
            this.txtMaPN.MenuManager = this.bmPN;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(125, 22);
            this.txtMaPN.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.txtDate.EditValue = null;
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(124, 76);
            this.txtDate.MenuManager = this.bmPN;
            this.txtDate.Name = "txtDate";
            this.txtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDate.Size = new System.Drawing.Size(125, 22);
            this.txtDate.TabIndex = 3;
            // 
            // gbCTPN
            // 
            this.gbCTPN.Controls.Add(this.dgvCTPN);
            this.gbCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCTPN.Location = new System.Drawing.Point(0, 0);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(471, 175);
            this.gbCTPN.TabIndex = 1;
            this.gbCTPN.Text = " Chi tiết Phiếu Nhập";
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AutoGenerateColumns = false;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCTPN.ContextMenuStrip = this.cmsCTPN;
            this.dgvCTPN.DataSource = this.bdsCTPN;
            this.dgvCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTPN.Location = new System.Drawing.Point(2, 25);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.RowTemplate.Height = 24;
            this.dgvCTPN.Size = new System.Drawing.Size(467, 148);
            this.dgvCTPN.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
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
            // cmsCTPN
            // 
            this.cmsCTPN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCTPN});
            this.cmsCTPN.Name = "cmsCTPN";
            this.cmsCTPN.Size = new System.Drawing.Size(235, 56);
            // 
            // btnAddCTPN
            // 
            this.btnAddCTPN.Name = "btnAddCTPN";
            this.btnAddCTPN.Size = new System.Drawing.Size(234, 24);
            this.btnAddCTPN.Text = "Tạo Chi tiết Phiếu Nhập";
            this.btnAddCTPN.Click += new System.EventHandler(this.btnAddCTPN_Click);
            // 
            // frmGoodsReceivedNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(871, 1067);
            this.Controls.Add(this.gcReceivedNote);
            this.Controls.Add(this.pnPickDepartment);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoodsReceivedNote";
            this.Text = "QUẢN LÝ PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.GoodsReceivedNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
            this.pnPickDepartment.ResumeLayout(false);
            this.pnPickDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcReceivedNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbReceivedNote)).EndInit();
            this.gbReceivedNote.ResumeLayout(false);
            this.gbReceivedNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMaDDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbCTPN)).EndInit();
            this.gbCTPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
            this.cmsCTPN.ResumeLayout(false);
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
      private DevExpress.XtraBars.Bar bar3;
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
      private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
      private DevExpress.XtraGrid.GridControl gcReceivedNote;
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
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
        private DevExpress.XtraEditors.SearchLookUpEdit lkeEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource bdsDSNV;
        private DataSetTableAdapters.DSNVTableAdepter taDSNV;
        private System.Windows.Forms.ContextMenuStrip cmsCTPN;
        private System.Windows.Forms.ToolStripMenuItem btnAddCTPN;
    }
}