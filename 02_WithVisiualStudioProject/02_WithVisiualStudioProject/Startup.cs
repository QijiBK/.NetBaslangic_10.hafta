using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_WithVisiualStudioProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Uygulamada kulaln�lacak olan service'lerin eklendi�i, bildirildi�i
            //ayarland��� yerdir.Service mod�l, k�t�phane gibi d���n�lebilir.
            //Ayr�ca ele alaca��z.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metod uygulamada kullan�lacak olan ara katman veya ara yaz�l�m diyebiliriz
            //bildirildi�i ve ayarlar�n yap�ld�p� yerdir. S�k�a MiddleWare olarak an�l�r
            //an�lacakt�r.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Bu middleware routing �zelliklerini kullanaca��m�z� belirtir.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //EndPoint uygulamaya gelen isteklerin var�� noktas�n� ifade eden �ablon yap�s�dr.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
