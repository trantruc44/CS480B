using hailstone.core;
using System;
using System.Collections.Generic;


// Author: Truc Tran
// Date: 9/19/2019
// Class: CS480B
namespace HW1.core
{
    /// <summary>
    /// Simple random quote provider class
    /// </summary>
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        /// <summary>
        /// prints out random quotes based on number of quotes requested 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public IEnumerable<string> printNumberOfQuotes(long num)
        {
            int counter = 0;
            IEnumerable<string> quotes = new string[] { "People lie, actions don't", "To be or not to be that is the question",
            "Failure is not a person, it's an event", "Let it go"};

            foreach (string value in quotes)
            {
                counter++;
                if (num >= counter)
                {
                    Console.WriteLine(value);
                }
            }
            Console.ReadKey();

            return quotes;
        }
    }
}
