using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    public class AddTenController : ApiController
    {/// <summary>
     /// Adds 10 to the input integer.
     /// </summary>
     /// <param name="id">
     /// Iteger to which 10 will be added
     /// </param>
     /// <returns>
     /// Result obatained when 10 is added to input integer
     /// </returns>
     /// <example>
     ///     GET api/AddTen/21
     ///     Returns 31
     /// </example>
     /// <example>
     ///     GET api/AddTen/0
     ///     Returns 10
     /// </example>
     /// <example>
     ///     GET api/AddTen/-9
     ///     Returns 1
     /// </example>


        public int Get(int id)
        {    
            //add 10 to input integer
            int Addten = id + 10;
            //return result
            return Addten;
        }
    }
}
