using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Abstract
{
    public interface IGununSozuService
    {
        void AddGununSozu(GununSozu gununSozu);
        void UpdateGununSozu(GununSozu gununSozu);
        void DeleteGununSozu(GununSozu gununSozu);
        GununSozu GetGununSozu(Expression<Func<GununSozu, bool>> filter);
        List<GununSozu> GetAllGununSozus(Expression<Func<GununSozu, bool>> filter = null);
    }
}
