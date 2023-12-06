using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIAPPLayer.Controllers
{
    public class PersonController : ApiController
    {
        [HttpGet]
        [Route("api/name/{id}")]
        public HttpResponseMessage GetName(int id)
        {
            try {
                var data = PersonService.GetName(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch { 
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
