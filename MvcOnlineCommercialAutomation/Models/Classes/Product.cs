﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Column(TypeName="Nvarchar")]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        public short Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(300)]
        public string ProductPicture { get; set; }
        public Category Category { get; set; }
        public ICollection<SaleOperation> SaleOperations { get; set; }
    }
}