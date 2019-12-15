using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Empresa> Empresas { get; set; }
        DbSet<ResponsavelTecnico> ResponsavelTecnicos { get; set; }
        DbSet<SubLocal> SubLocals { get; set; }
        
       

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
