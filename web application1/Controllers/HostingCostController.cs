using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace web_application1.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// calculating cost by Get request,input is days
        /// </summary>
        /// <param name="id"></param>
        /// <returns>3 string output</returns>
        public IEnumerable<string> Get(int id)
        {
            int fornight = id / 14;// id is days, fornight is number of 14 days
            int fornight1 = fornight + 1;//method shoul calculate cost to fornight=0;thus it should be add 1
            double FN = fornight1 * 5.5;//cost before tax
            FN = Math.Round(FN,2);// for 2 decimal place
            double HST = FN * 0.13;//Tax calculation
            HST = Math.Round(HST, 2);//for 2 decimal place
            double total = HST + FN;//final cost after tax
            total = Math.Round(total, 2);
            //we need 3 string output; therefore, some string  is in variable that type is string
            String sfornight = fornight.ToString() + " fornight "+" at 5.5 is " + FN.ToString() + "$";
            String sHST = "HST %13= " + HST.ToString();
            String stotal = "total cost is " + total.ToString();
            return new String[] { sfornight, sHST, stotal };
                
        }
    }
}
