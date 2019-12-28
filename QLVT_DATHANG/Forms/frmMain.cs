﻿using System;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
   using DevExpress.XtraEditors;
   using UserControls;
   using Utility;

   public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
   {
      public frmMain()
      {
         InitializeComponent();
         bsiMaNV.Caption = "Mã NV : " + UtilDB.UserName;
         bsiHoTenNV.Caption = "Họ tên nhân viên : " + UtilDB.CurrentFullName;
         string gr = null;
         switch (UtilDB.CurrentGroup)
         {
            case MyConfig.UserGroupName:
               gr = "User";
               break;
            case MyConfig.ChiNhanhGroupName:
               gr = "Chi Nhánh";
               break;
            case MyConfig.CongTyGroupName:
               gr = "Công Ty";
               break;
            default:
               break;
         }
         bsiNhom.Caption = "Nhóm : " + gr;
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

      private void btnRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         if (!UtilDB.CurrentGroup.Equals(MyConfig.UserGroupName))
         {
            FlyoutAction flyoutAction = new FlyoutAction()
            {
               Caption = Cons.CaptionCreateLogin,
            };
            CustomFlyoutDialog.ShowForm(this, flyoutAction, new frmRegister());
         }
         else
         {
            XtraMessageBox.Show(Cons.WarningUserCreateTK, Cons.CaptionWarning,
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
         }
      }

      private void frmMain_Load(object sender, EventArgs e)
      {
         if (UtilDB.CurrentGroup.Equals(MyConfig.UserGroupName))
         {
            btnRegister.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
         }
      }

      private void btnReportDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmReportDSNV));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmReportDSNV f = new frmReportDSNV();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmDSDDHChuaCoPhieuNhap));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmDSDDHChuaCoPhieuNhap f = new frmDSDDHChuaCoPhieuNhap();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmReportDSVT));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmReportDSVT f = new frmReportDSVT();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmReportDSDVT));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmReportDSDVT f = new frmReportDSDVT();
            f.MdiParent = this;
            f.Show();
         }
      }

      private void btnTongHopNhapXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         Form nvForm = CheckExists(typeof(frmReportTongHopNhapXuat));
         if (nvForm != null)
         {
            nvForm.Activate();
         }
         else
         {
            frmReportTongHopNhapXuat f = new frmReportTongHopNhapXuat();
            f.MdiParent = this;
            f.Show();
         }
      }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form nvForm = CheckExists(typeof(frmReportDSVT));
            if (nvForm != null)
            {
                nvForm.Activate();
            }
            else
            {
                frmReportDSVT f = new frmReportDSVT();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form nvForm = CheckExists(typeof(frmReportDSDVT));
            if (nvForm != null)
            {
                nvForm.Activate();
            }
            else
            {
                frmReportDSDVT f = new frmReportDSDVT();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
