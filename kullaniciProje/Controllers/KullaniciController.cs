using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kullaniciProje.Models.Entity;

namespace kullaniciProje.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        kullaniciProjeEntities1 db = new kullaniciProjeEntities1();
        public ActionResult kullaniciListele()
        {
            var kullanicilar = db.Kullanicilar.ToList();
            return View(kullanicilar);
        }
        [HttpGet]
        public ActionResult kullaniciEkleme()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult kullaniciEkleme(Kullanicilar p1)
        {
            db.Kullanicilar.Add(p1);
            db.SaveChanges();
            return RedirectToAction("kullaniciListele");
        }

        public ActionResult sil(int id)
        {
            var kullaniciSil = db.Kullanicilar.Find(id);
            db.Kullanicilar.Remove(kullaniciSil);
            db.SaveChanges();
            return RedirectToAction("kullaniciListele");
        }

        public ActionResult kullaniciGetir(int id)
        {
            var klncGetir = db.Kullanicilar.Find(id);
            return View("kullaniciGetir", klncGetir);
        }
    }


}