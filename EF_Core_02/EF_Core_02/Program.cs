using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EF_Core_02
{
    public class Program
    {
        //DotNet Framework ile EF projeleri yaparken sihirbaz yardýmý ile projemize
        //EF ekleyebiliyorduk.
        //Ancak Core projelerinde sihirbaz yardýmýyla yapabileceðimiz bir yol yok.
        //Bu iþe terminal ekranýndan komutlar yazarak gerçekleþtireceðiz.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
