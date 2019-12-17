using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambiente_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Usuarios_CodUsuarioNavigationId",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationId",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationId",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationId",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestrutura_Empresas_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationId",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropTable(
                name: "Localidade");

            migrationBuilder.DropTable(
                name: "UsuarioRelprev");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioLocalidade_CodLocalidadeNavigationCodLocalidade",
                table: "UsuarioLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioLocalidade_CodUsuarioNavigationId",
                table: "UsuarioLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioLocalidade_UsuarioRelprevCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocalidade",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationId",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_UsuarioRelprevCodUsuario",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_PerfilUsuario_CodUsuarioNavigationId",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PerfilUsuario_UsuarioRelprevCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationId",
                table: "HistoricoRelato");

            migrationBuilder.DropIndex(
                name: "IX_HistoricoRelato_UsuarioRelprevCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropIndex(
                name: "IX_Evento_CodUsuarioNavigationId",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_Evento_UsuarioRelprevCodUsuario",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaResponsavelTecnico_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaLocalidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_ContratoUtilizacaoSistema_CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_Ambiente_CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeInfraestrutura",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAssunto",
                table: "SubAssunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponsavelTecnico",
                table: "ResponsavelTecnico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assunto",
                table: "Assunto");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Done",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Reminder",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "UsuarioLocalidade");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationId",
                table: "UsuarioLocalidade");

            migrationBuilder.DropColumn(
                name: "UsuarioRelprevCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioRelatorNavigationId",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "UsuarioRelprevCodUsuario",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationId",
                table: "PerfilUsuario");

            migrationBuilder.DropColumn(
                name: "UsuarioRelprevCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationId",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "UsuarioRelprevCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationId",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "UsuarioRelprevCodUsuario",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropColumn(
                name: "CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente");

            migrationBuilder.RenameTable(
                name: "UnidadeInfraestrutura",
                newName: "UnidadeInfraestruturas");

            migrationBuilder.RenameTable(
                name: "SubAssunto",
                newName: "SubAssuntos");

            migrationBuilder.RenameTable(
                name: "ResponsavelTecnico",
                newName: "ResponsavelTecnicos");

            migrationBuilder.RenameTable(
                name: "Assunto",
                newName: "Assuntos");

            migrationBuilder.RenameIndex(
                name: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa",
                table: "UnidadeInfraestruturas",
                newName: "IX_UnidadeInfraestruturas_EmpresaCodEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_SubAssunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssuntos",
                newName: "IX_SubAssuntos_CodAssuntoNavigationCodAssunto");

            migrationBuilder.AddColumn<int>(
                name: "CodUsuario",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "DscLogin",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscSenha",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DthRegistro",
                table: "Usuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EndEmail",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlgPrimeiroAcesso",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlgUsuarioBloqueado",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomUsuario",
                table: "Usuarios",
                maxLength: 800,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumCpf",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumTelefone",
                table: "Usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QtdTentativasIncorretas",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubLocalCodSubLocal",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioNavigationCodUsuario",
                table: "Evento",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "Ambiente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumDocumento",
                table: "ResponsavelTecnicos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "CodUsuario");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeInfraestruturas",
                table: "UnidadeInfraestruturas",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAssuntos",
                table: "SubAssuntos",
                column: "CodSubAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponsavelTecnicos",
                table: "ResponsavelTecnicos",
                column: "CodResponsavelTecnico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assuntos",
                table: "Assuntos",
                column: "CodAssunto");

            migrationBuilder.CreateTable(
                name: "Local",
                columns: table => new
                {
                    CodLocal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscLocal = table.Column<string>(nullable: true),
                    SigLocal = table.Column<string>(nullable: true),
                    EndLocal = table.Column<string>(nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(nullable: false),
                    DatFimVigencia = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.CodLocal);
                });

            migrationBuilder.CreateTable(
                name: "SubLocals",
                columns: table => new
                {
                    CodSubLocal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscSubLocal = table.Column<string>(nullable: true),
                    CodLocal = table.Column<int>(nullable: false),
                    CodLocalNavigationCodLocal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubLocals", x => x.CodSubLocal);
                    table.ForeignKey(
                        name: "FK_SubLocals_Local_CodLocalNavigationCodLocal",
                        column: x => x.CodLocalNavigationCodLocal,
                        principalTable: "Local",
                        principalColumn: "CodLocal",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioLocalidade_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocal",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_SubLocalCodSubLocal",
                table: "Relato",
                column: "SubLocalCodSubLocal");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CodUsuarioNavigationCodUsuario",
                table: "Evento",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsavelTecnico_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaLocalidade_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoUtilizacaoSistema_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Ambiente_CodLocalidadeNavigationCodLocal",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_SubLocals_CodLocalNavigationCodLocal",
                table: "SubLocals",
                column: "CodLocalNavigationCodLocal");

            migrationBuilder.AddForeignKey(
                name: "FK_Ambiente_Local_CodLocalidadeNavigationCodLocal",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnicos",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Local_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnicos",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "Evento",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assuntos",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Local_CodLocalidadeNavigationCodLocal",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssuntos_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto",
                principalTable: "SubAssuntos",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubLocals_SubLocalCodSubLocal",
                table: "Relato",
                column: "SubLocalCodSubLocal",
                principalTable: "SubLocals",
                principalColumn: "CodSubLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssuntos_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "SubAssuntos",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assuntos",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestruturas_Empresas_EmpresaCodEmpresa",
                table: "UnidadeInfraestruturas",
                column: "EmpresaCodEmpresa",
                principalTable: "Empresas",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "Usuarios",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambiente_Local_CodLocalidadeNavigationCodLocal",
                table: "Ambiente");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Local_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_Local_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnicos_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_Evento_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "Evento");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Local_CodLocalidadeNavigationCodLocal",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssuntos_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubLocals_SubLocalCodSubLocal",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssuntos_Assuntos_CodAssuntoNavigationCodAssunto",
                table: "SubAssuntos");

            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestruturas_Empresas_EmpresaCodEmpresa",
                table: "UnidadeInfraestruturas");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Local_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropTable(
                name: "SubLocals");

            migrationBuilder.DropTable(
                name: "Local");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioLocalidade_CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioLocalidade_CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocal",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_SubLocalCodSubLocal",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_PerfilUsuario_CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropIndex(
                name: "IX_Evento_CodUsuarioNavigationCodUsuario",
                table: "Evento");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaResponsavelTecnico_CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropIndex(
                name: "IX_EmpresaLocalidade_CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade");

            migrationBuilder.DropIndex(
                name: "IX_ContratoUtilizacaoSistema_CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_Ambiente_CodLocalidadeNavigationCodLocal",
                table: "Ambiente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeInfraestruturas",
                table: "UnidadeInfraestruturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAssuntos",
                table: "SubAssuntos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponsavelTecnicos",
                table: "ResponsavelTecnicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assuntos",
                table: "Assuntos");

            migrationBuilder.DropColumn(
                name: "CodUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DscLogin",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DscSenha",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DthRegistro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "EndEmail",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FlgPrimeiroAcesso",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FlgUsuarioBloqueado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NomUsuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NumCpf",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "NumTelefone",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "QtdTentativasIncorretas",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "UsuarioLocalidade");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationCodUsuario",
                table: "UsuarioLocalidade");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "SubLocalCodSubLocal",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationCodUsuario",
                table: "PerfilUsuario");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationCodUsuario",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "EmpresaLocalidade");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropColumn(
                name: "CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "Ambiente");

            migrationBuilder.DropColumn(
                name: "NumDocumento",
                table: "ResponsavelTecnicos");

            migrationBuilder.RenameTable(
                name: "UnidadeInfraestruturas",
                newName: "UnidadeInfraestrutura");

            migrationBuilder.RenameTable(
                name: "SubAssuntos",
                newName: "SubAssunto");

            migrationBuilder.RenameTable(
                name: "ResponsavelTecnicos",
                newName: "ResponsavelTecnico");

            migrationBuilder.RenameTable(
                name: "Assuntos",
                newName: "Assunto");

            migrationBuilder.RenameIndex(
                name: "IX_UnidadeInfraestruturas_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                newName: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa");

            migrationBuilder.RenameIndex(
                name: "IX_SubAssuntos_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                newName: "IX_SubAssunto_CodAssuntoNavigationCodAssunto");

            migrationBuilder.AddColumn<long>(
                name: "Id",
                table: "Usuarios",
                type: "bigint",
                nullable: false,
                defaultValue: 0L)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Reminder",
                table: "Usuarios",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Usuarios",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "UsuarioLocalidade",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CodUsuarioNavigationId",
                table: "UsuarioLocalidade",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioRelprevCodUsuario",
                table: "UsuarioLocalidade",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CodUsuarioRelatorNavigationId",
                table: "Relato",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioRelprevCodUsuario",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CodUsuarioNavigationId",
                table: "PerfilUsuario",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioRelprevCodUsuario",
                table: "PerfilUsuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CodUsuarioNavigationId",
                table: "HistoricoRelato",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioRelprevCodUsuario",
                table: "HistoricoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CodUsuarioNavigationId",
                table: "Evento",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioRelprevCodUsuario",
                table: "Evento",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeInfraestrutura",
                table: "UnidadeInfraestrutura",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAssunto",
                table: "SubAssunto",
                column: "CodSubAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponsavelTecnico",
                table: "ResponsavelTecnico",
                column: "CodResponsavelTecnico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assunto",
                table: "Assunto",
                column: "CodAssunto");

            migrationBuilder.CreateTable(
                name: "Localidade",
                columns: table => new
                {
                    CodLocalidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatFimVigencia = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatInicioVigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscLocalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndLocalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SigLocalidade = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidade", x => x.CodLocalidade);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioRelprev",
                columns: table => new
                {
                    CodUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlteradoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriadoPor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DscLogin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DscSenha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DthRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlgPrimeiroAcesso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlgUsuarioBloqueado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomUsuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumCpf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QtdTentativasIncorretas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioRelprev", x => x.CodUsuario);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocalidade",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationId",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_UsuarioRelprevCodUsuario",
                table: "Relato",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_CodUsuarioNavigationId",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilUsuario_UsuarioRelprevCodUsuario",
                table: "PerfilUsuario",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationId",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_UsuarioRelprevCodUsuario",
                table: "HistoricoRelato",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_CodUsuarioNavigationId",
                table: "Evento",
                column: "CodUsuarioNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_UsuarioRelprevCodUsuario",
                table: "Evento",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaResponsavelTecnico_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaLocalidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoUtilizacaoSistema_CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato",
                column: "UsuarioRelprevCodUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Ambiente_CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocalidade");

            migrationBuilder.AddForeignKey(
                name: "FK_Ambiente_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "Ambiente",
                column: "CodLocalidadeNavigationCodLocalidade",
                principalTable: "Localidade",
                principalColumn: "CodLocalidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_Usuarios_CodUsuarioAtribuidorNavigationId",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "AtribuicaoRelato",
                column: "UsuarioRelprevCodUsuario",
                principalTable: "UsuarioRelprev",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ContratoUtilizacaoSistema_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "ContratoUtilizacaoSistema",
                column: "CodLocalidadeNavigationCodLocalidade",
                principalTable: "Localidade",
                principalColumn: "CodLocalidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaLocalidade_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaLocalidade",
                column: "CodLocalidadeNavigationCodLocalidade",
                principalTable: "Localidade",
                principalColumn: "CodLocalidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "EmpresaResponsavelTecnico",
                column: "CodLocalidadeNavigationCodLocalidade",
                principalTable: "Localidade",
                principalColumn: "CodLocalidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_Usuarios_CodUsuarioNavigationId",
                table: "Evento",
                column: "CodUsuarioNavigationId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Evento_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "Evento",
                column: "UsuarioRelprevCodUsuario",
                principalTable: "UsuarioRelprev",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_Usuarios_CodUsuarioNavigationId",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "HistoricoRelato",
                column: "UsuarioRelprevCodUsuario",
                principalTable: "UsuarioRelprev",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_Usuarios_CodUsuarioNavigationId",
                table: "PerfilUsuario",
                column: "CodUsuarioNavigationId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PerfilUsuario_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "PerfilUsuario",
                column: "UsuarioRelprevCodUsuario",
                principalTable: "UsuarioRelprev",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocalidade",
                principalTable: "Localidade",
                principalColumn: "CodLocalidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto",
                principalTable: "SubAssunto",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Usuarios_CodUsuarioRelatorNavigationId",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "Relato",
                column: "UsuarioRelprevCodUsuario",
                principalTable: "UsuarioRelprev",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestrutura_Empresas_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                column: "EmpresaCodEmpresa",
                principalTable: "Empresas",
                principalColumn: "CodEmpresa",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Localidade_CodLocalidadeNavigationCodLocalidade",
                table: "UsuarioLocalidade",
                column: "CodLocalidadeNavigationCodLocalidade",
                principalTable: "Localidade",
                principalColumn: "CodLocalidade",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_Usuarios_CodUsuarioNavigationId",
                table: "UsuarioLocalidade",
                column: "CodUsuarioNavigationId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioLocalidade_UsuarioRelprev_UsuarioRelprevCodUsuario",
                table: "UsuarioLocalidade",
                column: "UsuarioRelprevCodUsuario",
                principalTable: "UsuarioRelprev",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
