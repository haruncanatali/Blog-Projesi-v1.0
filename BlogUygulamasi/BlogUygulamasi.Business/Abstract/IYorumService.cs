using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Abstract
{
    public interface IYorumService
    {
        void AddYorum(Yorum yorum);
        void UpdateYorum(Yorum yorum);
        void DeleteYorum(Yorum yorum);
        Yorum GetYorum(Expression<Func<Yorum, bool>> filter);
        List<Yorum> GetAllYorums(Expression<Func<Yorum, bool>> filter = null);
    }
}
