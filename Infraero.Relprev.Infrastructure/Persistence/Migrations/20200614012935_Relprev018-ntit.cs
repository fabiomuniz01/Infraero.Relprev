using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev018ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DSC_FINALIZACAO",
                table: "HST_CAD_RELATO",
                maxLength: 255,
                nullable: true,
                comment: "Descriçao do status de finalização");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DSC_FINALIZACAO",
                table: "HST_CAD_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9224));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 931, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 12, 2, 16, 27, 930, DateTimeKind.Local).AddTicks(1131));
        }
    }
}
