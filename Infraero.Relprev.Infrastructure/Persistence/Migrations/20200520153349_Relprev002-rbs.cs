using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev002rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HorOcorrencia",
                table: "CAD_RELATO",
                newName: "HOR_OCORRENCIA");

            migrationBuilder.AlterColumn<string>(
                name: "HOR_OCORRENCIA",
                table: "CAD_RELATO",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 653, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 20, 12, 33, 48, 649, DateTimeKind.Local).AddTicks(4412));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HOR_OCORRENCIA",
                table: "CAD_RELATO",
                newName: "HorOcorrencia");

            migrationBuilder.AlterColumn<string>(
                name: "HorOcorrencia",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3813));
        }
    }
}
