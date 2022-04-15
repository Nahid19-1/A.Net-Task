using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Admin_Presentation_API.Controllers
{
    [EnableCors("*", "*", "*")]
    public class UserController : ApiController
    {
        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = UserService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/user/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var st = UserService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }
    }
}
