namespace QLVT_DATHANG.Report
{
   partial class Xrpt_DanhSachNhanVien
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

      #region Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters msSqlConnectionParameters1 = new DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters();
         DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_DanhSachNhanVien));
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.lblDate = new DevExpress.XtraReports.UI.XRLabel();
         this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.lblChiNhanh = new DevExpress.XtraReports.UI.XRLabel();
         this.label1 = new DevExpress.XtraReports.UI.XRLabel();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.table1 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.table2 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tcLuong = new DevExpress.XtraReports.UI.XRTableCell();
         this.taReportDSNV = new QLVT_DATHANG.DataSetReportTableAdapters.Report_DSNVTableAdapter();
         this.dataSetReport = new QLVT_DATHANG.DataSetReport();
         ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         msSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer;
         msSqlConnectionParameters1.DatabaseName = null;
         msSqlConnectionParameters1.ServerName = null;
         this.sqlDataSource1.ConnectionParameters = msSqlConnectionParameters1;
         this.sqlDataSource1.Name = "sqlDataSource1";
         storedProcQuery1.Name = "Report_DSNV";
         queryParameter1.Name = "@macn";
         queryParameter1.Type = typeof(string);
         storedProcQuery1.Parameters.Add(queryParameter1);
         storedProcQuery1.StoredProcName = "Report_DSNV";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Segoe UI", 14.25F);
         this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.Title.Name = "Title";
         // 
         // DetailCaption1
         // 
         this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(98)))), ((int)(((byte)(110)))));
         this.DetailCaption1.BorderColor = System.Drawing.Color.White;
         this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
         this.DetailCaption1.BorderWidth = 2F;
         this.DetailCaption1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.DetailCaption1.ForeColor = System.Drawing.Color.White;
         this.DetailCaption1.Name = "DetailCaption1";
         this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 96F);
         this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailData1
         // 
         this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
         this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
         this.DetailData1.BorderWidth = 2F;
         this.DetailData1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         this.DetailData1.ForeColor = System.Drawing.Color.Black;
         this.DetailData1.Name = "DetailData1";
         this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 96F);
         this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailData3_Odd
         // 
         this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
         this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
         this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DetailData3_Odd.BorderWidth = 1F;
         this.DetailData3_Odd.Font = new System.Drawing.Font("Segoe UI", 8.25F);
         this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
         this.DetailData3_Odd.Name = "DetailData3_Odd";
         this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 96F);
         this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.PageInfo.Name = "PageInfo";
         this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         // 
         // TopMargin
         // 
         this.TopMargin.Dpi = 96F;
         this.TopMargin.HeightF = 96F;
         this.TopMargin.Name = "TopMargin";
         // 
         // BottomMargin
         // 
         this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDate,
            this.pageInfo2});
         this.BottomMargin.Dpi = 96F;
         this.BottomMargin.HeightF = 206.1999F;
         this.BottomMargin.Name = "BottomMargin";
         // 
         // lblDate
         // 
         this.lblDate.Dpi = 96F;
         this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblDate.LocationFloat = new DevExpress.Utils.PointFloat(5.76001F, 5.76001F);
         this.lblDate.Multiline = true;
         this.lblDate.Name = "lblDate";
         this.lblDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.lblDate.SizeF = new System.Drawing.SizeF(299F, 22.08F);
         this.lblDate.StylePriority.UseFont = false;
         this.lblDate.StylePriority.UseForeColor = false;
         this.lblDate.Text = "lblDate";
         // 
         // pageInfo2
         // 
         this.pageInfo2.Dpi = 96F;
         this.pageInfo2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(317.76F, 5.76F);
         this.pageInfo2.Name = "pageInfo2";
         this.pageInfo2.SizeF = new System.Drawing.SizeF(300.48F, 22.08F);
         this.pageInfo2.StyleName = "PageInfo";
         this.pageInfo2.StylePriority.UseFont = false;
         this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.pageInfo2.TextFormatString = "Trang {0} trong tổng số {1}";
         // 
         // ReportHeader
         // 
         this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblChiNhanh,
            this.label1});
         this.ReportHeader.Dpi = 96F;
         this.ReportHeader.HeightF = 88.60001F;
         this.ReportHeader.Name = "ReportHeader";
         // 
         // lblChiNhanh
         // 
         this.lblChiNhanh.Dpi = 96F;
         this.lblChiNhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblChiNhanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblChiNhanh.LocationFloat = new DevExpress.Utils.PointFloat(426.24F, 59.52002F);
         this.lblChiNhanh.Multiline = true;
         this.lblChiNhanh.Name = "lblChiNhanh";
         this.lblChiNhanh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
         this.lblChiNhanh.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
         this.lblChiNhanh.SizeF = new System.Drawing.SizeF(192F, 22.08F);
         this.lblChiNhanh.StylePriority.UseFont = false;
         this.lblChiNhanh.StylePriority.UseForeColor = false;
         this.lblChiNhanh.Text = "lblChiNhanh";
         // 
         // label1
         // 
         this.label1.Dpi = 96F;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.LocationFloat = new DevExpress.Utils.PointFloat(5.76001F, 5.76001F);
         this.label1.Name = "label1";
         this.label1.SizeF = new System.Drawing.SizeF(612.48F, 43.23999F);
         this.label1.StyleName = "Title";
         this.label1.StylePriority.UseFont = false;
         this.label1.StylePriority.UseTextAlignment = false;
         this.label1.Text = "DANH SÁCH NHÂN VIÊN";
         this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
         this.GroupHeader1.Dpi = 96F;
         this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader1.HeightF = 26.88F;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // table1
         // 
         this.table1.Dpi = 96F;
         this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table1.Name = "table1";
         this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
         this.table1.SizeF = new System.Drawing.SizeF(624F, 26.88F);
         // 
         // tableRow1
         // 
         this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5});
         this.tableRow1.Dpi = 96F;
         this.tableRow1.Name = "tableRow1";
         this.tableRow1.Weight = 1D;
         // 
         // tableCell1
         // 
         this.tableCell1.BorderColor = System.Drawing.Color.Transparent;
         this.tableCell1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.tableCell1.Dpi = 96F;
         this.tableCell1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell1.Name = "tableCell1";
         this.tableCell1.StyleName = "DetailCaption1";
         this.tableCell1.StylePriority.UseBorderColor = false;
         this.tableCell1.StylePriority.UseBorders = false;
         this.tableCell1.StylePriority.UseFont = false;
         this.tableCell1.StylePriority.UseTextAlignment = false;
         this.tableCell1.Text = "Mã NV";
         this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.tableCell1.Weight = 0.1348145726822774D;
         // 
         // tableCell2
         // 
         this.tableCell2.BorderColor = System.Drawing.Color.Transparent;
         this.tableCell2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.tableCell2.Dpi = 96F;
         this.tableCell2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell2.Name = "tableCell2";
         this.tableCell2.StyleName = "DetailCaption1";
         this.tableCell2.StylePriority.UseBorderColor = false;
         this.tableCell2.StylePriority.UseBorders = false;
         this.tableCell2.StylePriority.UseFont = false;
         this.tableCell2.StylePriority.UseTextAlignment = false;
         this.tableCell2.Text = "Họ tên";
         this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.tableCell2.Weight = 0.20443572900234697D;
         // 
         // tableCell3
         // 
         this.tableCell3.BorderColor = System.Drawing.Color.Transparent;
         this.tableCell3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.tableCell3.Dpi = 96F;
         this.tableCell3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell3.Name = "tableCell3";
         this.tableCell3.StyleName = "DetailCaption1";
         this.tableCell3.StylePriority.UseBorderColor = false;
         this.tableCell3.StylePriority.UseBorders = false;
         this.tableCell3.StylePriority.UseFont = false;
         this.tableCell3.StylePriority.UseTextAlignment = false;
         this.tableCell3.Text = "Địa chỉ";
         this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.tableCell3.Weight = 0.2868625302286455D;
         // 
         // tableCell4
         // 
         this.tableCell4.BorderColor = System.Drawing.Color.Transparent;
         this.tableCell4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.tableCell4.Dpi = 96F;
         this.tableCell4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell4.Name = "tableCell4";
         this.tableCell4.StyleName = "DetailCaption1";
         this.tableCell4.StylePriority.UseBorderColor = false;
         this.tableCell4.StylePriority.UseBorders = false;
         this.tableCell4.StylePriority.UseFont = false;
         this.tableCell4.StylePriority.UseTextAlignment = false;
         this.tableCell4.Text = "Ngày sinh";
         this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.tableCell4.Weight = 0.18365373208913402D;
         // 
         // tableCell5
         // 
         this.tableCell5.BorderColor = System.Drawing.Color.Transparent;
         this.tableCell5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
         this.tableCell5.Dpi = 96F;
         this.tableCell5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell5.Name = "tableCell5";
         this.tableCell5.StyleName = "DetailCaption1";
         this.tableCell5.StylePriority.UseBorderColor = false;
         this.tableCell5.StylePriority.UseBorders = false;
         this.tableCell5.StylePriority.UseFont = false;
         this.tableCell5.StylePriority.UseTextAlignment = false;
         this.tableCell5.Text = "Lương";
         this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell5.Weight = 0.19023338904747597D;
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
         this.Detail.Dpi = 96F;
         this.Detail.HeightF = 24F;
         this.Detail.HierarchyPrintOptions.Indent = 20F;
         this.Detail.Name = "Detail";
         // 
         // table2
         // 
         this.table2.Dpi = 96F;
         this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table2.Name = "table2";
         this.table2.OddStyleName = "DetailData3_Odd";
         this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
         this.table2.SizeF = new System.Drawing.SizeF(624F, 24F);
         // 
         // tableRow2
         // 
         this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6,
            this.tableCell7,
            this.tableCell8,
            this.tableCell9,
            this.tcLuong});
         this.tableRow2.Dpi = 96F;
         this.tableRow2.Name = "tableRow2";
         this.tableRow2.Weight = 11.5D;
         // 
         // tableCell6
         // 
         this.tableCell6.BorderColor = System.Drawing.Color.LightGray;
         this.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell6.BorderWidth = 1F;
         this.tableCell6.Dpi = 96F;
         this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Mã NV]")});
         this.tableCell6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell6.Name = "tableCell6";
         this.tableCell6.StyleName = "DetailData1";
         this.tableCell6.StylePriority.UseBorderColor = false;
         this.tableCell6.StylePriority.UseBorders = false;
         this.tableCell6.StylePriority.UseBorderWidth = false;
         this.tableCell6.StylePriority.UseFont = false;
         this.tableCell6.StylePriority.UseTextAlignment = false;
         this.tableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.tableCell6.Weight = 0.13481459124789008D;
         // 
         // tableCell7
         // 
         this.tableCell7.BorderColor = System.Drawing.Color.LightGray;
         this.tableCell7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell7.BorderWidth = 1F;
         this.tableCell7.Dpi = 96F;
         this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Họ tên]")});
         this.tableCell7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell7.Name = "tableCell7";
         this.tableCell7.StyleName = "DetailData1";
         this.tableCell7.StylePriority.UseBorderColor = false;
         this.tableCell7.StylePriority.UseBorders = false;
         this.tableCell7.StylePriority.UseBorderWidth = false;
         this.tableCell7.StylePriority.UseFont = false;
         this.tableCell7.Weight = 0.20443585346906545D;
         // 
         // tableCell8
         // 
         this.tableCell8.BorderColor = System.Drawing.Color.LightGray;
         this.tableCell8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell8.BorderWidth = 1F;
         this.tableCell8.Dpi = 96F;
         this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Địa chỉ]")});
         this.tableCell8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell8.Name = "tableCell8";
         this.tableCell8.StyleName = "DetailData1";
         this.tableCell8.StylePriority.UseBorderColor = false;
         this.tableCell8.StylePriority.UseBorders = false;
         this.tableCell8.StylePriority.UseBorderWidth = false;
         this.tableCell8.StylePriority.UseFont = false;
         this.tableCell8.Weight = 0.28686250028291249D;
         // 
         // tableCell9
         // 
         this.tableCell9.BorderColor = System.Drawing.Color.LightGray;
         this.tableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell9.BorderWidth = 1F;
         this.tableCell9.Dpi = 96F;
         this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ngày sinh]")});
         this.tableCell9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell9.Name = "tableCell9";
         this.tableCell9.StyleName = "DetailData1";
         this.tableCell9.StylePriority.UseBorderColor = false;
         this.tableCell9.StylePriority.UseBorders = false;
         this.tableCell9.StylePriority.UseBorderWidth = false;
         this.tableCell9.StylePriority.UseFont = false;
         this.tableCell9.StylePriority.UseTextAlignment = false;
         this.tableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.tableCell9.TextFormatString = "{0:dd/MM/yyyy}";
         this.tableCell9.Weight = 0.1836536776901859D;
         // 
         // tcLuong
         // 
         this.tcLuong.BorderColor = System.Drawing.Color.LightGray;
         this.tcLuong.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tcLuong.BorderWidth = 1F;
         this.tcLuong.Dpi = 96F;
         this.tcLuong.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Lương]")});
         this.tcLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tcLuong.Name = "tcLuong";
         this.tcLuong.StyleName = "DetailData1";
         this.tcLuong.StylePriority.UseBorderColor = false;
         this.tcLuong.StylePriority.UseBorders = false;
         this.tcLuong.StylePriority.UseBorderWidth = false;
         this.tcLuong.StylePriority.UseFont = false;
         this.tcLuong.StylePriority.UseTextAlignment = false;
         this.tcLuong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tcLuong.TextFormatString = "{0:#,# đ}";
         this.tcLuong.Weight = 0.19023343599759615D;
         // 
         // taReportDSNV
         // 
         this.taReportDSNV.ClearBeforeFill = true;
         // 
         // dataSetReport
         // 
         this.dataSetReport.DataSetName = "DataSetReport";
         this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // Xrpt_DanhSachNhanVien
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
         this.BorderWidth = 0.5F;
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.dataSetReport});
         this.DataAdapter = this.taReportDSNV;
         this.DataMember = "Report_DSNV";
         this.DataSource = this.dataSetReport;
         this.Dpi = 96F;
         this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
         this.Margins = new System.Drawing.Printing.Margins(96, 96, 96, 206);
         this.PageHeight = 1056;
         this.PageWidth = 816;
         this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
         this.SnapGridSize = 12.5F;
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailData3_Odd,
            this.PageInfo});
         this.Version = "19.1";
         ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
      private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
      private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
      private DevExpress.XtraReports.UI.XRLabel label1;
      private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
      private DevExpress.XtraReports.UI.XRTable table1;
      private DevExpress.XtraReports.UI.XRTableRow tableRow1;
      private DevExpress.XtraReports.UI.XRTableCell tableCell1;
      private DevExpress.XtraReports.UI.XRTableCell tableCell2;
      private DevExpress.XtraReports.UI.XRTableCell tableCell3;
      private DevExpress.XtraReports.UI.XRTableCell tableCell4;
      private DevExpress.XtraReports.UI.XRTableCell tableCell5;
      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.XRTable table2;
      private DevExpress.XtraReports.UI.XRTableRow tableRow2;
      private DevExpress.XtraReports.UI.XRTableCell tableCell6;
      private DevExpress.XtraReports.UI.XRTableCell tableCell7;
      private DevExpress.XtraReports.UI.XRTableCell tableCell8;
      private DevExpress.XtraReports.UI.XRTableCell tableCell9;
      private DevExpress.XtraReports.UI.XRTableCell tcLuong;
      private DataSetReportTableAdapters.Report_DSNVTableAdapter taReportDSNV;
      private DataSetReport dataSetReport;
      private DevExpress.XtraReports.UI.XRLabel lblChiNhanh;
      private DevExpress.XtraReports.UI.XRLabel lblDate;
      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
   }
}
