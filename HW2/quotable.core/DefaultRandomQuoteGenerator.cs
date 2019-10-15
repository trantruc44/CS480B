using System;
using System.Collections.Generic;

// Author: Truc Tran
// Date: 10/15/2019
// Class: CS480B

namespace quotable.core
{
    /// <summary>
    /// Implementation of RandomQuoteProvider with constructor of IEnumerable<>
    /// </summary>
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        IEnumerable<string> quotesList;

        /// <summary>
        /// constructor for DefaultRandomQuoteGenerator
        /// </summary>
        /// <param name="quotes"></param>
         public DefaultRandomQuoteGenerator(IEnumerable<string> quotes) {
            quotesList = quotes;
         }

        /// <summary>
        /// prints out random quotes based on number of quotes requested 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public IEnumerable<string> printNumberofQuotes(long num)
        {
            int counter = 0;
            IEnumerable<string> iquotes = quotesList;

            foreach (var iquote in iquotes)
            {
                counter++;
                if (num >= counter)
                {
                    Console.WriteLine(iquote);
                }
            }
            Console.ReadKey();
            return iquotes;
        }
    }
}
