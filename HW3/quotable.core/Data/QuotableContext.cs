using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

// Author: Truc Tran	
// Date: 11/19/2019	
// Class: CS480B


namespace quotable.core
{
    /// <summary>
    /// Database context provides access to Author, Quote, and QuoteAuthor
    /// </summary>
    public class QuotableContext: DbContext
    {
        /// <summary>
		/// Constructor
		/// </summary>
		public QuotableContext(DbContextOptions options) : base(options)
        {

        }

        /// <summary>
        ///Access all the quotes in the database
        /// </summary>
        public DbSet<Quote> Quotes { get; set; }

        /// <summary>
        /// Access all the authors in the database
        /// </summary>
        public DbSet<Author> Authors { get; set; }

        /// <inheritdoc/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteAuthor>().HasKey(x => new { x.QuoteId, x.AuthorId });
        }
    }
}
