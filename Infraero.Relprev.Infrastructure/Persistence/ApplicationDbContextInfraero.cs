using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Infraero.Relprev.Application;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Common;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Infrastructure.Identity;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infraero.Relprev.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<WebProfileUser>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
        }


        public DbSet<VinculoResponsavelEmpresa> VinculoResponsavelEmpresa { get; set; }

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

        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<UnidadeInfraestrutura> UnidadeInfraestrutura { get; set; }
        public DbSet<VinculoUnidadeEmpresa> VinculoUnidadeEmpresa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ResponsavelTecnico> ResponsavelTecnico { get; set; }
        public DbSet<Local> Local { get; set; }
        public DbSet<SubLocal> SubLocal { get; set; }
        public DbSet<Assunto> Assunto { get; set; }
        public DbSet<SubAssunto> SubAssunto { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Relato> Relato { get; set; }
        public DbSet<RelatoArquivo> RelatoArquivo { get; set; }
        public DbSet<ConfigurarAmbiente> ConfigurarAmbiente { get; set; }
        public DbSet<AtribuicaoRelato> AtribuicaoRelato { get; set; }









        public virtual DbSet<ContratoUtilizacaoSistema> ContratoUtilizacaoSistema { get; set; }
        public virtual DbSet<EmpresaLocalidade> EmpresaLocalidade { get; set; }
        public virtual DbSet<EmpresaResponsavelTecnico> EmpresaResponsavelTecnico { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<FuncaoSistema> FuncaoSistema { get; set; }
        public virtual DbSet<HistoricoRelato> HistoricoRelato { get; set; }
        public virtual DbSet<Local> Localidade { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilFuncao> PerfilFuncao { get; set; }
        public virtual DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public virtual DbSet<SituacaoAtribuicaoRelato> SituacaoAtribuicaoRelato { get; set; }
        public virtual DbSet<SituacaoRelato> SituacaoRelato { get; set; }

        public virtual DbSet<TipoEvento> TipoEvento { get; set; }
        public virtual DbSet<UsuarioLocalidade> UsuarioLocalidade { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            builder.Entity<Modulo>().HasData(
                new Modulo { CodModulo = 1, NomModulo = "UnidadeInfraestrutura", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 2, NomModulo = "Empresa", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 3, NomModulo = "ResponsavelTecnico", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 4, NomModulo = "Assunto", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 5, NomModulo = "SubAssunto", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 6, NomModulo = "Local", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 7, NomModulo = "SubLocal", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 8, NomModulo = "Usuario", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 9, NomModulo = "Perfil", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 10, NomModulo = "Relatos", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 11, NomModulo = "AtribuirResponsavelRelato", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 12, NomModulo = "AtendimentoTecnico", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 13, NomModulo = "ParecerTecnico", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 14, NomModulo = "ContratoSmartStream", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Modulo { CodModulo = 15, NomModulo = "ConfigurarAmbiente", CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) });

            builder.Entity<Funcionalidade>().HasData(
                new Funcionalidade { CodFuncionalidade = 1, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 1, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 2, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 2, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 3, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 3, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 4, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 4, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 5, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 5, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 6, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 6, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 7, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 7, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 8, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 8, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 9, NomFuncionalidade = "Consultar,Incluir,Excluir,Alterar", CodModulo = 9, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 10, NomFuncionalidade = "Consultar,Cadastrar,Classificar,Cancelar,Finalizar", CodModulo = 10, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 11, NomFuncionalidade = "Enviar,Consultar,Incluir,Excluir", CodModulo = 11, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 12, NomFuncionalidade = "Cancelar,Detalhar,Executar,Finalizar,Atribuir", CodModulo = 12, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 13, NomFuncionalidade = "Completar,Avaliar,Responder", CodModulo = 13, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 14, NomFuncionalidade = "Importar,Configurar", CodModulo = 14, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) },
                new Funcionalidade { CodFuncionalidade = 15, NomFuncionalidade = "Consultar,Incluir,Alterar", CodModulo = 15, CriadoPor = "SistemaRelprev", DataCriacao = new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838) }
            );

            base.OnModelCreating(builder);
        }
    }
}

