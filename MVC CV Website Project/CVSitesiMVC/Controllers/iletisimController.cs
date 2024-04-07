using CVSitesiMVC.Models.Entity;
using CVSitesiMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CVSitesiMVC.Controllers
{
    public class iletisimController : Controller
    {
        // GET: iletisim
        GenericRepository<TBLiletisim> repo = new GenericRepository<TBLiletisim>();
        public ActionResult Index()
        {
            var mesajlar = repo.List();
            return View(mesajlar);
        }
    }
}