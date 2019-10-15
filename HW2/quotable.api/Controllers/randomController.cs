using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quotable.api.Models;

// Author: Truc Tran
// Date: 10/15/2019
// Class: CS480B

namespace quotable.api.Controllers
{
    /// <summary>
    /// Controller to get a random quote
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class randomController : ControllerBase
    {
        // GET: api/random
        /// <summary>
        /// Gets a random quote from quotesObjects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<quotableData> Get()
        {
            Random rand = new Random();
            int randQuote = rand.Next(7);

            return quotesController.quotesObjects[randQuote];
        }

        // GET: api/random/5
        [HttpGet("{id}", Name = "Get")]
        private string Get(int id)
        {
            return "value";
        }

        // POST: api/random
        [HttpPost]
        private void Post([FromBody] string value)
        {
        }

        // PUT: api/random/5
        [HttpPut("{id}")]
        private void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/random/5
        [HttpDelete("{id}")]
        private void Delete(int id)
        {
        }
    }
}
