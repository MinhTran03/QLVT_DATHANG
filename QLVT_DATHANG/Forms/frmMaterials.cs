using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QLVT_DATHANG.Utility;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using DevExpress.XtraEditors.Mask;

   public partial class frmMaterials : XtraForm
   {

      private int _currentPosition;

      public frmMaterials()
      {
         InitializeComponent();

         txtMaterialName.Properties.Mask.MaskType = MaskType.RegEx;
         txtMaterialName.Properties.Mask.EditMask = "[a-zA-Z ]+";

         spiSLT.Properties.Mask.MaskType = MaskType.Numeric;
         spiSLT.Properties.Increment = 1;
      }
      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taVT.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taVT.Fill(this.dataSet.Vattu);

            this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            ShowError(ex);
         }
      }

      private void ChangeStateInputForm(bool state)
      {
         foreach (var item in gbVT.Controls)
         {
            if (item.GetType() != typeof(Label))
            {
               ((Control)item).Enabled = state;
            }
         }
      }

      private void ChangeStateAddMaterials()
      {
         gcVT.Enabled = false;
         ChangeStateInputForm(true);

         btnAdd.Enabled = false;
         btnDelete.Enabled = false;
         btnReload.Enabled = false;
         btnExit.Enabled = false;

         btnCancelEdit.Enabled = true;
         btnCancelEdit.Visibility = BarItemVisibility.Always;

         btnSave.Enabled = true;
         btnSave.Visibility = BarItemVisibility.Always;

         btnUndo.Enabled = true;
         btnUndo.Visibility = BarItemVisibility.Always;
      }

      private void RecoverDefaultState()
      {
         //gbNV.Enabled = false;
         gcVT.Enabled = true;
         ChangeStateInputForm(false);

         btnAdd.Enabled = true;
         btnDelete.Enabled = true;
         btnExit.Enabled = true;
         btnReload.Enabled = true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;

         btnUndo.Enabled = false;
         btnUndo.Visibility = BarItemVisibility.Never;
      }

      public void ShowError(Exception e)
      {
         string message = e.Message + "\n";
         string source = "Source: " + e.Source + "\n";
         string targetSite = "Method: " + e.TargetSite + "\n";
         MessageBox.Show(source + targetSite + message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         Console.WriteLine(e.StackTrace);
         if (e.GetType() == typeof(SqlException))
         {
            Console.WriteLine("===>" + ((SqlException)e).Number.ToString());
         }
      }

      private void frmMaterials_Load(object sender, EventArgs e)
      {

         LoadTable();
         ChangeStateInputForm(false);
      }

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsVT.Position;

         bdsVT.AddNew();
         ChangeStateAddMaterials();
         txtMaterialId.Focus();
      }

      private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
      {
         try
         {
            bdsVT.EndEdit();
            bdsVT.ResetCurrentItem();
            this.taVT.Update(this.dataSet.Vattu);
         }
         catch (Exception ex)
         {
            // #load lại từ database
            dataSet.EnforceConstraints = false;

            this.taVT.Fill(this.dataSet.Vattu);

            dataSet.EnforceConstraints = true;
            ShowError(ex);
         }
         bdsVT.Position = _currentPosition;
         RecoverDefaultState();
      }

      private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         bdsVT.CancelEdit();
      }

      private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         this.Close();
      }

      private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         LoadTable();
      }

      private void btnCancelEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
      {
         try
         {
            bdsVT.CancelEdit();
            bdsVT.ResetCurrentItem();
            bdsVT.Position = _currentPosition;
         }
         catch (Exception ex)
         {
            ShowError(ex);
         }
         RecoverDefaultState();
      }

      private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsVT.Position;
         string ten = ((DataRowView)bdsVT[_currentPosition])["TENVT"].ToString();
         var result = MessageBox.Show($"Bạn có chắc muốn xóa {ten}", "QESTION",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (result == DialogResult.Yes)
         {
            try
            {
               bdsVT.RemoveCurrent();
               this.taVT.Update(this.dataSet.Vattu);
            }
            catch (Exception ex)
            {
               ShowError(ex);
            }
         }
      }

      private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
      {
         _currentPosition = bdsVT.Position;
         ChangeStateAddMaterials();
      }
   }
}
