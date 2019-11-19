using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

// Author: Truc Tran	
// Date: 11/19/2019	
// Class: CS480B

namespace quotable.api.Models
{
    /// <summary>
    /// Model for a quote
    /// </summary>
    public class Quote
    {
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
    }
}
