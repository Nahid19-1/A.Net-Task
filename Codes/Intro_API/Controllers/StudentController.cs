using Intro_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Intro_API.Controllers
{
    public class StudentController : ApiController
    {
        [Route("api/get/student")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {

            return Request.CreateResponse(HttpStatusCode.OK, "All Student");
        }
        [Route("api/create/student")]
        [HttpPost]
        public HttpResponseMessage Create(Student data)
        {

            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/st/{id}")]
        [HttpGet]
        public HttpResponseMessage getStudent(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, "");
        }
    }
}
