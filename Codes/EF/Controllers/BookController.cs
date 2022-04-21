using EF.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index()
        {
            EFEntities db = new EFEntities();
            var data = db.Books.ToList();  //db.Books here we use Select * from Database_ table
            //if we want LINQ then
           /* var data = (from b in db.Books
                       where b.Author.Contains("Humayun")
                       select b).ToList();
            */
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Book b)
        {
            if(ModelState.IsValid)
            {
                EFEntities db = new EFEntities();
                db.Books.Add(b);
                db.SaveChanges(); // after this it will reflect in the database
                return RedirectToAction("Index");
            }
            return View(b);
        }
    }
}