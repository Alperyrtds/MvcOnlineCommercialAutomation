using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }
        public string CariName { get; set; }
        public string CariSurname { get; set; }
        public string CariCity { get; set; }
        public string CariMail { get; set; }
    }
}