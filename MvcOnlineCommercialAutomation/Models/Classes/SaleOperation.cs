using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class SaleOperation
    {
        [Key]
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int Adet { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }

        public Product Product { get; set; }
        public Cariler Cariler { get; set; }
        public Employee Employee { get; set; }
    }
}