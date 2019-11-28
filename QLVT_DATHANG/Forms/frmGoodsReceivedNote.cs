using System;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using System.Data.SqlClient;
   using System.Drawing;
   using System.Windows.Forms;
   using Utility;

   public partial class frmGoodsReceivedNote : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private int _backupWidth;

      public frmGoodsReceivedNote()
      {
         InitializeComponent();
         SetupControls();
      }

      private void GoodsReceivedNote_Load(object sender, EventArgs e)
      {
         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsPN[0])["MAPN"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilDB.SetupDSCN(cboDeployment, LoadTable);
            this.pnPickDepartment.Visible = true;
            btnAdd.Enabled = false;
         }
      }

      private void SetupControls()
      {
         gcCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         gcCTPN.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         gcCTPN.Columns[3].DefaultCellStyle.FormatProvider = Cons.CiVNI;
         gcCTPN.Columns[3].DefaultCellStyle.Format = "c0";

         gcCTPN.BorderStyle = BorderStyle.None;
         gcCTPN.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
         gcCTPN.CellBorderStyle = DataGridViewCellBorderStyle.Single;
         gcCTPN.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 234, 253);
         gcCTPN.DefaultCellStyle.SelectionForeColor = Color.Black;
         gcCTPN.BackgroundColor = Color.White;

         gcCTPN.EnableHeadersVisualStyles = false;
         gcCTPN.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
         gcCTPN.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 247);
         gcCTPN.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
         gcCTPN.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taPN.Connection.ConnectionString =
                this.taCTPN.Connection.ConnectionString =
                this.taDDH.Connection.ConnectionString =
                this.taDSNV.Connection.ConnectionString =
                this.taDSVT.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.taPN.Fill(this.dataSet.PhieuNhap);

            this.taDDH.Fill(this.dataSet.DatHang);

            this.taDSNV.Fill(this.dataSet.DSNV);

            this.taCTPN.Fill(this.dataSet.CTPN);

            this.taDSVT.Fill(this.dataSet.DSVT);

            //this.dataSet.EnforceConstraints = true;

         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void EnableEditMode()
      {
         //gbOrderDetail.Enabled = false;

         gcReceivedNote.Enabled = false;
         gbReceivedNote.Enabled = true;

         btnAdd.Enabled = false;
         btnExit.Enabled = false;
         btnRefresh.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;
      }

      private void DisableEditMode()
      {
         gcReceivedNote.Enabled = true;
         gbReceivedNote.Enabled = false;

         btnAdd.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      #endregion

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsPN.Position;

         bdsPN.AddNew();

         txtDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = UtilDB.UserName;

         EnableEditMode();
         txtMaPN.Focus();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         SaveReceivedNote();
      }

      private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         dxErrorProvider.ClearErrors();
         try
         {
            gbReceivedNote.Enabled = false;
            bdsPN.CancelEdit();
            bdsPN.ResetCurrentItem();
            bdsPN.Position = _currentPosition;
            DisableEditMode();
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.Close();
      }

      private bool SaveReceivedNote()
      {
         try
         {
            if (IsExistGoodsReceivedNote(txtMaPN.EditValue.ToString()))
            {
               XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
               txtMaPN.Focus();
               return false;
            }

            bdsPN.EndEdit();
            this.taPN.Update(this.dataSet.PhieuNhap);
            gbReceivedNote.Enabled = false;
            bdsPN.ResetCurrentItem();
            bdsPN.Position = _currentPosition;
            DisableEditMode();
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }

         return true;
      }

      private bool IsExistGoodsReceivedNote(string id)
      {
         bool exist = true;
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand sqlcmd = new SqlCommand(MyConfig.ExecSPTimPhieuNhap, connection))
            {
               sqlcmd.CommandType = CommandType.StoredProcedure;
               sqlcmd.Parameters.AddWithValue("@mapn", id);

               try
               {
                  sqlcmd.ExecuteNonQuery();
               }
               catch (SqlException ex)
               {
                  if (ex.Number == MyConfig.ErrorMsgNumNotExistObject)
                     exist = false;
               }
               catch (Exception ex)
               {
                  UtilDB.ShowError(ex);
               }
            }
         }
         return exist;
      }

      private void btnAddCTPN_Click(object sender, EventArgs e)
      {

      }

      private void frmGoodsReceivedNote_Resize(object sender, EventArgs e)
      {
         int Width = (sender as XtraForm).Width;
         if (Width != _backupWidth)
         {
            sccReceived.SplitterPosition = Width / 2;
            _backupWidth = Width;
         }
      }
   }
}