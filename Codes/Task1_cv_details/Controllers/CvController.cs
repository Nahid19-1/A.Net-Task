using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1_cv_details.Controllers
{
    public class CvController : Controller
    {
        // GET: Cv
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Project()
        {
            return View();
        }
        public ActionResult Referance()
        {
            return View();
        }

    }
}