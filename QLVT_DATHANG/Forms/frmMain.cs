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
         Form nvForm = CheckExists(typeof(XtraForm1));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            XtraForm1 f = new XtraForm1();
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

      private void btnDepot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmDepot));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmDepot f = new frmDepot();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void btnOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmOrders));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmOrders f = new frmOrders();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmGoodsReceivedNote));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmGoodsReceivedNote f = new frmGoodsReceivedNote();
            f.MdiParent = this;
            f.Show();
         }
      }
   }
}
