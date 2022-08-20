﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStockTracking.Models.Entity;

namespace MvcStockTracking.Controllers
{
    public class KategoryController : Controller
    {
        // GET: Kategory
        MvcDbStockEntities db = new MvcDbStockEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLKATEGORI.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniKategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniKategori(TBLKATEGORI p1)
        {
            db.TBLKATEGORI.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}