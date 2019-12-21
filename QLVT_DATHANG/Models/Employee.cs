using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT_DATHANG.Models
{
   public class Employee
   {
      public int Id { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public string Address { get; set; }
      public DateTime Birth { get; set; }
      public float Salary { get; set; }
      public string DepartmentId { get; set; }
      public int IsDelete { get; set; }
   }
}
