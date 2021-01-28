using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogUygulamasi.WebUI.Controllers
{
    public class YaziController : Controller
    {
        IYaziService _yaziService;

        public YaziController()
        {
            _yaziService = InstanceFactory.GetInstance<IYaziService>();
        }

        public ActionResult Index()
        {
            return View(_yaziService.GetAllYazis());
        }
        public ActionResult Details(int id)
        {
            return View(_yaziService.GetYazi(c => c.YaziId == id));
        }
        public ActionResult ListByCategoryName(int id)
        {
            ViewBag.kategoriId = id;
            return View(_yaziService.GetAllYazis(c => c.KategoriId == id));
        }
    }
}