using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KargoTakipProje.Database
{
    public class KuryeSayfa
    {
        [Key]
        public int KargoTakipNo { get; set; }
        [StringLength(10)]
        public string MusteriInfo { get; set; }
        [StringLength(50)]
        public string AdresInfo { get; set; }
        [StringLength(150)]
        public int KuryeTel { get; set; }
       
        public virtual Musteri Musteri { get; set; }
       
    }
}