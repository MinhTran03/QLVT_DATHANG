using QLVT_DATHANG.Utility;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using QLVT_DATHANG.Constant;

   public partial class frmDepot : XtraForm
   {
      private MyStack _userDo;
      private string _currentDeploymentId;
      private ButtonActionType _buttonAction;

      public frmDepot()
      {
         InitializeComponent();
         SetupControls();
      }

      private void frmDepot_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsDepot[0])["MAKHO"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilCommon.SetupDSCN(this.cboDeployment);
            this.pnPickDepartment.Visible = true;
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
         }
      }

      private void userDo_StackPopped(object sender, StackEventAgrs e)
      {
         if (_userDo.Count == 0)
         {
            btnUndo.Enabled = false;
         }
      }

      private void userDo_StackPushed(object sender, StackEventAgrs e)
      {
         if (_userDo.Count == 1)
         {
            btnUndo.Enabled = true;
         }
      }

      private void DisableEditMode()
      {
         btnDel.Enabled = (bdsDepot.Count == 0) ? false : true;
         txtEmpDepartment.ReadOnly = true;

         gcDepot.Enabled = true;
         gbDepot.Enabled = false;

         btnAdd.Enabled = true;
         btnDel.Enabled = true;
         btnEdit.Enabled = true;
         btnExit.Enabled = true;
         btnRefresh.Enabled = true;
         btnUndo.Enabled = (_userDo.Count == 0) ? false : true;

         btnCancelEdit.Enabled = false;
         btnCancelEdit.Visibility = BarItemVisibility.Never;

         btnSave.Enabled = false;
         btnSave.Visibility = BarItemVisibility.Never;
      }

      private void LoadTable()
      {
         this.taDepot.Connection.ConnectionString =
            this.taCN.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taCN.Fill(this.dataSet.ChiNhanh);

            this.taDepot.Fill(this.dataSet.Kho);

            this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilCommon.ShowError(ex);
         }
      }

      private void SetupControls()
      {

      }

      #endregion

      #region EVENTS

      private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
      {

      }

      private void cboDeployment_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (cboDeployment.SelectedValue.ToString() == "System.Data.DataRowView") return;

         // đổi server
         UtilDB.ServerName = cboDeployment.SelectedValue.ToString();

         // đổi login
         if (cboDeployment.SelectedIndex != UtilDB.CurrentDeployment)
         {
            UtilDB.CurrentLogin = MyConfig.RemoteLogin;
            UtilDB.CurrentPassword = MyConfig.RemotePassword;
         }
         else
         {
            UtilDB.CurrentLogin = UtilDB.BackupLogin;
            UtilDB.CurrentPassword = UtilDB.BackupPassword;
         }

         //
         if (UtilDB.Connect() == 0)
         {
            XtraMessageBox.Show(Cons.ErrorConnectDepartment, Cons.CaptionError, MessageBoxButtons.OK);
         }
         else
         {
            LoadTable();
            _currentDeploymentId = ((DataRowView)bdsDepot[0])["MAKHO"].ToString();
         }
      }

      #endregion
   }
}
