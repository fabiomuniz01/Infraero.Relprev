using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubLocal_Local_CodLocal",
                table: "SubLocal");

            migrationBuilder.DropForeignKey(
                name: "FK_SubLocal_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "SubLocal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubLocal",
                table: "SubLocal");

            migrationBuilder.DropIndex(
                name: "IX_SubLocal_CodUnidadeInfraestrutura",
                table: "SubLocal");

            migrationBuilder.RenameTable(
                name: "SubLocal",
                newName: "CAD_SUBLOCAL");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_SUBLOCAL",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DscSubLocal",
                table: "CAD_SUBLOCAL",
                newName: "DSC_SUBLOCAL");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_SUBLOCAL",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_SUBLOCAL",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_SUBLOCAL",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_SUBLOCAL",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "CodLocal",
                table: "CAD_SUBLOCAL",
                newName: "COD_LOCAL");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_SUBLOCAL",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameIndex(
                name: "IX_SubLocal_CodLocal",
                table: "CAD_SUBLOCAL",
                newName: "IX_CAD_SUBLOCAL_COD_LOCAL");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_SUBLOCAL",
                table: "CAD_SUBLOCAL",
                column: "CodSubLocal");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3577));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 951, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 7, 20, 59, 21, 948, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBLOCAL_Local_COD_LOCAL",
                table: "CAD_SUBLOCAL",
                column: "COD_LOCAL",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBLOCAL_Local_COD_LOCAL",
                table: "CAD_SUBLOCAL");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_SUBLOCAL",
                table: "CAD_SUBLOCAL");

            migrationBuilder.RenameTable(
                name: "CAD_SUBLOCAL",
                newName: "SubLocal");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "SubLocal",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DSC_SUBLOCAL",
                table: "SubLocal",
                newName: "DscSubLocal");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "SubLocal",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "SubLocal",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "SubLocal",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "SubLocal",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "COD_LOCAL",
                table: "SubLocal",
                newName: "CodLocal");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "SubLocal",
                newName: "AlteradoPor");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_SUBLOCAL_COD_LOCAL",
                table: "SubLocal",
                newName: "IX_SubLocal_CodLocal");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubLocal",
                table: "SubLocal",
                column: "CodSubLocal");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4777));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 495, DateTimeKind.Local).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 3, 26, 9, 32, 14, 494, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.CreateIndex(
                name: "IX_SubLocal_CodUnidadeInfraestrutura",
                table: "SubLocal",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_SubLocal_Local_CodLocal",
                table: "SubLocal",
                column: "CodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubLocal_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "SubLocal",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
