using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStockTracking.Controllers
{
    public class KategoryController : Controller
    {
        // GET: Kategory
        public ActionResult Index()
        {
            return View();
        }
    }
}