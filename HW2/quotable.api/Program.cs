using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

// Author: Truc Tran
// Date: 10/15/2019
// Class: CS480B

namespace quotable.api
{
    /// <summary>
    /// Driver of quotable.api
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Runs the webpage
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {        
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Builds the webhost
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
