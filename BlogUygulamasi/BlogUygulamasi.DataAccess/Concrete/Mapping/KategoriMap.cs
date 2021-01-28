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
    public class KategoriMap:EntityTypeConfiguration<Kategori>
    {
        public KategoriMap()
        {
            this.HasKey(c => c.KategoriId);
            this.Property(c => c.KategoriId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.KategoriAd).HasMaxLength(60).IsRequired();
            this.Property(c => c.KategoriAciklama).HasMaxLength(2500).IsRequired();

            this.ToTable("Kategori");
            this.Property(c => c.KategoriId).HasColumnName("KategoriId");
            this.Property(c => c.KategoriAd).HasColumnName("KategoriAd");
            this.Property(c => c.KategoriAciklama).HasColumnName("KategoriAciklama");
        }
    }
}
