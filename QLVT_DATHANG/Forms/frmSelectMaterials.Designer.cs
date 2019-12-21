namespace QLVT_DATHANG.Forms
{
   partial class frmSelectMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectMaterials));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcVT = new DevExpress.XtraGrid.GridControl();
            this.bdsVT = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new QLVT_DATHANG.DataSet();
            this.gvMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ckbSelect = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.taVT = new QLVT_DATHANG.DataSetTableAdapters.VattuTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbSelect)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 71);
            this.panel1.TabIndex = 0;
            // 
            // gcVT
            // 
            this.gcVT.DataSource = this.bdsVT;
            this.gcVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcVT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcVT.Location = new System.Drawing.Point(0, 71);
            this.gcVT.MainView = this.gvMaterial;
            this.gcVT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcVT.Name = "gcVT";
            this.gcVT.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ckbSelect});
            this.gcVT.Size = new System.Drawing.Size(833, 408);
            this.gcVT.TabIndex = 1;
            this.gcVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMaterial});
            // 
            // bdsVT
            // 
            this.bdsVT.DataMember = "Vattu";
            this.bdsVT.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvMaterial
            // 
            this.gvMaterial.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMaterial.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvMaterial.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMaterial.Appearance.Row.Options.UseFont = true;
            this.gvMaterial.Appearance.SelectedRow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMaterial.Appearance.SelectedRow.Options.UseFont = true;
            this.gvMaterial.Appearance.ViewCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMaterial.Appearance.ViewCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.gvMaterial.Appearance.ViewCaption.Options.UseFont = true;
            this.gvMaterial.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colDVT,
            this.colSOLUONGTON});
            this.gvMaterial.CustomizationFormBounds = new System.Drawing.Rectangle(506, 324, 303, 330);
            this.gvMaterial.DetailHeight = 371;
            this.gvMaterial.FixedLineWidth = 3;
            this.gvMaterial.GridControl = this.gcVT;
            this.gvMaterial.Name = "gvMaterial";
            this.gvMaterial.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.CheckAllDetails;
            this.gvMaterial.OptionsView.ShowGroupPanel = false;
            this.gvMaterial.OptionsView.ShowViewCaption = true;
            this.gvMaterial.ViewCaption = "Danh Sách Vật Tư";
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "MÃ VẬT TƯ";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 22;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 184;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "TÊN VẬT TƯ";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 22;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 184;
            // 
            // colDVT
            // 
            this.colDVT.Caption = "ĐƠN VỊ TÍNH";
            this.colDVT.FieldName = "DVT";
            this.colDVT.MinWidth = 22;
            this.colDVT.Name = "colDVT";
            this.colDVT.Visible = true;
            this.colDVT.VisibleIndex = 2;
            this.colDVT.Width = 184;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.Caption = "SỐ LƯỢNG TỒN";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.MinWidth = 22;
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 194;
            // 
            // ckbSelect
            // 
            this.ckbSelect.AutoHeight = false;
            this.ckbSelect.Name = "ckbSelect";
            // 
            // taVT
            // 
            this.taVT.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 479);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 69);
            this.panel2.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Location = new System.Drawing.Point(715, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 42);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAccept.ImageOptions.SvgImage")));
            this.btnAccept.Location = new System.Drawing.Point(596, 13);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(104, 42);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Chọn";
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmSelectMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 548);
            this.Controls.Add(this.gcVT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSelectMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSelectMaterials";
            this.Load += new System.EventHandler(this.frmSelectMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbSelect)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private DevExpress.XtraGrid.GridControl gcVT;
      private DevExpress.XtraGrid.Views.Grid.GridView gvMaterial;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
      private DevExpress.XtraGrid.Columns.GridColumn colDVT;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
      private System.Windows.Forms.BindingSource bdsVT;
      private DataSet dataSet;
      private DataSetTableAdapters.VattuTableAdapter taVT;
      private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit ckbSelect;
      private System.Windows.Forms.Panel panel2;
      private DevExpress.XtraEditors.SimpleButton btnAccept;
      private DevExpress.XtraEditors.SimpleButton btnExit;
   }
}