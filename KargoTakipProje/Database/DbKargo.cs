using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KargoTakipProje.Database
{
    public class DbKargo:DbContext
    {
        public DbSet<SaticiFirma> SaticiFirmas { get; set; }

        public DbSet<KuryeSayfa> KuryeSayfas { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<KargoFirma> KargoFirmas { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<Urun> Uruns { get; set; }
    }
}