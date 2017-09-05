using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISecurityPipeline.Authentication;
using WebAPISecurityPipeline.Authorization;

namespace WebAPISecurityPipeline.Controllers
{
    [TestAuthenticationFilter]
    [TestAuthorizationFilter]
    public class HomeController : ApiController
    {
        
        public IHttpActionResult Get()
        {
            Helper.Write("Controller", User);
            return Ok();
        }
    }
}
