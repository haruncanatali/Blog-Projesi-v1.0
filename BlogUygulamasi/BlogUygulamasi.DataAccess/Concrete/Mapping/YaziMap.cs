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
    public class YaziMap:EntityTypeConfiguration<Yazi>
    {
        public YaziMap()
        {
            this.HasKey(c => c.YaziId);
            this.Property(c => c.YaziId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.YaziBaslik).HasMaxLength(100).IsRequired();
            this.Property(c => c.YaziResimUrl).HasMaxLength(150).IsRequired();
            this.Property(c => c.YaziIcerik).HasMaxLength(20000).IsRequired();
            this.Property(c => c.YaziYazar).HasMaxLength(100).IsRequired();
            this.Property(c => c.KategoriId).IsRequired();
            this.Property(c => c.YaziTarih).IsRequired();

            this.ToTable("Yazi");
            this.Property(c => c.YaziId).HasColumnName("YaziId");
            this.Property(c => c.YaziBaslik).HasColumnName("YaziBaslik");
            this.Property(c => c.YaziResimUrl).HasColumnName("YaziResimUrl");
            this.Property(c => c.YaziIcerik).HasColumnName("YaziIcerik");
            this.Property(c => c.YaziYazar).HasColumnName("YaziYazar");
            this.Property(c => c.YaziTarih).HasColumnName("YaziTarih");
            this.Property(c => c.KategoriId).HasColumnName("KategoriId");
        }
    }
}
