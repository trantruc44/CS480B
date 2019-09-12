using System;
using System.Collections.Generic;
using System.Linq;

// Author: Truc Tran
// Date: 9/11/2019
// Class: CS480B

namespace quotable.core
{
    interface RandomQuoteProvider
    {
        IEnumerable<string> printNumberOfQuotes(long num);
    }

    public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        public IEnumerable<string> printNumberOfQuotes(long num)
        {
            int counter = 0;
            IEnumerable<string> quotes = new string[] { "People lie, actions don't", "To be or not to be that is the question",
            "Failure is not a person, it's an event", "Let it go"};

            foreach (string value in quotes)
            {
                //print only the number of requested quotes
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
