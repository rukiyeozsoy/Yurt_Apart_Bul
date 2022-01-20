using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yurt_Apart_Bul.Models.Siniflar;
namespace Yurt_Apart_Bul.Controllers
{

    public class DefaultController : Controller
    {
        Context c = new Context();
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Index()
        {
            var degerler = c.Sehirlers.Take(5).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Sehirlers.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.Sehirlers.Where(x => x.ID==1).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.Sehirlers.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = c.Sehirlers.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.Sehirlers.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(degerler);
        }
        public ActionResult Index2()
        {
            var degerler = c.Universitelers.Take(5).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial6()
        {
            var degerler = c.Universitelers.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial7()
        {
            var degerler = c.Universitelers.Where(x => x.ID == 1).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial8()
        {
            var degerler = c.Universitelers.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial9()
        {
            var degerler = c.Universitelers.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial10()
        {
            var degerler = c.Universitelers.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(degerler);
        }
        public ActionResult Bilecik()
        {
            var degerler = c.Bileciks.ToList();
            return View(degerler);
        }
        public ActionResult Eskisehir()
        {
            var degerler = c.Eskisehirs.ToList();
            return View(degerler);
        }
        public ActionResult Istanbul()
        {
            var degerler = c.Istanbuls.ToList();
            return View(degerler);
        }
        public ActionResult Izmir()
        {
            var degerler = c.Izmirs.ToList();
            return View(degerler);
        }
        public ActionResult Ankara()
        {
            var degerler = c.Ankaras.ToList();
            return View(degerler);
        }
        public ActionResult Sakarya()
        {
            var degerler = c.Sakaryas.ToList();
            return View(degerler);
        }
        public ActionResult Antalya()
        {
            var degerler = c.Antalyas.ToList();
            return View(degerler);
        }
        public ActionResult Kocaeli()
        {
            var degerler = c.Kocaelis.ToList();
            return View(degerler);
        }
        public ActionResult Bursa()
        {
            var degerler = c.Bursas.ToList();
            return View(degerler);
        }
        public ActionResult Konya()
        {
            var degerler = c.Konyas.ToList();
            return View(degerler);
        }
    }
}