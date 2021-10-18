using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineCommercialAutomation.Models.Class
{
    public class Cariler
    {
        [Key]
        public int CariId { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30,ErrorMessage ="En fazla 30 karakter yazabilirsiniz")]
        public string CariName { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(30)]
        [Required(ErrorMessage ="Soyadı Boş Geçemezsin!")]
        public string CariSurname { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(15)]
        public string CariCity { get; set; }
        [Column(TypeName = "Nvarchar")]
        [StringLength(50)]
        public string CariMail { get; set; }
        public bool Status { get; set; }
        public ICollection<SaleOperation> SaleOperations { get; set; }

    }
}