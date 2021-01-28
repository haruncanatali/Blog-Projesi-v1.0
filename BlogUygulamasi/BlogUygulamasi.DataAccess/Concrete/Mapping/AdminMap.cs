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
    public class AdminMap:EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            this.HasKey(c => c.AdminId);
            this.Property(c => c.AdminId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(c => c.AdminUsername).IsRequired().HasMaxLength(10);
            this.Property(c => c.AdminPassword).IsRequired().HasMaxLength(7);

            this.ToTable("Admin");
            this.Property(c => c.AdminId).HasColumnName("AdminId");
            this.Property(c => c.AdminUsername).HasColumnName("AdminUserName");
            this.Property(c => c.AdminPassword).HasColumnName("AdminPassword");

        }
    }
}
