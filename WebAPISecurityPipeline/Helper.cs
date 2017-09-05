using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Security.Principal;

namespace WebAPISecurityPipeline
{



    public class Helper
    {
        public static void Write(string stage, IPrincipal principal)
        {
            Debug.WriteLine("-----------------" + stage + "------------------");

            if (principal == null || principal.Identity == null || !principal.Identity.IsAuthenticated)
            {
                Debug.Write("Anonymous User");
            }
            else
            {
                Debug.WriteLine("User :" + principal.Identity.IsAuthenticated);
            }

            Debug.WriteLine("\n");
        }
    }
}