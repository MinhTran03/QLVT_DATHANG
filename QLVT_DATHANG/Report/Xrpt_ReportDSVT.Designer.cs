namespace QLVT_DATHANG.Report
{
   partial class Xrpt_ReportDSVT
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
         DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xrpt_ReportDSVT));
         this.sqlDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.label1 = new DevExpress.XtraReports.UI.XRLabel();
         this.table1 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         this.table2 = new DevExpress.XtraReports.UI.XRTable();
         this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
         this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
         this.dataSetReport = new QLVT_DATHANG.DataSetReport();
         this.taReport_DSVT = new QLVT_DATHANG.DataSetReportTableAdapters.Report_DSVTTableAdapter();
         ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataSetReport)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource.ConnectionName = "QLVT_DATHANG.Properties.Settings.QLVT_DATHANGConnectionString";
         this.sqlDataSource.Name = "sqlDataSource1";
         storedProcQuery1.Name = "Report_DSVT";
         storedProcQuery1.StoredProcName = "Report_DSVT";
         this.sqlDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
         this.sqlDataSource.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
         this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
         this.Title.Name = "Title";
         // 
         // DetailCaption1
         // 
         this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(148)))), ((int)(((byte)(130)))));
         this.DetailCaption1.BorderColor = System.Drawing.Color.White;
         this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
         this.DetailCaption1.BorderWidth = 2F;
         this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
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
         this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
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
         this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
         this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
         this.DetailData3_Odd.Name = "DetailData3_Odd";
         this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
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
            this.pageInfo1,
            this.pageInfo2});
         this.BottomMargin.Name = "BottomMargin";
         // 
         // ReportHeader
         // 
         this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
         this.ReportHeader.HeightF = 60F;
         this.ReportHeader.Name = "ReportHeader";
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table1});
         this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.GroupHeader1.HeightF = 28F;
         this.GroupHeader1.Name = "GroupHeader1";
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
         this.Detail.HeightF = 25F;
         this.Detail.Name = "Detail";
         // 
         // pageInfo1
         // 
         this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.pageInfo1.Name = "pageInfo1";
         this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.pageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.pageInfo1.StyleName = "PageInfo";
         // 
         // pageInfo2
         // 
         this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
         this.pageInfo2.Name = "pageInfo2";
         this.pageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.pageInfo2.StyleName = "PageInfo";
         this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         this.pageInfo2.TextFormatString = "Page {0} of {1}";
         // 
         // label1
         // 
         this.label1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.label1.Name = "label1";
         this.label1.SizeF = new System.Drawing.SizeF(638F, 24.19433F);
         this.label1.StyleName = "Title";
         this.label1.Text = "DANH MỤC VẬT TƯ";
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
            this.tableCell4});
         this.tableRow1.Name = "tableRow1";
         this.tableRow1.Weight = 1D;
         // 
         // tableCell1
         // 
         this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.tableCell1.Name = "tableCell1";
         this.tableCell1.StyleName = "DetailCaption1";
         this.tableCell1.StylePriority.UseBorders = false;
         this.tableCell1.Text = "Mã VT";
         this.tableCell1.Weight = 0.1831986060509315D;
         // 
         // tableCell2
         // 
         this.tableCell2.Name = "tableCell2";
         this.tableCell2.StyleName = "DetailCaption1";
         this.tableCell2.Text = "Tên VT";
         this.tableCell2.Weight = 0.20025794396033653D;
         // 
         // tableCell3
         // 
         this.tableCell3.Name = "tableCell3";
         this.tableCell3.StyleName = "DetailCaption1";
         this.tableCell3.Text = "Đơn vị tính";
         this.tableCell3.Weight = 0.28508305476262019D;
         // 
         // tableCell4
         // 
         this.tableCell4.Name = "tableCell4";
         this.tableCell4.StyleName = "DetailCaption1";
         this.tableCell4.StylePriority.UseTextAlignment = false;
         this.tableCell4.Text = "Số lượng tồn";
         this.tableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell4.Weight = 0.33146040696364182D;
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
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8});
         this.tableRow2.Name = "tableRow2";
         this.tableRow2.Weight = 11.5D;
         // 
         // tableCell5
         // 
         this.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.tableCell5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Mã VT]")});
         this.tableCell5.Name = "tableCell5";
         this.tableCell5.StyleName = "DetailData1";
         this.tableCell5.StylePriority.UseBorders = false;
         this.tableCell5.Weight = 0.1831986060509315D;
         // 
         // tableCell6
         // 
         this.tableCell6.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Tên VT]")});
         this.tableCell6.Name = "tableCell6";
         this.tableCell6.StyleName = "DetailData1";
         this.tableCell6.Weight = 0.20025794396033653D;
         // 
         // tableCell7
         // 
         this.tableCell7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Đơn vị tính]")});
         this.tableCell7.Name = "tableCell7";
         this.tableCell7.StyleName = "DetailData1";
         this.tableCell7.Weight = 0.28508305476262019D;
         // 
         // tableCell8
         // 
         this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Số lượng tồn]")});
         this.tableCell8.Name = "tableCell8";
         this.tableCell8.StyleName = "DetailData1";
         this.tableCell8.StylePriority.UseTextAlignment = false;
         this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         this.tableCell8.Weight = 0.33146038348858176D;
         // 
         // dataSetReport1
         // 
         this.dataSetReport.DataSetName = "DataSetReport";
         this.dataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
         // 
         // report_DSVTTableAdapter1
         // 
         this.taReport_DSVT.ClearBeforeFill = true;
         // 
         // Xrpt_ReportDSVT
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader1,
            this.Detail});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource,
            this.dataSetReport});
         this.DataAdapter = this.taReport_DSVT;
         this.DataMember = "Report_DSVT";
         this.DataSource = this.dataSetReport;
         this.Font = new System.Drawing.Font("Arial", 9.75F);
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

      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource;
      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
      private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
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
      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.XRTable table2;
      private DevExpress.XtraReports.UI.XRTableRow tableRow2;
      private DevExpress.XtraReports.UI.XRTableCell tableCell5;
      private DevExpress.XtraReports.UI.XRTableCell tableCell6;
      private DevExpress.XtraReports.UI.XRTableCell tableCell7;
      private DevExpress.XtraReports.UI.XRTableCell tableCell8;
      private DataSetReport dataSetReport;
      private DataSetReportTableAdapters.Report_DSVTTableAdapter taReport_DSVT;
   }
}
