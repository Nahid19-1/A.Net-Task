using BLL.Services;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Admin_Presentation_API.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var st = AdminService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/admin/")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var st = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, st);
        }

        [Route("api/admin/Add")]
        [HttpPost]
        public HttpResponseMessage Add(News data)
        {
           
            var st = AdminService.Create(data);
            return Request.CreateResponse(HttpStatusCode.OK, "News Created");

        }

        [Route("api/delete/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var st = AdminService.Remove(id);
            return Request.CreateResponse(HttpStatusCode.OK, "News Deleted");

        }

        [Route("api/edit/admin")]
        [HttpPost]
        public HttpResponseMessage Edit(News data)
        {
            var st = AdminService.Update(data);
            return Request.CreateResponse(HttpStatusCode.OK, "News Edited"); ;

        }

    }
}
