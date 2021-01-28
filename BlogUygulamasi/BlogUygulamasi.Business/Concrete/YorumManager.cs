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
    public class YorumManager : IYorumService
    {

        IYorumDal _dal;

        public YorumManager(IYorumDal x)
        {
            _dal = x;
        }

        public void AddYorum(Yorum yorum)
        {
            ValidationTool.Validate(new YorumValidator(), yorum);
            _dal.Add(yorum);
        }

        public void DeleteYorum(Yorum yorum)
        {
            _dal.Delete(yorum);
        }

        public List<Yorum> GetAllYorums(Expression<Func<Yorum, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public Yorum GetYorum(Expression<Func<Yorum, bool>> filter)
        {
            return _dal.Get(filter);
        }

        public void UpdateYorum(Yorum yorum)
        {
            ValidationTool.Validate(new YorumValidator(), yorum);
            _dal.Update(yorum);
        }
    }
}
