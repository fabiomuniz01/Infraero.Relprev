using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev004 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Assunto",
                table: "Assunto");

            migrationBuilder.RenameTable(
                name: "Assunto",
                newName: "CAD_ASSUNTO");

            migrationBuilder.RenameColumn(
                name: "DscAssunto",
                table: "CAD_ASSUNTO",
                newName: "DSC_ASSUNTO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_ASSUNTO",
                table: "CAD_ASSUNTO",
                column: "CodAssunto");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_CAD_ASSUNTO_CodAssunto",
                table: "SubAssunto",
                column: "CodAssunto",
                principalTable: "CAD_ASSUNTO",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_CAD_ASSUNTO_CodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_ASSUNTO",
                table: "CAD_ASSUNTO");

            migrationBuilder.RenameTable(
                name: "CAD_ASSUNTO",
                newName: "Assunto");

            migrationBuilder.RenameColumn(
                name: "DSC_ASSUNTO",
                table: "Assunto",
                newName: "DscAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Assunto",
                table: "Assunto",
                column: "CodAssunto");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssunto",
                table: "SubAssunto",
                column: "CodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
