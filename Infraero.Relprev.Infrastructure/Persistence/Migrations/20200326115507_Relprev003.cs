using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev003 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BinArquivo",
                table: "Arquivo");

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Arquivo",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 953, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 8, 55, 5, 950, DateTimeKind.Local).AddTicks(6779));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Arquivo");

            migrationBuilder.AddColumn<byte[]>(
                name: "BinArquivo",
                table: "Arquivo",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4263));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 650, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 11, 18, 47, 37, 648, DateTimeKind.Local).AddTicks(4948));
        }
    }
}
