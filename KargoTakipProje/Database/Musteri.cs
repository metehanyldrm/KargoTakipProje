using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KargoTakipProje.Database
{
    public class Musteri
    {
        [Key]
        public int KargoTakipNo { get; set; }
        [StringLength(10)]
        public string SiparisNo { get; set; }
        [StringLength(10)]
        public string UrunInfo { get; set; }
        [StringLength(100)]
        public string Odeme { get; set; }

        public ICollection<Urun>Uruns { get; set; }
        public virtual SaticiFirma SaticiFirma { get; set; }

    }
}