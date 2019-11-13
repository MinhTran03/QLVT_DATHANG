using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   public class CustomFlyoutDialog : FlyoutDialog
   {
      public CustomFlyoutDialog(Form owner, FlyoutAction action, Control userControlToShow)
         : base(owner, action)
      {
         this.Properties.HeaderOffset = 0;
         this.Properties.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
         this.Properties.Style = FlyoutStyle.Popup;
         this.FlyoutControl = userControlToShow;
      }

      public static DialogResult ShowForm(Form owner, FlyoutAction action, Control userControlToShow)
      {
         CustomFlyoutDialog flyoutDialog = new CustomFlyoutDialog(owner, action, userControlToShow);
         return flyoutDialog.ShowDialog();
      }
   }
}
