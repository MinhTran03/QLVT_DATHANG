using DevExpress.XtraEditors;
using QLVT_DATHANG.Utility;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLVT_DATHANG.UserControls
{
   public partial class frmSwitchDepartment : XtraUserControl
   {
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

      private void btnSwitch_Click(object sender, EventArgs e)
      {
         if (UtilDB.CurrentDeployment == cboDepartment.SelectedIndex)
         {
            XtraMessageBox.Show(Cons.ErrorSwitchDepartToCurrent, Cons.CaptionError,
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }

         int oldEmployeeId = int.Parse(txtEmployeeId.Text);
         int newEmployeeId = UtilDB.GenerateEmployeeId();
         string newDepartId = GetDepartIdInFilterClause(cboDepartment.SelectedValue.ToString());

         if (SwitchDepartment(oldEmployeeId, newEmployeeId, newDepartId) == false)
         {
            XtraMessageBox.Show(Cons.ErrorSwitchDepart, Cons.CaptionError,
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         else
         {
            XtraMessageBox.Show(Cons.SuccessSwitchDepart, Cons.CaptionSuccess,
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }

      private string GetDepartIdInFilterClause(string filterClause)
      {
         Regex pattern = new Regex(MyConfig.PatternGetDepartId);
         Match match = pattern.Match(filterClause);
         return match.Groups["departId"].Value;
      }

      private bool SwitchDepartment(int oldId, int newId, string newDepartment)
      {
         using (SqlConnection connection = new SqlConnection(UtilDB.ConnectionString))
         {
            connection.Open();
            using (SqlCommand command = new SqlCommand(MyConfig.SpChuyenChiNhanh, connection))
            {
               command.CommandType = CommandType.StoredProcedure;
               command.Parameters.AddWithValue("@manv", oldId);
               command.Parameters.AddWithValue("@manvmoi", newId);
               command.Parameters.AddWithValue("@chinhanhmoi", newDepartment);

               try
               {
                  command.ExecuteNonQuery();
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
