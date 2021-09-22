using MvcOnlineCommercialAutomation.Models.Class;
using MvcOnlineCommercialAutomation.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class DepartmentController : Controller
    {
        Context context = new Context();
        // GET: Department
        public ActionResult Index()
        {

            var values = context.TblDepartment.Where(x=>x.Status==true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDepartment(Department department)
        {
            context.TblDepartment.Add(department);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteDepartment(int id)
        {
            var p = context.TblDepartment.Find(id);
            p.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");

            
        }
        [HttpGet]
        public ActionResult GetDepartment(int id)
        {
            var p = context.TblDepartment.Find(id);
            return View("GetDepartment",p);
        }
        public ActionResult GetDepartment(Department department)
        {
            var p = context.TblDepartment.Find(department.DepartmentId);
            p.DepartmentName = department.DepartmentName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DepartmentDetail(int id)
        {
            var p = context.TblEmployees.Where(x=>x.DepartmentId == id).ToList();
            var dep = context.TblDepartment.Where(x => x.DepartmentId == id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.v1 = dep;
            return View(p);

        }
        public ActionResult DepartmentEmployeeSale(int id)
        {
            var p = context.TblSaleOperation.Where(x => x.EmployeeId == id).ToList();

            var emp = context.TblEmployees.Where(x => x.EmployeeId == id).Select(y => y.EmployeeName +" " + y.EmployeeSurname).FirstOrDefault();
            ViewBag.v2 = emp;
            return View(p);
        }

    }
}