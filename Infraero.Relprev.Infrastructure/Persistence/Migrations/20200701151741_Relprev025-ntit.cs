using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev025ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RESPONSAVEL_TECNICO_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.DropColumn(
                name: "COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.AddColumn<int>(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_VINCULO_RESPONSAVEL_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropIndex(
                name: "IX_CAD_VINCULO_RESPONSAVEL_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.AddColumn<int>(
                name: "COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 940, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 25, 20, 43, 16, 937, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                column: "COD_EMPRESA");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RESPONSAVEL_TECNICO_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
