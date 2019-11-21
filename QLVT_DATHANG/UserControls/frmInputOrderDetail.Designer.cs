namespace QLVT_DATHANG.UserControls
{
   partial class frmInputOrderDetail
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

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.Windows.Forms.Label masoDDHLabel;
         System.Windows.Forms.Label mAVTLabel;
         System.Windows.Forms.Label sOLUONGLabel;
         System.Windows.Forms.Label dONGIALabel;
         this.gbOrderDetail = new DevExpress.XtraEditors.GroupControl();
         this.btnSave = new DevExpress.XtraEditors.SimpleButton();
         this.btnExit = new DevExpress.XtraEditors.SimpleButton();
         this.txtOrderId = new DevExpress.XtraEditors.TextEdit();
         this.txtMaterialId = new DevExpress.XtraEditors.TextEdit();
         this.spiQuantity = new DevExpress.XtraEditors.SpinEdit();
         this.spiCost = new DevExpress.XtraEditors.SpinEdit();
         this.gcVT = new DevExpress.XtraGrid.GridControl();
         this.gvMaterial = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colDVT = new DevExpress.XtraGrid.Columns.GridColumn();
         this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
         this.dxErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
         masoDDHLabel = new System.Windows.Forms.Label();
         mAVTLabel = new System.Windows.Forms.Label();
         sOLUONGLabel = new System.Windows.Forms.Label();
         dONGIALabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).BeginInit();
         this.gbOrderDetail.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialId.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiQuantity.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiCost.Properties)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcVT)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // masoDDHLabel
         // 
         masoDDHLabel.AutoSize = true;
         masoDDHLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         masoDDHLabel.Location = new System.Drawing.Point(25, 75);
         masoDDHLabel.Name = "masoDDHLabel";
         masoDDHLabel.Size = new System.Drawing.Size(124, 13);
         masoDDHLabel.TabIndex = 0;
         masoDDHLabel.Text = "Mã số đơn đặt hàng:";
         // 
         // mAVTLabel
         // 
         mAVTLabel.AutoSize = true;
         mAVTLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         mAVTLabel.Location = new System.Drawing.Point(84, 101);
         mAVTLabel.Name = "mAVTLabel";
         mAVTLabel.Size = new System.Drawing.Size(70, 13);
         mAVTLabel.TabIndex = 2;
         mAVTLabel.Text = "Tên vật tư:";
         // 
         // sOLUONGLabel
         // 
         sOLUONGLabel.AutoSize = true;
         sOLUONGLabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         sOLUONGLabel.Location = new System.Drawing.Point(87, 127);
         sOLUONGLabel.Name = "sOLUONGLabel";
         sOLUONGLabel.Size = new System.Drawing.Size(62, 13);
         sOLUONGLabel.TabIndex = 4;
         sOLUONGLabel.Text = "Số lượng:";
         // 
         // dONGIALabel
         // 
         dONGIALabel.AutoSize = true;
         dONGIALabel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dONGIALabel.Location = new System.Drawing.Point(93, 153);
         dONGIALabel.Name = "dONGIALabel";
         dONGIALabel.Size = new System.Drawing.Size(56, 13);
         dONGIALabel.TabIndex = 6;
         dONGIALabel.Text = "Đơn giá:";
         // 
         // gbOrderDetail
         // 
         this.gbOrderDetail.AppearanceCaption.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbOrderDetail.AppearanceCaption.Options.UseFont = true;
         this.gbOrderDetail.Controls.Add(this.btnSave);
         this.gbOrderDetail.Controls.Add(this.btnExit);
         this.gbOrderDetail.Controls.Add(masoDDHLabel);
         this.gbOrderDetail.Controls.Add(this.txtOrderId);
         this.gbOrderDetail.Controls.Add(mAVTLabel);
         this.gbOrderDetail.Controls.Add(this.txtMaterialId);
         this.gbOrderDetail.Controls.Add(sOLUONGLabel);
         this.gbOrderDetail.Controls.Add(this.spiQuantity);
         this.gbOrderDetail.Controls.Add(dONGIALabel);
         this.gbOrderDetail.Controls.Add(this.spiCost);
         this.gbOrderDetail.Dock = System.Windows.Forms.DockStyle.Left;
         this.gbOrderDetail.Location = new System.Drawing.Point(0, 0);
         this.gbOrderDetail.Name = "gbOrderDetail";
         this.gbOrderDetail.Size = new System.Drawing.Size(427, 235);
         this.gbOrderDetail.TabIndex = 2;
         this.gbOrderDetail.Text = "Chi tiết Đơn Đặt Hàng";
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(127, 188);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(75, 23);
         this.btnSave.TabIndex = 9;
         this.btnSave.Text = "Ghi";
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnExit
         // 
         this.btnExit.Location = new System.Drawing.Point(236, 188);
         this.btnExit.Name = "btnExit";
         this.btnExit.Size = new System.Drawing.Size(75, 23);
         this.btnExit.TabIndex = 8;
         this.btnExit.Text = "Thoát";
         this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
         // 
         // txtOrderId
         // 
         this.txtOrderId.Location = new System.Drawing.Point(155, 72);
         this.txtOrderId.Name = "txtOrderId";
         this.txtOrderId.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtOrderId.Properties.Appearance.Options.UseFont = true;
         this.txtOrderId.Properties.ReadOnly = true;
         this.txtOrderId.Size = new System.Drawing.Size(166, 20);
         this.txtOrderId.TabIndex = 1;
         // 
         // txtMaterialId
         // 
         this.txtMaterialId.Location = new System.Drawing.Point(155, 98);
         this.txtMaterialId.Name = "txtMaterialId";
         this.txtMaterialId.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMaterialId.Properties.Appearance.Options.UseFont = true;
         this.txtMaterialId.Properties.ReadOnly = true;
         this.txtMaterialId.Size = new System.Drawing.Size(166, 20);
         this.txtMaterialId.TabIndex = 3;
         this.txtMaterialId.EditValueChanged += new System.EventHandler(this.txtMaterialId_EditValueChanged);
         // 
         // spiQuantity
         // 
         this.spiQuantity.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.dxErrorProvider.SetIconAlignment(this.spiQuantity, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
         this.spiQuantity.Location = new System.Drawing.Point(155, 124);
         this.spiQuantity.Name = "spiQuantity";
         this.spiQuantity.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.spiQuantity.Properties.Appearance.Options.UseFont = true;
         this.spiQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spiQuantity.Properties.IsFloatValue = false;
         this.spiQuantity.Properties.Mask.EditMask = "N00";
         this.spiQuantity.Size = new System.Drawing.Size(166, 20);
         this.spiQuantity.TabIndex = 5;
         this.spiQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.spiQuantity_Validating);
         // 
         // spiCost
         // 
         this.spiCost.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
         this.spiCost.Location = new System.Drawing.Point(155, 150);
         this.spiCost.Name = "spiCost";
         this.spiCost.Properties.Appearance.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.spiCost.Properties.Appearance.Options.UseFont = true;
         this.spiCost.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
         this.spiCost.Size = new System.Drawing.Size(166, 20);
         this.spiCost.TabIndex = 7;
         this.spiCost.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.spiCost_CustomDisplayText);
         this.spiCost.Validating += new System.ComponentModel.CancelEventHandler(this.spiCost_Validating);
         // 
         // gcVT
         // 
         this.gcVT.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gcVT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
         this.gcVT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gcVT.Location = new System.Drawing.Point(427, 0);
         this.gcVT.MainView = this.gvMaterial;
         this.gcVT.Margin = new System.Windows.Forms.Padding(2);
         this.gcVT.Name = "gcVT";
         this.gcVT.Size = new System.Drawing.Size(441, 235);
         this.gcVT.TabIndex = 7;
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
         // dxErrorProvider
         // 
         this.dxErrorProvider.ContainerControl = this;
         // 
         // frmInputOrderDetail
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.Controls.Add(this.gcVT);
         this.Controls.Add(this.gbOrderDetail);
         this.Name = "frmInputOrderDetail";
         this.Size = new System.Drawing.Size(868, 235);
         this.Load += new System.EventHandler(this.frmInputOrderDetail_Load);
         ((System.ComponentModel.ISupportInitialize)(this.gbOrderDetail)).EndInit();
         this.gbOrderDetail.ResumeLayout(false);
         this.gbOrderDetail.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.txtOrderId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.txtMaterialId.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiQuantity.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.spiCost.Properties)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gcVT)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gvMaterial)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraEditors.GroupControl gbOrderDetail;
      private DevExpress.XtraGrid.GridControl gcVT;
      private DevExpress.XtraGrid.Views.Grid.GridView gvMaterial;
      private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
      private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
      private DevExpress.XtraGrid.Columns.GridColumn colDVT;
      private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
      private DevExpress.XtraEditors.TextEdit txtOrderId;
      private DevExpress.XtraEditors.TextEdit txtMaterialId;
      private DevExpress.XtraEditors.SpinEdit spiQuantity;
      private DevExpress.XtraEditors.SpinEdit spiCost;
      private DevExpress.XtraEditors.SimpleButton btnSave;
      private DevExpress.XtraEditors.SimpleButton btnExit;
      private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider;
   }
}
