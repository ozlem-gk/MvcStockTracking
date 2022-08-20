using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStockTracking.Models.Entity;

namespace MvcStockTracking.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLURUN.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniUrun()
        {
            return View();
        }
        public ActionResult YeniUrun(TBLURUN p1)
        {
            db.TBLURUN.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}