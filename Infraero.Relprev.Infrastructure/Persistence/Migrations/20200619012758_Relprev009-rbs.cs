using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev009rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
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
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_TECNICO");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO");

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
    }
}
