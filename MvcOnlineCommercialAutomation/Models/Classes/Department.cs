using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}