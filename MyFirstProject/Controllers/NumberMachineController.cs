using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstProject.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Applies four mathematical operations (addition, subtraction, multiplication, and division) to the input integer.

        /// </summary>
        /// <param name="id">
        /// input integer for mathematical operations
        /// </param>
        /// <returns>
        /// result obtained after the 4 mathematical operations
        /// </returns>
        /// <example>   
        ///     GET api/NumberMachine/10
        ///     Returns 47.5
        /// </example>
        /// <example>
        ///     GET api/NumberMachine/-5
        ///     Returns 10
        /// </example>
        /// <example>
        ///     GET api/NumberMachine/30
        ///     Returns 97.5
        /// </example>
        public float Get(int id)
        {   
            //adding 14 to input integer
            float sum = id + 14;
            //subtracting 5 
            float diff = sum - 5;
            //multiply by 25
            float product = diff * 25;
            //divide  by 10
            float div= product/10;
           
           //return result
            return div;
        }
    }
}
