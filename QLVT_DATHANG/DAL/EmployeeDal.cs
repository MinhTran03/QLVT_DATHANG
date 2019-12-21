using QLVT_DATHANG.Models;
using QLVT_DATHANG.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT_DATHANG.DAL
{
   public class EmployeeDal
   {
      public async Task<int> AddAsync(Employee employee)
      {
         int maNvMoi = 0;
         using (var connection = new SqlConnection(UtilDB.ConnectionString))
         {
            await connection.OpenAsync();
            using (var command = new SqlCommand(MyConfig.SpThemNhanVien, connection))
            {
               command.CommandType = CommandType.StoredProcedure;
               command.Parameters.AddWithValue("@ho", employee.FirstName);
               command.Parameters.AddWithValue("@ten", employee.LastName);
               command.Parameters.AddWithValue("@diachi", employee.Address);
               command.Parameters.AddWithValue("@ngaysinh", employee.Birth);
               command.Parameters.AddWithValue("@luong", employee.Salary);
               command.Parameters.AddWithValue("@ttx", employee.IsDelete);

               try
               {
                  using (var reader = await command.ExecuteReaderAsync())
                  {
                     while (await reader.ReadAsync())
                     {
                        maNvMoi = reader.GetInt32(0);
                     }
                  }
               }
               catch (Exception ex)
               {
                  throw ex;
               }
            }
         }
         return maNvMoi;
      }
   }
}
