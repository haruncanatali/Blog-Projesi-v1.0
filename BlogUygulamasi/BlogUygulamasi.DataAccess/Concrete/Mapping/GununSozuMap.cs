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
    public class GununSozuMap:EntityTypeConfiguration<GununSozu>
    {
        public GununSozuMap()
        {
            this.HasKey(c => c.GununSozuId);
            this.Property(c => c.GununSozuId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.GununSozuIcerik).HasMaxLength(250).IsRequired();
            this.Property(c => c.GununSozuSahip).HasMaxLength(50).IsRequired();
            this.Property(c => c.GununSozuTarih).IsRequired();
            this.Property(c => c.GununSozuFotoUrl).IsRequired().HasMaxLength(500);

            this.ToTable("GununSozu");
            this.Property(c => c.GununSozuId).HasColumnName("GununSozuId");
            this.Property(c => c.GununSozuFotoUrl).HasColumnName("GununSozuFotoUrl");
            this.Property(c => c.GununSozuIcerik).HasColumnName("GununSozuIcerik");
            this.Property(c => c.GununSozuSahip).HasColumnName("GununSozuSahip");
            this.Property(c => c.GununSozuTarih).HasColumnName("GununSozuTarih");
        }
    }
}
