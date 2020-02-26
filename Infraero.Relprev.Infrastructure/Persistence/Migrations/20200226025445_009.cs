using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodEmpresaResponsavelTecnico",
                table: "ResponsavelTecnico");

            migrationBuilder.AlterColumn<string>(
                name: "NumTelefone",
                table: "Usuario",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumCpf",
                table: "Usuario",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomUsuario",
                table: "Usuario",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuario",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumTelefone",
                table: "ResponsavelTecnico",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumDocumento",
                table: "ResponsavelTecnico",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumCpf",
                table: "ResponsavelTecnico",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomResponsavelTecnico",
                table: "ResponsavelTecnico",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EndEmail",
                table: "ResponsavelTecnico",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodEmpresa",
                table: "ResponsavelTecnico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 174, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 25, 23, 54, 45, 173, DateTimeKind.Local).AddTicks(805));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodEmpresa",
                table: "ResponsavelTecnico");

            migrationBuilder.AlterColumn<string>(
                name: "NumTelefone",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NumCpf",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NomUsuario",
                table: "Usuario",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "NumTelefone",
                table: "ResponsavelTecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NumDocumento",
                table: "ResponsavelTecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumCpf",
                table: "ResponsavelTecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<string>(
                name: "NomResponsavelTecnico",
                table: "ResponsavelTecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "EndEmail",
                table: "ResponsavelTecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodEmpresaResponsavelTecnico",
                table: "ResponsavelTecnico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 285, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 2, 23, 22, 0, 3, 283, DateTimeKind.Local).AddTicks(8491));
        }
    }
}
