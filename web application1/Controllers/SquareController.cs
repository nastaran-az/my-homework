using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_application1.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// method  recieves id  and then calculate square by Get request
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id*id, for example id= -2 -->4 </returns>
        public int Get(int id)
        {
            return id*id;
        }

    }
}
