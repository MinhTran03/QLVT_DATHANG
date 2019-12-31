namespace QLVT_DATHANG.Report
{
   partial class Xrpt_TongHopNhapXuat
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
         DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_TongHopNhapXuat));
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
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
         this.lblCN = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.lblNhanVienLap = new DevExpress.XtraReports.UI.XRLabel();
         this.lblFromTo = new DevExpress.XtraReports.UI.XRLabel();
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
         this.tbcTongNhap = new DevExpress.XtraReports.UI.XRTableCell();
         this.tbcTyLeNhap = new DevExpress.XtraReports.UI.XRTableCell();
         this.tbcTongXuat = new DevExpress.XtraReports.UI.XRTableCell();
         this.tbcTyLeXuat = new DevExpress.XtraReports.UI.XRTableCell();
         this.dataSetReport = new QLVT_DATHANG.DataSetReport();
         this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.lblSumTLX = new DevExpress.XtraReports.UI.XRLabel();
         this.lblSumTX = new DevExpress.XtraReports.UI.XRLabel();
         this.lblSumTLN = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.lblSumTN = new DevExpress.XtraReports.UI.XRLabel();
         this.taTongHopNhapXuat = new QLVT_DATHANG.DataSetReportTableAdapters.Report_TongHopNhapXuatTableAdapter();
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
         storedProcQuery1.Name = "Report_TongHopNhapXuat";
         queryParameter1.Name = "@from";
         queryParameter1.Type = typeof(System.DateTime);
         queryParameter1.ValueInfo = "2017-09-15";
         queryParameter2.Name = "@to";
         queryParameter2.Type = typeof(System.DateTime);
         queryParameter2.ValueInfo = "2017-09-17";
         storedProcQuery1.Parameters.Add(queryParameter1);
         storedProcQuery1.Parameters.Add(queryParameter2);
         storedProcQuery1.StoredProcName = "Report_TongHopNhapXuat";
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
         this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.DetailCaption1.BorderColor = System.Drawing.Color.White;
         this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
         this.DetailCaption1.BorderWidth = 2F;
         this.DetailCaption1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.DetailCaption1.ForeColor = System.Drawing.Color.White;
         this.DetailCaption1.Name = "DetailCaption1";
         this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
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
         this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
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
         this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.PageInfo.Name = "PageInfo";
         this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // TopMargin
         // 
         this.TopMargin.Name = "TopMargin";
         // 
         // BottomMargin
         // 
         this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblDate,
            this.pageInfo2});
         this.BottomMargin.HeightF = 183.875F;
         this.BottomMargin.Name = "BottomMargin";
         // 
         // lblDate
         // 
         this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblDate.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 6.00001F);
         this.lblDate.Multiline = true;
         this.lblDate.Name = "lblDate";
         this.lblDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.lblDate.SizeF = new System.Drawing.SizeF(311.4583F, 23F);
         this.lblDate.StylePriority.UseFont = false;
         this.lblDate.StylePriority.UseForeColor = false;
         this.lblDate.Text = "lblDate";
         // 
         // pageInfo2
         // 
         this.pageInfo2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
         this.pageInfo2.Name = "pageInfo2";
         this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.pageInfo2.StyleName = "PageInfo";
         this.pageInfo2.StylePriority.UseFont = false;
         this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.pageInfo2.TextFormatString = "Trang {0} trong tổng số {1}";
         // 
         // ReportHeader
         // 
         this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCN,
            this.xrLabel4,
            this.lblNhanVienLap,
            this.lblFromTo,
            this.label1});
         this.ReportHeader.HeightF = 167.2917F;
         this.ReportHeader.Name = "ReportHeader";
         // 
         // lblCN
         // 
         this.lblCN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblCN.LocationFloat = new DevExpress.Utils.PointFloat(331F, 98.37497F);
         this.lblCN.Multiline = true;
         this.lblCN.Name = "lblCN";
         this.lblCN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.lblCN.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.lblCN.StylePriority.UseFont = false;
         this.lblCN.StylePriority.UseForeColor = false;
         this.lblCN.StylePriority.UseTextAlignment = false;
         this.lblCN.Text = "lblCN";
         this.lblCN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel4
         // 
         this.xrLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(331F, 134.2917F);
         this.xrLabel4.Multiline = true;
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(166.7736F, 23F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "Nhân viên lập phiếu:";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // lblNhanVienLap
         // 
         this.lblNhanVienLap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNhanVienLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblNhanVienLap.LocationFloat = new DevExpress.Utils.PointFloat(503.7736F, 134.2917F);
         this.lblNhanVienLap.Multiline = true;
         this.lblNhanVienLap.Name = "lblNhanVienLap";
         this.lblNhanVienLap.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.lblNhanVienLap.SizeF = new System.Drawing.SizeF(146.2264F, 23F);
         this.lblNhanVienLap.StylePriority.UseFont = false;
         this.lblNhanVienLap.StylePriority.UseForeColor = false;
         this.lblNhanVienLap.StylePriority.UseTextAlignment = false;
         this.lblNhanVienLap.Text = "lblNhanVienLap";
         this.lblNhanVienLap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // lblFromTo
         // 
         this.lblFromTo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblFromTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblFromTo.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 50F);
         this.lblFromTo.Multiline = true;
         this.lblFromTo.Name = "lblFromTo";
         this.lblFromTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.lblFromTo.SizeF = new System.Drawing.SizeF(638F, 36.45834F);
         this.lblFromTo.StylePriority.UseFont = false;
         this.lblFromTo.StylePriority.UseForeColor = false;
         this.lblFromTo.StylePriority.UseTextAlignment = false;
         this.lblFromTo.Text = "TỪ {0} ĐẾN {1}";
         this.lblFromTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 6.00001F);
         this.label1.Name = "label1";
         this.label1.SizeF = new System.Drawing.SizeF(638F, 43.99999F);
         this.label1.StyleName = "Title";
         this.label1.StylePriority.UseFont = false;
         this.label1.StylePriority.UseTextAlignment = false;
         this.label1.Text = "BẢNG TỔNG HỢP NHẬP XUẤT";
         this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
         this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader1.HeightF = 28F;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // table1
         // 
         this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table1.Name = "table1";
         this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
         this.table1.SizeF = new System.Drawing.SizeF(650F, 28F);
         // 
         // tableRow1
         // 
         this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2,
            this.tableCell3,
            this.tableCell4,
            this.tableCell5});
         this.tableRow1.Name = "tableRow1";
         this.tableRow1.Weight = 1D;
         // 
         // tableCell1
         // 
         this.tableCell1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.tableCell1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell1.Name = "tableCell1";
         this.tableCell1.StyleName = "DetailCaption1";
         this.tableCell1.StylePriority.UseBorderColor = false;
         this.tableCell1.StylePriority.UseBorders = false;
         this.tableCell1.StylePriority.UseFont = false;
         this.tableCell1.Text = "NGÀY";
         this.tableCell1.Weight = 0.17782141647865574D;
         // 
         // tableCell2
         // 
         this.tableCell2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.tableCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell2.Name = "tableCell2";
         this.tableCell2.StyleName = "DetailCaption1";
         this.tableCell2.StylePriority.UseBorderColor = false;
         this.tableCell2.StylePriority.UseFont = false;
         this.tableCell2.StylePriority.UseTextAlignment = false;
         this.tableCell2.Text = "TỔNG TIỀN NHẬP";
         this.tableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell2.Weight = 0.23633157715053826D;
         // 
         // tableCell3
         // 
         this.tableCell3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.tableCell3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell3.Name = "tableCell3";
         this.tableCell3.StyleName = "DetailCaption1";
         this.tableCell3.StylePriority.UseBorderColor = false;
         this.tableCell3.StylePriority.UseFont = false;
         this.tableCell3.StylePriority.UseTextAlignment = false;
         this.tableCell3.Text = "TỶ LỆ NHẬP";
         this.tableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.tableCell3.Weight = 0.18491327167264002D;
         // 
         // tableCell4
         // 
         this.tableCell4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.tableCell4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell4.Name = "tableCell4";
         this.tableCell4.StyleName = "DetailCaption1";
         this.tableCell4.StylePriority.UseBorderColor = false;
         this.tableCell4.StylePriority.UseFont = false;
         this.tableCell4.StylePriority.UseTextAlignment = false;
         this.tableCell4.Text = "TỔNG TIỀN XUẤT";
         this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell4.Weight = 0.22537468722114651D;
         // 
         // tableCell5
         // 
         this.tableCell5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(159)))), ((int)(((byte)(228)))));
         this.tableCell5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell5.Name = "tableCell5";
         this.tableCell5.StyleName = "DetailCaption1";
         this.tableCell5.StylePriority.UseBorderColor = false;
         this.tableCell5.StylePriority.UseFont = false;
         this.tableCell5.StylePriority.UseTextAlignment = false;
         this.tableCell5.Text = "TỶ LỆ XUẤT";
         this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.tableCell5.Weight = 0.17555898878936926D;
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
         this.Detail.HeightF = 25F;
         this.Detail.Name = "Detail";
         // 
         // table2
         // 
         this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table2.Name = "table2";
         this.table2.OddStyleName = "DetailData3_Odd";
         this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
         this.table2.SizeF = new System.Drawing.SizeF(650F, 25F);
         // 
         // tableRow2
         // 
         this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6,
            this.tbcTongNhap,
            this.tbcTyLeNhap,
            this.tbcTongXuat,
            this.tbcTyLeXuat});
         this.tableRow2.Name = "tableRow2";
         this.tableRow2.Weight = 11.5D;
         // 
         // tableCell6
         // 
         this.tableCell6.BorderColor = System.Drawing.Color.LightGray;
         this.tableCell6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell6.BorderWidth = 1F;
         this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGÀY]")});
         this.tableCell6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell6.Name = "tableCell6";
         this.tableCell6.StyleName = "DetailData1";
         this.tableCell6.StylePriority.UseBorderColor = false;
         this.tableCell6.StylePriority.UseBorders = false;
         this.tableCell6.StylePriority.UseBorderWidth = false;
         this.tableCell6.StylePriority.UseFont = false;
         this.tableCell6.TextFormatString = "{0:dd/MM/yyyy}";
         this.tableCell6.Weight = 0.17782140635879884D;
         // 
         // tbcTongNhap
         // 
         this.tbcTongNhap.BorderColor = System.Drawing.Color.LightGray;
         this.tbcTongNhap.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tbcTongNhap.BorderWidth = 1F;
         this.tbcTongNhap.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NHẬP]")});
         this.tbcTongNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbcTongNhap.Name = "tbcTongNhap";
         this.tbcTongNhap.StyleName = "DetailData1";
         this.tbcTongNhap.StylePriority.UseBorderColor = false;
         this.tbcTongNhap.StylePriority.UseBorders = false;
         this.tbcTongNhap.StylePriority.UseBorderWidth = false;
         this.tbcTongNhap.StylePriority.UseFont = false;
         this.tbcTongNhap.StylePriority.UseTextAlignment = false;
         this.tbcTongNhap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tbcTongNhap.TextFormatString = "{0:#,##0.0 đ}";
         this.tbcTongNhap.Weight = 0.2363314475110315D;
         // 
         // tbcTyLeNhap
         // 
         this.tbcTyLeNhap.BorderColor = System.Drawing.Color.LightGray;
         this.tbcTyLeNhap.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tbcTyLeNhap.BorderWidth = 1F;
         this.tbcTyLeNhap.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TỶ LỆ NHẬP]")});
         this.tbcTyLeNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbcTyLeNhap.Name = "tbcTyLeNhap";
         this.tbcTyLeNhap.StyleName = "DetailData1";
         this.tbcTyLeNhap.StylePriority.UseBorderColor = false;
         this.tbcTyLeNhap.StylePriority.UseBorders = false;
         this.tbcTyLeNhap.StylePriority.UseBorderWidth = false;
         this.tbcTyLeNhap.StylePriority.UseFont = false;
         this.tbcTyLeNhap.StylePriority.UseTextAlignment = false;
         this.tbcTyLeNhap.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.tbcTyLeNhap.TextFormatString = "{0:0.00%}";
         this.tbcTyLeNhap.Weight = 0.18491355326048556D;
         // 
         // tbcTongXuat
         // 
         this.tbcTongXuat.BorderColor = System.Drawing.Color.LightGray;
         this.tbcTongXuat.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tbcTongXuat.BorderWidth = 1F;
         this.tbcTongXuat.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[XUẤT]")});
         this.tbcTongXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbcTongXuat.Name = "tbcTongXuat";
         this.tbcTongXuat.StyleName = "DetailData1";
         this.tbcTongXuat.StylePriority.UseBorderColor = false;
         this.tbcTongXuat.StylePriority.UseBorders = false;
         this.tbcTongXuat.StylePriority.UseBorderWidth = false;
         this.tbcTongXuat.StylePriority.UseFont = false;
         this.tbcTongXuat.StylePriority.UseTextAlignment = false;
         this.tbcTongXuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tbcTongXuat.TextFormatString = "{0:#,##0.0 đ}";
         this.tbcTongXuat.Weight = 0.2253744752308332D;
         // 
         // tbcTyLeXuat
         // 
         this.tbcTyLeXuat.BorderColor = System.Drawing.Color.LightGray;
         this.tbcTyLeXuat.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tbcTyLeXuat.BorderWidth = 1F;
         this.tbcTyLeXuat.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TỶ LỆ XUẤT]")});
         this.tbcTyLeXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tbcTyLeXuat.Name = "tbcTyLeXuat";
         this.tbcTyLeXuat.StyleName = "DetailData1";
         this.tbcTyLeXuat.StylePriority.UseBorderColor = false;
         this.tbcTyLeXuat.StylePriority.UseBorders = false;
         this.tbcTyLeXuat.StylePriority.UseBorderWidth = false;
         this.tbcTyLeXuat.StylePriority.UseFont = false;
         this.tbcTyLeXuat.StylePriority.UseTextAlignment = false;
         this.tbcTyLeXuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.tbcTyLeXuat.TextFormatString = "{0:0.00%}";
         this.tbcTyLeXuat.Weight = 0.17555908242626081D;
         // 
         // dataSetReport
         // 
         this.dataSetReport.DataSetName = "DataSetReport";
         this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // GroupFooter1
         // 
         this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblSumTLX,
            this.lblSumTX,
            this.lblSumTLN,
            this.xrLabel2,
            this.lblSumTN});
         this.GroupFooter1.HeightF = 23F;
         this.GroupFooter1.Name = "GroupFooter1";
         // 
         // lblSumTLX
         // 
         this.lblSumTLX.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([TỶ LỆ XUẤT])")});
         this.lblSumTLX.ForeColor = System.Drawing.Color.DarkRed;
         this.lblSumTLX.LocationFloat = new DevExpress.Utils.PointFloat(535.8866F, 0F);
         this.lblSumTLX.Multiline = true;
         this.lblSumTLX.Name = "lblSumTLX";
         this.lblSumTLX.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.lblSumTLX.SizeF = new System.Drawing.SizeF(114.1134F, 23F);
         this.lblSumTLX.StylePriority.UseForeColor = false;
         this.lblSumTLX.StylePriority.UseTextAlignment = false;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.lblSumTLX.Summary = xrSummary1;
         this.lblSumTLX.Text = "lblSumTLX";
         this.lblSumTLX.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.lblSumTLX.TextFormatString = "{0:0.00%}";
         // 
         // lblSumTX
         // 
         this.lblSumTX.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([XUẤT])")});
         this.lblSumTX.ForeColor = System.Drawing.Color.DarkRed;
         this.lblSumTX.LocationFloat = new DevExpress.Utils.PointFloat(389.3931F, 0F);
         this.lblSumTX.Multiline = true;
         this.lblSumTX.Name = "lblSumTX";
         this.lblSumTX.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.lblSumTX.SizeF = new System.Drawing.SizeF(146.4936F, 23F);
         this.lblSumTX.StylePriority.UseForeColor = false;
         this.lblSumTX.StylePriority.UsePadding = false;
         this.lblSumTX.StylePriority.UseTextAlignment = false;
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.lblSumTX.Summary = xrSummary2;
         this.lblSumTX.Text = "lblSumTX";
         this.lblSumTX.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.lblSumTX.TextFormatString = "{0:#,##0.0 đ}";
         // 
         // lblSumTLN
         // 
         this.lblSumTLN.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumAvg([TỶ LỆ NHẬP])")});
         this.lblSumTLN.ForeColor = System.Drawing.Color.DarkRed;
         this.lblSumTLN.LocationFloat = new DevExpress.Utils.PointFloat(269.1995F, 0F);
         this.lblSumTLN.Multiline = true;
         this.lblSumTLN.Name = "lblSumTLN";
         this.lblSumTLN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.lblSumTLN.SizeF = new System.Drawing.SizeF(120.1938F, 23F);
         this.lblSumTLN.StylePriority.UseForeColor = false;
         this.lblSumTLN.StylePriority.UseTextAlignment = false;
         xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.lblSumTLN.Summary = xrSummary3;
         this.lblSumTLN.Text = "lblSumTLN";
         this.lblSumTLN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         this.lblSumTLN.TextFormatString = "{0:0.00%}";
         // 
         // xrLabel2
         // 
         this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel2.ForeColor = System.Drawing.Color.DarkRed;
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel2.Multiline = true;
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(115.5839F, 23F);
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseForeColor = false;
         this.xrLabel2.StylePriority.UsePadding = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.Text = "CỘNG";
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // lblSumTN
         // 
         this.lblSumTN.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([NHẬP])")});
         this.lblSumTN.ForeColor = System.Drawing.Color.DarkRed;
         this.lblSumTN.LocationFloat = new DevExpress.Utils.PointFloat(115.5839F, 0F);
         this.lblSumTN.Multiline = true;
         this.lblSumTN.Name = "lblSumTN";
         this.lblSumTN.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.lblSumTN.SizeF = new System.Drawing.SizeF(153.6154F, 23F);
         this.lblSumTN.StylePriority.UseForeColor = false;
         this.lblSumTN.StylePriority.UsePadding = false;
         this.lblSumTN.StylePriority.UseTextAlignment = false;
         xrSummary4.IgnoreNullValues = true;
         xrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.lblSumTN.Summary = xrSummary4;
         this.lblSumTN.Text = "lblSumTN";
         this.lblSumTN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.lblSumTN.TextFormatString = "{0:#,##0.0 đ}";
         // 
         // taTongHopNhapXuat
         // 
         this.taTongHopNhapXuat.ClearBeforeFill = true;
         // 
         // Xrpt_TongHopNhapXuat
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail,
            this.GroupFooter1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.dataSetReport});
         this.DataAdapter = this.taTongHopNhapXuat;
         this.DataMember = "Report_TongHopNhapXuat";
         this.DataSource = this.dataSetReport;
         this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
         this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 184);
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
      private DevExpress.XtraReports.UI.XRTableCell tbcTongNhap;
      private DevExpress.XtraReports.UI.XRTableCell tbcTyLeNhap;
      private DevExpress.XtraReports.UI.XRTableCell tbcTongXuat;
      private DevExpress.XtraReports.UI.XRTableCell tbcTyLeXuat;
      private DevExpress.XtraReports.UI.XRLabel lblFromTo;
      private DevExpress.XtraReports.UI.XRLabel lblDate;
      private DataSetReport dataSetReport;
      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
      private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
      private DevExpress.XtraReports.UI.XRLabel lblSumTN;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.UI.XRLabel lblSumTLX;
      private DevExpress.XtraReports.UI.XRLabel lblSumTX;
      private DevExpress.XtraReports.UI.XRLabel lblSumTLN;
      private DataSetReportTableAdapters.Report_TongHopNhapXuatTableAdapter taTongHopNhapXuat;
      private DevExpress.XtraReports.UI.XRLabel lblCN;
      private DevExpress.XtraReports.UI.XRLabel xrLabel4;
      private DevExpress.XtraReports.UI.XRLabel lblNhanVienLap;
   }
}
