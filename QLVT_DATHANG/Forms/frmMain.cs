using System;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using Utility;

   public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public frmMain()
      {
         InitializeComponent();
         bsiMaNV.Caption = "Mã NV : " + UtilDB.UserName;
         bsiHoTenNV.Caption = "Họ tên nhân viên : " + UtilDB.CurrentFullName;
         bsiNhom.Caption = "Nhóm : " + UtilDB.CurrentGroup;
      }

      private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmEmployee));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmEmployee f = new frmEmployee();
            f.MdiParent = this;
            f.Show();
         }
      }

      private Form CheckExists(Type fType)
      {
         foreach (var form in this.MdiChildren)
         {
            if (form.GetType() == fType)
            {
               return form;
            }
         }
         return null;
      }

      private void btnVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmMaterials));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmMaterials f = new frmMaterials();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void btnPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmGoodsDeliveryNote));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmGoodsDeliveryNote f = new frmGoodsDeliveryNote();
            f.MdiParent = this;
            f.Show();
         }
      }
   }
}
