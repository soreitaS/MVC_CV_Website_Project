using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CVSitesiMVC.Models.Entity;
using CVSitesiMVC.Repositories;

namespace CVSitesiMVC.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<TBLHobilerim> repo = new GenericRepository<TBLHobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(TBLHobilerim p)
        {
            var t = repo.Find(x => x.ID == 1);
            t.Aciklama1 = p.Aciklama1;
            t.Aciklama2 = p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}