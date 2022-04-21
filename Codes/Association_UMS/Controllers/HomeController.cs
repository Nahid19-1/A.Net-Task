using Association_UMS.Auth;
using Association_UMS.Models.Database;
using Association_UMS.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;

namespace Association_UMS.Controllers
{
    public class HomeController : Controller
    {
        [Authorize] //check behind the sceen inside Web.config if user is authenticated or not 
        //[AllowAnonymous]  //can access without authorization
        public ActionResult Index()
        {
           // if (Session["username"].ToString() == null) return RedirectToAction("Login");//without login we can not visit login
           //we will use anotation for Authorization
            
            AssocEntities db = new AssocEntities();
            var dept = (from d in db.Departments where d.Id==1 select d).FirstOrDefault(); //the dept from database whos id is 1
                                                                                           //with above query we can see all data that is related with the Department Id  = 1

            //Automapper between Department and DepartmentModels
            /*
             var config = new MapperConfiguration(cfg => cfg.CreateMap<Department, DepartmentModel>());
             var mapper = new Mapper(config);
             var dp = mapper.Map<DepartmentModel>(dept);
             DepartmentModel de = new DepartmentModel();
             return View(dp);
            */

            
            DepartmentModel de = new DepartmentModel();
            de.Name = dept.Name;
            de.Id = dept.Id;
            return View(dept);
        }

        [HttpGet]
        public ActionResult Login()
        {
            if(User.Identity.IsAuthenticated) { return RedirectToAction("Index"); } //if user authencate take him to Index
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            AssocEntities db = new AssocEntities();
            var data = (from e in db.Users
                        where e.Password.Equals(user.Password) &&
                        e.Username.Equals(user.Username)
                        select e).FirstOrDefault();
            if (data != null)
            {
                //tracing the cookie
                FormsAuthentication.SetAuthCookie(data.Username, true);
                Session["role"] = data.Role;


                //Session["username"] = data.Username;
                return RedirectToAction("Index");
            }

            TempData["msg"] = "Invalid Crdentials"; // we can have this tempdata value in the view
            //TempData store the request upto a subsequence request
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut(); // this will delete value from SetAuthCookie and logout user
            return RedirectToAction("Login");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AdminAccess]  //created by us annotation
        public ActionResult UserList()
        {
            AssocEntities db = new AssocEntities();
            return View(db.Users.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //Automapper between Department and DepartmentCourseModel
        /*
     
        */
        public ActionResult DepartmentCourse()
        {
            AssocEntities db = new AssocEntities();
            var dept = (from d in db.Departments where d.Id == 1 select d).FirstOrDefault();
            var config = new MapperConfiguration(cfg =>
                 {
                     cfg.CreateMap<Department, DepartmentCourseModel>();
                     cfg.CreateMap<Cours,CourseModel>();    
                 }

            );
            var mapper = new Mapper(config);
           var data = mapper.Map<DepartmentCourseModel>(dept);
            return View(data);
        }
    }
}