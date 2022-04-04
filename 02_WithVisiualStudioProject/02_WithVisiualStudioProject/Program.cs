using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisiualStudioProject
{
    public class Program
    {
        //Aslýnda tüm ASP.NET CORE uygulamalarý birer console uygulamasýdýr.
        //Doðal olarak uygulama çalýþmaya Program.cs dosyasý içindeki main
        //metodu ile baþlar.
        public static void Main(string[] args)
        {
            //Burasý ise uygulamanýn baþlangýç noktasýýdýr.
            //Tüm iþleyiþ bu noktada baþlýyor.
            //CreateHostBuilder metodu çapýrýlarak sunucumuza dair
            //tüm özellikler ,konfigurasyolar belirleniyor ve sonuç
            //buraya döndürülüyor. Dönen sunucu bilgileri ile 
            //uygulama önce Build(derleme) sonra ise Run(çalýþtýrma) ediliyor.
            CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder metodu sunucuyu ayaða kaldýrýrken bir takým
        //konfugürasyonlara ihtiyaç duyar. Bu konfugurusyonlari Startup 
        //classýndan alýr ve kullanýr.

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    //Default olarak oluþturulan bu yapýda, baþlangýç konfigürasyonlari
                    //Startup adýndaki classta yer alýyor. Anca bu isim mecbur deðildir.

                    webBuilder.UseStartup<Startup>();
                });
    }
}
