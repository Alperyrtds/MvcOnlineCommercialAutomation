using MvcOnlineCommercialAutomation.Models.Class;
using MvcOnlineCommercialAutomation.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        // GET: Product
        public ActionResult Index()
        {
            var p = context.TblProducts.Where(x=>x.Status==true).ToList();
            return View(p);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> value1 = (from x in context.TblCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = value1;
            //List<SelectListItem> value2 = (from x in context.TblProducts.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Group = x.Status,
                                               
            //                               }).ToList();
            return View();

        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            context.TblProducts.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id)
        {
            var p = context.TblProducts.Find(id);
            p.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult GetProduct(int id)
        {
            List<SelectListItem> value1 = (from x in context.TblCategories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v1 = value1;
            var p = context.TblProducts.Find(id);
            return View("GetProduct", p);


        }
        [HttpPost]
        public ActionResult GetProduct(Product product)
        {
            var p = context.TblProducts.Find(product.ProductId);
            p.ProductName = product.ProductName;
            p.Brand = product.Brand;
            p.Stock = product.Stock;
            p.PurchasePrice = product.PurchasePrice;
            p.SalePrice = product.SalePrice;
            p.CategoryId = product.CategoryId;
            p.ProductPicture = product.ProductPicture;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}