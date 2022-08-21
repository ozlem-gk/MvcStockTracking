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
            List<SelectListItem> degerler = (from i in db.TBLKATEGORI.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = i.KATEGORIAD,
                                                 Value = i.KATEGORIID.ToString()
                                             }).ToList();
            ViewBag.dgr = degerler;
            return View();
        }
        public ActionResult YeniUrun(TBLURUN p1)
        {
            var ktg = db.TBLKATEGORI.Where(m => m.KATEGORIID == p1.TBLKATEGORI.KATEGORIID).FirstOrDefault();
            p1.TBLKATEGORI = ktg;
            db.TBLURUN.Add(p1);
            db.SaveChanges();
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult SIL(int id)
        {
            var urun = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}