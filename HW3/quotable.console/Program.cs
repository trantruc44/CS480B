using System;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using quotable.core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

// Author: Truc Tran	
// Date: 11/19/2019	
// Class: CS480B


namespace lorem.console
{
    /// <summary>
    /// Driver class for database 
    /// </summary>
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var container = new ServiceCollection();

            // setup to use a sqlite database
            container.AddDbContext<QuotableContext>(options => options.UseSqlite("Data Source=quotable.db"), ServiceLifetime.Transient);

            var provider = container.BuildServiceProvider();

            using (var context = provider.GetService<QuotableContext>())
            {
                await context.Database.EnsureDeletedAsync();

                var dbDidntExist = await context.Database.EnsureCreatedAsync();

                if (dbDidntExist)
                {
                    await PopulateDatabase(context);
                }
            }

            using (var context = provider.GetService<QuotableContext>())
            {
                var quotes = context.Quotes
                                        .Include(q => q.QuoteAuthor)
                                        .ThenInclude(a => a.Author);

                foreach (var quote in quotes)
                {
                    Console.WriteLine($"document.id = {quote.Id}");
                    Console.WriteLine($"document.title = {quote.Title}");

                    foreach (var author in quote.Authors)
					{
						Console.WriteLine($"document.author.id = {author.Id}");
						Console.WriteLine($"document.author.firstname = {author.FirstName}");
						Console.WriteLine($"document.author.lastname = {author.LastName}");
					}

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        private static async Task PopulateDatabase(QuotableContext context)
        {
            var dataset1 = new QuoteAuthor() { Quote = new Quote("To be or not to be.", "William Shakespeare"), Author = new Author("William", "Shakespeare")};
            var dataset2 = new QuoteAuthor() { Quote = new Quote("So many books, so little time.", "Frank Zappa"), Author = new Author("Frank", "Zappa")};
            var dataset3 = new QuoteAuthor() { Quote = new Quote("Be the change you wish in the world.", "Mahatma Gandhi"), Author = new Author("Mahatma", "Gandhi")};
            var dataset4 = new QuoteAuthor() { Quote = new Quote("If you tell the truth, you don't have to remember anything.", "Mark Twain"), Author = new Author("Mark", "Twain")};
            var dataset5 = new QuoteAuthor() { Quote = new Quote("Without music, life would be a mistake.", "Friedrich Nietzsche"), Author = new Author("Friedrich", "Nietzsche")};
            var dataset6 = new QuoteAuthor() { Quote = new Quote("We accept the love we think we deserve.", "Stephen Chbosky"), Author = new Author("Stephen", "Chbosky")};
            var dataset7 = new QuoteAuthor() { Quote = new Quote("The man who does not read has no advantage over the man who cannot read.", "Mark Twain"), Author = new Author("Mark", "Twain")};

            context.AddRange(dataset1, dataset2, dataset3, dataset4, dataset5, dataset6, dataset7);

            await context.SaveChangesAsync();
        }
    }
}
