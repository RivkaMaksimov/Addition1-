using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using App_Services;
using App_Services.Profiles;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repositories;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace HMO_corona_database
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        IConfiguration config;
        public Startup(IConfiguration config)
        {
            this.config = config;
          


        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(c => { c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()); });
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddServices(config);
            services.AddMvc();
           
            services.AddAutoMapper(typeof(VaccinesProfile)) ;
            services.AddAutoMapper(typeof(CustomersProfile));
            services.AddAutoMapper(typeof(Vaccine_gettingProfile));
            services.AddAutoMapper(typeof(Corona_diseaseProfile));
            //trial :
            //   services.AddScoped<IVaccine_gettingRepository, Vaccine_gettingRepository>();
            services.AddControllers();


        }
      

       




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


           

                
            
          ///  app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
          //  });
            app.UseRouting();


            app.UseAuthentication();


            //app.UseEndpoints(x => x.MapControllers());

            app.UseHttpsRedirection();
            //  app.UseMvc();
            // app.UseCors();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });

        }
      

    }
}
