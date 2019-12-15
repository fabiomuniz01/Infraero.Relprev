using Infraero.Relprev.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Infraero.Relprev.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Domain.Entities.Usuario> Usuarios { get; set; }
        DbSet<Domain.Entities.Empresa> Empresas { get; set; }

        DbSet<UnidadeInfraestrutura> UnidadeInfraestruturas { get; set; }
        DbSet<Domain.Entities.Assunto> Assuntos { get; set; }
        DbSet<Domain.Entities.SubAssunto> SubAssuntos { get; set; }


        DbSet<Domain.Entities.ResponsavelTecnico> ResponsavelTecnicos { get; set; }
        DbSet<Domain.Entities.SubLocal> SubLocals { get; set; }

        DbSet<Domain.Entities.Local> Locals { get; set; }



        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
