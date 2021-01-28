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
    public class AdminManager : IAdminService
    {
        IAdminDal _dal;

        public AdminManager(IAdminDal x)
        {
            _dal = x;
        }
        public void AddAdmin(Admin admin)
        {
            ValidationTool.Validate(new AdminValidator(), admin);
            _dal.Add(admin);
        }

        public List<Admin> AllAdmins(Expression<Func<Admin, bool>> filter = null)
        {
            return _dal.GetAll(filter);
        }

        public void DeleteAdmin(Admin admin)
        {
            _dal.Delete(admin);
        }

        public Admin GetAdmin(Expression<Func<Admin, bool>> filter)
        {
            return _dal.Get(filter);
        }

        public void UpdateAdmin(Admin admin)
        {
            ValidationTool.Validate(new AdminValidator(), admin);
            _dal.Update(admin);
        }
    }
}
