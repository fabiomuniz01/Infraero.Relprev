using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev039ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelato_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropTable(
                name: "ContratoUtilizacaoSistema");

            migrationBuilder.DropTable(
                name: "EmpresaLocalidade");

            migrationBuilder.DropTable(
                name: "EmpresaResponsavelTecnico");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "PerfilFuncao");

            migrationBuilder.DropTable(
                name: "PerfilUsuario");

            migrationBuilder.DropTable(
                name: "SituacaoAtribuicaoRelato");

            migrationBuilder.DropTable(
                name: "SituacaoRelato");

            migrationBuilder.DropTable(
                name: "UsuarioLocalidade");

            migrationBuilder.DropTable(
                name: "TipoEvento");

            migrationBuilder.DropTable(
                name: "FuncaoSistema");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContratoUtilizacaoSistema",
                columns: table => new
                {
                    CodContrato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodEmpresa = table.Column<int>(type: "int", nullable: true),
                    CodEmpresaNavigationCodEmpresa = table.Column<int>(type: "int", nullable: true),
                    CodLocalidade = table.Column<int>(type: "int", nullable: true),
                    CodLocalidadeNavigationCodLocal = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailContratada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailContratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false),
                    NomContratada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomCotratante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumAtoAdm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumContrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumTelefoneContratada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumTelefoneContratante = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoUtilizacaoSistema", x => x.CodContrato);
                    table.ForeignKey(
                        name: "FK_ContratoUtilizacaoSistema_CAD_EMPRESA_CodEmpresaNavigationCodEmpresa",
                        column: x => x.CodEmpresaNavigationCodEmpresa,
                        principalTable: "CAD_EMPRESA",
                        principalColumn: "SEQ_EMPRESA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoUtilizacaoSistema_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                        column: x => x.CodLocalidadeNavigationCodLocal,
                        principalTable: "CAD_LOCAL",
                        principalColumn: "SEQ_LOCAL",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaLocalidade",
                columns: table => new
                {
                    CodEmpresa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodEmpresaNavigationCodEmpresa = table.Column<int>(type: "int", nullable: true),
                    CodLocalidade = table.Column<int>(type: "int", nullable: false),
                    CodLocalidadeNavigationCodLocal = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaLocalidade", x => x.CodEmpresa);
                    table.ForeignKey(
                        name: "FK_EmpresaLocalidade_CAD_EMPRESA_CodEmpresaNavigationCodEmpresa",
                        column: x => x.CodEmpresaNavigationCodEmpresa,
                        principalTable: "CAD_EMPRESA",
                        principalColumn: "SEQ_EMPRESA",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaLocalidade_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                        column: x => x.CodLocalidadeNavigationCodLocal,
                        principalTable: "CAD_LOCAL",
                        principalColumn: "SEQ_LOCAL",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaResponsavelTecnico",
                columns: table => new
                {
                    CodEmpresaResponsavelTecnico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodEmpresa = table.Column<int>(type: "int", nullable: false),
                    CodLocalidade = table.Column<int>(type: "int", nullable: false),
                    CodLocalidadeNavigationCodLocal = table.Column<int>(type: "int", nullable: true),
                    CodResponsavelTecnico = table.Column<int>(type: "int", nullable: false),
                    CodResponsavelTecnicoNavigationCodResponsavelTecnico = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false),
                    NumDocumentoRepresentacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaResponsavelTecnico", x => x.CodEmpresaResponsavelTecnico);
                    table.ForeignKey(
                        name: "FK_EmpresaResponsavelTecnico_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                        column: x => x.CodLocalidadeNavigationCodLocal,
                        principalTable: "CAD_LOCAL",
                        principalColumn: "SEQ_LOCAL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmpresaResponsavelTecnico_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                        column: x => x.CodResponsavelTecnicoNavigationCodResponsavelTecnico,
                        principalTable: "CAD_RESPONSAVEL_TECNICO",
                        principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuncaoSistema",
                columns: table => new
                {
                    CodFuncao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscFuncao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false),
                    FlgVisivel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuncaoSistema", x => x.CodFuncao);
                });

            migrationBuilder.CreateTable(
                name: "PerfilUsuario",
                columns: table => new
                {
                    CodPerfilUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodPerfil = table.Column<int>(type: "int", nullable: false),
                    CodPerfilNavigationCodPerfil = table.Column<int>(type: "int", nullable: true),
                    CodUsuario = table.Column<int>(type: "int", nullable: false),
                    CodUsuarioNavigationCodUsuario = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilUsuario", x => x.CodPerfilUsuario);
                    table.ForeignKey(
                        name: "FK_PerfilUsuario_CAD_PERFIL_CodPerfilNavigationCodPerfil",
                        column: x => x.CodPerfilNavigationCodPerfil,
                        principalTable: "CAD_PERFIL",
                        principalColumn: "SEQ_PERFIL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PerfilUsuario_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                        column: x => x.CodUsuarioNavigationCodUsuario,
                        principalTable: "CAD_USUARIO",
                        principalColumn: "SEQ_USUARIO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoAtribuicaoRelato",
                columns: table => new
                {
                    CodSituacaoAtribuicao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscSituacaoAtribuicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoAtribuicaoRelato", x => x.CodSituacaoAtribuicao);
                });

            migrationBuilder.CreateTable(
                name: "SituacaoRelato",
                columns: table => new
                {
                    CodSituacaoRelato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscSituacaoRelato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituacaoRelato", x => x.CodSituacaoRelato);
                });

            migrationBuilder.CreateTable(
                name: "TipoEvento",
                columns: table => new
                {
                    TipEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscTipoEvento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoEvento", x => x.TipEvento);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioLocalidade",
                columns: table => new
                {
                    CodUsuarioLocalidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodLocalidade = table.Column<int>(type: "int", nullable: false),
                    CodLocalidadeNavigationCodLocal = table.Column<int>(type: "int", nullable: true),
                    CodUsuario = table.Column<int>(type: "int", nullable: false),
                    CodUsuarioNavigationCodUsuario = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioLocalidade", x => x.CodUsuarioLocalidade);
                    table.ForeignKey(
                        name: "FK_UsuarioLocalidade_CAD_LOCAL_CodLocalidadeNavigationCodLocal",
                        column: x => x.CodLocalidadeNavigationCodLocal,
                        principalTable: "CAD_LOCAL",
                        principalColumn: "SEQ_LOCAL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsuarioLocalidade_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                        column: x => x.CodUsuarioNavigationCodUsuario,
                        principalTable: "CAD_USUARIO",
                        principalColumn: "SEQ_USUARIO",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PerfilFuncao",
                columns: table => new
                {
                    CodPerfilFuncao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodFuncao = table.Column<int>(type: "int", nullable: false),
                    CodFuncaoNavigationCodFuncao = table.Column<int>(type: "int", nullable: true),
                    CodPerfil = table.Column<int>(type: "int", nullable: false),
                    CodPerfilNavigationCodPerfil = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false)
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
                        name: "FK_PerfilFuncao_CAD_PERFIL_CodPerfilNavigationCodPerfil",
                        column: x => x.CodPerfilNavigationCodPerfil,
                        principalTable: "CAD_PERFIL",
                        principalColumn: "SEQ_PERFIL",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    CodEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CodUsuario = table.Column<int>(type: "int", nullable: false),
                    CodUsuarioNavigationCodUsuario = table.Column<int>(type: "int", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FlagAtivo = table.Column<bool>(type: "bit", nullable: false),
                    ObsEvento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipEvento = table.Column<int>(type: "int", nullable: false),
                    TipEventoNavigationTipEvento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.CodEvento);
                    table.ForeignKey(
                        name: "FK_Evento_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                        column: x => x.CodUsuarioNavigationCodUsuario,
                        principalTable: "CAD_USUARIO",
                        principalColumn: "SEQ_USUARIO",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_TipoEvento_TipEventoNavigationTipEvento",
                        column: x => x.TipEventoNavigationTipEvento,
                        principalTable: "TipoEvento",
                        principalColumn: "TipEvento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoUtilizacaoSistema_CodEmpresaNavigationCodEmpresa",
                table: "ContratoUtilizacaoSistema",
                column: "CodEmpresaNavigationCodEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoUtilizacaoSistema_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaLocalidade_CodEmpresaNavigationCodEmpresa",
                table: "EmpresaLocalidade",
                column: "CodEmpresaNavigationCodEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaLocalidade_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsavelTecnico_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CodUsuarioNavigationCodUsuario",
                table: "Evento",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipEventoNavigationTipEvento",
                table: "Evento",
                column: "TipEventoNavigationTipEvento");

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
                name: "IX_PerfilUsuario_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelato_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                principalTable: "SituacaoAtribuicaoRelato",
                principalColumn: "CodSituacaoAtribuicao",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
