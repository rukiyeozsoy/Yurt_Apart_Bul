using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yurt_Apart_Bul.Models.Siniflar;
namespace Yurt_Apart_Bul.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.YurtAparts.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniYurt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYurt(YurtApart p)
        {
            c.YurtAparts.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YurtSil(int id)
        {
            var b = c.YurtAparts.Find(id);
            c.YurtAparts.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YurtGetir(int id)
        {
            var y = c.YurtAparts.Find(id);
            return View("YurtGetir", y);
        }
        public ActionResult YurtGuncelle(YurtApart yurt)
        {
            var ya = c.YurtAparts.Find(yurt.ID);
            ya.Aciklama = yurt.Aciklama;
            ya.Baslik = yurt.Baslik;
            ya.YurtApartUrl = yurt.YurtApartUrl;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult YorumSil(int id)
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yr = c.Yorumlars.Find(id);
            return View("YorumGetir", yr);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yrm = c.Yorumlars.Find(y.ID);
            yrm.KullaniciAdi = yrm.KullaniciAdi;
            yrm.Mail = yrm.Mail;
            yrm.Yorum = yrm.Yorum;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }
    }
}