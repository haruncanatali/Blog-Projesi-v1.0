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
    public class YaziManager : IYaziService
    {
        IYaziDal _dal;

        public YaziManager(IYaziDal x)
        {
            _dal = x;
        }

        public void AddYazi(Yazi yazi)
        {
            ValidationTool.Validate(new YaziValidator(), yazi);
            _dal.Add(yazi);
        }

        public void DeleteYazi(Yazi yazi)
        {
            _dal.Delete(yazi);
        }

        public List<Yazi> GetAllYazis(Expression<Func<Yazi, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public Yazi GetYazi(Expression<Func<Yazi, bool>> filter)
        {
            return _dal.Get(filter);
        }

        public void UpdateYazi(Yazi yazi)
        {
            ValidationTool.Validate(new YaziValidator(), yazi);
            _dal.Update(yazi);
        }
    }
}
