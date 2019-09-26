using System;
using System.Collections.Generic;

// Author: Truc Tran
// Date: 9/19/2019
// Class: CS480B
namespace HW1.core
{
    /// <summary>
    /// Defines a RandomQuoteProvider interface with one method
    /// </summary>
    public interface RandomQuoteProvider
    {
        IEnumerable<string> printNumberofQuotes(long num);
    }

}