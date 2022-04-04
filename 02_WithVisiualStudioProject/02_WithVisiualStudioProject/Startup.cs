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
            //Uygulamada kulalnýlacak olan service'lerin eklendiði, bildirildiði
            //ayarlandýðý yerdir.Service modül, kütüphane gibi düþünülebilir.
            //Ayrýca ele alacaðýz.
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //Bu metod uygulamada kullanýlacak olan ara katman veya ara yazýlým diyebiliriz
            //bildirildiði ve ayarlarýn yapýldýpý yerdir. Sýkça MiddleWare olarak anýlýr
            //anýlacaktýr.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Bu middleware routing özelliklerini kullanacaðýmýzý belirtir.
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //EndPoint uygulamaya gelen isteklerin varýþ noktasýný ifade eden þablon yapýsýdr.
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
