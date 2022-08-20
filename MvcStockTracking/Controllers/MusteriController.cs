using MvcStockTracking.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStockTracking.Models.Entity;

namespace MvcStockTracking.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLMUSTERI.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniMusteri()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult YeniMusteri(TBLMUSTERI p1)
        {
            db.TBLMUSTERI.Add(p1);
            db.SaveChanges();
            return View();
        }

    }
}