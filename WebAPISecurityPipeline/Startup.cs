using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebAPISecurityPipeline.OwinMiddleware;

[assembly: OwinStartup(typeof(WebAPISecurityPipeline.Startup))]
namespace WebAPISecurityPipeline
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //For HttpModule
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);

            //For Middleware
            app.Use(typeof(TestMiddleware));

            //For Controller
            app.UseWebApi(config);
        }
    }
}