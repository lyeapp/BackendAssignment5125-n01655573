using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    public class HostingCostController : ApiController
    {/// <summary>
     /// Calculate hosting cost based on the number of days elapsed since the beginning of hosting.
     /// </summary>
     /// <param name="id">
     /// Number of days
     /// </param>
     /// <returns>
     /// strings describing the total hosting cost
     /// </returns>
     ///  <example>
     ///     GET api/HostingCost/0
     ///     Returns 1 fortnights at $5.5/FN = $5.5 CADHST 13% = $0.715 CADTotal = $6.215 CAD
     /// </example>
     /// <example>
     ///     GET api/HostingCost/14
     ///     Returns 2 fortnights at $5.5/FN = $11 CADHST 13% = $1.43 CADTotal = $12.43 CAD
     /// </example>
     ///  <example>
     ///     GET api/HostingCost/15
     ///     Returns 2 fortnights at $5.5/FN = $11 CADHST 13% = $1.43 CADTotal = $12.43 CAD
     /// </example>
     ///  <example>
     ///     GET api/HostingCost/21
     ///     Returns 2 fortnights at $5.5/FN = $11 CADHST 13% = $1.43 CADTotal = $12.43 CAD
     /// </example>
     ///  <example>
     ///     GET api/HostingCost/28
     ///     Returns 3 fortnights at $5.5/FN = $16.5 CADHST 13% = $2.145 CADTotal = $18.645 CAD
     /// </example>
        public string Get(double id)
        {
            //calculating number of fornights
            double fortnights = Math.Floor((id / 14.0) + 1);     
            // Cost of hosting a website for a fornight =5.5CAD
            double costPerFortnight = 5.50;
            //HST is 13%
            double hstRate = 0.13;

            //calculate hosting cost
            double hostingCost = fortnights * costPerFortnight;
            //calculate total hst 
            double  hst = hostingCost * hstRate;
            //calculate total cost
            double totalCost = hostingCost + hst;
            
            // Prepare response strings
            string response1 = $"{fortnights} fortnights at ${costPerFortnight}/FN = ${hostingCost} CAD";
            string response2= $"HST {hstRate * 100}% = ${hst} CAD";
            string response3 = $"Total = ${totalCost} CAD";
            string result = response1 + response2 + response3;

            //Return the result
            return result;
        }
    }
}
