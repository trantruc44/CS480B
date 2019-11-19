using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using quotable.core;

// Author: Truc Tran	
// Date: 11/19/2019	
// Class: CS480B


namespace quotable.api
{
    /// <summary>
    /// Startup class for API
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Congifurates API 
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<QuotableContext>(options => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);
        }

        /// <summary>
        /// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<QuotableContext>();
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
                PopulateDatabase(context);
            }
        }
        private static void PopulateDatabase(QuotableContext context)
        {
            var dataset1 = new QuoteAuthor() { Quote = new Quote("To be or not to be.", "William Shakespeare"), Author = new Author("William", "Shakespeare") };
            var dataset2 = new QuoteAuthor() { Quote = new Quote("So many books, so little time.", "Frank Zappa"), Author = new Author("Frank", "Zappa") };
            var dataset3 = new QuoteAuthor() { Quote = new Quote("Be the change you wish in the world.", "Mahatma Gandhi"), Author = new Author("Mahatma", "Gandhi") };
            var dataset4 = new QuoteAuthor() { Quote = new Quote("If you tell the truth, you don't have to remember anything.", "Mark Twain"), Author = new Author("Mark", "Twain") };
            var dataset5 = new QuoteAuthor() { Quote = new Quote("Without music, life would be a mistake.", "Friedrich Nietzsche"), Author = new Author("Friedrich", "Nietzsche") };
            var dataset6 = new QuoteAuthor() { Quote = new Quote("We accept the love we think we deserve.", "Stephen Chbosky"), Author = new Author("Stephen", "Chbosky") };
            var dataset7 = new QuoteAuthor() { Quote = new Quote("The man who does not read has no advantage over the man who cannot read.", "Mark Twain"), Author = new Author("Mark", "Twain") };

            context.AddRange(dataset1, dataset2, dataset3, dataset4, dataset5, dataset6, dataset7);

            context.SaveChanges();
        }
    }
}
