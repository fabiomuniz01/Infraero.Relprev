using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev003ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RelatoArquivo_CAD_RELATO_CodRelato",
                table: "RelatoArquivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RelatoArquivo",
                table: "RelatoArquivo");

            migrationBuilder.DropColumn(
                name: "Documento",
                table: "RelatoArquivo");

            migrationBuilder.RenameTable(
                name: "RelatoArquivo",
                newName: "CAD_RELATO_ARQUIVO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_RELATO_ARQUIVO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_RELATO_ARQUIVO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_RELATO_ARQUIVO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_RELATO_ARQUIVO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodRelato",
                table: "CAD_RELATO_ARQUIVO",
                newName: "COD_RELATO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_RELATO_ARQUIVO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodRelatoArquivo",
                table: "CAD_RELATO_ARQUIVO",
                newName: "SEQ_RELATO_ARQUIVO");

            migrationBuilder.RenameIndex(
                name: "IX_RelatoArquivo_CodRelato",
                table: "CAD_RELATO_ARQUIVO",
                newName: "IX_CAD_RELATO_ARQUIVO_COD_RELATO");

            migrationBuilder.AddColumn<string>(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NOM_CAMINHO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO",
                column: "SEQ_RELATO_ARQUIVO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 554, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 21, 0, 13, 12, 549, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_ARQUIVO_CAD_RELATO_COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_ARQUIVO_CAD_RELATO_COD_RELATO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_RELATO_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.DropColumn(
                name: "NOM_ARQUIVO_UNICO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.DropColumn(
                name: "NOM_CAMINHO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.DropColumn(
                name: "NOM_ARQUIVO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.RenameTable(
                name: "CAD_RELATO_ARQUIVO",
                newName: "RelatoArquivo");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "RelatoArquivo",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "RelatoArquivo",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "RelatoArquivo",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "RelatoArquivo",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_RELATO",
                table: "RelatoArquivo",
                newName: "CodRelato");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "RelatoArquivo",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_RELATO_ARQUIVO",
                table: "RelatoArquivo",
                newName: "CodRelatoArquivo");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_RELATO_ARQUIVO_COD_RELATO",
                table: "RelatoArquivo",
                newName: "IX_RelatoArquivo_CodRelato");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "RelatoArquivo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RelatoArquivo",
                table: "RelatoArquivo",
                column: "CodRelatoArquivo");

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

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoArquivo_CAD_RELATO_CodRelato",
                table: "RelatoArquivo",
                column: "CodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
