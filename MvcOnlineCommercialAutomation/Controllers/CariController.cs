using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOnlineCommercialAutomation.Models.Class;
using MvcOnlineCommercialAutomation.Models.Classes;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class CariController : Controller
    {
        Context context = new Context();
        // GET: Cari
        public ActionResult Index()
        {
            var values = context.TblCarilers.Where(x=>x.Status==true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCari()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCari(Cariler c)
        {
            c.Status = true;
            context.TblCarilers.Add(c);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCari(int id)
        {
            var p = context.TblCarilers.Find(id);
            p.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult GetCari(int id)
        {
            var p = context.TblCarilers.Find(id);
            return View("GetCari", p);
        }
        
        public ActionResult UpdateCari(Cariler cari)
        {
            if (!ModelState.IsValid)
            {
                return View("GetCari");
            }
            var p = context.TblCarilers.Find(cari.CariId);
            p.CariName = cari.CariName;
            p.CariSurname = cari.CariSurname;
            p.CariCity = cari.CariCity;
            p.CariMail = cari.CariMail;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}