using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Author: Truc Tran
// Date: 10/15/2019
// Class: CS480B

namespace quotable.api.Models
{
    /// <summary>
    /// Stores the required component of a quote: ID, Quote, Author
    /// </summary>
    public class quotableData
    {
        /// <summary>
        /// Get and Set ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Get and Set Quote
        /// </summary>
        public string Quote { get; set; }

        /// <summary>
        /// Get and Set Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Constructor for quotableData
        /// </summary>
        /// <param name="id"></param>
        /// <param name="quote"></param>
        /// <param name="author"></param>
        public quotableData (int id, string quote, string author)
        {
            ID = id;
            Quote = quote;
            Author = author;
        }
    }
}
