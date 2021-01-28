using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Concrete;
using BlogUygulamasi.DataAccess.Abstract;
using BlogUygulamasi.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.Ninject
{
    class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAdminService>().To<AdminManager>().InTransientScope();
            Bind<IAdminDal>().To<AdminDal>().InTransientScope();

            Bind<IGununSozuService>().To<GununSozuManager>().InTransientScope();
            Bind<IGununSozuDal>().To<GununSozuDal>().InTransientScope();

            Bind<IKategoriService>().To<KategoriManager>().InTransientScope();
            Bind<IKategoriDal>().To<KategoriDal>().InTransientScope();

            Bind<IYaziService>().To<YaziManager>().InTransientScope();
            Bind<IYaziDal>().To<YaziDal>().InTransientScope();

            Bind<IYorumService>().To<YorumManager>().InTransientScope();
            Bind<IYorumDal>().To<YorumDal>().InTransientScope();
        }
    }
}
