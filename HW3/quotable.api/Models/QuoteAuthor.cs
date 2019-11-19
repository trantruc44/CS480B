using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Author: Truc Tran	
// Date: 11/19/2019	
// Class: CS480B

namespace quotable.api.Models
{
    /// <summary>
    /// Many to many relations between Quote and Author
    /// </summary>
    public class QuoteAuthor
    {
        /// <summary>
        /// A quote's Id in relation to author
        /// </summary>
        public long QuoteId { get; set; }
        /// <summary>
        /// A quote in relation to author
        /// </summary>
        public Quote Quote { get; set; }

        /// <summary>
        /// An Author's Id in relation to Quote
        /// </summary>
        public long AuthorId { get; set; }
        /// <summary>
        /// An author in relation to Quote
        /// </summary>
        public Author Author { get; set; }
    }
}
