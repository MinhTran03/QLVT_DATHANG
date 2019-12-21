using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DATHANG.UserControls
{
   public partial class frmSwitchDepartment : XtraUserControl
   {
      public bool isSuccess = false;

      public frmSwitchDepartment(int employeeId, string employeeName)
      {
         InitializeComponent();

         txtEmployeeId.ReadOnly = txtEmployeeName.ReadOnly = true;
         txtEmployeeId.EditValue = employeeId;
         txtEmployeeName.EditValue = employeeName;
      }

      private void btnExit_Click(object sender, EventArgs e)
      {
         ((Form)this.TopLevelControl).Close();
      }

      private void SwitchDepartment_Load(object sender, EventArgs e)
      {
         cboDepartment.DataSource = UtilDB.BdsDSPM;
         cboDepartment.DisplayMember = MyConfig.DisplayMemberDSPM;
         cboDepartment.ValueMember = MyConfig.FilterClauseDSPM;
         //cboDepartment.DataBindings.Add(new Binding("Tag", UtilDB.BdsDSPM, MyConfig.FilterClauseDSPM, true));
      }

      private async void btnSwitch_Click(object sender, EventArgs e)
      {
         if (UtilDB.CurrentDeployment == cboDepartment.SelectedIndex)
         {
            XtraMessageBox.Show(Cons.ErrorSwitchDepartToCurrent, Cons.CaptionError,
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         int oldEmployeeId = int.Parse(txtEmployeeId.Text);
         string newDepartId = UtilDB.GetDepartIdInFilterClause(cboDepartment.SelectedValue.ToString());

         if (await SwitchDepartment(oldEmployeeId, newDepartId) == false)
         {
            XtraMessageBox.Show(Cons.ErrorSwitchDepart, Cons.CaptionError,
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            XtraMessageBox.Show(Cons.SuccessSwitchDepart, Cons.CaptionSuccess,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            isSuccess = true;
         }
      }

      private async Task<bool> SwitchDepartment(int oldId, string newDepartment)
      {
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand command = new SqlCommand(MyConfig.SpChuyenChiNhanh, connection))
            {
               command.CommandType = CommandType.StoredProcedure;
               command.Parameters.AddWithValue("@manv", oldId);
               command.Parameters.AddWithValue("@chinhanhmoi", newDepartment);

               try
               {
                  await command.ExecuteNonQueryAsync();
                  return true;
               }
               catch (Exception ex)
               {
                  UtilDB.ShowError(ex);
                  return false;
               }
            }
         }
      }
   }
}
