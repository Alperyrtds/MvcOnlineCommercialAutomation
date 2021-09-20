using MvcOnlineCommercialAutomation.Models.Class;
using MvcOnlineCommercialAutomation.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class CategoryController : Controller
    {
        Context context = new Context();
        // GET: Category
        public ActionResult Index()
        {
           var p = context.TblCategories.ToList();
            return View(p);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            context.TblCategories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var p = context.TblCategories.Find(id);
            context.TblCategories.Remove(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult GetCategory(int id)
        {
            var p = context.TblCategories.Find(id);
            return View("GetCategory", p);
        }
        [HttpPost]
        public ActionResult GetCategory(Category c)
        {
            var p = context.TblCategories.Find(c.CategoryId);
            p.CategoryName = c.CategoryName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}