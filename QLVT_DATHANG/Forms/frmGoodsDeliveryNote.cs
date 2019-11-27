using System;
using System.Data;

namespace QLVT_DATHANG.Forms
{
   using DevExpress.XtraBars;
   using DevExpress.XtraEditors;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using Utility;

   public partial class frmGoodsDeliveryNote : XtraForm
   {
      private string _currentDeploymentId;
      private int _currentPosition;
      private ButtonActionType _buttonAction;
      private MyStack _userDo;

      public frmGoodsDeliveryNote()
      {
         InitializeComponent();
         SetupControls();
      }

      private void frmGoodsDeliveryNote_Load(object sender, EventArgs e)
      {
            // TODO: This line of code loads data into the 'dataSet.CTPX' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet.DatHang' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataSet.CTPN' table. You can move, or remove it, as needed.

            _buttonAction = ButtonActionType.None;
         _userDo = new MyStack();
         _userDo.StackPushed += userDo_StackPushed;
         _userDo.StackPopped += userDo_StackPopped;

         LoadTable();
         DisableEditMode();

         _currentDeploymentId = ((DataRowView)bdsPX[0])["MAPX"].ToString().Trim();

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
         //string nameRegex = "[\u0000-\u001F\007F-\u009F]+(\\s{1}[\u0000-\u001F\007F-\u009F]+)*"; // regex with one space between 2 character

         //txtEmpId.Properties.Mask.MaskType = MaskType.RegEx;
         //txtEmpId.Properties.Mask.EditMask = "\\d+";
         //txtEmpId.Properties.Mask.BeepOnError = true;
         //txtEmpId.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpId.Properties.NullValuePrompt = "Id here";

         //txtEmpFirstName.Properties.Mask.MaskType = MaskType.None;
         //txtEmpFirstName.Properties.Mask.EditMask = nameRegex;
         //txtEmpFirstName.Properties.Mask.BeepOnError = true;
         //txtEmpFirstName.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpFirstName.Properties.NullValuePrompt = "First name here";

         //txtEmpLastName.Properties.Mask.MaskType = MaskType.None;
         //txtEmpLastName.Properties.Mask.EditMask = nameRegex;
         //txtEmpLastName.Properties.Mask.BeepOnError = true;
         //txtEmpLastName.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpLastName.Properties.NullValuePrompt = "Last name here";

         //txtEmpAddr.Properties.Mask.BeepOnError = true;
         //txtEmpAddr.Properties.AllowNullInput = DefaultBoolean.True;
         //////txtEmpAddr.Properties.NullValuePrompt = "Address here";

         //spiEmpSalary.Properties.Mask.MaskType = MaskType.Numeric;
         ////spiEmpSalary.Properties.MinValue = CommonCons.MinSalary;
         //spiEmpSalary.Properties.Increment = 100000;
         //spiEmpSalary.Properties.Mask.BeepOnError = true;
         //spiEmpSalary.Properties.AllowNullInput = DefaultBoolean.True;
         ////spiEmpSalary.Properties.NullValuePrompt = $"Min {CommonCons.MinSalary}";

         //dtpEmpBirth.Properties.Mask.MaskType = MaskType.DateTime;
         //dtpEmpBirth.Properties.Mask.EditMask = "dd//MM//yyyy";
         //dtpEmpBirth.Properties.MaxValue = DateTime.Today.AddDays(-1);
         //dtpEmpBirth.Properties.Mask.BeepOnError = true;
         //dtpEmpBirth.Properties.AllowNullInput = DefaultBoolean.True;
         ////dtpEmpBirth.Properties.NullValuePrompt = "Pick a day";
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
         this.taPX.Connection.ConnectionString =
                this.taDSNV.Connection.ConnectionString =
                this.taCTPX.Connection.ConnectionString =
            UtilDB.ConnectionString;
         try
         {
            this.dataSet.EnforceConstraints = false;

            this.taPX.Fill(this.dataSet.PhieuXuat);

                this.taCTPX.Fill(this.dataSet.CTPX);

                this.taDSNV.Fill(this.dataSet.DSNV);

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

            gcDeliveryNote.Enabled = false;
            gbDeliveryNote.Enabled = true;

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
            btnDel.Enabled = (bdsPX.Count == 0) ? false : true;

            gcDeliveryNote.Enabled = true;
            gbDeliveryNote.Enabled = false;

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
            _currentPosition = bdsPX.Position;
            _buttonAction = ButtonActionType.Add;

            bdsPX.AddNew();

            txtDate.EditValue = DateTime.Now;
            lkeEmployee.EditValue = UtilDB.UserName;

            EnableEditMode();
            txtPX.Focus();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveDeliveryNote();
        }

        private bool SaveDeliveryNote()
        {
            try
            {
                if (_buttonAction == ButtonActionType.Add)
                {
                    if (IsExistGoodsDeliveryNote(txtPX.EditValue.ToString()))
                    {
                        XtraMessageBox.Show(Cons.ErrorDuplicateOrderId, Cons.CaptionWarning,
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPX.Focus();
                        return false;
                    }
                }

                bdsPX.EndEdit();
                gbDeliveryNote.Enabled = false;
                //bdsNV.ResetCurrentItem();
                this.taPX.Update(this.dataSet.PhieuXuat);
                _buttonAction = ButtonActionType.None;
            }
            catch (Exception ex)
            {
                // #load lại từ database
                dataSet.EnforceConstraints = false;
                this.taPX.Fill(this.dataSet.PhieuXuat);
                //dataSet.EnforceConstraints = true;

                UtilDB.ShowError(ex);
                return false;
            }
            bdsPX.Position = _currentPosition;
            DisableEditMode();
            return true;
        }

        private bool IsExistGoodsDeliveryNote(string id)
        {
            bool exist = false;
            string strLenh = string.Format(MyConfig.ExecSPTimPhieuXuat, id);
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

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadTable();
        }

        private void btnCancelEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            dxErrorProvider.ClearErrors();
            try
            {
                gbDeliveryNote.Enabled = false;
                bdsCTPX.CancelEdit();
                bdsPX.ResetCurrentItem();
                bdsPX.Position = _currentPosition;
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

        private void btnAddCTPX_Click(object sender, EventArgs e)
        {

        }
    }
}