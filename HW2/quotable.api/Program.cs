using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace quotable.api
{
    /// <summary>
    /// 
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
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
