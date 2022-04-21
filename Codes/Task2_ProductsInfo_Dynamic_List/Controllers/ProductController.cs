using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2_ProductsInfo_Dynamic_List.Models;

namespace Task2_ProductsInfo_Dynamic_List.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            Product p = new Product();
            p.Id = 19399981;
            p.Name = "Admin";
            p.PDate = DateTime.Now;
            return View(p);

        }

        public ActionResult List()
        {
            string[] products = { "Burger", "Pizza","Chiken","Mutton", "Fries","Cake","Salad" };
            ViewBag.Names = products;
            ViewBag.PDate = DateTime.Now;
            return View();
        }

    }
}