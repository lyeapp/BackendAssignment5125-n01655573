using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    /// <summary>
    /// Returns a greeting string showingthe no of people based on the input integer.
    /// </summary>
    /// <param name="id">
    /// The number of people to be greeted
    /// </param>
    /// <returns>
    /// A greeting string in the format "Greetings to {id} people!"
    /// </returns>
    /// <example>
    ///     GET api/Greetings/3
    ///     Returns "Greetings to 3 people!"
    /// </example>
    /// <example>
    ///     GET api/Greetings/6
    ///     Returns "Greetings to 6 people!"
    /// </example>
    /// <example>
    ///     GET api/Greetings/0
    ///     Returns "Greetings to 0 people!"
    /// </example>

    public class GreetingsController : ApiController
    {
        public string Get(int id)
        {
            // Generate greeting string
            string greetings = $"Greetings to {id} people!";
            //return string
            return greetings;
        }
    }
}
