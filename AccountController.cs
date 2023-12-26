using KirtasiyeDunayasi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
//metadata=res://*/Models.Model1.csdl|res://*/Models.Model1.ssdl|res://*/Models.Model1.msl;provider=System.Data.SqlClient;provider connection string="data source=HUDASAYLAM;initial catalog=KirtasiyePark;integrated security=True;multipleactiveresultsets=True;trustservercertificate=True;application name=EntityFramework"
namespace KirtasiyeDunayasi.Controllers
{
    public class AccountController : Controller
    {
        KirtasiyeParkEntities1 db = new KirtasiyeParkEntities1();
        [HttpGet]
        public ActionResult Register()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Register(KISI kisiler)
        {
            KULLANCILAR kul = new KULLANCILAR();
            if (ModelState.IsValid)
            {
                if (db.KISIs.Any(x => x.Email == kisiler.Email))
                {

                    ViewBag.Message = " Girdiğiniz Email  Kullanıldı";

                }
                else
                {
                    kisiler.KisiRolu = "Kullanci";

                    db.KISIs.Add(kisiler);
                    db.SaveChanges();

                    Response.Write("<script>alert('başarıyla abone oldunuz ')</script>");

                    return RedirectToAction("HomePage", "Home");




                }


            }
            return View();
        }

            [HttpGet]
            public ActionResult LogIn()
            {


                return View();
            }

            [HttpPost]
            public ActionResult LogIn(LogInModel l)
            {

            var query = db.KISIs.SingleOrDefault(m => m.Email == l.Email && m.Parola == l.Parola);
              if (query != null)
            {
                //   Response.Write("<script>alert('başarıyla Giriş yapıldı')</script>");
                Session["IsLoggedIn"] = true;
                return RedirectToAction("HomePage", "Home");
            }

            else
            {
                Response.Write("<script>alert('Hatalı Giriş')</script>");

            }
            return View();

        }
        public ActionResult Logout()
        {
            Session["IsLoggedIn"] = null;
            return RedirectToAction("HomePage", "Home"); // Redirect to home page after logout
        }






    }
}