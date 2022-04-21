using M4_Unput_from_User.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M4_Unput_from_User.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
           if(ModelState.IsValid)
            {
                //database operation
                //return RedirectToAction("Submit"); //same controller only name
                return RedirectToAction("List","Person"); //different controller ""Name of action" ,"which controller"

            }
            return View(s);
        }

        /*
        public ActionResult Submit()
        {
            //ViewBag.Name= Request["Name"]; //this is from httpRequestBase class
            //1st approach(Direct Request veriable ) to take input using the Request class
            
             Student s = new Student();
             s.Name = Request["Name"];
             s.Id = Request["Id"];
             s.Dob = Request["Dob"];
             s.Email = Request["Email"];

             return View(s);
        }
        */

        /*
        public ActionResult Submit(FormCollection form) //all this submitted through form we can recived in the form
            //but out side the form we can not get other information but with the Request we can get other info like get/post
        {
            //2nd approach(FromCollection Obj perameter recived) is using the from collection this is only for MVC (FormCollection)
            Student s = new Student();
            s.Name = form["Name"];
            s.Id = form["Id"];
            s.Dob = form["Dob"];
            s.Email = form["Email"];
            return View(s);
        }
        */
        /*
        public ActionResult Submit(string Name,string Id,string Dob,string Email) 
        {
            //3nd approach(every variable in perameter) is using pasing parameter this paremeters name will be same name as the names of name="" in forms.
            Student s = new Student();
            s.Name = Name;
            s.Id = Id;
            s.Dob =Dob;
            s.Email =Email;
            return View(s);
        }
        */
        [HttpPost] //if the request is post then the Submit section will execute (annotation)
        public ActionResult Submit(Student s)
        {
            //4th approach(model base) class buinding. we will recived an obj of an class in perameter when we will submil the form 
            return View(s);
        }

    } 
}