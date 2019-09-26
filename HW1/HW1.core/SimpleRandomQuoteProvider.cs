using System;
using System.Collections.Generic;


// Author: Truc Tran
// Date: 9/19/2019
// Class: CS480B
namespace HW1.core
{
    /// <summary>
    ///  Implementation of RandomQuoteProvider
    /// </summary>
    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        /// <summary>
        /// prints out random quotes based on number of quotes requested 
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public IEnumerable<string> printNumberofQuotes(long num)
        {
            int counter = 0;
            IEnumerable<string> quotes = new string[] { "People lie, actions don't", "To be or not to be that is the question",
            "Failure is not a person, it's an event", "Let it go"};

            //substitute string for var
            foreach (var index in quotes)
            {
                counter++;
                if (num >= counter)
                {
                    Console.WriteLine(index);
                }
            }
            Console.ReadKey();

            return quotes;
        }
    }
}
