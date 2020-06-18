using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev019ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DSC_ACOES_CORRETIVAS_RECOMENDADAS",
                table: "CAD_RELATO",
                maxLength: 500,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 648, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 17, 23, 10, 5, 644, DateTimeKind.Local).AddTicks(5186));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DSC_ACOES_CORRETIVAS_RECOMENDADAS",
                table: "CAD_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 378, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 13, 22, 29, 34, 374, DateTimeKind.Local).AddTicks(8293));
        }
    }
}
