using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev003rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumTelefoneRelator",
                table: "CAD_RELATO",
                newName: "NUM_TELEFONE_RELATOR");

            migrationBuilder.RenameColumn(
                name: "NomRelator",
                table: "CAD_RELATO",
                newName: "NOM_RELATOR");

            migrationBuilder.RenameColumn(
                name: "NomEmpresaRelator",
                table: "CAD_RELATO",
                newName: "NOM_EMPRESA_RELATOR");

            migrationBuilder.RenameColumn(
                name: "EmailRelator",
                table: "CAD_RELATO",
                newName: "EMAIL_RELATOR");

            migrationBuilder.RenameColumn(
                name: "DscRelato",
                table: "CAD_RELATO",
                newName: "DSC_RELATO");

            migrationBuilder.RenameColumn(
                name: "DscLocalOcorrenciaRelator",
                table: "CAD_RELATO",
                newName: "DSC_LOCAL_OCORRENCIARELATOR");

            migrationBuilder.RenameColumn(
                name: "DscEnvolvidosOcorrencia",
                table: "CAD_RELATO",
                newName: "DSC_ENVOLVIDO_OCORRENCIA");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_RELATO",
                newName: "COD_UNIDADE_ESINFRAESTRUTURA");

            migrationBuilder.AlterColumn<string>(
                name: "NUM_TELEFONE_RELATOR",
                table: "CAD_RELATO",
                maxLength: 11,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RELATOR",
                table: "CAD_RELATO",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_EMPRESA_RELATOR",
                table: "CAD_RELATO",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EMAIL_RELATOR",
                table: "CAD_RELATO",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_RELATO",
                table: "CAD_RELATO",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_LOCAL_OCORRENCIARELATOR",
                table: "CAD_RELATO",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DSC_ENVOLVIDO_OCORRENCIA",
                table: "CAD_RELATO",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NUM_TELEFONE_RELATOR",
                table: "CAD_RELATO",
                newName: "NumTelefoneRelator");

            migrationBuilder.RenameColumn(
                name: "NOM_RELATOR",
                table: "CAD_RELATO",
                newName: "NomRelator");

            migrationBuilder.RenameColumn(
                name: "NOM_EMPRESA_RELATOR",
                table: "CAD_RELATO",
                newName: "NomEmpresaRelator");

            migrationBuilder.RenameColumn(
                name: "EMAIL_RELATOR",
                table: "CAD_RELATO",
                newName: "EmailRelator");

            migrationBuilder.RenameColumn(
                name: "DSC_RELATO",
                table: "CAD_RELATO",
                newName: "DscRelato");

            migrationBuilder.RenameColumn(
                name: "DSC_LOCAL_OCORRENCIARELATOR",
                table: "CAD_RELATO",
                newName: "DscLocalOcorrenciaRelator");

            migrationBuilder.RenameColumn(
                name: "DSC_ENVOLVIDO_OCORRENCIA",
                table: "CAD_RELATO",
                newName: "DscEnvolvidosOcorrencia");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.AlterColumn<string>(
                name: "NumTelefoneRelator",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomRelator",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomEmpresaRelator",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailRelator",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DscRelato",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "DscLocalOcorrenciaRelator",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "DscEnvolvidosOcorrencia",
                table: "CAD_RELATO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

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
    }
}
