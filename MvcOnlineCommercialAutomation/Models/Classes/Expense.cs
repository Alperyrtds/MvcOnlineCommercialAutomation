using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
    }
}