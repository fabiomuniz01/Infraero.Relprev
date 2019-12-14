using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assunto",
                columns: table => new
                {
                    CodAssunto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscAssunto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assunto", x => x.CodAssunto);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: false),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    CodEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    NomRazaoSocial = table.Column<string>(nullable: true),
                    NumCnpj = table.Column<string>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    NumTelefone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.CodEmpresa);
                });

            migrationBuilder.CreateTable(
                name: "FuncaoSistema",
                columns: table => new
                {
                    CodFuncao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscFuncao = table.Column<string>(nullable: true),
                    FlgVisivel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncaoSistema", x => x.CodFuncao);
                });

            migrationBuilder.CreateTable(
                name: "Localidade",
                columns: table => new
                {
                    CodLocalidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscLocalidade = table.Column<string>(nullable: true),
                    SigLocalidade = table.Column<string>(nullable: true),
                    EndLocalidade = table.Column<string>(nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(nullable: false),
                    DatFimVigencia = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidade", x => x.CodLocalidade);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    CodPerfil = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscPerfil = table.Column<string>(nullable: true),
                    FlgPermiteAlteracao = table.Column<string>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    FlgAtivo = table.Column<string>(nullable: true),
                    TxtObservacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.CodPerfil);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(maxLength: 200, nullable: false),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(maxLength: 200, nullable: true),
                    ClientId = table.Column<string>(maxLength: 200, nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    Expiration = table.Column<DateTime>(nullable: true),
                    Data = table.Column<string>(maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "ResponsavelTecnico",
                columns: table => new
                {
                    CodResponsavelTecnico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    NomResponsavelTecnico = table.Column<string>(nullable: true),
                    NumCpf = table.Column<string>(nullable: true),
                    NumTelefone = table.Column<string>(nullable: true),
                    EndEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsavelTecnico", x => x.CodResponsavelTecnico);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoAtribuicaoRelato",
                columns: table => new
                {
                    CodSituacaoAtribuicao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscSituacaoAtribuicao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoAtribuicaoRelato", x => x.CodSituacaoAtribuicao);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoRelato",
                columns: table => new
                {
                    CodSituacaoRelato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscSituacaoRelato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoRelato", x => x.CodSituacaoRelato);
                });

            migrationBuilder.CreateTable(
                name: "TipoEvento",
                columns: table => new
                {
                    TipEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscTipoEvento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEvento", x => x.TipEvento);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRelprev",
                columns: table => new
                {
                    CodUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    NomUsuario = table.Column<string>(nullable: true),
                    NumCpf = table.Column<string>(nullable: true),
                    NumTelefone = table.Column<string>(nullable: true),
                    DscLogin = table.Column<string>(nullable: true),
                    DscSenha = table.Column<string>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    EndEmail = table.Column<string>(nullable: true),
                    QtdTentativasIncorretas = table.Column<int>(nullable: false),
                    FlgPrimeiroAcesso = table.Column<string>(nullable: true),
                    FlgUsuarioBloqueado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRelprev", x => x.CodUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    ListId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 800, nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Done = table.Column<bool>(nullable: false),
                    Reminder = table.Column<DateTime>(nullable: true),
                    Priority = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubAssunto",
                columns: table => new
                {
                    CodSubAssunto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscSubAssunto = table.Column<string>(nullable: true),
                    CodAssunto = table.Column<int>(nullable: false),
                    CodAssuntoNavigationCodAssunto = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAssunto", x => x.CodSubAssunto);
                    table.ForeignKey(
                        name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                        column: x => x.CodAssuntoNavigationCodAssunto,
                        principalTable: "Assunto",
                        principalColumn: "CodAssunto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ambiente",
                columns: table => new
                {
                    CodAmbiente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscAmbiente = table.Column<string>(nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(nullable: false),
                    DatFimVigencia = table.Column<DateTime>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodLocalidade = table.Column<int>(nullable: false),
                    CodLocalidadeNavigationCodLocalidade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambiente", x => x.CodAmbiente);
                    table.ForeignKey(
                        name: "FK_Ambiente_Localidade_CodLocalidadeNavigationCodLocalidade",
                        column: x => x.CodLocalidadeNavigationCodLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "CodLocalidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContratoUtilizacaoSistema",
                columns: table => new
                {
                    CodContrato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodLocalidade = table.Column<int>(nullable: true),
                    CodEmpresa = table.Column<int>(nullable: true),
                    NumContrato = table.Column<string>(nullable: true),
                    NumAtoAdm = table.Column<string>(nullable: true),
                    NomCotratante = table.Column<string>(nullable: true),
                    EmailContratante = table.Column<string>(nullable: true),
                    NumTelefoneContratante = table.Column<string>(nullable: true),
                    NomContratada = table.Column<string>(nullable: true),
                    EmailContratada = table.Column<string>(nullable: true),
                    NumTelefoneContratada = table.Column<string>(nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(nullable: false),
                    DatFimVigencia = table.Column<DateTime>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodEmpresaNavigationCodEmpresa = table.Column<int>(nullable: true),
                    CodLocalidadeNavigationCodLocalidade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoUtilizacaoSistema", x => x.CodContrato);
                    table.ForeignKey(
                        name: "FK_ContratoUtilizacaoSistema_Empresas_CodEmpresaNavigationCodEmpresa",
                        column: x => x.CodEmpresaNavigationCodEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "CodEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoUtilizacaoSistema_Localidade_CodLocalidadeNavigationCodLocalidade",
                        column: x => x.CodLocalidadeNavigationCodLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "CodLocalidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaLocalidade",
                columns: table => new
                {
                    CodEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodLocalidade = table.Column<int>(nullable: false),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodEmpresaNavigationCodEmpresa = table.Column<int>(nullable: true),
                    CodLocalidadeNavigationCodLocalidade = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaLocalidade", x => x.CodEmpresa);
                    table.ForeignKey(
                        name: "FK_EmpresaLocalidade_Empresas_CodEmpresaNavigationCodEmpresa",
                        column: x => x.CodEmpresaNavigationCodEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "CodEmpresa",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaLocalidade_Localidade_CodLocalidadeNavigationCodLocalidade",
                        column: x => x.CodLocalidadeNavigationCodLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "CodLocalidade",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilFuncao",
                columns: table => new
                {
                    CodPerfilFuncao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodPerfil = table.Column<int>(nullable: false),
                    CodFuncao = table.Column<int>(nullable: false),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodFuncaoNavigationCodFuncao = table.Column<int>(nullable: true),
                    CodPerfilNavigationCodPerfil = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilFuncao", x => x.CodPerfilFuncao);
                    table.ForeignKey(
                        name: "FK_PerfilFuncao_FuncaoSistema_CodFuncaoNavigationCodFuncao",
                        column: x => x.CodFuncaoNavigationCodFuncao,
                        principalTable: "FuncaoSistema",
                        principalColumn: "CodFuncao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerfilFuncao_Perfil_CodPerfilNavigationCodPerfil",
                        column: x => x.CodPerfilNavigationCodPerfil,
                        principalTable: "Perfil",
                        principalColumn: "CodPerfil",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaResponsavelTecnico",
                columns: table => new
                {
                    CodEmpresaResponsavelTecnico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    NumDocumentoRepresentacao = table.Column<string>(nullable: true),
                    CodEmpresa = table.Column<int>(nullable: false),
                    CodLocalidade = table.Column<int>(nullable: false),
                    CodResponsavelTecnico = table.Column<int>(nullable: false),
                    CodLocalidadeNavigationCodLocalidade = table.Column<int>(nullable: true),
                    CodResponsavelTecnicoNavigationCodResponsavelTecnico = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaResponsavelTecnico", x => x.CodEmpresaResponsavelTecnico);
                    table.ForeignKey(
                        name: "FK_EmpresaResponsavelTecnico_Localidade_CodLocalidadeNavigationCodLocalidade",
                        column: x => x.CodLocalidadeNavigationCodLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "CodLocalidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                        column: x => x.CodResponsavelTecnicoNavigationCodResponsavelTecnico,
                        principalTable: "ResponsavelTecnico",
                        principalColumn: "CodResponsavelTecnico",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    CodEvento = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    ObsEvento = table.Column<string>(nullable: true),
                    TipEvento = table.Column<int>(nullable: false),
                    CodUsuario = table.Column<int>(nullable: false),
                    CodUsuarioNavigationId = table.Column<long>(nullable: true),
                    TipEventoNavigationTipEvento = table.Column<int>(nullable: true),
                    UsuarioRelprevCodUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.CodEvento);
                    table.ForeignKey(
                        name: "FK_Evento_Usuarios_CodUsuarioNavigationId",
                        column: x => x.CodUsuarioNavigationId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_TipoEvento_TipEventoNavigationTipEvento",
                        column: x => x.TipEventoNavigationTipEvento,
                        principalTable: "TipoEvento",
                        principalColumn: "TipEvento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_UsuarioRelprev_UsuarioRelprevCodUsuario",
                        column: x => x.UsuarioRelprevCodUsuario,
                        principalTable: "UsuarioRelprev",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilUsuario",
                columns: table => new
                {
                    CodPerfilUsuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodPerfil = table.Column<int>(nullable: false),
                    CodUsuario = table.Column<int>(nullable: false),
                    DatInicioVigencia = table.Column<DateTime>(nullable: false),
                    DatFimVigencia = table.Column<DateTime>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodPerfilNavigationCodPerfil = table.Column<int>(nullable: true),
                    CodUsuarioNavigationId = table.Column<long>(nullable: true),
                    UsuarioRelprevCodUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilUsuario", x => x.CodPerfilUsuario);
                    table.ForeignKey(
                        name: "FK_PerfilUsuario_Perfil_CodPerfilNavigationCodPerfil",
                        column: x => x.CodPerfilNavigationCodPerfil,
                        principalTable: "Perfil",
                        principalColumn: "CodPerfil",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationId",
                        column: x => x.CodUsuarioNavigationId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerfilUsuario_UsuarioRelprev_UsuarioRelprevCodUsuario",
                        column: x => x.UsuarioRelprevCodUsuario,
                        principalTable: "UsuarioRelprev",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioLocalidade",
                columns: table => new
                {
                    CodUsuarioLocalidade = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodUsuario = table.Column<int>(nullable: false),
                    CodLocalidade = table.Column<int>(nullable: false),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodLocalidadeNavigationCodLocalidade = table.Column<int>(nullable: true),
                    CodUsuarioNavigationId = table.Column<long>(nullable: true),
                    UsuarioRelprevCodUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLocalidade", x => x.CodUsuarioLocalidade);
                    table.ForeignKey(
                        name: "FK_UsuarioLocalidade_Localidade_CodLocalidadeNavigationCodLocalidade",
                        column: x => x.CodLocalidadeNavigationCodLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "CodLocalidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationId",
                        column: x => x.CodUsuarioNavigationId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioLocalidade_UsuarioRelprev_UsuarioRelprevCodUsuario",
                        column: x => x.UsuarioRelprevCodUsuario,
                        principalTable: "UsuarioRelprev",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubAmbiente",
                columns: table => new
                {
                    CodSubAmbiente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscSubAmbiente = table.Column<string>(nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(nullable: false),
                    DatFimVigencia = table.Column<DateTime>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    CodAmbiente = table.Column<int>(nullable: true),
                    CodAmbienteNavigationCodAmbiente = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubAmbiente", x => x.CodSubAmbiente);
                    table.ForeignKey(
                        name: "FK_SubAmbiente_Ambiente_CodAmbienteNavigationCodAmbiente",
                        column: x => x.CodAmbienteNavigationCodAmbiente,
                        principalTable: "Ambiente",
                        principalColumn: "CodAmbiente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Relato",
                columns: table => new
                {
                    CodRelato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodSituacaoRelato = table.Column<int>(nullable: false),
                    CodLocalidade = table.Column<int>(nullable: true),
                    CodAmbiente = table.Column<int>(nullable: true),
                    CodSubAmbiente = table.Column<int>(nullable: true),
                    DatOcorrencia = table.Column<DateTime>(nullable: false),
                    DscLocalOcorrenciaRelator = table.Column<string>(nullable: true),
                    DscEnvolvidosOcorrencia = table.Column<string>(nullable: true),
                    DscOcorrenciaRelator = table.Column<string>(nullable: true),
                    NomRelator = table.Column<string>(nullable: true),
                    EmailRelator = table.Column<string>(nullable: true),
                    NumTelefoneRelator = table.Column<string>(nullable: true),
                    NomEmpresaRelator = table.Column<string>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    HorOcorrencia = table.Column<string>(nullable: true),
                    DscOcorrenciaCorrigida = table.Column<string>(nullable: true),
                    CodUsuarioRelator = table.Column<int>(nullable: true),
                    CodAssunto = table.Column<int>(nullable: true),
                    CodSubAssunto = table.Column<int>(nullable: true),
                    CodAmbienteNavigationCodAmbiente = table.Column<int>(nullable: true),
                    CodAssuntoNavigationCodAssunto = table.Column<int>(nullable: true),
                    CodLocalidadeNavigationCodLocalidade = table.Column<int>(nullable: true),
                    CodSituacaoRelatoNavigationCodSituacaoRelato = table.Column<int>(nullable: true),
                    CodSubAmbienteNavigationCodSubAmbiente = table.Column<int>(nullable: true),
                    CodSubAssuntoNavigationCodSubAssunto = table.Column<int>(nullable: true),
                    CodUsuarioRelatorNavigationId = table.Column<long>(nullable: true),
                    UsuarioRelprevCodUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relato", x => x.CodRelato);
                    table.ForeignKey(
                        name: "FK_Relato_Ambiente_CodAmbienteNavigationCodAmbiente",
                        column: x => x.CodAmbienteNavigationCodAmbiente,
                        principalTable: "Ambiente",
                        principalColumn: "CodAmbiente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                        column: x => x.CodAssuntoNavigationCodAssunto,
                        principalTable: "Assunto",
                        principalColumn: "CodAssunto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_Localidade_CodLocalidadeNavigationCodLocalidade",
                        column: x => x.CodLocalidadeNavigationCodLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "CodLocalidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_SituacaoRelato_CodSituacaoRelatoNavigationCodSituacaoRelato",
                        column: x => x.CodSituacaoRelatoNavigationCodSituacaoRelato,
                        principalTable: "SituacaoRelato",
                        principalColumn: "CodSituacaoRelato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_SubAmbiente_CodSubAmbienteNavigationCodSubAmbiente",
                        column: x => x.CodSubAmbienteNavigationCodSubAmbiente,
                        principalTable: "SubAmbiente",
                        principalColumn: "CodSubAmbiente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                        column: x => x.CodSubAssuntoNavigationCodSubAssunto,
                        principalTable: "SubAssunto",
                        principalColumn: "CodSubAssunto",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationId",
                        column: x => x.CodUsuarioRelatorNavigationId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Relato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                        column: x => x.UsuarioRelprevCodUsuario,
                        principalTable: "UsuarioRelprev",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AtribuicaoRelato",
                columns: table => new
                {
                    CodAtribuicaoRelato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodResponsavelTecnico = table.Column<int>(nullable: false),
                    CodRelato = table.Column<int>(nullable: false),
                    CodSituacaoAtribuicao = table.Column<int>(nullable: true),
                    DscParecerTecnico = table.Column<string>(nullable: true),
                    CodUsuarioAtribuidor = table.Column<int>(nullable: false),
                    DthAtribuicao = table.Column<DateTime>(nullable: false),
                    DthFimAtendimento = table.Column<DateTime>(nullable: true),
                    ObsAtribuicao = table.Column<string>(nullable: true),
                    CodRelatoNavigationCodRelato = table.Column<int>(nullable: true),
                    CodResponsavelTecnicoNavigationCodResponsavelTecnico = table.Column<int>(nullable: true),
                    CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao = table.Column<int>(nullable: true),
                    CodUsuarioAtribuidorNavigationId = table.Column<long>(nullable: true),
                    UsuarioRelprevCodUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtribuicaoRelato", x => x.CodAtribuicaoRelato);
                    table.ForeignKey(
                        name: "FK_AtribuicaoRelato_Relato_CodRelatoNavigationCodRelato",
                        column: x => x.CodRelatoNavigationCodRelato,
                        principalTable: "Relato",
                        principalColumn: "CodRelato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                        column: x => x.CodResponsavelTecnicoNavigationCodResponsavelTecnico,
                        principalTable: "ResponsavelTecnico",
                        principalColumn: "CodResponsavelTecnico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtribuicaoRelato_SituacaoAtribuicaoRelato_CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                        column: x => x.CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao,
                        principalTable: "SituacaoAtribuicaoRelato",
                        principalColumn: "CodSituacaoAtribuicao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationId",
                        column: x => x.CodUsuarioAtribuidorNavigationId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtribuicaoRelato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                        column: x => x.UsuarioRelprevCodUsuario,
                        principalTable: "UsuarioRelprev",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoRelato",
                columns: table => new
                {
                    CodHistoricoRelato = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodHistorico = table.Column<int>(nullable: false),
                    CodRelato = table.Column<int>(nullable: false),
                    CodUsuario = table.Column<int>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    DscHistorico = table.Column<string>(nullable: true),
                    CodRelatoNavigationCodRelato = table.Column<int>(nullable: true),
                    CodUsuarioNavigationId = table.Column<long>(nullable: true),
                    UsuarioRelprevCodUsuario = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoRelato", x => x.CodHistoricoRelato);
                    table.ForeignKey(
                        name: "FK_HistoricoRelato_Relato_CodRelatoNavigationCodRelato",
                        column: x => x.CodRelatoNavigationCodRelato,
                        principalTable: "Relato",
                        principalColumn: "CodRelato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationId",
                        column: x => x.CodUsuarioNavigationId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoricoRelato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                        column: x => x.UsuarioRelprevCodUsuario,
                        principalTable: "UsuarioRelprev",
                        principalColumn: "CodUsuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AnexoRelato",
                columns: table => new
                {
                    CodAnexo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodRelato = table.Column<int>(nullable: false),
                    CodAtribuicaoRelato = table.Column<int>(nullable: true),
                    BinAnexo = table.Column<byte[]>(nullable: true),
                    TipFormatoAnexo = table.Column<string>(nullable: true),
                    DthRegistro = table.Column<DateTime>(nullable: false),
                    DscAnexo = table.Column<string>(nullable: true),
                    CodAtribuicaoRelatoNavigationCodAtribuicaoRelato = table.Column<int>(nullable: true),
                    CodRelatoNavigationCodRelato = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnexoRelato", x => x.CodAnexo);
                    table.ForeignKey(
                        name: "FK_AnexoRelato_AtribuicaoRelato_CodAtribuicaoRelatoNavigationCodAtribuicaoRelato",
                        column: x => x.CodAtribuicaoRelatoNavigationCodAtribuicaoRelato,
                        principalTable: "AtribuicaoRelato",
                        principalColumn: "CodAtribuicaoRelato",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AnexoRelato_Relato_CodRelatoNavigationCodRelato",
                        column: x => x.CodRelatoNavigationCodRelato,
                        principalTable: "Relato",
                        principalColumn: "CodRelato",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambiente_CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_AnexoRelato_CodAtribuicaoRelatoNavigationCodAtribuicaoRelato",
                table: "AnexoRelato",
                column: "CodAtribuicaoRelatoNavigationCodAtribuicaoRelato");

            migrationBuilder.CreateIndex(
                name: "IX_AnexoRelato_CodRelatoNavigationCodRelato",
                table: "AnexoRelato",
                column: "CodRelatoNavigationCodRelato");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato",
                column: "CodRelatoNavigationCodRelato");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato",
                column: "CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoUtilizacaoSistema_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema",
                column: "CodEmpresaNavigationCodEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoUtilizacaoSistema_CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaLocalidade_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade",
                column: "CodEmpresaNavigationCodEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaLocalidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsavelTecnico_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CodUsuarioNavigationId",
                table: "Evento",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipEventoNavigationTipEvento",
                table: "Evento",
                column: "TipEventoNavigationTipEvento");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_UsuarioRelprevCodUsuario",
                table: "Evento",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato",
                column: "CodRelatoNavigationCodRelato");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationId",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_UsuarioRelprevCodUsuario",
                table: "HistoricoRelato",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilFuncao_CodFuncaoNavigationCodFuncao",
                table: "PerfilFuncao",
                column: "CodFuncaoNavigationCodFuncao");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilFuncao_CodPerfilNavigationCodPerfil",
                table: "PerfilFuncao",
                column: "CodPerfilNavigationCodPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_CodPerfilNavigationCodPerfil",
                table: "PerfilUsuario",
                column: "CodPerfilNavigationCodPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_CodUsuarioNavigationId",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_UsuarioRelprevCodUsuario",
                table: "PerfilUsuario",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodAmbienteNavigationCodAmbiente",
                table: "Relato",
                column: "CodAmbienteNavigationCodAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocalidade",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato",
                column: "CodSituacaoRelatoNavigationCodSituacaoRelato");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato",
                column: "CodSubAmbienteNavigationCodSubAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationId",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_UsuarioRelprevCodUsuario",
                table: "Relato",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_SubAmbiente_CodAmbienteNavigationCodAmbiente",
                table: "SubAmbiente",
                column: "CodAmbienteNavigationCodAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_SubAssunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                column: "CodAssuntoNavigationCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_CodLocalidadeNavigationCodLocalidade",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_CodUsuarioNavigationId",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_UsuarioRelprevCodUsuario",
                table: "UsuarioLocalidade",
                column: "UsuarioRelprevCodUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnexoRelato");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ContratoUtilizacaoSistema");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "EmpresaLocalidade");

            migrationBuilder.DropTable(
                name: "EmpresaResponsavelTecnico");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "HistoricoRelato");

            migrationBuilder.DropTable(
                name: "PerfilFuncao");

            migrationBuilder.DropTable(
                name: "PerfilUsuario");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "UsuarioLocalidade");

            migrationBuilder.DropTable(
                name: "AtribuicaoRelato");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "TipoEvento");

            migrationBuilder.DropTable(
                name: "FuncaoSistema");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Relato");

            migrationBuilder.DropTable(
                name: "ResponsavelTecnico");

            migrationBuilder.DropTable(
                name: "SituacaoAtribuicaoRelato");

            migrationBuilder.DropTable(
                name: "SituacaoRelato");

            migrationBuilder.DropTable(
                name: "SubAmbiente");

            migrationBuilder.DropTable(
                name: "SubAssunto");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "UsuarioRelprev");

            migrationBuilder.DropTable(
                name: "Ambiente");

            migrationBuilder.DropTable(
                name: "Assunto");

            migrationBuilder.DropTable(
                name: "Localidade");
        }
    }
}
