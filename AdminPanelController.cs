using KirtasiyeDunayasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KirtasiyeDunayasi.Controllers
{
    public class AdminPanelController : Controller
    {
        public ActionResult AdminPanelHomePage()
        {
            return View();
        }
        public ActionResult Urunler()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddUrun(Urun urun)
        {
            return RedirectToAction("Urunler");
        }

        [HttpPost]
        public ActionResult EditUrun(Urun urun)
        {
            return RedirectToAction("Urunler");
        }

        public ActionResult DeleteUrun(int id)
        {
            return RedirectToAction("Urunler");
        }
    }
}