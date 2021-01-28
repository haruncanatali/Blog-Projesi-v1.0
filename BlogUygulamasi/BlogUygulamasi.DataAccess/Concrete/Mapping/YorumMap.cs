using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using BlogUygulamasi.Entities.Concrete;

namespace BlogUygulamasi.DataAccess.Concrete.Mapping
{
    public class YorumMap:EntityTypeConfiguration<Yorum>
    {
        public YorumMap()
        {
            this.HasKey(c => c.YorumId);
            this.Property(c => c.YorumId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.YorumAd).HasMaxLength(100).IsRequired();
            this.Property(c => c.YorumSoyad).HasMaxLength(100).IsRequired();
            this.Property(c => c.YorumMail).HasMaxLength(100).IsRequired();
            this.Property(c => c.YorumIcerik).HasMaxLength(1500).IsRequired();
            this.Property(c => c.YorumTarih).IsRequired();
            this.Property(c => c.YaziId).IsRequired();

            this.ToTable("Yorum");
            this.Property(c => c.YorumId).HasColumnName("YorumId");
            this.Property(c => c.YorumAd).HasColumnName("YorumAd");
            this.Property(c => c.YorumSoyad).HasColumnName("YorumSoyad");
            this.Property(c => c.YorumMail).HasColumnName("YorumMail");
            this.Property(c => c.YorumIcerik).HasColumnName("YorumIcerik");
            this.Property(c => c.YorumTarih).HasColumnName("YorumTarih");
            this.Property(c => c.YaziId).HasColumnName("YaziId");
        }
    }
}
