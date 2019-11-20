using System;
using System.Data;
using System.Windows.Forms;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
   using System.Drawing;
   using Utility;

   public partial class frmOrders : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;
      private int _backupWidth = 0;

      public frmOrders()
      {
         InitializeComponent();
         SetupControls();

         //gridView1.Columns[0].OptionsColumn.AllowEdit = false;
      }

      private void frmOrders_Load(object sender, EventArgs e)
      {
         _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsDDH[0])["MasoDDH"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilDB.SetupDSCN(cboDeployment);
            cboDeployment.Visible = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
         }
      }

      private void SetupControls()
      {
         gcOrderDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
         gcOrderDetail.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
         gcOrderDetail.BorderStyle = BorderStyle.None;
         gcOrderDetail.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
         gcOrderDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
         gcOrderDetail.EnableHeadersVisualStyles = false;
         gcOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
         gcOrderDetail.RowHeadersVisible = false;
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

      private void LoadTable()
      {
         // Đoạn này quan trọng. Đăng nhập bằng user nào => connectionString tương ứng
         this.taDDH.Connection.ConnectionString =
            this.taCTDDH.Connection.ConnectionString =
            this.taDSNV.Connection.ConnectionString =
            this.taVT.Connection.ConnectionString = 
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taDDH.Fill(this.dataSet.DatHang);

            this.taCTDDH.Fill(this.dataSet.CTDDH);

            this.taDSNV.Fill(this.dataSet.DSNV);

            this.taVT.Fill(this.dataSet.Vattu);

            //this.dataSet.EnforceConstraints = true;
         }
         catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

      private void DisableEditMode()
      {
         btnDel.Enabled = (bdsDDH.Count == 0) ? false : true;

         gcOrder.Enabled = true;
         gbOrder.Enabled = true;

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

      #endregion

      private void frmOrders_Resize(object sender, EventArgs e)
      {
         int Width = (sender as XtraForm).Width;
         if (Width != _backupWidth)
         {
            sccOrder.SplitterPosition = Width / 2;
            _backupWidth = Width;
         }
      }
   }
}