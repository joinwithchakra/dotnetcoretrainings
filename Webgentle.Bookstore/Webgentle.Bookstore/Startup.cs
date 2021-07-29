using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Webgentle.Bookstore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //this is an optional method.
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context, next)=>
            //{
            //    await context.Response.WriteAsync("ContentRootPath : " + env.ContentRootPath);
            //    await context.Response.WriteAsync("<br/>");
            //    await context.Response.WriteAsync("WebRootPath : " + env.WebRootPath);
            //    await context.Response.WriteAsync("<br/>");
            //    await context.Response.WriteAsync("WebRootFileProvider : " + env.WebRootFileProvider);
            //    await context.Response.WriteAsync("<br/>");
            //    await context.Response.WriteAsync("ContentRootFileProvider : " + env.ContentRootFileProvider);
            //    await context.Response.WriteAsync("<br/>");

            //    await context.Response.WriteAsync("ApplicationName : " + env.ApplicationName);
            //    await context.Response.WriteAsync("<br/>");
            //    await context.Response.WriteAsync("ContentRootFileProvider : " + env.ContentRootFileProvider);
            //    await context.Response.WriteAsync("<br/>");
            //    await context.Response.WriteAsync("EnvironmentName : " + env.EnvironmentName);
            //    await context.Response.WriteAsync("<br/>");
            //    await context.Response.WriteAsync("ContentRootPath : " + env.WebRootPath);
            //    await context.Response.WriteAsync("<br/>");

            //    await next();
            //});

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});

                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
