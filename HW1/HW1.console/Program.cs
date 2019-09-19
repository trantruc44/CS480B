using System;
using HW1.core;


// Author: Truc Tran
// Date: 9/19/2019
// Class: CS480B
namespace HW1.console
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleRandomQuoteProvider object1 = new SimpleRandomQuoteProvider();

            if (args.Length > 0)
            {
                Console.WriteLine("Arguments Passed by the Programmer:" + args[0]);
                object1.printNumberOfQuotes(Convert.ToInt64(args[0]));
            }

            else
            {
                Console.WriteLine("No command line arguments found.");
            }

            Console.ReadKey();

            // test code
            object1.printNumberOfQuotes(3);
            //Console.WriteLine("---------------------");
            //object1.printNumberOfQuotes(1);

        }
    }
}
