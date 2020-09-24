using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_application1.Controllers
{
    public class GreetingpeopleController : ApiController
    {
        /// <summary>
        /// method  recieves id  and then Return a string by Get request
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id*id, for example id= -2 -->4 </returns>
        public String Get(int id)
        {
            return "Greeting to " +id+ " people!";
        }
    }
}
