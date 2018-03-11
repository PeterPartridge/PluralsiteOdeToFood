using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using PluralsiteOdeToFood.Services;
using PluralsiteOdeToFood.Data;
using Microsoft.EntityFrameworkCore;

namespace PluralsiteOdeToFood
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IGreeter, Greeter>();
            services.AddDbContext<OdeTofoodDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("OdeToFood"))
                );
            services.AddScoped<IRestaurantData, SqlRestaurantData>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IGreeter greet, ILogger<Startup> logger)
        {


            

            if (env.IsDevelopment())
            {
               
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            //string Greet = configuration["Greeting"];

            //app.Use(next => 
            //{
            //    return async context =>
            //    {
            //        logger.LogInformation("Request Incoming");

            //        if (context.Request.Path.StartsWithSegments("/mym"))
            //        {
            //            await context.Response.WriteAsync("hit");
            //        }
            //        else
            //        {
            //            await next(context);
            //            logger.LogInformation("Response outgoing");
            //        }
            //    };
            //});

            //app.UseWelcomePage(new WelcomePageOptions
            //{
            //    Path= "/wp"
            //});

            // app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseMvc(configureRoutes);

            
            //app.UseFileServer();

            app.Run(async (context) =>
            {
             //   throw new Exception("Error");

                string Greet = greet.MessageOfTheDay();
                context.Request.ContentType = "text/plain";
                //await context.Response.WriteAsync($"{Greet} : {env.EnvironmentName}");
                await context.Response.WriteAsync($"Not Found");

            });
        }

        private void configureRoutes(IRouteBuilder routeBuilder)
        {
            //Maproute cannot have spaces in the = section,but if their are spaces the system would look for / home/ Index instead of /home/index.
            routeBuilder.MapRoute("Default","{controller=Home}/{action=Index}/{id?}");
        }
    }
}
