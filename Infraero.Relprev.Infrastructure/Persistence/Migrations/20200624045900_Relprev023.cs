using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev023 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 163, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 24, 1, 58, 59, 161, DateTimeKind.Local).AddTicks(2119));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 214, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 211, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 22, 10, 6, 59, 212, DateTimeKind.Local).AddTicks(1029));
        }
    }
}
