using CVSitesiMVC.Models.Entity;
using CVSitesiMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVSitesiMVC.Controllers
{
    public class HakkimdaController : Controller
    {
        CVSitesiMVCEntities db = new CVSitesiMVCEntities();
        // GET: Hakkimda
        GenericRepository<TBLHakkimda> repo = new GenericRepository<TBLHakkimda>();
        [HttpGet]
        public ActionResult Index()
        {
            var hakkimda = repo.List();
            return View(hakkimda);
        }
        [HttpPost]
        public ActionResult Index(TBLHakkimda p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Ad = p.Ad;
            t.Soyad = p.Soyad;
            t.Adres = p.Adres;
            t.Mail = p.Mail;
            t.Telefon = p.Telefon;
            t.Aciklama = p.Aciklama;
            t.Resim = p.Resim;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}