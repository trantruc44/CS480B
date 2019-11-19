using System;
using System.Collections.Generic;

// Author: Truc Tran	
// Date: 11/19/2019	
// Class: CS480B


namespace quotable.core
{
    /// <summary>
    /// Author of a quote
    /// </summary>
    public sealed class Author
    {
        /// <summary>
        /// Generic constructor
        /// </summary>
        public Author()
        {

        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        public Author(string firstname, string lastname)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
        }
        /// <summary>
        /// Author's unique Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Author's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Author's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// relation between quote and Author
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthor { get; set; }
    }
}
