using System;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.CrossCutting.Models;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Infraero.Relprev.Infrastructure.Services;
using Infraero.Relprev.WebUi.Configuration;
using Infraero.Relprev.WebUi.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartBreadcrumbs.Extensions;

namespace Infraero.Relprev.WebUi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));



            /*****
             * SQLite is used for an easy demo, no database server is required for it to work.
             * You can find the connection strings in appsettings.json
             * 
             * Alternative Database Options.
             *****************************************
             *** Microsoft SQL Server              ***
             * services.AddDbContext<ApplicationDbContext>(options =>
             *    options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));
             * 
             *** MySQL Server                      ***
             * services.AddDbContext<ApplicationDbContext>(options =>
             *     options.UseMySQL();
             *     
             *** SQLite File                       ***
             * services.AddDbContext<ApplicationDbContext>(options =>
             *****/

            // Add functionality to inject IOptions<T>
            services.AddOptions();
            // Load SendGrid settings from appsettings.json
            services.Configure<SendGridSettings>(Configuration.GetSection("SendGrid"));
            services.AddSingleton(Configuration);

            services.AddScoped<ICurrentUserService, CurrentUserService>();

            services.AddDefaultIdentity<WebProfileUser>(config =>
            {
                config.User.RequireUniqueEmail = true;
                config.SignIn.RequireConfirmedEmail = false;
            })
                .AddRoles<IdentityRole>()
                //.AddDefaultUI(UIFramework.Bootstrap4)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 8;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });



            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.Name = "RelprevCookieLogin";
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.LoginPath = "/Identity/Account/Login";
                options.SlidingExpiration = true;
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;


            });

            // Register email service. Configured in appsettings.json
            services.AddTransient<IEmailSender, SendGridEmailService>();

            services.AddBreadcrumbs(GetType().Assembly, options =>
            {
                options.TagName = "small";
                options.TagClasses = "";
                options.OlClasses = "";
                options.LiClasses = "";
                options.ActiveLiClasses = "c-white";
                options.SeparatorElement = "<br >";
            });

            // Register our user in role handler for security
            services.AddSingleton<IAuthorizationHandler, UserInRoleHandler>();

            // Create an admins policy group for high level security requirements
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admins", policy =>
                    policy.Requirements.Add(new UserInRoleRequirement(UserRoles.Administrator)));


                options.AddPolicy(ModuloAccess.Cadastros, policy =>
                    policy.RequireAssertion(context =>
                        context.User.IsInRole(UserRoles.Administrator)
                        || context.User.IsInRole(UserRoles.GestorCorporativo)
                        || context.User.IsInRole(UserRoles.GestorSgsoSite)));

                options.AddPolicy(ModuloAccess.Relatos, policy =>
                    policy.RequireAssertion(context =>
                        context.User.IsInRole(UserRoles.Administrator)
                        || context.User.IsInRole(UserRoles.UsuarioPublico)));

                options.AddPolicy("EmployeeId", policy => policy.RequireClaim("EmployeeId"));

            });

            services.AddMvc().AddRazorPagesOptions(options =>
            {
                // High level pages security setup
                options.Conventions.AllowAnonymousToPage("/Privacy");
                options.Conventions.AllowAnonymousToPage("/Terms");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services.AddMvc(option => option.EnableEndpointRouting = false);

            services.Configure<SettingsModel>(Configuration.GetSection("RelprevSettings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}