using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Entities.Usuario> Usuario { get; set; }
        DbSet<Domain.Entities.Empresa> Empresa { get; set; }

        DbSet<UnidadeInfraestrutura> UnidadeInfraestrutura { get; set; }
        DbSet<Domain.Entities.Assunto> Assunto { get; set; }
        DbSet<Domain.Entities.SubAssunto> SubAssunto { get; set; }


        DbSet<Domain.Entities.ResponsavelTecnico> ResponsavelTecnico { get; set; }
        DbSet<Domain.Entities.SubLocal> SubLocal { get; set; }

        DbSet<Domain.Entities.Local> Local { get; set; }

        DbSet<Relato> Relato { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
