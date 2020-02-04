using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Local_CodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropColumn(
                name: "CodUnidade",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "DtFimVigencia",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "DtIniVigencia",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "NomUnidadeÌnfraestrutura",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "UnidadeInfraestrutura");

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura");

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
                name: "FK_Relato_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Local_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Local_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Local");

            migrationBuilder.AddColumn<string>(
                name: "CodUnidade",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFimVigencia",
                table: "UnidadeInfraestrutura",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIniVigencia",
                table: "UnidadeInfraestrutura",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomUnidadeÌnfraestrutura",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodUnidadeInfraestrutura",
                table: "Relato",
                column: "CodUnidadeInfraestrutura");

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
                name: "FK_Relato_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Relato",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
