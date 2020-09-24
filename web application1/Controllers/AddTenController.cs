using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_application1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// method recieves id as an input and then add ten bey GET request
        /// </summary>
        /// <param name="id"></param>
        /// <returns>id+10, for example id=-1 -->9 </returns>
        public int Get(int id)
        {
            return id+10;
        }

    }
}
