using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcOnlineCommercialAutomation.Models.Class;

namespace MvcOnlineCommercialAutomation.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> TblAdmin { get; set; }
        public DbSet<Cariler> TblCarilers { get; set; }
        public DbSet<Department> TblDepartment { get; set; }
        public DbSet<BillItem> TblBıllItem { get; set; }
        public DbSet<Bills> TblBılls { get; set; }
        public DbSet<Expense> TblExpences { get; set; }
        public DbSet<Category> TblCategories { get; set; }
        public DbSet<Employee> TblEmployees { get; set; }
        public DbSet<SaleOperation> TblSaleOperation { get; set; }
        public DbSet<Product> TblProducts { get; set; }
    }
}