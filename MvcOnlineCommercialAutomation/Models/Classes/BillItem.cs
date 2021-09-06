using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class BillItem
    {
        [Key]
        public int BillItemId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(100)]
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Price { get; set; }
        public Bills Bills { get; set; }
    }
}