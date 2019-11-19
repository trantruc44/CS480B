using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Quote 
    /// </summary>
    public sealed class Quote
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        public Quote(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }

        /// <summary>
        /// Quote's unique Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The actual quote
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Author of a quote
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// The collection of authors of the document
        /// </summary>
        [NotMapped]
        public IEnumerable<Author> Authors => from x in QuoteAuthor select x.Author;

        /// <summary>
        /// The relation of document to author
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthor { get; set; } = new List<QuoteAuthor>();

    }
}
