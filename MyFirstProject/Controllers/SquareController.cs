using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    public class SquareController : ApiController
    {
        /// <summary>
        /// Returns square of input integer
        /// </summary>
        /// <param name="id">
        /// integer to be squared
        /// </param>
        /// <returns>
        /// Square of input integer
        /// </returns>
        /// <example>
        ///     GET api/Square/2
        ///     Returns 4
        /// </example>
        /// <example>
        ///     GET api/Square/-2
        ///     Returns 4
        /// </example>
        /// <example>
        ///     GET api/Square/10
        ///     Returns 100
        /// </example>
        public int Get(int id)
        {
            //calculate  square of input integer
            int square = id * id;
            //return result
            return square;
        }
    }
}
