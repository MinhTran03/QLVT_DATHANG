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
         System.Windows.Forms.Label mAKHOLabel;
         System.Windows.Forms.Label tENKHOLabel;
         System.Windows.Forms.Label dIACHILabel;
         System.Windows.Forms.Label mACNLabel;
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
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gbDepot = new DevExpress.XtraEditors.GroupControl();
         this.txtDepotId = new DevExpress.XtraEditors.TextEdit();
         this.txtDepotName = new DevExpress.XtraEditors.TextEdit();
         this.txtDepotAddress = new DevExpress.XtraEditors.TextEdit();
         this.txtEmpDepartment = new DevExpress.XtraEditors.TextEdit();
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.bdsCN = new System.Windows.Forms.BindingSource(this.components);
         this.taCN = new QLVT_DATHANG.DataSetTableAdapters.ChiNhanhTableAdapter();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         mAKHOLabel = new System.Windows.Forms.Label();
         tENKHOLabel = new System.Windows.Forms.Label();
         dIACHILabel = new System.Windows.Forms.Label();
         mACNLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.bmOrder)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDepot)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDepot)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbDepot)).BeginInit();
         this.gbDepot.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotName.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotAddress.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.bdsCN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // mAKHOLabel
         // 
         mAKHOLabel.AutoSize = true;
         mAKHOLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         mAKHOLabel.Location = new System.Drawing.Point(115, 49);
         mAKHOLabel.Name = "mAKHOLabel";
         mAKHOLabel.Size = new System.Drawing.Size(53, 13);
         mAKHOLabel.TabIndex = 0;
         mAKHOLabel.Text = "Mã kho:";
         // 
         // tENKHOLabel
         // 
         tENKHOLabel.AutoSize = true;
         tENKHOLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         tENKHOLabel.Location = new System.Drawing.Point(110, 75);
         tENKHOLabel.Name = "tENKHOLabel";
         tENKHOLabel.Size = new System.Drawing.Size(58, 13);
         tENKHOLabel.TabIndex = 2;
         tENKHOLabel.Text = "Tên kho:";
         // 
         // dIACHILabel
         // 
         dIACHILabel.AutoSize = true;
         dIACHILabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dIACHILabel.Location = new System.Drawing.Point(117, 101);
         dIACHILabel.Name = "dIACHILabel";
         dIACHILabel.Size = new System.Drawing.Size(51, 13);
         dIACHILabel.TabIndex = 4;
         dIACHILabel.Text = "Địa chỉ:";
         // 
         // mACNLabel
         // 
         mACNLabel.AutoSize = true;
         mACNLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         mACNLabel.Location = new System.Drawing.Point(81, 127);
         mACNLabel.Name = "mACNLabel";
         mACNLabel.Size = new System.Drawing.Size(87, 13);
         mACNLabel.TabIndex = 6;
         mACNLabel.Text = "Mã chi nhánh:";
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
         this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
         // 
         // btnCancelEdit
         // 
         this.btnCancelEdit.Caption = "HỦY";
         this.btnCancelEdit.Id = 7;
         this.btnCancelEdit.ImageOptions.Image = global::QLVT_DATHANG.Properties.Resources.icons8_cancel_file_16;
         this.btnCancelEdit.Name = "btnCancelEdit";
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
         this.gcDepot.Location = new System.Drawing.Point(0, 54);
         this.gcDepot.MainView = this.gridView1;
         this.gcDepot.MenuManager = this.bmOrder;
         this.gcDepot.Name = "gcDepot";
         this.gcDepot.Size = new System.Drawing.Size(800, 220);
         this.gcDepot.TabIndex = 5;
         this.gcDepot.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
         // 
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
         this.gridView1.GridControl = this.gcDepot;
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsBehavior.Editable = false;
         this.gridView1.OptionsView.ShowGroupPanel = false;
         this.gridView1.OptionsView.ShowViewCaption = true;
         this.gridView1.ViewCaption = "Danh sách Kho";
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
         this.gbDepot.Controls.Add(mAKHOLabel);
         this.gbDepot.Controls.Add(this.txtDepotId);
         this.gbDepot.Controls.Add(tENKHOLabel);
         this.gbDepot.Controls.Add(this.txtDepotName);
         this.gbDepot.Controls.Add(dIACHILabel);
         this.gbDepot.Controls.Add(this.txtDepotAddress);
         this.gbDepot.Controls.Add(mACNLabel);
         this.gbDepot.Controls.Add(this.txtEmpDepartment);
         this.gbDepot.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.gbDepot.Location = new System.Drawing.Point(0, 279);
         this.gbDepot.Name = "gbDepot";
         this.gbDepot.Size = new System.Drawing.Size(800, 171);
         this.gbDepot.TabIndex = 6;
         this.gbDepot.Text = "Thông Tin Kho";
         // 
         // txtDepotId
         // 
         this.txtDepotId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "MAKHO", true));
         this.txtDepotId.Location = new System.Drawing.Point(174, 46);
         this.txtDepotId.MenuManager = this.bmOrder;
         this.txtDepotId.Name = "txtDepotId";
         this.txtDepotId.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDepotId.Properties.Appearance.Options.UseFont = true;
         this.txtDepotId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtDepotId.Size = new System.Drawing.Size(214, 20);
         this.txtDepotId.TabIndex = 1;
         // 
         // txtDepotName
         // 
         this.txtDepotName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "TENKHO", true));
         this.txtDepotName.Location = new System.Drawing.Point(174, 72);
         this.txtDepotName.MenuManager = this.bmOrder;
         this.txtDepotName.Name = "txtDepotName";
         this.txtDepotName.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDepotName.Properties.Appearance.Options.UseFont = true;
         this.txtDepotName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtDepotName.Size = new System.Drawing.Size(214, 20);
         this.txtDepotName.TabIndex = 3;
         // 
         // txtDepotAddress
         // 
         this.txtDepotAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "DIACHI", true));
         this.txtDepotAddress.Location = new System.Drawing.Point(174, 98);
         this.txtDepotAddress.MenuManager = this.bmOrder;
         this.txtDepotAddress.Name = "txtDepotAddress";
         this.txtDepotAddress.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDepotAddress.Properties.Appearance.Options.UseFont = true;
         this.txtDepotAddress.Size = new System.Drawing.Size(214, 20);
         this.txtDepotAddress.TabIndex = 5;
         // 
         // txtEmpDepartment
         // 
         this.txtEmpDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepot, "MACN", true));
         this.txtEmpDepartment.Location = new System.Drawing.Point(174, 124);
         this.txtEmpDepartment.MenuManager = this.bmOrder;
         this.txtEmpDepartment.Name = "txtEmpDepartment";
         this.txtEmpDepartment.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtEmpDepartment.Properties.Appearance.Options.UseFont = true;
         this.txtEmpDepartment.Size = new System.Drawing.Size(214, 20);
         this.txtEmpDepartment.TabIndex = 7;
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
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitterControl1.Location = new System.Drawing.Point(0, 274);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(800, 5);
         this.splitterControl1.TabIndex = 24;
         this.splitterControl1.TabStop = false;
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
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.gbDepot);
         this.Controls.Add(this.barDockControl3);
         this.Controls.Add(this.barDockControl4);
         this.Controls.Add(this.barDockControl2);
         this.Controls.Add(this.barDockControl1);
         this.Name = "frmDepot";
         this.Text = "QUẢN LÝ KHO";
         this.Load += new System.EventHandler(this.frmDepot_Load);
         ((System.ComponentModel.ISupportInitialize)(this.bmOrder)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsDepot)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDepot)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gbDepot)).EndInit();
         this.gbDepot.ResumeLayout(false);
         this.gbDepot.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotName.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtDepotAddress.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtEmpDepartment.Properties)).EndInit();
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
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
    }
}