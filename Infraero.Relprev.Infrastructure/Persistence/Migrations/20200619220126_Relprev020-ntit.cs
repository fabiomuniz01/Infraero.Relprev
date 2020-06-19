using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev020ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_USUARIO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.AddColumn<bool>(
                name: "FLG_GESTOR_SGSO",
                table: "CAD_RESPONSAVEL_TECNICO",
                nullable: false,
                defaultValue: false,
                comment: "Flag gestor sgso site");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 817, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 19, 19, 1, 24, 813, DateTimeKind.Local).AddTicks(2081));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FLG_GESTOR_SGSO",
                table: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.AddColumn<int>(
                name: "COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Código do responsavel SGSO da atribuicao do relato");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 631, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 18, 22, 27, 56, 628, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_SGSO");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_USUARIO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_SGSO",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
