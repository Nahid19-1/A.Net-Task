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
    public class DeptController : ApiController
    {
        [Route("api/get/department")]
        [HttpGet]
        public List<Department> Get()
        {
            StudentEntities1 db = new StudentEntities1();
            return db.Departments.ToList();

        }

        [Route("api/create/department")]
        [HttpPost]
        public HttpResponseMessage Create(Department data)
        {
            StudentEntities1 db = new StudentEntities1();
            db.Departments.Add(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Department Created");

        }

        [Route("api/delete/department/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            StudentEntities1 db = new StudentEntities1();
            var data = (from d in db.Departments
                        where d.Id == id
                        select d).FirstOrDefault();

            db.Departments.Remove(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Department Deleted");

        }

        [Route("api/edit/department")]
        [HttpPost]
        public HttpResponseMessage Edit(Department data)
        {
            StudentEntities1 db = new StudentEntities1();
            var dept = (from d in db.Departments
                      where d.Id == data.Id
                      select d).FirstOrDefault();

            db.Entry(dept).CurrentValues.SetValues(data);
            db.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "Department Edited");

        }

        /*
        [Route("api/dept/details/{id}")]
        [HttpPost]
        public HttpResponseMessage DeptApi(Department data)
        {
            StudentEntities1 db = new StudentEntities1();
            var dept = (from d in db.Departments
                  
                      select d).ToList();

            return dept;

        }
        */
    }
}
