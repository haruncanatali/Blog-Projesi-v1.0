using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Abstract
{
    public interface IYaziService
    {
        void AddYazi(Yazi yazi);
        void UpdateYazi(Yazi yazi);
        void DeleteYazi(Yazi yazi);
        Yazi GetYazi(Expression<Func<Yazi, bool>> filter);
        List<Yazi> GetAllYazis(Expression<Func<Yazi, bool>> filter = null);
    }
}
