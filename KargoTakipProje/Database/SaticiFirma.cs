using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KargoTakipProje.Database
{
    public class SaticiFirma
    {
        [Key]
        public int UrunKodu { get; set; }
        [StringLength(10)]
        public string UrunName { get; set; }
        [StringLength(20)]
        public string UrunDescription { get; set; }
        [StringLength(20)]
        public string SiparisNo { get; set; }
        [StringLength(10)]
        public string UrunInfo { get; set; }
        [StringLength(100)]
        public string Odeme { get; set; }
        public string AdresInfo { get; set; }
        [StringLength(150)]
        public string MusteriInfo { get; set; }
        [StringLength(50)]
        public int KargoSecenek { get; set; }
        [StringLength(3)]
        public bool UrunStatus { get; set; }

        public virtual KargoFirma KargoFirma { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual KuryeSayfa KuryeSayfa { get; set; }
        public virtual Tedarikci Tedarikci { get; set; }

    }
}