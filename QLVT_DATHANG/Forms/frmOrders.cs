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

      public frmOrders()
      {
         InitializeComponent();
         SetupControls();
         //gridView1.Columns[0].OptionsColumn.AllowEdit = false;
      }

      private void frmOrders_Load(object sender, EventArgs e)
      {
         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsDDH[0])["MasoDDH"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals(MyConfig.CongTyGroupName))
         {
            UtilDB.SetupDSCN(this.cboDeployment, LoadTable);
            this.pnPickDepartment.Visible = true;
            this.btnAdd.Enabled = false;
         }
      }

      private void SetupControls()
      {
         gcOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         gcOrderDetail.Columns[2].DefaultCellStyle.FormatProvider = Cons.CiVNI;
         gcOrderDetail.Columns[2].DefaultCellStyle.Format = "c0";

         gcOrderDetail.BorderStyle = BorderStyle.None;
         gcOrderDetail.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
         gcOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.Single;
         gcOrderDetail.DefaultCellStyle.SelectionBackColor = Color.FromArgb(226, 234, 253);
         gcOrderDetail.DefaultCellStyle.SelectionForeColor = Color.Black;
         gcOrderDetail.BackgroundColor = Color.White;

         gcOrderDetail.EnableHeadersVisualStyles = false;
         gcOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
         gcOrderDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(246, 246, 247);
         gcOrderDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
         gcOrderDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
      }

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taDDH.Connection.ConnectionString =
            this.taCTDDH.Connection.ConnectionString =
            this.taDSVT.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taDDH.Fill(this.dataSet.DatHang);

            this.taCTDDH.Fill(this.dataSet.CTDDH);

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
         gcOrder.Enabled = false;

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
         bool exist = true;
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

      private bool SaveOrder()
      {
         try
         {
            //if (IsExistOrder(txtOrderId.EditValue.ToString()))
            //{
            //   XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
            //      MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //   txtOrderId.Focus();
            //   txtOrderId.SelectAll();
            //   return false;
            //}

            //bdsDDH.EndEdit();
            //this.taDDH.Update(this.dataSet.DatHang);
            //gbOrder.Enabled = false;
            //bdsDDH.ResetCurrentItem();
            //bdsDDH.Position = _currentPosition;
            //DisableEditMode();
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }
         return true;
      }

      #endregion

      #region EVENTS

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         frmAddOrder addOrder = new frmAddOrder(bdsDDH, taDDH, bdsCTDDH, taCTDDH, dataSet);
         FlyoutAction flyoutAction = new FlyoutAction()
         {
            Caption = "LẬP ĐƠN ĐẶT HÀNG",
         };
         CustomFlyoutDialog.ShowForm(this, flyoutAction, addOrder);
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
            bdsDDH.CancelEdit();
            bdsDDH.ResetCurrentItem();
            //bdsDDH.Position = _currentPosition;
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

         //string orderId = txtOrderId.EditValue.ToString();
         //using (frmInputOrderDetail inputOrderDetail = new frmInputOrderDetail(orderId, bdsCTDDH, bdsVT, taCTDDH, dataSet))
         //{
         //   CustomFlyoutDialog.ShowForm(this, flyoutAction, inputOrderDetail);
         //   //inputOrderDetail.Disposed += (o, arg) =>
         //   //{
         //   //   try
         //   //   {
         //   //      this.taCTDDH.Update(this.dataSet.CTDDH);
         //   //      this.taVT.Update(this.dataSet.Vattu);
         //   //   }
         //   //   catch (Exception ex)
         //   //   {
         //   //      UtilDB.ShowError(ex);
         //   //   }
         //   //};
         //}
      }

      private void frmOrders_FormClosing(object sender, FormClosingEventArgs e)
      {
         //if (gbOrder.Enabled == true)
         //{
         //   var result = XtraMessageBox.Show(Cons.AskExitWhileEditing, Cons.CaptionQuestion,
         //                              MessageBoxButtons.YesNoCancel,
         //                              MessageBoxIcon.Question);
         //   switch (result)
         //   {
         //      case DialogResult.Yes:
         //         // kiểm tra nút được nhấn [thêm, sửa] => [Lưu lại, update]
         //         e.Cancel = !(SaveOrder());
         //         break;
         //      case DialogResult.No:
         //         // thoát bất chấp
         //         btnCancelEdit.PerformClick();
         //         break;
         //      case DialogResult.Cancel:
         //         // hủy thoát
         //         e.Cancel = true;
         //         break;
         //      default:
         //         break;
         //   }
         //}
      }
   }
}