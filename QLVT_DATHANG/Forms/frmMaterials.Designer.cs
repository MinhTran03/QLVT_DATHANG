﻿namespace QLVT_DATHANG.Forms
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
         System.Windows.Forms.Label mAVTLabel;
         System.Windows.Forms.Label tENVTLabel;
         System.Windows.Forms.Label dVTLabel;
         System.Windows.Forms.Label sOLUONGTONLabel;
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
         this.txtMaterialName = new DevExpress.XtraEditors.TextEdit();
         this.txtDVT = new DevExpress.XtraEditors.TextEdit();
         this.spiSLT = new DevExpress.XtraEditors.SpinEdit();
         this.bmVT = new DevExpress.XtraBars.BarManager(this.components);
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
         this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
         this.btnDel = new DevExpress.XtraBars.BarButtonItem();
         this.btnReload = new DevExpress.XtraBars.BarButtonItem();
         this.btnExit = new DevExpress.XtraBars.BarButtonItem();
         this.btnSave = new DevExpress.XtraBars.BarButtonItem();
         this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
         this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
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
         mAVTLabel = new System.Windows.Forms.Label();
         tENVTLabel = new System.Windows.Forms.Label();
         dVTLabel = new System.Windows.Forms.Label();
         sOLUONGTONLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiSLT.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbVT)).BeginInit();
         this.gbVT.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
         this.SuspendLayout();
         // 
         // mAVTLabel
         // 
         mAVTLabel.AutoSize = true;
         mAVTLabel.Location = new System.Drawing.Point(139, 30);
         mAVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         mAVTLabel.Name = "mAVTLabel";
         mAVTLabel.Size = new System.Drawing.Size(65, 13);
         mAVTLabel.TabIndex = 10;
         mAVTLabel.Text = "MÃ VẬT TƯ:";
         // 
         // tENVTLabel
         // 
         tENVTLabel.AutoSize = true;
         tENVTLabel.Location = new System.Drawing.Point(139, 66);
         tENVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         tENVTLabel.Name = "tENVTLabel";
         tENVTLabel.Size = new System.Drawing.Size(69, 13);
         tENVTLabel.TabIndex = 11;
         tENVTLabel.Text = "TÊN VẬT TƯ:";
         // 
         // dVTLabel
         // 
         dVTLabel.AutoSize = true;
         dVTLabel.Location = new System.Drawing.Point(139, 100);
         dVTLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         dVTLabel.Name = "dVTLabel";
         dVTLabel.Size = new System.Drawing.Size(74, 13);
         dVTLabel.TabIndex = 16;
         dVTLabel.Text = "ĐƠN VỊ TÍNH:";
         // 
         // sOLUONGTONLabel
         // 
         sOLUONGTONLabel.AutoSize = true;
         sOLUONGTONLabel.Location = new System.Drawing.Point(139, 136);
         sOLUONGTONLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
         sOLUONGTONLabel.Name = "sOLUONGTONLabel";
         sOLUONGTONLabel.Size = new System.Drawing.Size(87, 13);
         sOLUONGTONLabel.TabIndex = 17;
         sOLUONGTONLabel.Text = "SỐ LƯỢNG TỒN:";
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
         this.gcVT.Dock = System.Windows.Forms.DockStyle.Top;
         this.gcVT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
         this.gcVT.Location = new System.Drawing.Point(0, 24);
         this.gcVT.MainView = this.gvMaterial;
         this.gcVT.Margin = new System.Windows.Forms.Padding(2);
         this.gcVT.Name = "gcVT";
         this.gcVT.Size = new System.Drawing.Size(873, 208);
         this.gcVT.TabIndex = 6;
         this.gcVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterial});
         // 
         // gvMaterial
         // 
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
         this.colMAVT.Caption = "MÃ Vật TƯ";
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
         this.txtMaterialId.Location = new System.Drawing.Point(236, 28);
         this.txtMaterialId.Margin = new System.Windows.Forms.Padding(2);
         this.txtMaterialId.Name = "txtMaterialId";
         this.txtMaterialId.Size = new System.Drawing.Size(111, 20);
         this.txtMaterialId.TabIndex = 11;
         // 
         // txtMaterialName
         // 
         this.txtMaterialName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "TENVT", true));
         this.txtMaterialName.Location = new System.Drawing.Point(236, 63);
         this.txtMaterialName.Margin = new System.Windows.Forms.Padding(2);
         this.txtMaterialName.Name = "txtMaterialName";
         this.txtMaterialName.Size = new System.Drawing.Size(111, 20);
         this.txtMaterialName.TabIndex = 12;
         // 
         // txtDVT
         // 
         this.txtDVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "DVT", true));
         this.txtDVT.Location = new System.Drawing.Point(236, 97);
         this.txtDVT.Margin = new System.Windows.Forms.Padding(2);
         this.txtDVT.Name = "txtDVT";
         this.txtDVT.Size = new System.Drawing.Size(111, 20);
         this.txtDVT.TabIndex = 17;
         // 
         // spiSLT
         // 
         this.spiSLT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVT, "SOLUONGTON", true));
         this.spiSLT.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.spiSLT.Location = new System.Drawing.Point(236, 133);
         this.spiSLT.Margin = new System.Windows.Forms.Padding(2);
         this.spiSLT.Name = "spiSLT";
         this.spiSLT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spiSLT.Size = new System.Drawing.Size(111, 20);
         this.spiSLT.TabIndex = 18;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancelEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
         // btnReload
         // 
         this.btnReload.Caption = "LÀM MỚI";
         this.btnReload.Id = 3;
         this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
         this.btnReload.Name = "btnReload";
         this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
         // 
         // btnExit
         // 
         this.btnExit.Caption = "THOÁT";
         this.btnExit.Id = 4;
         this.btnExit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_exit_16;
         this.btnExit.Name = "btnExit";
         this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
         // 
         // btnSave
         // 
         this.btnSave.Caption = "GHI";
         this.btnSave.Id = 5;
         this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
         this.btnSave.Name = "btnSave";
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnUndo
         // 
         this.btnUndo.Caption = "PHỤC HỒI";
         this.btnUndo.Id = 6;
         this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
         this.btnUndo.Name = "btnUndo";
         this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Id = 7;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
         this.btnCancelEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelEdit_ItemClick);
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
         this.barDockControl2.Location = new System.Drawing.Point(0, 487);
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
         this.barDockControl3.Size = new System.Drawing.Size(0, 463);
         // 
         // barDockControl4
         // 
         this.barDockControl4.CausesValidation = false;
         this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControl4.Location = new System.Drawing.Point(873, 24);
         this.barDockControl4.Manager = this.bmVT;
         this.barDockControl4.Margin = new System.Windows.Forms.Padding(2);
         this.barDockControl4.Size = new System.Drawing.Size(0, 463);
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
         this.gbVT.Controls.Add(this.txtMaterialName);
         this.gbVT.Controls.Add(mAVTLabel);
         this.gbVT.Controls.Add(sOLUONGTONLabel);
         this.gbVT.Controls.Add(this.txtDVT);
         this.gbVT.Controls.Add(this.txtMaterialId);
         this.gbVT.Controls.Add(tENVTLabel);
         this.gbVT.Controls.Add(this.spiSLT);
         this.gbVT.Controls.Add(dVTLabel);
         this.gbVT.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbVT.Location = new System.Drawing.Point(0, 232);
         this.gbVT.Name = "gbVT";
         this.gbVT.Size = new System.Drawing.Size(873, 255);
         this.gbVT.TabIndex = 19;
         this.gbVT.Text = "Thông tin Vật Tư";
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
         this.splitterControl1.Location = new System.Drawing.Point(0, 232);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(873, 5);
         this.splitterControl1.TabIndex = 24;
         this.splitterControl1.TabStop = false;
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
         // frmMaterials
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(873, 487);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.gbVT);
         this.Controls.Add(this.gcVT);
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
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDVT.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiSLT.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbVT)).EndInit();
         this.gbVT.ResumeLayout(false);
         this.gbVT.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtDVT;
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
   }
}