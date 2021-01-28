using BlogUygulamasi.Business.Abstract;
using BlogUygulamasi.Business.Ninject;
using BlogUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogUygulamasi.WebUI.Controllers
{
    public class YorumController : Controller
    {

        IYorumService _yaziService;

        public YorumController()
        {
            _yaziService = InstanceFactory.GetInstance<IYorumService>();
        }

        // GET: Yorum
        public RedirectResult YorumYap(string pageUrl,string adTxt,string soyadTxt,string mailTxt,string yorumTxt,int yaziId)
        {

            try
            {
                _yaziService.AddYorum(new Yorum
                {
                    YaziId = yaziId,
                    YorumTarih = DateTime.Now,
                    YorumAd = adTxt,
                    YorumSoyad = soyadTxt,
                    YorumMail = mailTxt,
                    YorumIcerik = yorumTxt
                });
                return Redirect(pageUrl);
            }
            catch (Exception e)
            {
                return Redirect(pageUrl);
            }

        }
    }
}