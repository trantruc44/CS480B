using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.api.Models;
using quotable.core;

namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class quotesController : ControllerBase
    {

        public static quotableData[] quotesObjects = new quotableData[]{
            new quotableData(0, "To be or not to be.", "William Shakespeare"),
            new quotableData(1, "So many books, so little time.", "Frank Zappa"),
            new quotableData(2, "Be the change you wish in the world.", "Mahatma Gandhi"),
            new quotableData(3, "If you tell the truth, you don't have to remember anything.", "Mark Twain"),
            new quotableData(4, "Without music, life would be a mistake.", "Friedrich Nietzsche"),
            new quotableData(5, "We accept the love we think we deserve.", "Stephen Chbosky"),
            new quotableData(6, "The man who does not read has no advantage over the man who cannot read.", "Mark Twain")
            };

        // GET api/quotes
        [HttpGet]
        public ActionResult<quotableData[]> Get()
        {
            return quotesObjects;    
        }

        // GET api/quotes/5
        [HttpGet("{id}")]
        public ActionResult<quotableData> Get(int id)
        {
           return quotesObjects[id];
        }

        // POST api/quotes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/quotes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/quotes/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
