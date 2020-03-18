using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VinculoUnidadeEmpresa_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.DropIndex(
                name: "IX_VinculoUnidadeEmpresa_CodUnidadeInfraestrutura",
                table: "VinculoUnidadeEmpresa");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 308, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 9, 3, 58, 307, DateTimeKind.Local).AddTicks(3036));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 277, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 10, 8, 15, 48, 276, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.CreateIndex(
                name: "IX_VinculoUnidadeEmpresa_CodUnidadeInfraestrutura",
                table: "VinculoUnidadeEmpresa",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_VinculoUnidadeEmpresa_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "VinculoUnidadeEmpresa",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
