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
    public class GununSozuManager : IGununSozuService
    {

        IGununSozuDal _dal;

        public GununSozuManager(IGununSozuDal x)
        {
            _dal = x;
        }

        public void AddGununSozu(GununSozu gununSozu)
        {
            ValidationTool.Validate(new GununSozuValidator(), gununSozu);
            _dal.Add(gununSozu);
        }

        public void DeleteGununSozu(GununSozu gununSozu)
        {
            _dal.Delete(gununSozu);
        }

        public List<GununSozu> GetAllGununSozus(Expression<Func<GununSozu, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public GununSozu GetGununSozu(Expression<Func<GununSozu, bool>> filter)
        {
            return _dal.Get(filter);
        }

        public void UpdateGununSozu(GununSozu gununSozu)
        {
            ValidationTool.Validate(new GununSozuValidator(), gununSozu);
            _dal.Update(gununSozu);
        }
    }
}
