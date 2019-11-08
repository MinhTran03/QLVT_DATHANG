namespace QLVT_DATHANG
{
   partial class frmMain
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
         this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
         this.bsiMaNV = new DevExpress.XtraBars.BarStaticItem();
         this.bsiHoTenNV = new DevExpress.XtraBars.BarStaticItem();
         this.bsiNhom = new DevExpress.XtraBars.BarStaticItem();
         this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
         this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
         this.rbpCategory = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
         this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
         this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
         this.SuspendLayout();
         // 
         // ribbonControl1
         // 
         this.ribbonControl1.ExpandCollapseItem.Id = 0;
         this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnNhanVien,
            this.bsiMaNV,
            this.bsiHoTenNV,
            this.bsiNhom,
            this.btnVatTu});
         this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
         this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
         this.ribbonControl1.MaxItemId = 6;
         this.ribbonControl1.Name = "ribbonControl1";
         this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
         this.ribbonControl1.Size = new System.Drawing.Size(722, 143);
         this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
         // 
         // btnNhanVien
         // 
         this.btnNhanVien.Caption = "Nhân Viên";
         this.btnNhanVien.Hint = "Quản lý nhân viên";
         this.btnNhanVien.Id = 1;
         this.btnNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhanVien.ImageOptions.SvgImage")));
         this.btnNhanVien.Name = "btnNhanVien";
         this.btnNhanVien.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
         this.btnNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
         this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
         // 
         // bsiMaNV
         // 
         this.bsiMaNV.Caption = "MANV";
         this.bsiMaNV.Id = 2;
         this.bsiMaNV.Name = "bsiMaNV";
         // 
         // bsiHoTenNV
         // 
         this.bsiHoTenNV.Caption = "HOTENNV";
         this.bsiHoTenNV.Id = 3;
         this.bsiHoTenNV.Name = "bsiHoTenNV";
         // 
         // bsiNhom
         // 
         this.bsiNhom.Caption = "NHOM";
         this.bsiNhom.Id = 4;
         this.bsiNhom.Name = "bsiNhom";
         // 
         // btnVatTu
         // 
         this.btnVatTu.Caption = "Vật Tư";
         this.btnVatTu.Hint = "Quản Lý Vật Tư";
         this.btnVatTu.Id = 5;
         this.btnVatTu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.Image")));
         this.btnVatTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVatTu.ImageOptions.LargeImage")));
         this.btnVatTu.Name = "btnVatTu";
         this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
         // 
         // ribbonPage1
         // 
         this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpCategory});
         this.ribbonPage1.Name = "ribbonPage1";
         this.ribbonPage1.Text = "TRANG CHÍNH";
         // 
         // rbpCategory
         // 
         this.rbpCategory.ItemLinks.Add(this.btnNhanVien);
         this.rbpCategory.ItemLinks.Add(this.btnVatTu);
         this.rbpCategory.Name = "rbpCategory";
         this.rbpCategory.Text = "DANH MỤC";
         // 
         // ribbonStatusBar1
         // 
         this.ribbonStatusBar1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.ribbonStatusBar1.ItemLinks.Add(this.bsiMaNV);
         this.ribbonStatusBar1.ItemLinks.Add(this.bsiHoTenNV);
         this.ribbonStatusBar1.ItemLinks.Add(this.bsiNhom);
         this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 422);
         this.ribbonStatusBar1.Name = "ribbonStatusBar1";
         this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
         this.ribbonStatusBar1.Size = new System.Drawing.Size(722, 31);
         // 
         // xtraTabbedMdiManager1
         // 
         this.xtraTabbedMdiManager1.MdiParent = this;
         // 
         // frmMain
         // 
         this.Appearance.Options.UseFont = true;
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(722, 453);
         this.Controls.Add(this.ribbonStatusBar1);
         this.Controls.Add(this.ribbonControl1);
         this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.IsMdiContainer = true;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmMain";
         this.Ribbon = this.ribbonControl1;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.StatusBar = this.ribbonStatusBar1;
         this.Text = "QUẢN LÝ VẬT TƯ ĐẶT HÀNG";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
      private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
      private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpCategory;
      private DevExpress.XtraBars.BarButtonItem btnNhanVien;
      private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
      private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
      private DevExpress.XtraBars.BarStaticItem bsiMaNV;
      private DevExpress.XtraBars.BarStaticItem bsiHoTenNV;
      private DevExpress.XtraBars.BarStaticItem bsiNhom;
      private DevExpress.XtraBars.BarButtonItem btnVatTu;
   }
}

