using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Bills
    {
        [Key]
        public int BillId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(10)]
        public string BillSerialNo { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(10)]
        public string BillRowNo { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(100)]
        public string TaxAdministration { get; set; }
        public DateTime Hour { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string Submitter { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string Receiver { get; set; }
        public ICollection<BillItem> BillsItem { get; set; }
    }
}