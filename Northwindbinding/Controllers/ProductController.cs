using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NorthwindLibrary;
using Northwindbinding.Models;

namespace Northwindbinding.Controllers
{
    public class ProductController : Controller
    {
        NORTHWNDEntities db;
        public ProductController(NORTHWNDEntities db)
        {
            this.db = db;
        }
        

        public IActionResult Create()
        {
            var customPSModel = new CreateFormModel
            {
                Categories = db.Categories.ToList(),
                Suppliers = db.Suppliers.ToList()
            };
            return View("New", customPSModel);
        }

        [HttpPost]
        //[Route("{ProductName}-{UnitPrice}-{QuantityPerUnit}-{Supplier}-{Category}")]
        public ActionResult HandleProduct(string ProductName, decimal UnitPrice, string QuantityPerUnit, string Supplier, string Category)
        {
            Random r = new Random();

            //Products p = new Products
            //{
            //    ProductName = ProductName,
            //    QuantityPerUnit = QuantityPerUnit,
            //    Discontinued = false,
            //    UnitsInStock = Convert.ToInt16(r.Next(100)),
            //    CategoryID = db.Categories.Where(x => x.CategoryName == Category).Select(x => x.CategoryID).First(),
            //    ReorderLevel = Convert.ToInt16(r.Next()),
            //    UnitPrice = UnitPrice,
            //    SupplierID = db.Suppliers.Where(x => x.CompanyName == Supplier).Select(x => x.SupplierID).First(),
            //    UnitsOnOrder = Convert.ToInt16(r.Next(100)),

            //};
            Products p = new Products();
            Task<bool> taskboi = TryUpdateModelAsync(p);
            //bool boi = await taskboi;
            p.UnitsInStock = Convert.ToInt16(r.Next(100));
            

            return View("Edit", p);
        }
    }
}