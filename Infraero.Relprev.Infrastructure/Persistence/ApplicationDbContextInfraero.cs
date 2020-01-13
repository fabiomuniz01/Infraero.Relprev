using Infraero.Relprev.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infraero.Relprev.Infrastructure.Persistence
{
    public class ApplicationDbContextInfraero : IdentityDbContext<WebProfileUser>
    {
        public ApplicationDbContextInfraero(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
