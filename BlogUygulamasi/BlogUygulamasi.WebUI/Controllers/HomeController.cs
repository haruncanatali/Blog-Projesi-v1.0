using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogUygulamasi.WebUI.Controllers
{
    public class HomeController : Controller
    {
        IKategoriService _kategoriService;
        IYorumService _yorumService;
        IYaziService _yaziService;
        IGununSozuService _gununSozuService;

        public HomeController()
        {
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
            _yorumService = InstanceFactory.GetInstance<IYorumService>();
            _yaziService = InstanceFactory.GetInstance<IYaziService>();
            _gununSozuService = InstanceFactory.GetInstance<IGununSozuService>();
        }

        public ActionResult Index()
        {
            return View(_yaziService.GetAllYazis().OrderBy(c => c.YaziTarih).Take(3).ToList());
        }
        public PartialViewResult GununSozu()
        {
            return PartialView(_gununSozuService.GetGununSozu(c=>c.GununSozuTarih.Day == DateTime.Now.Day && c.GununSozuTarih.Month == DateTime.Now.Month && c.GununSozuTarih.Year == DateTime.Now.Year));
        }
        public PartialViewResult Kategori()
        {
            return PartialView(_kategoriService.GetAllKategoris());
        }
        public PartialViewResult SonYorumlar()
        {
            return PartialView(_yorumService.GetAllYorums().OrderByDescending(c=>c.YorumTarih).Take(5).ToList());
        }
        public PartialViewResult SonYazilar()
        {
            return PartialView(_yaziService.GetAllYazis().OrderByDescending(c=>c.YaziTarih).Take(5).ToList());
        }

    }
}