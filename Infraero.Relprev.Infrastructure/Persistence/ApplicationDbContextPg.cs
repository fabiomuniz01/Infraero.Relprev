using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Common;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Infrastructure.Identity;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infraero.Relprev.Infrastructure.Persistence
{
    public class ApplicationDbContextPg : ApiAuthorizationDbContext<ApplicationUser>, IApplicationDbContextPg
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContextPg(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
        }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.DataCriacao = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.DataAlteracao = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
