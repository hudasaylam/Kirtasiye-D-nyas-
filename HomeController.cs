using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using KirtasiyeDunayasi.Models;
namespace KirtasiyeDunayasi.Controllers
{
    public class HomeController : Controller
    {
        KirtasiyeParkEntities1 db = new KirtasiyeParkEntities1();

        public ActionResult HomePage()
        {
            return View();
        }


        public ActionResult urun(int urunid)
        {
            var urun = db.Uruns.FirstOrDefault(u => u.UrunID == urunid);
            if (urun == null)
            {
                return HttpNotFound();
            }

            return View("urun" , urun);
        }




        public ActionResult Okul(int selectedCategoryId)
        {
            var uruns = db.Uruns.Where(u => u.KategoriID == selectedCategoryId).ToList();

            return View("UrunListesi" ,  uruns);
        }

        public ActionResult Ofis(int selectedCategoryId)
        {
            var uruns = db.Uruns.Where(u => u.KategoriID == selectedCategoryId).ToList();

            return View("UrunListesi", uruns);
        }


        public ActionResult Teknoloji(int selectedCategoryId)
        {
            var uruns = db.Uruns.Where(u => u.KategoriID == selectedCategoryId).ToList();

            return View("UrunListesi", uruns);
          
        }

        public ActionResult Sanat(int selectedCategoryId)
        {
            var uruns = db.Uruns.Where(u => u.KategoriID == selectedCategoryId).ToList();

            return View("UrunListesi", uruns);
        }
        public ActionResult Oyuncak(int selectedCategoryId)
        {
            var uruns = db.Uruns.Where(u => u.KategoriID == selectedCategoryId).ToList();

            return View("UrunListesi", uruns);
        }
       


        }
}