using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
   using DevExpress.XtraEditors;
   using System.Data.SqlClient;
   using System.Drawing;
   using Utility;
   using UserControls;

   public partial class frmOrders : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private int _backupWidth = 0;

      public frmOrders()
      {
         InitializeComponent();
         SetupControls();

         //gridView1.Columns[0].OptionsColumn.AllowEdit = false;
      }

      private void frmOrders_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsDDH[0])["MasoDDH"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals(Cons.CongTyGroupName))
         {
            UtilDB.SetupDSCN(cboDeployment);
            cboDeployment.Visible = true;

            btnAdd.Enabled = false;
         }
      }

      private void SetupControls()
      {
         gcOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         gcOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
         gcOrderDetail.BorderStyle = BorderStyle.None;
         gcOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
         gcOrderDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
         gcOrderDetail.EnableHeadersVisualStyles = false;
         gcOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         gcOrderDetail.RowHeadersVisible = false;
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taDDH.Connection.ConnectionString =
            this.taCTDDH.Connection.ConnectionString =
            this.taDSNV.Connection.ConnectionString =
            this.taVT.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taDDH.Fill(this.dataSet.DatHang);

            this.taCTDDH.Fill(this.dataSet.CTDDH);

            this.taDSNV.Fill(this.dataSet.DSNV);

            this.taVT.Fill(this.dataSet.Vattu);

            //this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void EnableEditMode()
      {
         gcOrder.Enabled = false;
         gbOrder.Enabled = true;

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
         gcOrder.Enabled = true;
         gbOrder.Enabled = false;

         btnAdd.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      private bool IsExistOrder(string orderId)
      {
         bool exist = false;
         string strLenh = string.Format(MyConfig.ExecSPTimDDH, orderId);
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand sqlcmd = new SqlCommand(strLenh, connection))
            {
               sqlcmd.CommandType = CommandType.Text;
               try
               {
                  sqlcmd.ExecuteNonQuery();
                  exist = true;
               }
               catch (Exception ex)
               {
                  if (ex is SqlException && (ex as SqlException).Class == MyConfig.ErrorCodeDatabase)
                     exist = false;
                  else
                     UtilDB.ShowError(ex);
               }
            }
         }
         return exist;
      }

      private bool SaveOrder()
      {
         try
         {
            if (_buttonAction == ButtonActionType.Add)
            {
               if (IsExistOrder(txtOrderId.EditValue.ToString()))
               {
                  XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  txtOrderId.Focus();
                  txtOrderId.SelectAll();
                  return false;
               }
            }

            bdsDDH.EndEdit();
            gbOrder.Enabled = false;
            //bdsNV.ResetCurrentItem();
            this.taDDH.Update(this.dataSet.DatHang);
            _buttonAction = ButtonActionType.None;
         }
         catch (Exception ex)
         {
            // #load lại từ database
            dataSet.EnforceConstraints = false;
            this.taDDH.Fill(this.dataSet.DatHang);
            dataSet.EnforceConstraints = true;

            UtilDB.ShowError(ex);
            return false;
         }
         bdsDDH.Position = _currentPosition;
         DisableEditMode();
         return true;
      }

      #endregion

      #region EVENTS

      private void frmOrders_Resize(object sender, EventArgs e)
      {
         int Width = (sender as XtraForm).Width;
         if (Width != _backupWidth)
         {
            sccOrder.SplitterPosition = Width / 2;
            _backupWidth = Width;
         }
      }

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsDDH.Position;
         _buttonAction = ButtonActionType.Add;

         bdsDDH.AddNew();
         dtpOrderDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = UtilDB.UserName;

         EnableEditMode();
         txtOrderId.Focus();
      }

      private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         SaveOrder();
      }

      private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         dxErrorProvider.ClearErrors();
         try
         {
            gbOrder.Enabled = false;
            bdsDDH.CancelEdit();
            bdsDDH.ResetCurrentItem();
            bdsDDH.Position = _currentPosition;
            _buttonAction = ButtonActionType.None;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
         DisableEditMode();
      }

      private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
      {
         this.Close();
      }

      #endregion

      private void btnAddOrderDetail_Click(object sender, EventArgs e)
      {
         FlyoutAction flyoutAction = new FlyoutAction()
         {
            Caption = Cons.CaptionCreateOrderDetail,
         };

         string orderId = txtOrderId.EditValue.ToString();
         CustomFlyoutDialog.ShowForm(this, flyoutAction, new frmInputOrderDetail(orderId));
      }
   }
}