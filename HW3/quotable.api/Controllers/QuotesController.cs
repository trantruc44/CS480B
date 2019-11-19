using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quotable.core;
using Quote = quotable.api.Models.Quote;
namespace quotable.api.Controllers
{
    /// <summary>
    /// API controller for the '/quotes' resource.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private readonly QuotableContext Context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">The database context to data access.</param>
        public QuotesController(QuotableContext context)
        {
            Context = context;
        }

        // GET api/quotes
        /// <summary>
        /// Returns all the quotes.
        /// </summary>
        /// <returns>All the quotes.</returns>
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return from quote in Context.Quotes
                   select new Quote()
                   {
                       Id = quote.Id,
                       Title = quote.Title,
                       Author = quote.Author
                   };
        }

        // GET api/quotes/5
        /// <summary>
        /// Gets a specific quote.
        /// </summary>
        /// <param name="id">The id of the quote.</param>
        /// <returns>The quote.</returns>
        [HttpGet("{id}")]
        public ActionResult<Quote> Get(long id)
        {
            var quote = Context.Quotes.SingleOrDefault(d => d.Id == id);

            if (quote == null)
            {
                return NotFound();
            }

            return new Quote()
            {
                Id = quote.Id,
                Title = quote.Title,
                Author = quote.Author
            };
        }
    }
}
