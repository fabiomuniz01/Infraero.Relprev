using System;
using Infraero.Relprev.Application;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Infraero.Relprev.Api
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
            services.AddControllers();
            services.AddApplication();
            services.AddInfrastructure(Configuration, Environment);

            services.AddScoped<ICurrentUserService, CurrentUserService>();

            services.AddHttpContextAccessor();

            //services.AddHealthChecks()
            //    .AddDbContextCheck<ApplicationDbContext>();

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

            //Old Way
            //services.AddMvc();
            // New Ways
            services.AddRazorPages();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseRouting();

            app.UseHttpsRedirection();

            //app.UseAuthentication();

            //Replace UseMvc or UseSignalR with UseEndpoints.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }

    public class CurrentUserService : ICurrentUserService
    {
        public string UsuarioId { get; }
    }
}
