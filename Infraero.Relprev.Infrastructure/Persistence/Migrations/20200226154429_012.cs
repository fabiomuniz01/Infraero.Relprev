using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_SubLocal_Local_CodLocal",
                table: "SubLocal");

            migrationBuilder.DropIndex(
                name: "IX_SubLocal_CodLocal",
                table: "SubLocal");

            migrationBuilder.DropIndex(
                name: "IX_Local_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.AddColumn<int>(
                name: "LocalCodLocal",
                table: "SubLocal",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 122, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 118, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 12, 44, 28, 119, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.CreateIndex(
                name: "IX_SubLocal_LocalCodLocal",
                table: "SubLocal",
                column: "LocalCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Local_CodUnidadeInfraestrutura",
                table: "Local",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Local",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubLocal_Local_LocalCodLocal",
                table: "SubLocal",
                column: "LocalCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_SubLocal_Local_LocalCodLocal",
                table: "SubLocal");

            migrationBuilder.DropIndex(
                name: "IX_SubLocal_LocalCodLocal",
                table: "SubLocal");

            migrationBuilder.DropIndex(
                name: "IX_Local_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropColumn(
                name: "LocalCodLocal",
                table: "SubLocal");

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 117, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 26, 8, 26, 7, 115, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.CreateIndex(
                name: "IX_SubLocal_CodLocal",
                table: "SubLocal",
                column: "CodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Local_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubLocal_Local_CodLocal",
                table: "SubLocal",
                column: "CodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
