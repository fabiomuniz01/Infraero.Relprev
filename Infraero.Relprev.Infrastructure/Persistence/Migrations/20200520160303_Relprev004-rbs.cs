using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev004rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL_OCORRENCIARELATOR",
                table: "CAD_RELATO",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldMaxLength: 5);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL_OCORRENCIARELATOR",
                table: "CAD_RELATO",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 22, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 51, 11, 18, DateTimeKind.Local).AddTicks(7111));
        }
    }
}
