namespace QLVT_DATHANG.Report
{
   partial class Xrpt_DanhSachDDHChuaCoPhieuNhap
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_DanhSachDDHChuaCoPhieuNhap));
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
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
         this.label1 = new DevExpress.XtraReports.UI.XRLabel();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.table1 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.table2 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.table3 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
         this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.label2 = new DevExpress.XtraReports.UI.XRLabel();
         this.dataSetReport = new QLVT_DATHANG.DataSetReport();
         this.taReportDSDDHChuaCoPN = new QLVT_DATHANG.DataSetReportTableAdapters.Report_DanhSachDDHChuaCoPhieuNhapTableAdapter();
         this.Sumary = new DevExpress.XtraReports.UI.CalculatedField();
         ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
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
         storedProcQuery1.Name = "sp_rep_DSDDHChuaCoPhieuNhap";
         storedProcQuery1.StoredProcName = "sp_rep_DSDDHChuaCoPhieuNhap";
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
         // GroupCaption1
         // 
         this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
         this.GroupCaption1.BorderColor = System.Drawing.Color.White;
         this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.GroupCaption1.BorderWidth = 2F;
         this.GroupCaption1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
         this.GroupCaption1.Name = "GroupCaption1";
         this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
         this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // GroupData1
         // 
         this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
         this.GroupData1.BorderColor = System.Drawing.Color.White;
         this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.GroupData1.BorderWidth = 2F;
         this.GroupData1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.GroupData1.ForeColor = System.Drawing.Color.White;
         this.GroupData1.Name = "GroupData1";
         this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
         this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailCaption1
         // 
         this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
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
         // GroupFooterBackground3
         // 
         this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
         this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
         this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.GroupFooterBackground3.BorderWidth = 2F;
         this.GroupFooterBackground3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
         this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
         this.GroupFooterBackground3.Name = "GroupFooterBackground3";
         this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
         this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
            this.label1});
         this.ReportHeader.HeightF = 189.1666F;
         this.ReportHeader.Name = "ReportHeader";
         // 
         // lblCN
         // 
         this.lblCN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblCN.LocationFloat = new DevExpress.Utils.PointFloat(331F, 118.5833F);
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
         this.xrLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(331F, 156.1667F);
         this.xrLabel4.Multiline = true;
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(166.7736F, 23F);
         this.xrLabel4.StylePriority.UseForeColor = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "Nhân viên lập phiếu:";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // lblNhanVienLap
         // 
         this.lblNhanVienLap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNhanVienLap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.lblNhanVienLap.LocationFloat = new DevExpress.Utils.PointFloat(497.7736F, 156.1667F);
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
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 6.00001F);
         this.label1.Name = "label1";
         this.label1.SizeF = new System.Drawing.SizeF(638F, 96.08333F);
         this.label1.StyleName = "Title";
         this.label1.StylePriority.UseFont = false;
         this.label1.StylePriority.UseTextAlignment = false;
         this.label1.Text = "DANH SÁCH ĐƠN ĐẶT HÀNG CHƯA CÓ PHIẾU NHẬP";
         this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
         this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("Mã số DDH", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader1.HeightF = 27F;
         this.GroupHeader1.Level = 1;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // table1
         // 
         this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2F);
         this.table1.Name = "table1";
         this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1});
         this.table1.SizeF = new System.Drawing.SizeF(650F, 25F);
         // 
         // tableRow1
         // 
         this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1,
            this.tableCell2});
         this.tableRow1.Name = "tableRow1";
         this.tableRow1.Weight = 1D;
         // 
         // tableCell1
         // 
         this.tableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
         this.tableCell1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell1.Name = "tableCell1";
         this.tableCell1.StyleName = "GroupCaption1";
         this.tableCell1.StylePriority.UseBackColor = false;
         this.tableCell1.StylePriority.UseFont = false;
         this.tableCell1.StylePriority.UseTextAlignment = false;
         this.tableCell1.Text = "Mã số DDH";
         this.tableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         this.tableCell1.Weight = 0.1694732991711391D;
         // 
         // tableCell2
         // 
         this.tableCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
         this.tableCell2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Mã số DDH]")});
         this.tableCell2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell2.Name = "tableCell2";
         this.tableCell2.StyleName = "GroupData1";
         this.tableCell2.StylePriority.UseBackColor = false;
         this.tableCell2.StylePriority.UseFont = false;
         this.tableCell2.Weight = 0.83052665387874081D;
         // 
         // GroupHeader2
         // 
         this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
         this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader2.HeightF = 28F;
         this.GroupHeader2.Level = 2;
         this.GroupHeader2.Name = "GroupHeader2";
         // 
         // table2
         // 
         this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table2.Name = "table2";
         this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
         this.table2.SizeF = new System.Drawing.SizeF(650F, 28F);
         // 
         // tableRow2
         // 
         this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8});
         this.tableRow2.Name = "tableRow2";
         this.tableRow2.Weight = 1D;
         // 
         // tableCell3
         // 
         this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.tableCell3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell3.Name = "tableCell3";
         this.tableCell3.StyleName = "DetailCaption1";
         this.tableCell3.StylePriority.UseBorders = false;
         this.tableCell3.StylePriority.UseFont = false;
         this.tableCell3.Text = "Ngày đặt";
         this.tableCell3.Weight = 0.16947328875991227D;
         // 
         // tableCell4
         // 
         this.tableCell4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell4.Name = "tableCell4";
         this.tableCell4.StyleName = "DetailCaption1";
         this.tableCell4.StylePriority.UseFont = false;
         this.tableCell4.Text = "Nhà cung cấp";
         this.tableCell4.Weight = 0.18753189218585095D;
         // 
         // tableCell5
         // 
         this.tableCell5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell5.Name = "tableCell5";
         this.tableCell5.StyleName = "DetailCaption1";
         this.tableCell5.StylePriority.UseFont = false;
         this.tableCell5.Text = "NV đặt hàng";
         this.tableCell5.Weight = 0.190465815617488D;
         // 
         // tableCell6
         // 
         this.tableCell6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell6.Name = "tableCell6";
         this.tableCell6.StyleName = "DetailCaption1";
         this.tableCell6.StylePriority.UseFont = false;
         this.tableCell6.Text = "Tên vật tư";
         this.tableCell6.Weight = 0.16356337327223558D;
         // 
         // tableCell7
         // 
         this.tableCell7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell7.Name = "tableCell7";
         this.tableCell7.StyleName = "DetailCaption1";
         this.tableCell7.StylePriority.UseFont = false;
         this.tableCell7.StylePriority.UseTextAlignment = false;
         this.tableCell7.Text = "Số lượng";
         this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell7.Weight = 0.13020182823994095D;
         // 
         // tableCell8
         // 
         this.tableCell8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell8.Name = "tableCell8";
         this.tableCell8.StyleName = "DetailCaption1";
         this.tableCell8.StylePriority.UseFont = false;
         this.tableCell8.StylePriority.UseTextAlignment = false;
         this.tableCell8.Text = "Đơn giá";
         this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell8.Weight = 0.15876374323692205D;
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
         this.Detail.HeightF = 25F;
         this.Detail.Name = "Detail";
         // 
         // table3
         // 
         this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.table3.Name = "table3";
         this.table3.OddStyleName = "DetailData3_Odd";
         this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
         this.table3.SizeF = new System.Drawing.SizeF(650F, 25F);
         // 
         // tableRow3
         // 
         this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14});
         this.tableRow3.Name = "tableRow3";
         this.tableRow3.Weight = 11.5D;
         // 
         // tableCell9
         // 
         this.tableCell9.BorderColor = System.Drawing.Color.Silver;
         this.tableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell9.BorderWidth = 1F;
         this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Ngày đặt]")});
         this.tableCell9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell9.Name = "tableCell9";
         this.tableCell9.StyleName = "DetailData1";
         this.tableCell9.StylePriority.UseBorderColor = false;
         this.tableCell9.StylePriority.UseBorders = false;
         this.tableCell9.StylePriority.UseBorderWidth = false;
         this.tableCell9.StylePriority.UseFont = false;
         this.tableCell9.TextFormatString = "{0:dd/MM/yyyy}";
         this.tableCell9.Weight = 0.16947330260417887D;
         // 
         // tableCell10
         // 
         this.tableCell10.BorderColor = System.Drawing.Color.Silver;
         this.tableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell10.BorderWidth = 1F;
         this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Nhà cung cấp]")});
         this.tableCell10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell10.Name = "tableCell10";
         this.tableCell10.StyleName = "DetailData1";
         this.tableCell10.StylePriority.UseBorderColor = false;
         this.tableCell10.StylePriority.UseBorders = false;
         this.tableCell10.StylePriority.UseBorderWidth = false;
         this.tableCell10.StylePriority.UseFont = false;
         this.tableCell10.Weight = 0.18753191355417451D;
         // 
         // tableCell11
         // 
         this.tableCell11.BorderColor = System.Drawing.Color.Silver;
         this.tableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell11.BorderWidth = 1F;
         this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NV đặt hàng]")});
         this.tableCell11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell11.Name = "tableCell11";
         this.tableCell11.StyleName = "DetailData1";
         this.tableCell11.StylePriority.UseBorderColor = false;
         this.tableCell11.StylePriority.UseBorders = false;
         this.tableCell11.StylePriority.UseBorderWidth = false;
         this.tableCell11.StylePriority.UseFont = false;
         this.tableCell11.Weight = 0.19046582735501802D;
         // 
         // tableCell12
         // 
         this.tableCell12.BorderColor = System.Drawing.Color.Silver;
         this.tableCell12.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell12.BorderWidth = 1F;
         this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tên vật tư]")});
         this.tableCell12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell12.Name = "tableCell12";
         this.tableCell12.StyleName = "DetailData1";
         this.tableCell12.StylePriority.UseBorderColor = false;
         this.tableCell12.StylePriority.UseBorders = false;
         this.tableCell12.StylePriority.UseBorderWidth = false;
         this.tableCell12.StylePriority.UseFont = false;
         this.tableCell12.Weight = 0.16356338500976564D;
         // 
         // tableCell13
         // 
         this.tableCell13.BorderColor = System.Drawing.Color.Silver;
         this.tableCell13.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell13.BorderWidth = 1F;
         this.tableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Số lượng]")});
         this.tableCell13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell13.Name = "tableCell13";
         this.tableCell13.StyleName = "DetailData1";
         this.tableCell13.StylePriority.UseBorderColor = false;
         this.tableCell13.StylePriority.UseBorders = false;
         this.tableCell13.StylePriority.UseBorderWidth = false;
         this.tableCell13.StylePriority.UseFont = false;
         this.tableCell13.StylePriority.UseTextAlignment = false;
         this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell13.Weight = 0.13020183772024815D;
         // 
         // tableCell14
         // 
         this.tableCell14.BorderColor = System.Drawing.Color.Silver;
         this.tableCell14.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
         this.tableCell14.BorderWidth = 1F;
         this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Đơn giá]")});
         this.tableCell14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.tableCell14.Name = "tableCell14";
         this.tableCell14.StyleName = "DetailData1";
         this.tableCell14.StylePriority.UseBorderColor = false;
         this.tableCell14.StylePriority.UseBorders = false;
         this.tableCell14.StylePriority.UseBorderWidth = false;
         this.tableCell14.StylePriority.UseFont = false;
         this.tableCell14.StylePriority.UseTextAlignment = false;
         this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell14.TextFormatString = "{0:#,# đ}";
         this.tableCell14.Weight = 0.15876376896920497D;
         // 
         // GroupFooter1
         // 
         this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1,
            this.label2});
         this.GroupFooter1.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
         this.GroupFooter1.HeightF = 25.08002F;
         this.GroupFooter1.Name = "GroupFooter1";
         // 
         // xrLabel2
         // 
         this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(434.232F, 2.080027F);
         this.xrLabel2.Multiline = true;
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(83.40482F, 23F);
         this.xrLabel2.StylePriority.UseBorders = false;
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseForeColor = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.Text = "Thành tiền:";
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrLabel2.TextFormatString = "{0:}";
         // 
         // xrLabel1
         // 
         this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([Sumary])")});
         this.xrLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(517.6368F, 2.080027F);
         this.xrLabel1.Multiline = true;
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(132.3632F, 23F);
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UsePadding = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel1.Summary = xrSummary1;
         this.xrLabel1.Text = "xrLabel1";
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.xrLabel1.TextFormatString = "{0:#,# đ}";
         // 
         // label2
         // 
         this.label2.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.label2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.label2.Name = "label2";
         this.label2.SizeF = new System.Drawing.SizeF(650F, 2.08F);
         this.label2.StyleName = "GroupFooterBackground3";
         this.label2.StylePriority.UseBorders = false;
         // 
         // dataSetReport
         // 
         this.dataSetReport.DataSetName = "DataSetReport";
         this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // taReportDSDDHChuaCoPN
         // 
         this.taReportDSDDHChuaCoPN.ClearBeforeFill = true;
         // 
         // Sumary
         // 
         this.Sumary.DataMember = "Report_DanhSachDDHChuaCoPhieuNhap";
         this.Sumary.Expression = "[][[Mã số DDH]=[^.Mã số DDH]].Sum([Đơn giá] * [Số lượng])";
         this.Sumary.Name = "Sumary";
         // 
         // Xrpt_DanhSachDDHChuaCoPhieuNhap
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.GroupHeader2,
            this.Detail,
            this.GroupFooter1});
         this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.Sumary});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1,
            this.dataSetReport});
         this.DataAdapter = this.taReportDSDDHChuaCoPN;
         this.DataMember = "Report_DanhSachDDHChuaCoPhieuNhap";
         this.DataSource = this.dataSetReport;
         this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.PageInfo});
         this.Version = "19.1";
         ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
      private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
      private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
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
      private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
      private DevExpress.XtraReports.UI.XRTable table2;
      private DevExpress.XtraReports.UI.XRTableRow tableRow2;
      private DevExpress.XtraReports.UI.XRTableCell tableCell3;
      private DevExpress.XtraReports.UI.XRTableCell tableCell4;
      private DevExpress.XtraReports.UI.XRTableCell tableCell5;
      private DevExpress.XtraReports.UI.XRTableCell tableCell6;
      private DevExpress.XtraReports.UI.XRTableCell tableCell7;
      private DevExpress.XtraReports.UI.XRTableCell tableCell8;
      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.XRTable table3;
      private DevExpress.XtraReports.UI.XRTableRow tableRow3;
      private DevExpress.XtraReports.UI.XRTableCell tableCell9;
      private DevExpress.XtraReports.UI.XRTableCell tableCell10;
      private DevExpress.XtraReports.UI.XRTableCell tableCell11;
      private DevExpress.XtraReports.UI.XRTableCell tableCell12;
      private DevExpress.XtraReports.UI.XRTableCell tableCell13;
      private DevExpress.XtraReports.UI.XRTableCell tableCell14;
      private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
      private DevExpress.XtraReports.UI.XRLabel label2;
      private DataSetReport dataSetReport;
      private DataSetReportTableAdapters.Report_DanhSachDDHChuaCoPhieuNhapTableAdapter taReportDSDDHChuaCoPN;
      private DevExpress.XtraReports.UI.XRLabel lblDate;
      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel1;
      private DevExpress.XtraReports.UI.CalculatedField Sumary;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.UI.XRLabel lblCN;
      private DevExpress.XtraReports.UI.XRLabel xrLabel4;
      private DevExpress.XtraReports.UI.XRLabel lblNhanVienLap;
   }
}
