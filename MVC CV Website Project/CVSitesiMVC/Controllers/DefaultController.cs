using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVSitesiMVC.Models.Entity;

namespace CVSitesiMVC.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        CVSitesiMVCEntities db = new CVSitesiMVCEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLHakkimda.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.TBLSosyalMedya.Where(x => x.Durum == true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TBLDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }
        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.TBLEgitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.TBLYeteneklerim.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.TBLHobilerim.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifikalarım()
        {
            var sertifikalar = db.TBLSertifikalarim.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult iletisim(TBLiletisim t)
        {
            t.Tarih =DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBLiletisim.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}