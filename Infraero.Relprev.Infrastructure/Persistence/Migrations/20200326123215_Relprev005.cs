using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_ASSUNTO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_ASSUNTO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_ASSUNTO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_ASSUNTO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodAssunto",
                table: "CAD_ASSUNTO",
                newName: "SEQ_ASSUNTO");

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "VinculoUnidadeEmpresa",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "UsuarioLocalidade",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Usuario",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "UnidadeInfraestrutura",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "TipoEvento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "SubLocal",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "SubAssunto",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "SubAmbiente",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "SituacaoRelato",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "SituacaoAtribuicaoRelato",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "ResponsavelTecnico",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "RelatoArquivo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Relato",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "PerfilUsuario",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "PerfilFuncao",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Perfil",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Modulo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Local",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "HistoricoRelato",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Funcionalidade",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "FuncaoSistema",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Evento",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "EmpresaResponsavelTecnico",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "EmpresaLocalidade",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Empresa",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "ContratoUtilizacaoSistema",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ASSUNTO",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "AtribuicaoRelato",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Arquivo",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "FlagAtivo",
                table: "Ambiente",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1470));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "UsuarioLocalidade");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "TipoEvento");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "SubLocal");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "SubAssunto");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "SubAmbiente");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "SituacaoRelato");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "SituacaoAtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "ResponsavelTecnico");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "RelatoArquivo");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "PerfilUsuario");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "PerfilFuncao");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Modulo");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Local");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "HistoricoRelato");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Funcionalidade");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "FuncaoSistema");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Evento");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "EmpresaLocalidade");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "ContratoUtilizacaoSistema");

            migrationBuilder.DropColumn(
                name: "FLG_ATIVO",
                table: "CAD_ASSUNTO");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Arquivo");

            migrationBuilder.DropColumn(
                name: "FlagAtivo",
                table: "Ambiente");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "CAD_ASSUNTO",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "CAD_ASSUNTO",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ASSUNTO",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ASSUNTO",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_ASSUNTO",
                table: "CAD_ASSUNTO",
                newName: "CodAssunto");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 411, DateTimeKind.Local).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 58, 16, 409, DateTimeKind.Local).AddTicks(9177));
        }
    }
}
