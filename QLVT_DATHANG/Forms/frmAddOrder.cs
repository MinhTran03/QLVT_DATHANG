using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraEditors;
   using DevExpress.XtraGrid.Views.Base;
   using DataSetTableAdapters;
   using Utility;
   using DevExpress.XtraGrid.Views.Grid;
   using System.Collections.Generic;
   using System.Threading.Tasks;

   public partial class frmAddOrder : XtraForm
   {
      private BindingSource _bdsDDH;
      private DatHangTableAdapter _taDDH;
      private BindingSource _bdsCTDDH;
      private CTDDHTableAdapter _taCTDDH;
      private DataSet _dataSet;

      public frmAddOrder(BindingSource bdsDDH, DatHangTableAdapter taDDH
                           , BindingSource bdsCTDDH, CTDDHTableAdapter taCTDDH, DataSet dataSet)
      {
         InitializeComponent();

         _bdsDDH = bdsDDH;
         _taDDH = taDDH;
         _bdsCTDDH = bdsCTDDH;
         _taCTDDH = taCTDDH;
         _dataSet = dataSet;

         this.gcOrderDetail.DataSource = _bdsCTDDH;
      }

      private void frmAddOrder_Load(object sender, EventArgs e)
      {
         LoadTable();
         btnAdd.PerformClick();
      }

      private void LoadTable()
      {
         this.taDSKHO.Connection.ConnectionString =
            this.taDSNCC.Connection.ConnectionString =
            this.taDSNV.Connection.ConnectionString =
            this.taDSVT.Connection.ConnectionString =
            UtilDB.ConnectionString;

         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taDSNCC.Fill(this.dataSet.DSNCC);
            this.taDSNV.Fill(this.dataSet.DSNV);
            this.taDSKHO.Fill(this.dataSet.DSKHO);
            this.taDSVT.Fill(this.dataSet.DSVT);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void gvOrderDetail_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
      {
         ColumnView view = sender as ColumnView;
         if (e.Column.FieldName == "DONGIA" && e.ListSourceRowIndex != DevExpress.XtraGrid.GridControl.InvalidRowHandle)
         {
            if (!(e.Value is DBNull))
            {
               decimal price = Convert.ToDecimal(e.Value);
               e.DisplayText = string.Format(Cons.CiVNI, "{0:c0}", price);
            }
         }
      }

      private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         SaveOrder();
         DisableEditMode();
      }

      private bool SaveOrder()
      {
         try
         {
            if (IsSaveOrder() == false) return false;

            ((DataRowView)_bdsDDH[_bdsDDH.Position]).Row.ItemArray = GetDataOrder();
            int orderDetailCount = gvOrderDetail.DataRowCount;

            ((DataRowView)_bdsCTDDH.Current).BeginEdit();
            for (int i = 0; i < orderDetailCount; i++)
            {
               ((DataRowView)_bdsCTDDH.Current).Row["MasoDDH"] = txtOrderId.Text;
               _bdsCTDDH.MovePrevious();
            }

            _bdsCTDDH.EndEdit();
            _bdsDDH.EndEdit();
            this._taDDH.Update(this._dataSet.DatHang);
            this._taCTDDH.Update(this._dataSet.CTDDH);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
            return false;
         }
         return true;
      }

      private void SaveALlDataOrderDetailOnView()
      {
         for (int i = 0; i < gvOrderDetail.DataRowCount; i++)
         {
            _bdsCTDDH.AddNew();
            ((DataRowView)_bdsCTDDH[_bdsCTDDH.Position]).Row.ItemArray = gvOrderDetail.GetDataRow(i).ItemArray;
            _bdsCTDDH.EndEdit();
            this._taCTDDH.Update(this._dataSet.CTDDH);
         }
      }

      private bool IsSaveOrder()
      {
         if (IsExistOrder(txtOrderId.Text))
         {
            XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtOrderId.Focus();
            txtOrderId.SelectAll();
            return false;
         }

         return true;
      }

      private object[] GetDataOrder()
      {
         object[] data = new object[5];

         data[0] = txtOrderId.Text;
         data[1] = dtpOrderDate.EditValue;
         data[2] = cboNCC.Text;
         data[3] = lkeEmployee.EditValue;
         data[4] = lkeDepot.EditValue;

         return data;
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

      private void EnableEditMode()
      {
         btnAdd.Enabled = btnEdit.Enabled = btnEdit.Enabled = btnExit.Enabled = false;
         btnSave.Enabled = btnCancelEdit.Enabled = lcOrder.Enabled = gcOrderDetail.Enabled = true;
      }

      private void DisableEditMode()
      {
         btnAdd.Enabled = btnEdit.Enabled = btnEdit.Enabled = btnExit.Enabled = true;
         btnSave.Enabled = btnCancelEdit.Enabled = lcOrder.Enabled = gcOrderDetail.Enabled = false;
      }

      private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         dtpOrderDate.EditValue = DateTime.Now;
         lkeEmployee.EditValue = UtilDB.UserName;

         _bdsDDH.AddNew();

         EnableEditMode();
      }

      private void btnCancelEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         _bdsDDH.CancelEdit();
         _bdsCTDDH.CancelEdit();
         DisableEditMode();
      }
   }
}