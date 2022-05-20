using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KargoTakipProje.Database
{
    public class Tedarikci
    {
        [Key]
        public int UrunKodu { get; set; }
        [StringLength(10)]
        public bool UrunStatus { get; set; }

        public ICollection<SaticiFirma> SaticiFirmas { get; set; }
        

    }
}