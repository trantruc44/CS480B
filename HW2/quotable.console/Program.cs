using System;
using System.Collections.Generic;
using quotable.api.Controllers;
using quotable.core;

// Author: Truc Tran
// Date: 9/19/2019
// Class: CS480B
namespace quotable.console
{
    /// <summary>
    /// Contains 2 objects: SimpleRandomQuoteProvider and DefaultRandomQuoteGenerator
    /// Both calls printNumberOfQuotes 
    /// </summary>
    class Program
    { 
         private static void Main(string[] args)
        {

            var controller = new quotesController();
            var actual2 = controller.Get();
            Console.WriteLine(actual2.Value);

            IEnumerable<string> quotesList = new string[] { "quote1", "quote2", "quote3", "quote4", "quote5", "quotes6"};
            SimpleRandomQuoteProvider object1 = new SimpleRandomQuoteProvider();
            DefaultRandomQuoteGenerator object2 = new DefaultRandomQuoteGenerator(quotesList);

            if (args.Length > 0)
            {
                Console.WriteLine("Number of quotes wanted (enter a number):" + args[0]);
                object1.printNumberofQuotes(Convert.ToInt64(args[0]));
                object2.printNumberofQuotes(Convert.ToInt64(args[0]));
            }

            else
            {
                Console.WriteLine("No command line arguments found.");
            }

            Console.ReadKey();

            // test code to see if simpleRandomQuoteProvider and DefaultRandomQuoteGenerator works
            object1.printNumberofQuotes(3);
            Console.WriteLine("---------------------");
            object2.printNumberofQuotes(4);

        }
    }
}
