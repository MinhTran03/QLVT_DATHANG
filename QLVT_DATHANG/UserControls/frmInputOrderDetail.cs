using DevExpress.XtraEditors;
using QLVT_DATHANG.DataSetTableAdapters;
using QLVT_DATHANG.Utility;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG.UserControls
{
   public partial class frmInputOrderDetail : XtraUserControl
   {
      private BindingSource _bdsCTDDH;
      private BindingSource _bdsVT;
      private CTDDHTableAdapter _taCTDDH;
      private DataSet _dataSet;

      public frmInputOrderDetail(string orderId, BindingSource bdsCTDDH, BindingSource bdsVT,
                                    CTDDHTableAdapter taCTDDH, DataSet dataSet)
      {
         InitializeComponent();

         spiCost.Properties.Increment = 100000;
         txtOrderId.EditValue = orderId;

         _bdsCTDDH = bdsCTDDH;
         _bdsVT = bdsVT;
         _taCTDDH = taCTDDH;
         _dataSet = dataSet;
      }

      private void frmInputOrderDetail_Load(object sender, EventArgs e)
      {
         gcVT.DataSource = _bdsVT;
         txtMaterialId.DataBindings.Add(new Binding("EditValue", _bdsVT, "TENVT", true));
         txtMaterialId.DataBindings.Add(new Binding("Tag", _bdsVT, "MAVT", true));
      }

      private void spiQuantity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var editVal = spiQuantity.EditValue;
         if (!(editVal is null))
         {
            if (int.Parse(editVal.ToString()) < 0)
            {
               dxErrorProvider.SetError((sender as BaseEdit), Cons.ErrorBelowThenZero);
               e.Cancel = true;
            }
         }
         else
         {
            dxErrorProvider.SetError((sender as BaseEdit), string.Empty);
            e.Cancel = false;
         }
      }

      private void spiCost_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
      {
         if (!(e.Value is DBNull))
         {
            decimal price = Convert.ToDecimal(e.Value);
            e.DisplayText = string.Format(Cons.CiVNI, "{0:c0}", price);
         }
      }

      private bool CheckContainOrderDetail(string materialId)
      {
         bool exist = false;

         for (int i = 0; i < _bdsCTDDH.Count; i++)
         {
            if (materialId.Equals(((DataRowView)_bdsCTDDH[i])["MAVT"].ToString()))
            {
               exist = true;
               break;
            }
         }

         return exist;
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         int orderDetailQuantity = int.Parse(spiQuantity.EditValue.ToString());
         string materialId = txtMaterialId.Tag.ToString();

         if (CheckContainOrderDetail(materialId))
         {
            XtraMessageBox.Show("Vật tư đã lập ddh");
            return;
         }

         object[] orderDetailData = new object[4];
         orderDetailData[0] = txtOrderId.EditValue.ToString();
         orderDetailData[1] = materialId;
         orderDetailData[2] = orderDetailQuantity;
         orderDetailData[3] = float.Parse(spiCost.EditValue.ToString());

         _bdsCTDDH.AddNew();
         // Count - 1 vì AddNew() xong Count + 1
         ((DataRowView)_bdsCTDDH[_bdsCTDDH.Count - 1]).Row.ItemArray = orderDetailData;
         _bdsCTDDH.EndEdit();
         _taCTDDH.Update(_dataSet.CTDDH);

         // Xóa data trên form
         spiQuantity.EditValue = null;
         spiCost.EditValue = null;
         _bdsVT.Position = 0;
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         var result = XtraMessageBox.Show(Cons.AskExit, Cons.CaptionQuestion,
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
            ((Form)this.TopLevelControl).Close();
      }

      private void spiCost_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         var editVal = spiQuantity.EditValue;
         if (!(editVal is null))
         {
            if (float.Parse(editVal.ToString()) < 0)
            {
               dxErrorProvider.SetError((sender as BaseEdit), Cons.ErrorBelowThenZero);
               e.Cancel = true;
            }
         }
         else
         {
            dxErrorProvider.SetError((sender as BaseEdit), string.Empty);
            e.Cancel = false;
         }
      }
   }
}
