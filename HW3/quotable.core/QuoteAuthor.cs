﻿using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Many to many relations between the Quote class and the Author class
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