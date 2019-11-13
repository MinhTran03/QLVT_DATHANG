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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsDeliveryNote));
         this.dataSet = new QLVT_DATHANG.DataSet();
         this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
         this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
         this.gbDeliveryNote = new DevExpress.XtraEditors.GroupControl();
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
         this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
         this.taPX = new QLVT_DATHANG.DataSetTableAdapters.PhieuXuatTableAdapter();
         this.tableAdapterManager = new QLVT_DATHANG.DataSetTableAdapters.TableAdapterManager();
         this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gcDeliveryNote = new DevExpress.XtraGrid.GridControl();
         this.bar3 = new DevExpress.XtraBars.Bar();
         this.cboDeployment = new System.Windows.Forms.ComboBox();
         this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
         this.pnPickDepartment = new DevExpress.XtraEditors.PanelControl();
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
         this.splitContainerControl1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.gbDeliveryNote)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).BeginInit();
         this.pnPickDepartment.SuspendLayout();
         this.SuspendLayout();
         // 
         // dataSet
         // 
         this.dataSet.DataSetName = "DataSet";
         this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // splitterControl1
         // 
         this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitterControl1.Location = new System.Drawing.Point(0, 297);
         this.splitterControl1.Name = "splitterControl1";
         this.splitterControl1.Size = new System.Drawing.Size(785, 5);
         this.splitterControl1.TabIndex = 6;
         this.splitterControl1.TabStop = false;
         // 
         // splitContainerControl1
         // 
         this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.splitContainerControl1.Location = new System.Drawing.Point(0, 302);
         this.splitContainerControl1.Name = "splitContainerControl1";
         this.splitContainerControl1.Panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
         this.splitContainerControl1.Panel1.Controls.Add(this.gbDeliveryNote);
         this.splitContainerControl1.Panel1.Text = "Panel1";
         this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
         this.splitContainerControl1.Panel2.Text = "Panel2";
         this.splitContainerControl1.Size = new System.Drawing.Size(785, 166);
         this.splitContainerControl1.SplitterPosition = 418;
         this.splitContainerControl1.TabIndex = 7;
         // 
         // gbDeliveryNote
         // 
         this.gbDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gbDeliveryNote.Location = new System.Drawing.Point(0, 0);
         this.gbDeliveryNote.Name = "gbDeliveryNote";
         this.gbDeliveryNote.Size = new System.Drawing.Size(414, 162);
         this.gbDeliveryNote.TabIndex = 0;
         this.gbDeliveryNote.Text = "Thông tin Phiếu Xuất";
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
         this.barDockControlTop.Size = new System.Drawing.Size(785, 24);
         // 
         // barDockControlBottom
         // 
         this.barDockControlBottom.CausesValidation = false;
         this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.barDockControlBottom.Location = new System.Drawing.Point(0, 468);
         this.barDockControlBottom.Manager = this.bmPN;
         this.barDockControlBottom.Size = new System.Drawing.Size(785, 0);
         // 
         // barDockControlLeft
         // 
         this.barDockControlLeft.CausesValidation = false;
         this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
         this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
         this.barDockControlLeft.Manager = this.bmPN;
         this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
         // 
         // barDockControlRight
         // 
         this.barDockControlRight.CausesValidation = false;
         this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
         this.barDockControlRight.Location = new System.Drawing.Point(785, 24);
         this.barDockControlRight.Manager = this.bmPN;
         this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
         // 
         // bdsPX
         // 
         this.bdsPX.DataMember = "PhieuXuat";
         this.bdsPX.DataSource = this.dataSet;
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
         // gridView1
         // 
         this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV});
         this.gridView1.GridControl = this.gcDeliveryNote;
         this.gridView1.Name = "gridView1";
         this.gridView1.OptionsBehavior.Editable = false;
         this.gridView1.OptionsView.ShowGroupPanel = false;
         this.gridView1.OptionsView.ShowViewCaption = true;
         this.gridView1.ViewCaption = "Danh sách Phiếu Xuất";
         // 
         // colMAPX
         // 
         this.colMAPX.FieldName = "MAPX";
         this.colMAPX.Name = "colMAPX";
         this.colMAPX.Visible = true;
         this.colMAPX.VisibleIndex = 0;
         // 
         // colNGAY
         // 
         this.colNGAY.FieldName = "NGAY";
         this.colNGAY.Name = "colNGAY";
         this.colNGAY.Visible = true;
         this.colNGAY.VisibleIndex = 1;
         // 
         // colHOTENKH
         // 
         this.colHOTENKH.FieldName = "HOTENKH";
         this.colHOTENKH.Name = "colHOTENKH";
         this.colHOTENKH.Visible = true;
         this.colHOTENKH.VisibleIndex = 2;
         // 
         // colMANV
         // 
         this.colMANV.FieldName = "MANV";
         this.colMANV.Name = "colMANV";
         this.colMANV.Visible = true;
         this.colMANV.VisibleIndex = 3;
         // 
         // gcDeliveryNote
         // 
         this.gcDeliveryNote.DataSource = this.bdsPX;
         this.gcDeliveryNote.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcDeliveryNote.Location = new System.Drawing.Point(0, 54);
         this.gcDeliveryNote.MainView = this.gridView1;
         this.gcDeliveryNote.MenuManager = this.bmPN;
         this.gcDeliveryNote.Name = "gcDeliveryNote";
         this.gcDeliveryNote.Size = new System.Drawing.Size(785, 243);
         this.gcDeliveryNote.TabIndex = 0;
         this.gcDeliveryNote.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
         this.cboDeployment.Location = new System.Drawing.Point(99, 5);
         this.cboDeployment.Name = "cboDeployment";
         this.cboDeployment.Size = new System.Drawing.Size(193, 21);
         this.cboDeployment.TabIndex = 1;
         // 
         // labelControl1
         // 
         this.labelControl1.Location = new System.Drawing.Point(12, 9);
         this.labelControl1.Name = "labelControl1";
         this.labelControl1.Size = new System.Drawing.Size(81, 13);
         this.labelControl1.TabIndex = 2;
         this.labelControl1.Text = "Chọn Chi Nhánh:";
         // 
         // pnPickDepartment
         // 
         this.pnPickDepartment.Controls.Add(this.labelControl1);
         this.pnPickDepartment.Controls.Add(this.cboDeployment);
         this.pnPickDepartment.Dock = System.Windows.Forms.DockStyle.Top;
         this.pnPickDepartment.Location = new System.Drawing.Point(0, 24);
         this.pnPickDepartment.Name = "pnPickDepartment";
         this.pnPickDepartment.Size = new System.Drawing.Size(785, 30);
         this.pnPickDepartment.TabIndex = 24;
         this.pnPickDepartment.Visible = false;
         // 
         // frmGoodsDeliveryNote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(785, 468);
         this.Controls.Add(this.gcDeliveryNote);
         this.Controls.Add(this.pnPickDepartment);
         this.Controls.Add(this.splitterControl1);
         this.Controls.Add(this.splitContainerControl1);
         this.Controls.Add(this.barDockControlLeft);
         this.Controls.Add(this.barDockControlRight);
         this.Controls.Add(this.barDockControlBottom);
         this.Controls.Add(this.barDockControlTop);
         this.Name = "frmGoodsDeliveryNote";
         this.Text = "QUẢN LÝ PHIẾU XUẤT";
         this.Load += new System.EventHandler(this.frmGoodsDeliveryNote_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
         this.splitContainerControl1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.gbDeliveryNote)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bmPN)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcDeliveryNote)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pnPickDepartment)).EndInit();
         this.pnPickDepartment.ResumeLayout(false);
         this.pnPickDepartment.PerformLayout();
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
      private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
      private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
      private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
      private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
      private DevExpress.XtraGrid.Columns.GridColumn colMANV;
      private DevExpress.XtraEditors.PanelControl pnPickDepartment;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboDeployment;
      private DevExpress.XtraBars.Bar bar3;
   }
}