using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KargoTakipProje.Database
{
    public class Urun
    {
        [Key]
        public string UrunName { get; set; }
        [StringLength(20)]
        public string UrunInfo { get; set; }
        [StringLength(100)]
        public int UrunKodu { get; set; }
        [StringLength(10)]
        
        public string UrunYorum { get; set; }
        [StringLength(200)]
        public string UrunResim { get; set; }
        public bool UrunStatus { get; set; }

        public virtual SaticiFirma SaticiFirma { get; set; }
    }
}