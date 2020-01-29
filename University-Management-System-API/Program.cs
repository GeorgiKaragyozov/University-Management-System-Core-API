using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace University_Management_System_API
{
    public class Program
    {
        public static void Main(string[] args) =>
            CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                       .UseUrls("https://localhost:44373");           
                });
    }
}
