using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(10)]
        public string UserName { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string Password { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        public string Authority { get; set; }
    }
}