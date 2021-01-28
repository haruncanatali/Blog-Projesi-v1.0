using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Abstract
{
    public interface IKategoriService
    {
        void AddKategori(Kategori kategori);
        void UpdateKategori(Kategori kategori);
        void DeleteKategori(Kategori kategori);
        Kategori GetKategori(Expression<Func<Kategori, bool>> filter);
        List<Kategori> GetAllKategoris(Expression<Func<Kategori, bool>> filter = null);
    }
}
