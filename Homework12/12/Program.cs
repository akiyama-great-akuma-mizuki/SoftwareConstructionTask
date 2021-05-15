using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrderSystem;
namespace todoapi
{
    public class Program
    {
        public static List<Product> productList = new List<Product>();
        
        public static void Main(string[] args)
        {
            productList.Add(new Product("lemon", 10));
            productList.Add(new Product("suika", 30));
            productList.Add(new Product("guitar", 100));
            productList.Add(new Product("sukiyaki", 100));
            productList.Add(new Product("sushi", 50));
            CreateHostBuilder(args).Build().Run();
            new INFO();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
