using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using quotable.api.Models;

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class randomController : ControllerBase
    {
        // GET: api/random
        [HttpGet]
        public ActionResult<quotableData> Get()
        {
            Random rand = new Random();
            int randQuote = rand.Next(7);

            return quoteController.quotesObjects[randQuote];
        }

        // GET: api/random/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/random
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/random/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/random/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
