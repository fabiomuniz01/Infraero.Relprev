using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev016ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HistoricoRelato",
                table: "HistoricoRelato");

            migrationBuilder.DropIndex(
                name: "IX_HistoricoRelato_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato");

            migrationBuilder.DropIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "DSC_RELATO",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "CodHistorico",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "CodRelatoNavigationCodRelato",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "CodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "DscHistorico",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "DthRegistro",
                table: "HistoricoRelato");

            migrationBuilder.RenameTable(
                name: "HistoricoRelato",
                newName: "HST_CAD_RELATO");

            migrationBuilder.RenameColumn(
                name: "DscOcorrenciaRelator",
                table: "CAD_RELATO",
                newName: "DSC_OCORRENCIA_RELATOR");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "HST_CAD_RELATO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "HST_CAD_RELATO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "HST_CAD_RELATO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "HST_CAD_RELATO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodRelato",
                table: "HST_CAD_RELATO",
                newName: "COD_RELATO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "HST_CAD_RELATO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodHistoricoRelato",
                table: "HST_CAD_RELATO",
                newName: "SEQ_HISTORICO_RELATO");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_OCORRENCIA_RELATOR",
                table: "CAD_RELATO",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Codigo sequencial do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "HST_CAD_RELATO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_HISTORICO_RELATO",
                table: "HST_CAD_RELATO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "DSC_ATRIBUICAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de atribuição");

            migrationBuilder.AddColumn<string>(
                name: "DSC_CLASSIFICACAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de classificação");

            migrationBuilder.AddColumn<string>(
                name: "DSC_NAO_INICIADO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status nao iniciado");

            migrationBuilder.AddColumn<string>(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do assunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HST_CAD_RELATO",
                table: "HST_CAD_RELATO",
                column: "SEQ_HISTORICO_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 916, DateTimeKind.Local).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 912, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 21, 22, 17, 913, DateTimeKind.Local).AddTicks(815));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HST_CAD_RELATO",
                table: "HST_CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DSC_ATRIBUICAO",
                table: "HST_CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DSC_CLASSIFICACAO",
                table: "HST_CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DSC_NAO_INICIADO",
                table: "HST_CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "DSC_ULTIMA_OCORRENCIA",
                table: "HST_CAD_RELATO");

            migrationBuilder.RenameTable(
                name: "HST_CAD_RELATO",
                newName: "HistoricoRelato");

            migrationBuilder.RenameColumn(
                name: "DSC_OCORRENCIA_RELATOR",
                table: "CAD_RELATO",
                newName: "DscOcorrenciaRelator");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "HistoricoRelato",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "HistoricoRelato",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "HistoricoRelato",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "HistoricoRelato",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_RELATO",
                table: "HistoricoRelato",
                newName: "CodRelato");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "HistoricoRelato",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_HISTORICO_RELATO",
                table: "HistoricoRelato",
                newName: "CodHistoricoRelato");

            migrationBuilder.AlterColumn<string>(
                name: "DscOcorrenciaRelator",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AddColumn<string>(
                name: "DSC_RELATO",
                table: "CAD_RELATO",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<bool>(
                name: "FlagAtivo",
                table: "HistoricoRelato",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "HistoricoRelato",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "HistoricoRelato",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "CriadoPor",
                table: "HistoricoRelato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "CodRelato",
                table: "HistoricoRelato",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Codigo sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "AlteradoPor",
                table: "HistoricoRelato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "CodHistoricoRelato",
                table: "HistoricoRelato",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CodHistorico",
                table: "HistoricoRelato",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodRelatoNavigationCodRelato",
                table: "HistoricoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuario",
                table: "HistoricoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscHistorico",
                table: "HistoricoRelato",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DthRegistro",
                table: "HistoricoRelato",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_HistoricoRelato",
                table: "HistoricoRelato",
                column: "CodHistoricoRelato");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato",
                column: "CodRelatoNavigationCodRelato");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoRelato_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato",
                column: "CodRelatoNavigationCodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_CAD_USUARIO_CodUsuarioNavigationCodUsuario",
                table: "HistoricoRelato",
                column: "CodUsuarioNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
