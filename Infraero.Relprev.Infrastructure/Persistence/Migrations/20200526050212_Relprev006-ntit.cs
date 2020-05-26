using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev006ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TXT_MOTIVO_CANCELAMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                maxLength: 1000,
                nullable: false,
                comment: "Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato",
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_PARECER_TECNICO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Tempo que o técnico deve ter para responder um parecer técnico",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_DEVOLVIDO_PARA_COMPLEMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_CONFIG_AMBIENTE",
                table: "CAD_CONFIG_AMBIENTE",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9907));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.InsertData(
                table: "Modulo",
                columns: new[] { "CodModulo", "AlteradoPor", "CriadoPor", "DataAlteracao", "DataCriacao", "FlagAtivo", "NomModulo" },
                values: new object[] { 15, null, "SistemaRelprev", null, new DateTime(2020, 5, 26, 2, 2, 10, 301, DateTimeKind.Local).AddTicks(1966), false, "ConfigurarAmbiente" });

            migrationBuilder.InsertData(
                table: "Funcionalidade",
                columns: new[] { "CodFuncionalidade", "AlteradoPor", "CodModulo", "CriadoPor", "DataAlteracao", "DataCriacao", "FlagAtivo", "NomFuncionalidade" },
                values: new object[] { 15, null, 15, "SistemaRelprev", null, new DateTime(2020, 5, 26, 2, 2, 10, 304, DateTimeKind.Local).AddTicks(9917), false, "Consultar,Incluir,Alterar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15);

            migrationBuilder.AlterColumn<string>(
                name: "TXT_MOTIVO_CANCELAMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldComment: "Texto descritivo a ser inserido no e-mail de notificação em caso de cancelamento do relato");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_TEMPO_NOTIFICACAO_PARA_RESPONDER",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Tempo em que dever ser notificado por e-mail as Respostas dos Pareceres Técnicos");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_PARECER_TECNICO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Tempo que o técnico deve ter para responder um parecer técnico");

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<int>(
                name: "QTD_DEVOLVIDO_PARA_COMPLEMENTO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Tempo de resposta do parecer técnico quando o mesmo é rejeitado e devolvido para complemento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_CONFIG_AMBIENTE",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_CONFIG_AMBIENTE",
                table: "CAD_CONFIG_AMBIENTE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 317, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 26, 1, 56, 51, 314, DateTimeKind.Local).AddTicks(4727));
        }
    }
}
