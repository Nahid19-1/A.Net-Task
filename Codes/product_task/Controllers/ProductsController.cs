using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using product_task.Models.Database;

namespace product_task.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            productsEntities1 db = new productsEntities1();
            var data = db.productsscs.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(productssc p)
        {
            if(ModelState.IsValid)
            {
                productsEntities1 db = new productsEntities1();
                db.productsscs.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(p);
        }

        [HttpGet]
        public ActionResult AddToCart()
        {
            return View();
        }
    }
}