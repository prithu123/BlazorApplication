using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication.Models;

namespace WebApplication
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            _config = configuration;
        }

        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
         

            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_config.GetConnectionString("EmployeeDbConnection")));
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddTransient<IEmployeeRepository, SQLEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseStaticFiles();
            // app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
            { routes.MapRoute("default", "{controller=Home}/{action=index}/{id?}");
            }
            ); 

                
            
        }
    }
}
