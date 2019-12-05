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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
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
         this.gcOrderDetail = new System.Windows.Forms.DataGridView();
         this.TENVT = new System.Windows.Forms.DataGridViewComboBoxColumn();
         this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.taCTDDH = new QLVT_DATHANG.DataSetTableAdapters.CTDDHTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         this.gbOrderDetail = new DevExpress.XtraEditors.GroupControl();
         this.taDSVT = new QLVT_DATHANG.DataSetTableAdapters.DSVTTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDSVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).BeginInit();
         this.gbOrderDetail.SuspendLayout();
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
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 456);
         this.barDockControlBottom.Manager = this.bmPN;
         this.barDockControlBottom.Size = new System.Drawing.Size(987, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmPN;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(987, 24);
         this.barDockControlRight.Manager = this.bmPN;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
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
         this.gcOrder.Size = new System.Drawing.Size(987, 229);
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
         this.splitterControl1.Location = new System.Drawing.Point(0, 283);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(987, 5);
         this.splitterControl1.TabIndex = 2;
         this.splitterControl1.TabStop = false;
         // 
         // gcOrderDetail
         // 
         this.gcOrderDetail.AllowUserToAddRows = false;
         this.gcOrderDetail.AllowUserToDeleteRows = false;
         this.gcOrderDetail.AutoGenerateColumns = false;
         this.gcOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.gcOrderDetail.BackgroundColor = System.Drawing.Color.White;
         this.gcOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
         this.gcOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gray;
         dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSlateGray;
         dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gcOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
         this.gcOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.gcOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENVT,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
         this.gcOrderDetail.DataSource = this.bdsCTDDH;
         dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
         dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(234)))), ((int)(((byte)(253)))));
         dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
         dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.gcOrderDetail.DefaultCellStyle = dataGridViewCellStyle11;
         this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcOrderDetail.EnableHeadersVisualStyles = false;
         this.gcOrderDetail.GridColor = System.Drawing.Color.Silver;
         this.gcOrderDetail.Location = new System.Drawing.Point(2, 20);
         this.gcOrderDetail.Name = "gcOrderDetail";
         this.gcOrderDetail.ReadOnly = true;
         this.gcOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
         dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.gcOrderDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
         this.gcOrderDetail.RowHeadersVisible = false;
         this.gcOrderDetail.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
         this.gcOrderDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gcOrderDetail.Size = new System.Drawing.Size(983, 146);
         this.gcOrderDetail.TabIndex = 0;
         // 
         // TENVT
         // 
         this.TENVT.DataPropertyName = "MAVT";
         this.TENVT.DataSource = this.bdsDSVT;
         dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TENVT.DefaultCellStyle = dataGridViewCellStyle8;
         this.TENVT.DisplayMember = "TENVT";
         this.TENVT.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
         this.TENVT.HeaderText = "TÊN VẬT TƯ";
         this.TENVT.Name = "TENVT";
         this.TENVT.ReadOnly = true;
         this.TENVT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
         this.TENVT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
         this.TENVT.ValueMember = "MAVT";
         // 
         // dataGridViewTextBoxColumn3
         // 
         this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
         dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
         this.dataGridViewTextBoxColumn3.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn3.HeaderText = "SỐ LƯỢNG";
         this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
         this.dataGridViewTextBoxColumn3.ReadOnly = true;
         // 
         // dataGridViewTextBoxColumn4
         // 
         this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
         dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle10.Format = "C0";
         dataGridViewCellStyle10.NullValue = null;
         this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
         this.dataGridViewTextBoxColumn4.FillWeight = 92.72421F;
         this.dataGridViewTextBoxColumn4.HeaderText = "ĐƠN GIÁ";
         this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
         this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
         // gbOrderDetail
         // 
         this.gbOrderDetail.Controls.Add(this.gcOrderDetail);
         this.gbOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.gbOrderDetail.Location = new System.Drawing.Point(0, 288);
         this.gbOrderDetail.Name = "gbOrderDetail";
         this.gbOrderDetail.Size = new System.Drawing.Size(987, 168);
         this.gbOrderDetail.TabIndex = 12;
         this.gbOrderDetail.Text = "Chi tiết";
         // 
         // taDSVT
         // 
         this.taDSVT.ClearBeforeFill = true;
         // 
         // frmOrders
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.ClientSize = new System.Drawing.Size(987, 456);
         this.Controls.Add(this.gcOrder);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.gbOrderDetail);
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
         ((System.ComponentModel.ISupportInitialize)(this.gcOrderDetail)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).EndInit();
         this.gbOrderDetail.ResumeLayout(false);
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
      private System.Windows.Forms.DataGridView gcOrderDetail;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
      private System.Windows.Forms.BindingSource bdsCTDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
      private DevExpress.XtraEditors.GroupControl gbOrderDetail;
      private System.Windows.Forms.BindingSource bdsDSVT;
      private DataSetTableAdapters.DSVTTableAdapter taDSVT;
      private System.Windows.Forms.DataGridViewComboBoxColumn TENVT;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
      private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
      private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
   }
}