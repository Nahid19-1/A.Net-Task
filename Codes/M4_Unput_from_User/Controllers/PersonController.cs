using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M4_Unput_from_User.Models;
namespace M4_Unput_from_User.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            /* //var and dynamic 
            var a = 12;
            var b = "String";
            var c = new int[] { 1, 2, 3 };

            dynamic f = 1;
            */

            /*
            ViewBag.Name = "S M Nahid"; // viewBag is Dynamic
            ViewBag.Id = 123;
            //ViewBag.Dob = DateTime.Now;

            ViewData["Dob"] = DateTime.Now; //dictionary
            */

            Person p = new Person();
            p.Name = "Tamim";
            p.Id = 555;
            p.Dob = DateTime.Now;

            return View(p);
        }
        public ActionResult List()
        {
            string[] names = { "Nahid", "Kajol", "Sakib", "Anik" };
            ViewBag.Names = names;
            ViewBag.Dob = DateTime.Now;

            List<Person> persons = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                var p = new Person
                {
                    Id = i + 1,
                    Name = "Person" + (i + 1),
                    Dob = DateTime.Now
                };
                persons.Add(p);
            }
            return View(persons);
        }
    }
}