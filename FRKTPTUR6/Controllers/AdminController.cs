using FRKTPTUR6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FRKTPTUR6.Controllers
{
    public class AdminController : Controller
    {
        FRKTPTUREntities db = new FRKTPTUREntities();
        // GET: Admin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Personel avm)
        {
            Personel ad = db.Personel.Where(x => x.KullanıcıAd == avm.KullanıcıAd && x.Sifre == avm.Sifre).SingleOrDefault();
            if (ad!=null)
            {
                Session["ad_id"] = ad.KullanıcıAd.ToString();
                return RedirectToAction("Creat");
            }
            else
            {
                ViewBag.error = "Geçersiz Kullanıcı adı veya Şifre";

            }
            return View();
        }

        public ActionResult Creat()
        {
            if (Session["ad_id"]==null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
    }
}