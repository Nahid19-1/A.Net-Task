using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.Service;

namespace Presentation_Api.Controllers
{
    [EnableCors("*", "*", "*")]
    public class StudentController : ApiController
    {
        [Route("api/student/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = StudentService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/student/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var st = StudentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
    }
}
