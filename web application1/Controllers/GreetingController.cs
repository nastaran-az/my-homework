using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_application1.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// method return a string when recieving a post request
        /// </summary>
     
        public String POST()
        {
            return  "Hello World";
        }
    }
}
