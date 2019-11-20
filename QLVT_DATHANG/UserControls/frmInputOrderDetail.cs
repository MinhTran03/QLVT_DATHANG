using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;
using System;
using System.Data;

namespace QLVT_DATHANG.UserControls
{
   public partial class frmInputOrderDetail : XtraUserControl
   {
      private int _maxQuantity;

      public frmInputOrderDetail(string orderId)
      {
         InitializeComponent();

         spiCost.Properties.Increment = 100000;
         txtOrderId.EditValue = orderId;
      }

      private void frmInputOrderDetail_Load(object sender, EventArgs e)
      {
         this.taVT.Connection.ConnectionString =
            UtilDB.ConnectionString;

         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taVT.Fill(this.dataSet.Vattu);
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void txtMaterialId_EditValueChanged(object sender, EventArgs e)
      {
         if (bdsVT.Position > 0)
         {
            _maxQuantity = int.Parse(((DataRowView)bdsVT[bdsVT.Position])["SOLUONGTON"].ToString());
            Console.WriteLine(_maxQuantity);
         }
      }

      private void spiQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         e.Cancel = false;
         var editVal = spiQuantity.EditValue;
         if (!(editVal is null) && int.Parse(editVal.ToString()) > _maxQuantity)
         {
            dxErrorProvider.SetError((sender as BaseEdit), "Số lượng bạn chọn vượt quá số lượng tồn");
         }
         else
         {
            dxErrorProvider.SetError((sender as BaseEdit), string.Empty);
         }
      }
   }
}
