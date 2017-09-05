using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Threading.Tasks;

namespace WebAPISecurityPipeline.Authentication
{
    public class TestAuthenticationFilterAttribute : Attribute, IAuthenticationFilter
    {
        public async Task AuthenticateAsync(HttpAuthenticationContext context, System.Threading.CancellationToken cancellationToken)
        {
            Helper.Write("Authentication", context.ActionContext.RequestContext.Principal);
        }

        public async Task ChallengeAsync(HttpAuthenticationChallengeContext context, System.Threading.CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
        }

        public bool AllowMultiple
        {
            get { return false; }
        }
    }
}