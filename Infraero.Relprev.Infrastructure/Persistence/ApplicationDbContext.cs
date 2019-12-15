﻿using System;
using Infraero.Relprev.Application.Common.Interfaces;
using Infraero.Relprev.Domain.Common;
using Infraero.Relprev.Domain.Entities;
using Infraero.Relprev.Infrastructure.Identity;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Infraero.Relprev.Infrastructure.Persistence
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<IdentityUser>, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions,
            ICurrentUserService currentUserService) : base(options, operationalStoreOptions)
        {
            _currentUserService = currentUserService;
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<ResponsavelTecnico> ResponsavelTecnicos { get; set; }
        public DbSet<SubLocal> SubLocals { get; set; }








        public DbSet<UnidadeInfraestrutura> UnidadeInfraestrutura { get; set; }

        public virtual DbSet<Ambiente> Ambiente { get; set; }
        public virtual DbSet<AnexoRelato> AnexoRelato { get; set; }
        public virtual DbSet<Assunto> Assunto { get; set; }
        public virtual DbSet<AtribuicaoRelato> AtribuicaoRelato { get; set; }
        public virtual DbSet<ContratoUtilizacaoSistema> ContratoUtilizacaoSistema { get; set; }
        //public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresaLocalidade> EmpresaLocalidade { get; set; }
        public virtual DbSet<EmpresaResponsavelTecnico> EmpresaResponsavelTecnico { get; set; }
        public virtual DbSet<Evento> Evento { get; set; }
        public virtual DbSet<FuncaoSistema> FuncaoSistema { get; set; }
        public virtual DbSet<HistoricoRelato> HistoricoRelato { get; set; }
        public virtual DbSet<Local> Localidade { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<PerfilFuncao> PerfilFuncao { get; set; }
        public virtual DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public virtual DbSet<Relato> Relato { get; set; }
        public virtual DbSet<SituacaoAtribuicaoRelato> SituacaoAtribuicaoRelato { get; set; }
        public virtual DbSet<SituacaoRelato> SituacaoRelato { get; set; }
        public virtual DbSet<SubAmbiente> SubAmbiente { get; set; }
        public virtual DbSet<SubAssunto> SubAssunto { get; set; }
        public virtual DbSet<TipoEvento> TipoEvento { get; set; }
        public virtual DbSet<UsuarioRelprev> UsuarioRelprev { get; set; }
        public virtual DbSet<UsuarioLocalidade> UsuarioLocalidade { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CriadoPor = _currentUserService.UsuarioId;
                        entry.Entity.DataCriacao = new DateTime().Date;
                        break;
                    case EntityState.Modified:
                        entry.Entity.AlteradoPor = _currentUserService.UsuarioId;
                        entry.Entity.DataAlteracao = new DateTime().Date;
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
