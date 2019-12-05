//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace Relprev.Data.Entity
//{
//    public partial class RELPREVContext : DbContext
//    {
//        public RELPREVContext()
//        {
//        }

//        public RELPREVContext(DbContextOptions<RELPREVContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<Ambiente> Ambiente { get; set; }
//        public virtual DbSet<AnexoRelato> AnexoRelato { get; set; }
//        public virtual DbSet<Assunto> Assunto { get; set; }
//        public virtual DbSet<AtribuicaoRelato> AtribuicaoRelato { get; set; }
//        public virtual DbSet<ContratoUtilizacaoSistema> ContratoUtilizacaoSistema { get; set; }
//        public virtual DbSet<Empresa> Empresa { get; set; }
//        public virtual DbSet<EmpresaLocalidade> EmpresaLocalidade { get; set; }
//        public virtual DbSet<EmpresaResponsavelTecnico> EmpresaResponsavelTecnico { get; set; }
//        public virtual DbSet<Evento> Evento { get; set; }
//        public virtual DbSet<FuncaoSistema> FuncaoSistema { get; set; }
//        public virtual DbSet<HistoricoRelato> HistoricoRelato { get; set; }
//        public virtual DbSet<Localidade> Localidade { get; set; }
//        public virtual DbSet<Perfil> Perfil { get; set; }
//        public virtual DbSet<PerfilFuncao> PerfilFuncao { get; set; }
//        public virtual DbSet<PerfilUsuario> PerfilUsuario { get; set; }
//        public virtual DbSet<Relato> Relato { get; set; }
//        public virtual DbSet<ResponsavelTecnico> ResponsavelTecnico { get; set; }
//        public virtual DbSet<SituacaoAtribuicaoRelato> SituacaoAtribuicaoRelato { get; set; }
//        public virtual DbSet<SituacaoRelato> SituacaoRelato { get; set; }
//        public virtual DbSet<SubAmbiente> SubAmbiente { get; set; }
//        public virtual DbSet<SubAssunto> SubAssunto { get; set; }
//        public virtual DbSet<TipoEvento> TipoEvento { get; set; }
//        public virtual DbSet<Usuario> Usuario { get; set; }
//        public virtual DbSet<UsuarioLocalidade> UsuarioLocalidade { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=S-SPAN16\\PRDSBSP02;Initial Catalog=RELPREV;User ID=USR_RELPREV;Password=USR_RELPREV;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

//            modelBuilder.Entity<Ambiente>(entity =>
//            {
//                entity.HasKey(e => e.CodAmbiente)
//                    .HasName("AMBIENTE_PK");

//                entity.ToTable("AMBIENTE");

//                entity.HasIndex(e => e.CodLocalidade)
//                    .HasName("XIF1AMBIENTE");

//                entity.HasIndex(e => new { e.CodLocalidade, e.DscAmbiente })
//                    .HasName("AMBIENTE_NOME_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodAmbiente).HasColumnName("COD_AMBIENTE");

//                entity.Property(e => e.CodLocalidade).HasColumnName("COD_LOCALIDADE");

//                entity.Property(e => e.DatFimVigencia)
//                    .HasColumnName("DAT_FIM_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DatInicioVigencia)
//                    .HasColumnName("DAT_INICIO_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DscAmbiente)
//                    .IsRequired()
//                    .HasColumnName("DSC_AMBIENTE")
//                    .HasMaxLength(100);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodLocalidadeNavigation)
//                    .WithMany(p => p.Ambiente)
//                    .HasForeignKey(d => d.CodLocalidade)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("AMBIENTE_LOCALIDADE_FK");
//            });

//            modelBuilder.Entity<AnexoRelato>(entity =>
//            {
//                entity.HasKey(e => e.CodAnexo)
//                    .HasName("ANEXO_RELATO_PK");

//                entity.ToTable("ANEXO_RELATO");

//                entity.HasIndex(e => e.CodAtribuicaoRelato)
//                    .HasName("XIF2ANEXO_RELATO");

//                entity.HasIndex(e => e.CodRelato)
//                    .HasName("XIF1ANEXO_RELATO");

//                entity.Property(e => e.CodAnexo).HasColumnName("COD_ANEXO");

//                entity.Property(e => e.BinAnexo)
//                    .IsRequired()
//                    .HasColumnName("BIN_ANEXO");

//                entity.Property(e => e.CodAtribuicaoRelato).HasColumnName("COD_ATRIBUICAO_RELATO");

//                entity.Property(e => e.CodRelato).HasColumnName("COD_RELATO");

//                entity.Property(e => e.DscAnexo)
//                    .HasColumnName("DSC_ANEXO")
//                    .HasMaxLength(100);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.TipFormatoAnexo)
//                    .IsRequired()
//                    .HasColumnName("TIP_FORMATO_ANEXO")
//                    .HasMaxLength(20);

//                entity.HasOne(d => d.CodAtribuicaoRelatoNavigation)
//                    .WithMany(p => p.AnexoRelato)
//                    .HasForeignKey(d => d.CodAtribuicaoRelato)
//                    .HasConstraintName("HISTORICO_ATRIBUICAO_FK");

//                entity.HasOne(d => d.CodRelatoNavigation)
//                    .WithMany(p => p.AnexoRelato)
//                    .HasForeignKey(d => d.CodRelato)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("ANEXO_RELATO_FK");
//            });

//            modelBuilder.Entity<Assunto>(entity =>
//            {
//                entity.HasKey(e => e.CodAssunto)
//                    .HasName("ASSUNTO_PK");

//                entity.ToTable("ASSUNTO");

//                entity.HasIndex(e => e.DscAssunto)
//                    .HasName("ASSUNTO_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodAssunto).HasColumnName("COD_ASSUNTO");

//                entity.Property(e => e.DscAssunto)
//                    .IsRequired()
//                    .HasColumnName("DSC_ASSUNTO")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<AtribuicaoRelato>(entity =>
//            {
//                entity.HasKey(e => e.CodAtribuicaoRelato)
//                    .HasName("ATRIBUICAO_RELATO_PK");

//                entity.ToTable("ATRIBUICAO_RELATO");

//                entity.HasIndex(e => e.CodRelato)
//                    .HasName("XIF2ATRIBUICAO_RELATO");

//                entity.HasIndex(e => e.CodResponsavelTecnico)
//                    .HasName("XIF1ATRIBUICAO_RELATO");

//                entity.HasIndex(e => e.CodSituacaoAtribuicao)
//                    .HasName("XIF3ATRIBUICAO_RELATO");

//                entity.HasIndex(e => e.CodUsuarioAtribuidor)
//                    .HasName("XIF4ATRIBUICAO_RELATO");

//                entity.Property(e => e.CodAtribuicaoRelato).HasColumnName("COD_ATRIBUICAO_RELATO");

//                entity.Property(e => e.CodRelato).HasColumnName("COD_RELATO");

//                entity.Property(e => e.CodResponsavelTecnico).HasColumnName("COD_RESPONSAVEL_TECNICO");

//                entity.Property(e => e.CodSituacaoAtribuicao).HasColumnName("COD_SITUACAO_ATRIBUICAO");

//                entity.Property(e => e.CodUsuarioAtribuidor).HasColumnName("COD_USUARIO_ATRIBUIDOR");

//                entity.Property(e => e.DscParecerTecnico)
//                    .HasColumnName("DSC_PARECER_TECNICO")
//                    .HasMaxLength(4000);

//                entity.Property(e => e.DthAtribuicao)
//                    .HasColumnName("DTH_ATRIBUICAO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DthFimAtendimento)
//                    .HasColumnName("DTH_FIM_ATENDIMENTO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.ObsAtribuicao)
//                    .HasColumnName("OBS_ATRIBUICAO")
//                    .HasMaxLength(4000);

//                entity.HasOne(d => d.CodRelatoNavigation)
//                    .WithMany(p => p.AtribuicaoRelato)
//                    .HasForeignKey(d => d.CodRelato)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("ATRIBUICAO_RELATO_FK");

//                entity.HasOne(d => d.CodResponsavelTecnicoNavigation)
//                    .WithMany(p => p.AtribuicaoRelato)
//                    .HasForeignKey(d => d.CodResponsavelTecnico)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("ATRIBUICAO_RESPONSAVEL_TECNICO_FK");

//                entity.HasOne(d => d.CodSituacaoAtribuicaoNavigation)
//                    .WithMany(p => p.AtribuicaoRelato)
//                    .HasForeignKey(d => d.CodSituacaoAtribuicao)
//                    .HasConstraintName("ATRIBUICAO_SITUACAO_ATRIBUICAO_FK");

//                entity.HasOne(d => d.CodUsuarioAtribuidorNavigation)
//                    .WithMany(p => p.AtribuicaoRelato)
//                    .HasForeignKey(d => d.CodUsuarioAtribuidor)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("ATRIBUICAO_RELATO_USUARIO_FK");
//            });

//            modelBuilder.Entity<ContratoUtilizacaoSistema>(entity =>
//            {
//                entity.HasKey(e => e.CodContrato)
//                    .HasName("CONTRATO_PK");

//                entity.ToTable("CONTRATO_UTILIZACAO_SISTEMA");

//                entity.HasIndex(e => e.CodEmpresa)
//                    .HasName("XIF3CONTRATO_UTILIZACAO_SISTEMA");

//                entity.HasIndex(e => e.CodLocalidade)
//                    .HasName("XIF2CONTRATO_UTILIZACAO_SISTEMA");

//                entity.Property(e => e.CodContrato).HasColumnName("COD_CONTRATO");

//                entity.Property(e => e.CodEmpresa).HasColumnName("COD_EMPRESA");

//                entity.Property(e => e.CodLocalidade).HasColumnName("COD_LOCALIDADE");

//                entity.Property(e => e.DatFimVigencia)
//                    .HasColumnName("DAT_FIM_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DatInicioVigencia)
//                    .HasColumnName("DAT_INICIO_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EmailContratada)
//                    .HasColumnName("EMAIL_CONTRATADA")
//                    .HasMaxLength(100);

//                entity.Property(e => e.EmailContratante)
//                    .HasColumnName("EMAIL_CONTRATANTE")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NomContratada)
//                    .HasColumnName("NOM_CONTRATADA")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NomCotratante)
//                    .HasColumnName("NOM_COTRATANTE")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumAtoAdm)
//                    .HasColumnName("NUM_ATO_ADM")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumContrato)
//                    .HasColumnName("NUM_CONTRATO")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumTelefoneContratada)
//                    .HasColumnName("NUM_TELEFONE_CONTRATADA")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumTelefoneContratante)
//                    .HasColumnName("NUM_TELEFONE_CONTRATANTE")
//                    .HasMaxLength(100);

//                entity.HasOne(d => d.CodEmpresaNavigation)
//                    .WithMany(p => p.ContratoUtilizacaoSistema)
//                    .HasForeignKey(d => d.CodEmpresa)
//                    .HasConstraintName("EMPRESA_CONTRATO_FK");

//                entity.HasOne(d => d.CodLocalidadeNavigation)
//                    .WithMany(p => p.ContratoUtilizacaoSistema)
//                    .HasForeignKey(d => d.CodLocalidade)
//                    .HasConstraintName("LOCALIDADE_CONTRATO_FK");
//            });

//            modelBuilder.Entity<Empresa>(entity =>
//            {
//                entity.HasKey(e => e.CodEmpresa)
//                    .HasName("EMPRESA_PK");

//                entity.ToTable("EMPRESA");

//                entity.HasIndex(e => e.NumCnpj)
//                    .HasName("EMPRESA_CNPJ_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodEmpresa).HasColumnName("COD_EMPRESA");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EndEmail)
//                    .HasColumnName("END_EMAIL")
//                    .HasMaxLength(100);

//                entity.Property(e => e.EndEmpresa)
//                    .HasColumnName("END_EMPRESA")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NomRazaoSocial)
//                    .IsRequired()
//                    .HasColumnName("NOM_RAZAO_SOCIAL")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumCnpj)
//                    .IsRequired()
//                    .HasColumnName("NUM_CNPJ")
//                    .HasMaxLength(14);

//                entity.Property(e => e.NumTelefone)
//                    .HasColumnName("NUM_TELEFONE")
//                    .HasMaxLength(30);
//            });

//            modelBuilder.Entity<EmpresaLocalidade>(entity =>
//            {
//                entity.HasKey(e => new { e.CodLocalidade, e.CodEmpresa })
//                    .HasName("EMPRESA_LOCALIDADE_PK");

//                entity.ToTable("EMPRESA_LOCALIDADE");

//                entity.HasIndex(e => e.CodEmpresa)
//                    .HasName("XIF1EMPRESA_LOCALIDADE");

//                entity.HasIndex(e => e.CodLocalidade)
//                    .HasName("XIF2EMPRESA_LOCALIDADE");

//                entity.Property(e => e.CodLocalidade).HasColumnName("COD_LOCALIDADE");

//                entity.Property(e => e.CodEmpresa).HasColumnName("COD_EMPRESA");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodEmpresaNavigation)
//                    .WithMany(p => p.EmpresaLocalidade)
//                    .HasForeignKey(d => d.CodEmpresa)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("LOCALIDADE_EMPRESA_FK");

//                entity.HasOne(d => d.CodLocalidadeNavigation)
//                    .WithMany(p => p.EmpresaLocalidade)
//                    .HasForeignKey(d => d.CodLocalidade)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("EMPRESA_LOCALIDADE_FK");
//            });

//            modelBuilder.Entity<EmpresaResponsavelTecnico>(entity =>
//            {
//                entity.HasKey(e => new { e.CodEmpresa, e.CodResponsavelTecnico, e.CodLocalidade })
//                    .HasName("EMPRESA_RESPONSAVEL_TECNICO_PK");

//                entity.ToTable("EMPRESA_RESPONSAVEL_TECNICO");

//                entity.HasIndex(e => e.CodEmpresa)
//                    .HasName("XIF1EMPRESA_RESPONSAVEL_TECNICO");

//                entity.HasIndex(e => e.CodLocalidade)
//                    .HasName("XIF2EMPRESA_RESPONSAVEL_TECNICO");

//                entity.HasIndex(e => e.CodResponsavelTecnico)
//                    .HasName("XIF3EMPRESA_RESPONSAVEL_TECNICO");

//                entity.HasIndex(e => new { e.CodEmpresa, e.CodLocalidade, e.CodResponsavelTecnico })
//                    .HasName("EMPRESA_RESPONSAVEL_TECNICO_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodEmpresa).HasColumnName("COD_EMPRESA");

//                entity.Property(e => e.CodResponsavelTecnico).HasColumnName("COD_RESPONSAVEL_TECNICO");

//                entity.Property(e => e.CodLocalidade).HasColumnName("COD_LOCALIDADE");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.NumDocumentoRepresentacao)
//                    .HasColumnName("NUM_DOCUMENTO_REPRESENTACAO")
//                    .HasMaxLength(100);

//                entity.HasOne(d => d.CodLocalidadeNavigation)
//                    .WithMany(p => p.EmpresaResponsavelTecnico)
//                    .HasForeignKey(d => d.CodLocalidade)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("EMPRESA_RESP_LOCALIDADE_FK");

//                entity.HasOne(d => d.CodResponsavelTecnicoNavigation)
//                    .WithMany(p => p.EmpresaResponsavelTecnico)
//                    .HasForeignKey(d => d.CodResponsavelTecnico)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("EMPRESA_RESP_RESPONSAVELFK");
//            });

//            modelBuilder.Entity<Evento>(entity =>
//            {
//                entity.HasKey(e => e.CodEvento)
//                    .HasName("EVENTO_PK");

//                entity.ToTable("EVENTO");

//                entity.HasIndex(e => e.CodUsuario)
//                    .HasName("XIF2EVENTO");

//                entity.HasIndex(e => e.TipEvento)
//                    .HasName("XIF1EVENTO");

//                entity.Property(e => e.CodEvento).HasColumnName("COD_EVENTO");

//                entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.ObsEvento)
//                    .HasColumnName("OBS_EVENTO")
//                    .HasMaxLength(2000);

//                entity.Property(e => e.TipEvento).HasColumnName("TIP_EVENTO");

//                entity.HasOne(d => d.CodUsuarioNavigation)
//                    .WithMany(p => p.Evento)
//                    .HasForeignKey(d => d.CodUsuario)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("EVENTO_USUARIO_FK");

//                entity.HasOne(d => d.TipEventoNavigation)
//                    .WithMany(p => p.Evento)
//                    .HasForeignKey(d => d.TipEvento)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("EVENTO_TIPO_EVENTO_FK");
//            });

//            modelBuilder.Entity<FuncaoSistema>(entity =>
//            {
//                entity.HasKey(e => e.CodFuncao)
//                    .HasName("FUNCAO_SISTEMA_PK");

//                entity.ToTable("FUNCAO_SISTEMA");

//                entity.Property(e => e.CodFuncao)
//                    .HasColumnName("COD_FUNCAO")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.DscFuncao)
//                    .IsRequired()
//                    .HasColumnName("DSC_FUNCAO")
//                    .HasMaxLength(200);

//                entity.Property(e => e.FlgVisivel)
//                    .IsRequired()
//                    .HasColumnName("FLG_VISIVEL")
//                    .HasMaxLength(1);
//            });

//            modelBuilder.Entity<HistoricoRelato>(entity =>
//            {
//                entity.HasKey(e => e.CodHistorico)
//                    .HasName("HISTORICO_RELATO_PK");

//                entity.ToTable("HISTORICO_RELATO");

//                entity.HasIndex(e => e.CodRelato)
//                    .HasName("XIF1HISTORICO_RELATO");

//                entity.HasIndex(e => e.CodUsuario)
//                    .HasName("XIF2HISTORICO_RELATO");

//                entity.Property(e => e.CodHistorico).HasColumnName("COD_HISTORICO");

//                entity.Property(e => e.CodRelato).HasColumnName("COD_RELATO");

//                entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");

//                entity.Property(e => e.DscHistorico)
//                    .IsRequired()
//                    .HasColumnName("DSC_HISTORICO")
//                    .HasMaxLength(4000);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodRelatoNavigation)
//                    .WithMany(p => p.HistoricoRelato)
//                    .HasForeignKey(d => d.CodRelato)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("HISTORICO_RELATO_FK");

//                entity.HasOne(d => d.CodUsuarioNavigation)
//                    .WithMany(p => p.HistoricoRelato)
//                    .HasForeignKey(d => d.CodUsuario)
//                    .HasConstraintName("HISTORICO_USUARIO_FK");
//            });

//            modelBuilder.Entity<Localidade>(entity =>
//            {
//                entity.HasKey(e => e.CodLocalidade)
//                    .HasName("LOCALIDADE_PK");

//                entity.ToTable("LOCALIDADE");

//                entity.Property(e => e.CodLocalidade)
//                    .HasColumnName("COD_LOCALIDADE")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.DatFimVigencia)
//                    .HasColumnName("DAT_FIM_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DatInicioVigencia)
//                    .HasColumnName("DAT_INICIO_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DscLocalidade)
//                    .IsRequired()
//                    .HasColumnName("DSC_LOCALIDADE")
//                    .HasMaxLength(100);

//                entity.Property(e => e.EndLocalidade)
//                    .HasColumnName("END_LOCALIDADE")
//                    .HasMaxLength(100);

//                entity.Property(e => e.SigLocalidade)
//                    .HasColumnName("SIG_LOCALIDADE")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<Perfil>(entity =>
//            {
//                entity.HasKey(e => e.CodPerfil)
//                    .HasName("PERFIL_PK");

//                entity.ToTable("PERFIL");

//                entity.Property(e => e.CodPerfil)
//                    .HasColumnName("COD_PERFIL")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.DscPerfil)
//                    .IsRequired()
//                    .HasColumnName("DSC_PERFIL")
//                    .HasMaxLength(100);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.FlgAtivo)
//                    .IsRequired()
//                    .HasColumnName("FLG_ATIVO")
//                    .HasMaxLength(1);

//                entity.Property(e => e.FlgPermiteAlteracao)
//                    .IsRequired()
//                    .HasColumnName("FLG_PERMITE_ALTERACAO")
//                    .HasMaxLength(1);

//                entity.Property(e => e.TxtObservacao)
//                    .HasColumnName("TXT_OBSERVACAO")
//                    .HasMaxLength(200);
//            });

//            modelBuilder.Entity<PerfilFuncao>(entity =>
//            {
//                entity.HasKey(e => new { e.CodPerfil, e.CodFuncao })
//                    .HasName("PERFIL_FUNCAO_PK");

//                entity.ToTable("PERFIL_FUNCAO");

//                entity.HasIndex(e => e.CodFuncao)
//                    .HasName("XIF2PERFIL_FUNCAO");

//                entity.HasIndex(e => e.CodPerfil)
//                    .HasName("XIF1PERFIL_FUNCAO");

//                entity.Property(e => e.CodPerfil).HasColumnName("COD_PERFIL");

//                entity.Property(e => e.CodFuncao).HasColumnName("COD_FUNCAO");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodFuncaoNavigation)
//                    .WithMany(p => p.PerfilFuncao)
//                    .HasForeignKey(d => d.CodFuncao)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("PERFIL_FUNCAO_SISTEMA_FK");

//                entity.HasOne(d => d.CodPerfilNavigation)
//                    .WithMany(p => p.PerfilFuncao)
//                    .HasForeignKey(d => d.CodPerfil)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("FUNCAO_SISTEMA_PERFIL_FK");
//            });

//            modelBuilder.Entity<PerfilUsuario>(entity =>
//            {
//                entity.HasKey(e => new { e.CodPerfil, e.CodUsuario })
//                    .HasName("PERFIL_USUARIO_PK");

//                entity.ToTable("PERFIL_USUARIO");

//                entity.HasIndex(e => e.CodPerfil)
//                    .HasName("XIF1PERFIL_USUARIO");

//                entity.HasIndex(e => e.CodUsuario)
//                    .HasName("XIF2PERFIL_USUARIO");

//                entity.Property(e => e.CodPerfil).HasColumnName("COD_PERFIL");

//                entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");

//                entity.Property(e => e.DatFimVigencia)
//                    .HasColumnName("DAT_FIM_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DatInicioVigencia)
//                    .HasColumnName("DAT_INICIO_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodPerfilNavigation)
//                    .WithMany(p => p.PerfilUsuario)
//                    .HasForeignKey(d => d.CodPerfil)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("USUARIO_PERFIL_FK");

//                entity.HasOne(d => d.CodUsuarioNavigation)
//                    .WithMany(p => p.PerfilUsuario)
//                    .HasForeignKey(d => d.CodUsuario)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("PERFIL_USUARIO_FK");
//            });

//            modelBuilder.Entity<Relato>(entity =>
//            {
//                entity.HasKey(e => e.CodRelato)
//                    .HasName("RELATO_PK");

//                entity.ToTable("RELATO");

//                entity.HasIndex(e => e.CodAmbiente)
//                    .HasName("XIF3RELATO");

//                entity.HasIndex(e => e.CodLocalidade)
//                    .HasName("XIF2RELATO");

//                entity.HasIndex(e => e.CodSituacaoRelato)
//                    .HasName("XIF1RELATO");

//                entity.HasIndex(e => e.CodSubAmbiente)
//                    .HasName("XIF4RELATO");

//                entity.HasIndex(e => e.CodUsuarioRelator)
//                    .HasName("XIF5RELATO");

//                entity.Property(e => e.CodRelato).HasColumnName("COD_RELATO");

//                entity.Property(e => e.CodAmbiente).HasColumnName("COD_AMBIENTE");

//                entity.Property(e => e.CodAssunto).HasColumnName("COD_ASSUNTO");

//                entity.Property(e => e.CodLocalidade).HasColumnName("COD_LOCALIDADE");

//                entity.Property(e => e.CodSituacaoRelato).HasColumnName("COD_SITUACAO_RELATO");

//                entity.Property(e => e.CodSubAmbiente).HasColumnName("COD_SUB_AMBIENTE");

//                entity.Property(e => e.CodSubAssunto).HasColumnName("COD_SUB_ASSUNTO");

//                entity.Property(e => e.CodUsuarioRelator).HasColumnName("COD_USUARIO_RELATOR");

//                entity.Property(e => e.DatOcorrencia)
//                    .HasColumnName("DAT_OCORRENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DscEnvolvidosOcorrencia)
//                    .IsRequired()
//                    .HasColumnName("DSC_ENVOLVIDOS_OCORRENCIA")
//                    .HasMaxLength(500);

//                entity.Property(e => e.DscLocalOcorrenciaRelator)
//                    .IsRequired()
//                    .HasColumnName("DSC_LOCAL_OCORRENCIA_RELATOR")
//                    .HasMaxLength(500);

//                entity.Property(e => e.DscOcorrenciaCorrigida)
//                    .HasColumnName("DSC_OCORRENCIA_CORRIGIDA")
//                    .HasMaxLength(1000);

//                entity.Property(e => e.DscOcorrenciaRelator)
//                    .IsRequired()
//                    .HasColumnName("DSC_OCORRENCIA_RELATOR")
//                    .HasMaxLength(1000);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EmailRelator)
//                    .HasColumnName("EMAIL_RELATOR")
//                    .HasMaxLength(500);

//                entity.Property(e => e.HorOcorrencia)
//                    .IsRequired()
//                    .HasColumnName("HOR_OCORRENCIA")
//                    .HasMaxLength(5);

//                entity.Property(e => e.NomEmpresaRelator)
//                    .HasColumnName("NOM_EMPRESA_RELATOR")
//                    .HasMaxLength(500);

//                entity.Property(e => e.NomRelator)
//                    .HasColumnName("NOM_RELATOR")
//                    .HasMaxLength(500);

//                entity.Property(e => e.NumTelefoneRelator)
//                    .HasColumnName("NUM_TELEFONE_RELATOR")
//                    .HasMaxLength(500);

//                entity.HasOne(d => d.CodAmbienteNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodAmbiente)
//                    .HasConstraintName("RELATO_AMBIENTE_FK");

//                entity.HasOne(d => d.CodAssuntoNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodAssunto)
//                    .HasConstraintName("RELATO_ASSUNTO_FK");

//                entity.HasOne(d => d.CodLocalidadeNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodLocalidade)
//                    .HasConstraintName("RELATO_LOCALIDADE_FK");

//                entity.HasOne(d => d.CodSituacaoRelatoNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodSituacaoRelato)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("RELATO_SITUACAO_RELATO_FK");

//                entity.HasOne(d => d.CodSubAmbienteNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodSubAmbiente)
//                    .HasConstraintName("RELATO_SUBAMBIENTE_FK");

//                entity.HasOne(d => d.CodSubAssuntoNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodSubAssunto)
//                    .HasConstraintName("RELATO_SUBASSUNTO_FK");

//                entity.HasOne(d => d.CodUsuarioRelatorNavigation)
//                    .WithMany(p => p.Relato)
//                    .HasForeignKey(d => d.CodUsuarioRelator)
//                    .HasConstraintName("RELATO_USUARIO_FK");
//            });

//            modelBuilder.Entity<ResponsavelTecnico>(entity =>
//            {
//                entity.HasKey(e => e.CodResponsavelTecnico)
//                    .HasName("RESPONSAVEL_TECNICO_PK");

//                entity.ToTable("RESPONSAVEL_TECNICO");

//                entity.HasIndex(e => e.EndEmail)
//                    .HasName("RESPONSAVEL_TECNICO_EMAIL_UK")
//                    .IsUnique();

//                entity.HasIndex(e => e.NumCpf)
//                    .HasName("RESPONSAVEL_TECNICO_CPF_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodResponsavelTecnico).HasColumnName("COD_RESPONSAVEL_TECNICO");

//                entity.Property(e => e.EndEmail)
//                    .IsRequired()
//                    .HasColumnName("END_EMAIL")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NomResponsavelTecnico)
//                    .IsRequired()
//                    .HasColumnName("NOM_RESPONSAVEL_TECNICO")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumCpf)
//                    .IsRequired()
//                    .HasColumnName("NUM_CPF")
//                    .HasMaxLength(11);

//                entity.Property(e => e.NumTelefone)
//                    .HasColumnName("NUM_TELEFONE")
//                    .HasMaxLength(30);
//            });

//            modelBuilder.Entity<SituacaoAtribuicaoRelato>(entity =>
//            {
//                entity.HasKey(e => e.CodSituacaoAtribuicao)
//                    .HasName("SITUACAO_ATRIBUICAO_RELATO_PK");

//                entity.ToTable("SITUACAO_ATRIBUICAO_RELATO");

//                entity.Property(e => e.CodSituacaoAtribuicao).HasColumnName("COD_SITUACAO_ATRIBUICAO");

//                entity.Property(e => e.DscSituacaoAtribuicao)
//                    .IsRequired()
//                    .HasColumnName("DSC_SITUACAO_ATRIBUICAO")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<SituacaoRelato>(entity =>
//            {
//                entity.HasKey(e => e.CodSituacaoRelato)
//                    .HasName("SITUACAO_RELATO_PK");

//                entity.ToTable("SITUACAO_RELATO");

//                entity.Property(e => e.CodSituacaoRelato).HasColumnName("COD_SITUACAO_RELATO");

//                entity.Property(e => e.DscSituacaoRelato)
//                    .IsRequired()
//                    .HasColumnName("DSC_SITUACAO_RELATO")
//                    .HasMaxLength(50);
//            });

//            modelBuilder.Entity<SubAmbiente>(entity =>
//            {
//                entity.HasKey(e => e.CodSubAmbiente)
//                    .HasName("SUB_AMBIENTE_PK");

//                entity.ToTable("SUB_AMBIENTE");

//                entity.HasIndex(e => e.CodAmbiente)
//                    .HasName("XIF1SUB_AMBIENTE");

//                entity.HasIndex(e => new { e.CodAmbiente, e.DscSubAmbiente })
//                    .HasName("SUB_AMBIENTE_DESCRICAO_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodSubAmbiente).HasColumnName("COD_SUB_AMBIENTE");

//                entity.Property(e => e.CodAmbiente).HasColumnName("COD_AMBIENTE");

//                entity.Property(e => e.DatFimVigencia)
//                    .HasColumnName("DAT_FIM_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DatInicioVigencia)
//                    .HasColumnName("DAT_INICIO_VIGENCIA")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.DscSubAmbiente)
//                    .IsRequired()
//                    .HasColumnName("DSC_SUB_AMBIENTE")
//                    .HasMaxLength(100);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodAmbienteNavigation)
//                    .WithMany(p => p.SubAmbiente)
//                    .HasForeignKey(d => d.CodAmbiente)
//                    .HasConstraintName("SUB_AMBIENTE_AMBIENTE_FK");
//            });

//            modelBuilder.Entity<SubAssunto>(entity =>
//            {
//                entity.HasKey(e => e.CodSubAssunto)
//                    .HasName("SUB_ASSUNTO_PK");

//                entity.ToTable("SUB_ASSUNTO");

//                entity.HasIndex(e => e.CodAssunto)
//                    .HasName("XIF1SUB_ASSUNTO");

//                entity.HasIndex(e => new { e.DscSubAssunto, e.CodAssunto })
//                    .HasName("SUB_ASSUNTO_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodSubAssunto).HasColumnName("COD_SUB_ASSUNTO");

//                entity.Property(e => e.CodAssunto).HasColumnName("COD_ASSUNTO");

//                entity.Property(e => e.DscSubAssunto)
//                    .IsRequired()
//                    .HasColumnName("DSC_SUB_ASSUNTO")
//                    .HasMaxLength(50);

//                entity.HasOne(d => d.CodAssuntoNavigation)
//                    .WithMany(p => p.SubAssunto)
//                    .HasForeignKey(d => d.CodAssunto)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("SUBASSUNTO_ASSUNTO_FK");
//            });

//            modelBuilder.Entity<TipoEvento>(entity =>
//            {
//                entity.HasKey(e => e.TipEvento)
//                    .HasName("TIPO_EVENTO_PK");

//                entity.ToTable("TIPO_EVENTO");

//                entity.Property(e => e.TipEvento)
//                    .HasColumnName("TIP_EVENTO")
//                    .ValueGeneratedNever();

//                entity.Property(e => e.DscTipoEvento)
//                    .IsRequired()
//                    .HasColumnName("DSC_TIPO_EVENTO")
//                    .HasMaxLength(100);
//            });

//            modelBuilder.Entity<Usuario>(entity =>
//            {
//                entity.HasKey(e => e.CodUsuario)
//                    .HasName("USUARIO_PK");

//                entity.ToTable("USUARIO");

//                entity.HasIndex(e => e.DscLogin)
//                    .HasName("USUARIO_LOGIN_UK")
//                    .IsUnique();

//                entity.HasIndex(e => e.EndEmail)
//                    .HasName("USUARIO_EMAIL_UK")
//                    .IsUnique();

//                entity.HasIndex(e => e.NumCpf)
//                    .HasName("USUARIO_CPF_UK")
//                    .IsUnique();

//                entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");

//                entity.Property(e => e.DscLogin)
//                    .HasColumnName("DSC_LOGIN")
//                    .HasMaxLength(20);

//                entity.Property(e => e.DscSenha)
//                    .HasColumnName("DSC_SENHA")
//                    .HasMaxLength(100);

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EndEmail)
//                    .HasColumnName("END_EMAIL")
//                    .HasMaxLength(100);

//                entity.Property(e => e.FlgPrimeiroAcesso)
//                    .IsRequired()
//                    .HasColumnName("FLG_PRIMEIRO_ACESSO")
//                    .HasMaxLength(1);

//                entity.Property(e => e.FlgUsuarioBloqueado)
//                    .IsRequired()
//                    .HasColumnName("FLG_USUARIO_BLOQUEADO")
//                    .HasMaxLength(1);

//                entity.Property(e => e.NomUsuario)
//                    .IsRequired()
//                    .HasColumnName("NOM_USUARIO")
//                    .HasMaxLength(100);

//                entity.Property(e => e.NumCpf)
//                    .HasColumnName("NUM_CPF")
//                    .HasMaxLength(11);

//                entity.Property(e => e.NumTelefone)
//                    .HasColumnName("NUM_TELEFONE")
//                    .HasMaxLength(30);

//                entity.Property(e => e.QtdTentativasIncorretas).HasColumnName("QTD_TENTATIVAS_INCORRETAS");
//            });

//            modelBuilder.Entity<UsuarioLocalidade>(entity =>
//            {
//                entity.HasKey(e => new { e.CodUsuario, e.CodLocalidade })
//                    .HasName("USUARIO_LOCALIDADE_PK");

//                entity.ToTable("USUARIO_LOCALIDADE");

//                entity.HasIndex(e => e.CodLocalidade)
//                    .HasName("XIF2USUARIO_LOCALIDADE");

//                entity.HasIndex(e => e.CodUsuario)
//                    .HasName("XIF1USUARIO_LOCALIDADE");

//                entity.Property(e => e.CodUsuario).HasColumnName("COD_USUARIO");

//                entity.Property(e => e.CodLocalidade).HasColumnName("COD_LOCALIDADE");

//                entity.Property(e => e.DthRegistro)
//                    .HasColumnName("DTH_REGISTRO")
//                    .HasColumnType("datetime");

//                entity.HasOne(d => d.CodLocalidadeNavigation)
//                    .WithMany(p => p.UsuarioLocalidade)
//                    .HasForeignKey(d => d.CodLocalidade)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("USUARIO_LOCALIDADE_FK");

//                entity.HasOne(d => d.CodUsuarioNavigation)
//                    .WithMany(p => p.UsuarioLocalidade)
//                    .HasForeignKey(d => d.CodUsuario)
//                    .OnDelete(DeleteBehavior.ClientSetNull)
//                    .HasConstraintName("LOCALIDADE_USUARIO_FK");
//            });
//        }
//    }
//}
