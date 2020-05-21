using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev005rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_Ambiente_AmbienteCodAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_RELATO_AmbienteCodAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_RELATO_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_RELATO_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_RELATO_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "AmbienteCodAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 431, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 426, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 21, 24, 38, 427, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RELATO_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO",
                column: "COD_UNIDADE_ESINFRAESTRUTURA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO",
                column: "COD_UNIDADE_ESINFRAESTRUTURA",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_RELATO_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO");

            migrationBuilder.AddColumn<int>(
                name: "AmbienteCodAmbiente",
                table: "CAD_RELATO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 255, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 250, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 13, 3, 1, 251, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RELATO_AmbienteCodAmbiente",
                table: "CAD_RELATO",
                column: "AmbienteCodAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RELATO_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO",
                column: "SituacaoRelatoCodSituacaoRelato");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RELATO_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO",
                column: "SubAmbienteCodSubAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RELATO_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_Ambiente_AmbienteCodAmbiente",
                table: "CAD_RELATO",
                column: "AmbienteCodAmbiente",
                principalTable: "Ambiente",
                principalColumn: "CodAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO",
                column: "SituacaoRelatoCodSituacaoRelato",
                principalTable: "SituacaoRelato",
                principalColumn: "CodSituacaoRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO",
                column: "SubAmbienteCodSubAmbiente",
                principalTable: "SubAmbiente",
                principalColumn: "CodSubAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
