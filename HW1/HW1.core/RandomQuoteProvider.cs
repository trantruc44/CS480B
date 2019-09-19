using System;
using System.Collections.Generic;

// Author: Truc Tran
// Date: 9/19/2019
// Class: CS480B
namespace hailstone.core
{
    /// <summary>
    /// Defines a RandomQuoteProvider
    /// </summary>
    public interface RandomQuoteProvider
    {
        IEnumerable<string> printNumberOfQuotes(long num);
    }

}