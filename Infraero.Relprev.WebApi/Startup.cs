using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infraero.Relprev.Application;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Infrastructure.Persistence;
using Infraero.Relprev.WebApi.Common;
using Infraero.Relprev.WebApi.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace Infraero.Relprev.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddControllers();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddSwaggerGen(c => {

                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Relprev",
                        Version = "v1",
                        Description = "API REST criada com o ASP.NET Core 3.1 para consulta ao Relprev",
                        Contact = new OpenApiContact
                        {
                            Name = "binnovation.ntitsolutions",
                            Url = new Uri("https://github.com/ntitsolutions")
                        }
                    });
            });

            //services.AddApplication();
            //services.AddInfrastructure(Configuration, Environment);

            //services.AddScoped<ICurrentUserService, CurrentUserService>();

            //services.AddHttpContextAccessor();

            //services.AddHealthChecks()
            //    .AddDbContextCheck<ApplicationDbContext>();
            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //app.UseCustomExceptionHandler();
            //app.UseHealthChecks("/health");

            app.UseHttpsRedirection();
            //app.UseStaticFiles();
            //app.UseRouting();
            app.UseMvc();
        }
    }
}
