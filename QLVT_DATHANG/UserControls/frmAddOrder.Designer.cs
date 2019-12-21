namespace QLVT_DATHANG.UserControls
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
            this.btnCancelEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.gbOrder = new DevExpress.XtraEditors.GroupControl();
            this.txtEmployeeId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderId = new DevExpress.XtraEditors.TextEdit();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.bdsDSNCC = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.lkeDepot = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDSKHO = new System.Windows.Forms.BindingSource(this.components);
            this.lkeEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDSNV = new System.Windows.Forms.BindingSource(this.components);
            this.pnBtnOrderDetail = new System.Windows.Forms.Panel();
            this.btnRemoveLine = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddMaterials = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.bmVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).BeginInit();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).BeginInit();
            this.pnBtnOrderDetail.SuspendLayout();
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
            // btnCancelEdit
            // 
            this.btnCancelEdit.Caption = "HỦY";
            this.btnCancelEdit.Id = 8;
            this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl1.Size = new System.Drawing.Size(986, 30);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 605);
            this.barDockControl2.Manager = this.bmVT;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl2.Size = new System.Drawing.Size(986, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = this.bmVT;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl3.Size = new System.Drawing.Size(0, 575);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(986, 30);
            this.barDockControl4.Manager = this.bmVT;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl4.Size = new System.Drawing.Size(0, 575);
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
            this.gbOrder.Controls.Add(this.labelControl1);
            this.gbOrder.Controls.Add(this.txtOrderId);
            this.gbOrder.Controls.Add(this.cboNCC);
            this.gbOrder.Controls.Add(this.dtpOrderDate);
            this.gbOrder.Controls.Add(this.lkeDepot);
            this.gbOrder.Controls.Add(this.lkeEmployee);
            this.gbOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOrder.Location = new System.Drawing.Point(0, 30);
            this.gbOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(986, 166);
            this.gbOrder.TabIndex = 0;
            this.gbOrder.Text = "Thông tin đơn đặt hàng";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(155, 118);
            this.txtEmployeeId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeId.MenuManager = this.bmVT;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeId.Properties.Appearance.Options.UseFont = true;
            this.txtEmployeeId.Properties.ReadOnly = true;
            this.txtEmployeeId.Size = new System.Drawing.Size(122, 26);
            this.txtEmployeeId.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(364, 84);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(29, 20);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Kho:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(317, 50);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Ngày đặt:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(43, 84);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Nhà cung cấp:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(43, 122);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(95, 20);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Nhân viên đặt:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(43, 50);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số đơn hàng:";
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(155, 46);
            this.txtOrderId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderId.Properties.Appearance.Options.UseFont = true;
            this.txtOrderId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrderId.Properties.MaxLength = 8;
            this.txtOrderId.Size = new System.Drawing.Size(155, 26);
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
            this.cboNCC.Location = new System.Drawing.Point(155, 80);
            this.cboNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(201, 28);
            this.cboNCC.TabIndex = 5;
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
            // dtpOrderDate
            // 
            this.dtpOrderDate.EditValue = null;
            this.dtpOrderDate.Location = new System.Drawing.Point(384, 46);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.dtpOrderDate.Size = new System.Drawing.Size(168, 26);
            this.dtpOrderDate.TabIndex = 3;
            this.dtpOrderDate.Tag = "1";
            // 
            // lkeDepot
            // 
            this.lkeDepot.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDSKHO, "TENKHO", true));
            this.lkeDepot.Location = new System.Drawing.Point(399, 80);
            this.lkeDepot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lkeDepot.Name = "lkeDepot";
            this.lkeDepot.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkeDepot.Properties.Appearance.Options.UseFont = true;
            this.lkeDepot.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeDepot.Properties.DataSource = this.bdsDSKHO;
            this.lkeDepot.Properties.DisplayMember = "TENKHO";
            this.lkeDepot.Properties.NullText = "";
            this.lkeDepot.Properties.ValueMember = "MAKHO";
            this.lkeDepot.Size = new System.Drawing.Size(153, 26);
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
            this.lkeEmployee.Location = new System.Drawing.Point(285, 118);
            this.lkeEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.lkeEmployee.Size = new System.Drawing.Size(267, 26);
            this.lkeEmployee.TabIndex = 9;
            this.lkeEmployee.Tag = "3";
            this.lkeEmployee.EditValueChanged += new System.EventHandler(this.lkeEmployee_EditValueChanged);
            // 
            // bdsDSNV
            // 
            this.bdsDSNV.DataMember = "DSNV";
            this.bdsDSNV.DataSource = this.dataSet;
            // 
            // pnBtnOrderDetail
            // 
            this.pnBtnOrderDetail.BackColor = System.Drawing.Color.White;
            this.pnBtnOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBtnOrderDetail.Controls.Add(this.btnRemoveLine);
            this.pnBtnOrderDetail.Controls.Add(this.btnAddMaterials);
            this.pnBtnOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBtnOrderDetail.Location = new System.Drawing.Point(0, 545);
            this.pnBtnOrderDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBtnOrderDetail.Name = "pnBtnOrderDetail";
            this.pnBtnOrderDetail.Size = new System.Drawing.Size(986, 60);
            this.pnBtnOrderDetail.TabIndex = 2;
            // 
            // btnRemoveLine
            // 
            this.btnRemoveLine.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLine.Appearance.Options.UseFont = true;
            this.btnRemoveLine.Enabled = false;
            this.btnRemoveLine.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_delete_sign_16;
            this.btnRemoveLine.Location = new System.Drawing.Point(154, 9);
            this.btnRemoveLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveLine.Name = "btnRemoveLine";
            this.btnRemoveLine.Size = new System.Drawing.Size(117, 39);
            this.btnRemoveLine.TabIndex = 0;
            this.btnRemoveLine.Text = "Xóa dòng";
            this.btnRemoveLine.Click += new System.EventHandler(this.btnRemoveLine_Click);
            // 
            // btnAddMaterials
            // 
            this.btnAddMaterials.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaterials.Appearance.Options.UseFont = true;
            this.btnAddMaterials.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_add_list_16;
            this.btnAddMaterials.Location = new System.Drawing.Point(15, 9);
            this.btnAddMaterials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMaterials.Name = "btnAddMaterials";
            this.btnAddMaterials.Size = new System.Drawing.Size(117, 39);
            this.btnAddMaterials.TabIndex = 0;
            this.btnAddMaterials.Text = "Thêm nhiều";
            this.btnAddMaterials.Click += new System.EventHandler(this.btnAddMaterials_Click);
            // 
            // pageOrderDetail
            // 
            this.pageOrderDetail.AutoScroll = true;
            this.pageOrderDetail.Controls.Add(this.gcOrderDetail);
            this.pageOrderDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageOrderDetail.Name = "pageOrderDetail";
            this.pageOrderDetail.Size = new System.Drawing.Size(977, 370);
            this.pageOrderDetail.Text = "Chi tiết";
            // 
            // gcOrderDetail
            // 
            this.gcOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcOrderDetail.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.gcOrderDetail.MainView = this.gvOrderDetail;
            this.gcOrderDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcOrderDetail.MenuManager = this.bmVT;
            this.gcOrderDetail.Name = "gcOrderDetail";
            this.gcOrderDetail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gcOrderDetail.Size = new System.Drawing.Size(977, 370);
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
            this.colMasoDDH,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvOrderDetail.DetailHeight = 458;
            this.gvOrderDetail.FixedLineWidth = 3;
            this.gvOrderDetail.GridControl = this.gcOrderDetail;
            this.gvOrderDetail.Name = "gvOrderDetail";
            this.gvOrderDetail.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvOrderDetail.OptionsView.ShowGroupPanel = false;
            this.gvOrderDetail.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvOrderDetail_ValidateRow);
            this.gvOrderDetail.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvOrderDetail_CustomColumnDisplayText);
            this.gvOrderDetail.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvOrderDetail_ValidatingEditor);
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 23;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colMasoDDH.Width = 87;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "VẬT TƯ";
            this.colMAVT.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 23;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 87;
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
            this.colSOLUONG.Caption = "SỐ LƯỢNG";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 23;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 1;
            this.colSOLUONG.Width = 87;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "ĐƠN GIÁ";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 23;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            this.colDONGIA.Width = 87;
            // 
            // gbOrderDetail
            // 
            this.gbOrderDetail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gbOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbOrderDetail.Location = new System.Drawing.Point(0, 196);
            this.gbOrderDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbOrderDetail.Name = "gbOrderDetail";
            this.gbOrderDetail.SelectedTabPage = this.pageOrderDetail;
            this.gbOrderDetail.Size = new System.Drawing.Size(986, 409);
            this.gbOrderDetail.TabIndex = 1;
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
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnBtnOrderDetail);
            this.Controls.Add(this.gbOrderDetail);
            this.Controls.Add(this.gbOrder);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddOrder";
            this.Size = new System.Drawing.Size(986, 605);
            this.Load += new System.EventHandler(this.frmAddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOrder)).EndInit();
            this.gbOrder.ResumeLayout(false);
            this.gbOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeDepot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSNV)).EndInit();
            this.pnBtnOrderDetail.ResumeLayout(false);
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
      private System.Windows.Forms.Panel pnBtnOrderDetail;
      private DevExpress.XtraTab.XtraTabControl gbOrderDetail;
      private DevExpress.XtraTab.XtraTabPage pageOrderDetail;
      private DevExpress.XtraEditors.GroupControl gbOrder;
      private System.Windows.Forms.ComboBox cboNCC;
      private DevExpress.XtraEditors.TextEdit txtOrderId;
      private DevExpress.XtraEditors.LookUpEdit lkeDepot;
      private DevExpress.XtraEditors.DateEdit dtpOrderDate;
      private System.Windows.Forms.BindingSource bdsDSKHO;
      private DataSetTableAdapters.DSKHOTableAdapter taDSKHO;
      private System.Windows.Forms.BindingSource bdsDSNV;
      private DataSetTableAdapters.DSNVTableAdepter taDSNV;
      private System.Windows.Forms.BindingSource bdsDSNCC;
      private DataSetTableAdapters.DSNCCTableAdapter taDSNCC;
      private System.Windows.Forms.BindingSource bdsDSVT;
      private DataSetTableAdapters.DSVTTableAdapter taDSVT;
      private DataSet dataSet;
      private DevExpress.XtraGrid.GridControl gcOrderDetail;
      private DevExpress.XtraGrid.Views.Grid.GridView gvOrderDetail;
      private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
      private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
      private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
      private DevExpress.XtraBars.BarButtonItem btnCancelEdit;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.SimpleButton btnRemoveLine;
      private DevExpress.XtraEditors.SimpleButton btnAddMaterials;
      private DevExpress.XtraEditors.TextEdit txtEmployeeId;
      private DevExpress.XtraEditors.LookUpEdit lkeEmployee;
   }
}