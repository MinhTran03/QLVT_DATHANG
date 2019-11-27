using System;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using Utility;

   public partial class frmGoodsReceivedNote : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;

      public frmGoodsReceivedNote()
      {
         InitializeComponent();
         SetupControls();
      }

      private void GoodsReceivedNote_Load(object sender, EventArgs e)
      {
            _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsPN[0])["MAPN"].ToString().Trim();

         // Quyền công ty => enable combobox chi nhánh
         ShowControlsByGroup(UtilDB.CurrentGroup);
      }

      #region METHOD

      private void ShowControlsByGroup(string grName)
      {
         if (grName.Equals("congty"))
         {
            UtilDB.SetupDSCN(cboDeployment, LoadTable);
            cboDeployment.Visible = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
         }
      }

      private void SetupControls()
      {
         
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
         this.taPN.Connection.ConnectionString =
                this.taCTPN.Connection.ConnectionString =
                this.taDDH.Connection.ConnectionString =
                this.taDSNV.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dataSet.PhieuNhap' table. You can move, or remove it, as needed.
            this.taPN.Fill(this.dataSet.PhieuNhap);

                this.taDDH.Fill(this.dataSet.DatHang);

                this.taDSNV.Fill(this.dataSet.DSNV);

                this.taCTPN.Fill(this.dataSet.CTPN);

                //this.dataSet.EnforceConstraints = true;

            }
            catch (Exception ex)
         {
            UtilDB.ShowError(ex);
         }
      }

        private void EnableEditMode()
        {
            //gbOrderDetail.Enabled = false;

            gcReceivedNote.Enabled = false;
            gbReceivedNote.Enabled = true;

            btnAdd.Enabled = false;
            btnExit.Enabled = false;
            btnRefresh.Enabled = false;

            btnCancelEdit.Enabled = true;
            btnCancelEdit.Visibility = BarItemVisibility.Always;

            btnSave.Enabled = true;
            btnSave.Visibility = BarItemVisibility.Always;
        }

        private void DisableEditMode()
      {
         btnDel.Enabled = (bdsPN.Count == 0) ? false : true;

         gcReceivedNote.Enabled = true;
         gbReceivedNote.Enabled = false;

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

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            _currentPosition = bdsPN.Position;
            _buttonAction = ButtonActionType.Add;

            bdsPN.AddNew();

            txtDate.EditValue = DateTime.Now;
            lkeEmployee.EditValue = UtilDB.UserName;

            EnableEditMode();
            txtMaPN.Focus();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            _buttonAction = ButtonActionType.Edit;
            _currentPosition = bdsPN.Position;
            var row = ((DataRowView)bdsPN[_currentPosition]).Row.ItemArray;

            _userDo.Push(new ButtonAction(_buttonAction, row));
            EnableEditMode();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveReceivedNote();
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadTable();
        }

        private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dxErrorProvider.ClearErrors();
            try
            {
                gbReceivedNote.Enabled = false;
                bdsCTPN.CancelEdit();
                bdsPN.ResetCurrentItem();
                bdsPN.Position = _currentPosition;
                _buttonAction = ButtonActionType.None;
            }
            catch (Exception ex)
            {
                UtilDB.ShowError(ex);
            }
            DisableEditMode();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool SaveReceivedNote()
        {
            try
            {
                if (_buttonAction == ButtonActionType.Add)
                {
                    if (IsExistGoodsReceivedNote(txtMaPN.EditValue.ToString()))
                    {
                        XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMaPN.Focus();
                        return false;
                    }
                }

                bdsPN.EndEdit();
                gbReceivedNote.Enabled = false;
                //bdsNV.ResetCurrentItem();
                this.taPN.Update(this.dataSet.PhieuNhap);
                _buttonAction = ButtonActionType.None;
            }
            catch (Exception ex)
            {
                // #load lại từ database
                dataSet.EnforceConstraints = false;
                this.taPN.Fill(this.dataSet.PhieuNhap);
                //dataSet.EnforceConstraints = true;

                UtilDB.ShowError(ex);
                return false;
            }
            bdsPN.Position = _currentPosition;
            DisableEditMode();
            return true;
        }

        private bool IsExistGoodsReceivedNote(string id)
        {
            bool exist = false;
            string strLenh = string.Format(MyConfig.ExecSPTimPhieuNhap, id);
            using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
            {
                connection.Open();
                using (SqlCommand sqlcmd = new SqlCommand(strLenh, connection))
                {
                    sqlcmd.CommandType = CommandType.Text;
                    try
                    {
                        sqlcmd.ExecuteNonQuery();
                        exist = true;
                    }
                    catch (Exception ex)
                    {
                        if (ex is SqlException && (ex as SqlException).Class == MyConfig.ErrorCodeDatabase)
                            exist = false;
                        else
                            UtilDB.ShowError(ex);
                    }
                }
            }
            return exist;
        }

        private void btnAddCTPN_Click(object sender, EventArgs e)
        {

        }
    }
}