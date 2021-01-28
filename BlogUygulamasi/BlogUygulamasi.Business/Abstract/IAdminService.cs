using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Abstract
{
    public interface IAdminService
    {
        void AddAdmin(Admin admin);
        void DeleteAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        Admin GetAdmin(Expression<Func<Admin, bool>> filter);
        List<Admin> AllAdmins(Expression<Func<Admin, bool>> filter = null);
    }
}
