using BlogUygulamasi.DataAccess.Concrete.Mapping;
using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.DataAccess.Concrete.EntityFramework
{
    public class BlogUygulamasiContext:DbContext
    {
        public DbSet<Admin> Admin { get; set; }
        public DbSet<GununSozu> GununSozu { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<Yazi> Yazi { get; set; }
        public DbSet<Yorum> Yorum { get; set; }

        public BlogUygulamasiContext()
        {
            this.Configuration.LazyLoadingEnabled = false; // 3. soyut tablolarda hatayı önlemek için yazıldı
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Relations

            modelBuilder.Entity<Yorum>().HasRequired(c => c.Yazi).WithMany(c => c.Yorumlar).HasForeignKey(c => c.YaziId);
            modelBuilder.Entity<Yazi>().HasRequired(c => c.Kategori).WithMany(c => c.Yazilar).HasForeignKey(c => c.KategoriId);

            //Mapping

            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new GununSozuMap());
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new YaziMap());
            modelBuilder.Configurations.Add(new YorumMap());
        }
    }
}
