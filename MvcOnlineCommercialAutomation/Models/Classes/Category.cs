using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}