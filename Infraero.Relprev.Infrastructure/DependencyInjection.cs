using System.Collections.Generic;
using System.Security.Claims;
using IdentityModel;
using IdentityServer4.Models;
using IdentityServer4.Test;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.HttpClient.Clients.Implementations;
using Infraero.Relprev.HttpClient.Clients.Interfaces;
using Infraero.Relprev.Infrastructure.Identity;
using Infraero.Relprev.Infrastructure.Persistence;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Infraero.Relprev.Infrastructure.Files;

namespace Infraero.Relprev.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration, IWebHostEnvironment environment)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>());
            services.AddScoped<IEmpresaClient>(provider => provider.GetService<EmpresaClient>());
            services.AddScoped<ILocalClient>(provider => provider.GetService<LocalClient>());
            services.AddScoped<IUnidadeInfraEstruturaClient>(provider => provider.GetService<UnidadeInfraEstruturaClient>());

            if (environment.IsEnvironment("Test"))
            {
                services.AddIdentityServer()
                    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options =>
                    {
                        options.Clients.Add(new Client
                        {
                            ClientId = "Infraero.Relprev.IntegrationTests",
                            AllowedGrantTypes = { GrantType.ResourceOwnerPassword },
                            ClientSecrets = { new Secret("secret".Sha256()) },
                            AllowedScopes = { "Infraero.Relprev.WebUIAPI", "openid", "profile" }
                        });
                    }).AddTestUsers(new List<TestUser>
                    {
                        new TestUser
                        {
                            SubjectId = "f26da293-02fb-4c90-be75-e4aa51e0bb17",
                            Username = "jason@clean-architecture",
                            Password = "Infraero.Relprev!",
                            Claims = new List<Claim>
                            {
                                new Claim(JwtClaimTypes.Email, "jason@clean-architecture")
                            }
                        }
                    });
            }
            else
            {
                //services.AddIdentityServer()
                //    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

                services.AddDefaultIdentity<IdentityUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

                //services.AddTransient<IDateTime, DateTimeService>();
                //services.AddTransient<IIdentityService, IdentityService>();
                //services.AddTransient<IEmpresaClient, EmpresaClient>();
            }

            services.AddAuthentication()
                .AddIdentityServerJwt();

            return services;
        }
    }
}
