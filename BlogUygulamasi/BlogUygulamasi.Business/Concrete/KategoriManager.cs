using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.ValidationTools.FluentValidation;
using BlogUygulamasi.DataAccess.Abstract;
using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {

        IKategoriDal _dal;

        public KategoriManager(IKategoriDal x)
        {
            _dal = x;
        }

        public void AddKategori(Kategori kategori)
        {
            ValidationTool.Validate(new KategoriValidator(), kategori);
            _dal.Add(kategori);
        }

        public void DeleteKategori(Kategori kategori)
        {
            _dal.Delete(kategori);
        }

        public List<Kategori> GetAllKategoris(Expression<Func<Kategori, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public Kategori GetKategori(Expression<Func<Kategori, bool>> filter)
        {
            return _dal.Get(filter);
        }

        public void UpdateKategori(Kategori kategori)
        {
            ValidationTool.Validate(new KategoriValidator(), kategori);
            _dal.Update(kategori);
        }
    }
}
