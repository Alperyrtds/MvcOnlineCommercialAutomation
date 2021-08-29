using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Bills
    {
        [Key]
        public int BillId { get; set; }
        public string BillSerialNo { get; set; }
        public string BillRowNo { get; set; }
        public DateTime Date { get; set; }
        public string TaxAdministration { get; set; }
        public DateTime Hour { get; set; }
        public string Submitter { get; set; }
        public string Receiver { get; set; }
    }
}