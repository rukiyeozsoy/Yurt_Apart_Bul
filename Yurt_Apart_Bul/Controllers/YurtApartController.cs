using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yurt_Apart_Bul.Models.Siniflar;
namespace Yurt_Apart_Bul.Controllers
{
    public class YurtApartController : Controller
    {
        Context c = new Context();
        YurtApartYorum yay = new YurtApartYorum();
        public ActionResult Index()
        {
            yay.Deger1 = c.YurtAparts.ToList();
            yay.Deger3 = c.YurtAparts.Take(3).ToList();
            return View(yay);
        }
        public ActionResult Detays(int id)
        {
            yay.Deger1 = c.YurtAparts.Where(x => x.ID == id).ToList();
            yay.Deger2 = c.Yorumlars.Where(x => x.YurtApartID == id).ToList();
            return View(yay);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.degerler = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.Yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}