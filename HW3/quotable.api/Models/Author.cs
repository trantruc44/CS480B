using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    /// <summary>
    /// Model for an author
    /// </summary>
    public class Author
    {
        /// <summary>
		/// Author's first name
		/// </summary>
		public string FirstName { get; set; }

        /// <summary>
        /// Author's last name
        /// </summary>
        public string LastName { get; set; }
    }
}
