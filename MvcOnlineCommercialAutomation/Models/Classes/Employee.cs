using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string EmployeeName { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string EmployeeSurname { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(300)]
        public string EmployeeImage { get; set; }

        public ICollection<SaleOperation> SaleOperations { get; set; }
        public Department Department { get; set; }
    }
}