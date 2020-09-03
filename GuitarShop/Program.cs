using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

//Name:     Project 1
//Author:   Ryan Gerhardt
//Date:     9/2/2020

namespace GuitarShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
