using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    /// <summary>
    /// Returns the string "Hello World!" dduring POST request
    /// </summary>
    /// /// <returns>
    /// The string "Hello World!"
    /// </returns>
    /// <example>
    ///     POST api/string
    ///     Returns "Hello World!"
    /// </example>
    public class StringController : ApiController
    {
        public string Get()
        {
            // Return the string "Hello World!"
            return "Hello World!";
        }
    }
}
