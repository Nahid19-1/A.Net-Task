using FinalTask_1.Models;
using FinalTask_1.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalTask_1.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/get/student")]
        [HttpGet]
        public List<Student> Get()
        {
            StudentEntities1 db = new StudentEntities1();
            return db.Students.ToList();
        }

        [Route("api/create/student")]
        [HttpPost]
        public HttpResponseMessage Create(Student data)
        {
            StudentEntities1 db = new StudentEntities1();
            db.Students.Add(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Student Created");

        }

        [Route("api/delete/student/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            StudentEntities1 db = new StudentEntities1();
            var data =(from s in db.Students
                       where s.Id == id 
                       select s).FirstOrDefault();
           
            db.Students.Remove(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Student Deleted");

        }

        [Route("api/edit/student")]
        [HttpPost]
        public HttpResponseMessage Edit(Student data)
        {
            StudentEntities1 db = new StudentEntities1();
            var st = (from s in db.Students
                        where s.Id == data.Id
                        select s).FirstOrDefault();

            db.Entry(st).CurrentValues.SetValues(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Student Edited");

        }


    }
}
