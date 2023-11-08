using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        [Route("api/names")]
        public HttpResponseMessage GetNames() {
            var names = new string[] { "Tanvir","Sabbir"};
            return Request.CreateResponse(HttpStatusCode.OK,names);
        }
        [HttpPost]
        [Route("api/test/post")]
        public HttpResponseMessage ffhh() {
            return Request.CreateResponse(HttpStatusCode.OK, "Post received");
        }

        
    }
}
