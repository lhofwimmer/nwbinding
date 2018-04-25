using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwindbinding.Models;
using NorthwindLibrary;

namespace Northwindbinding.Controllers
{
    public class SupplierController : Controller
    {
        NORTHWNDEntities db;
        public SupplierController(NORTHWNDEntities db)
        {
            this.db = db;
        }
        [Route("Supplier/New")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HandleSupplier()
        {
            NewSupplierModel suppModel = new NewSupplierModel();
            TryUpdateModelAsync(suppModel);
            Suppliers s = new Suppliers();
            s.City = suppModel.City;
            s.CompanyName = suppModel.CompanyName;
            s.ContactName = suppModel.ContactName;
            if (suppModel.Country != null) s.Country = suppModel.Country;
            if (suppModel.PostalCode != null) s.PostalCode = (suppModel.PostalCode??0)+"";
            db.Suppliers.Add(s);
            db.SaveChanges();
            return View("Create");
        }
    }
}