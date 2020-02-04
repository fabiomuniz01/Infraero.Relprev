using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev010 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UnidadeInfraestrutura_ResponsavelTecnico_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropIndex(
                name: "IX_UnidadeInfraestrutura_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropColumn(
                name: "ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura");

            migrationBuilder.AddColumn<string>(
                name: "CodUnidade",
                table: "UnidadeInfraestrutura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "UnidadeInfraestrutura",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtFimVigencia",
                table: "UnidadeInfraestrutura",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtIniVigencia",
                table: "UnidadeInfraestrutura",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "UnidadeInfraestrutura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomUnidadeÌnfraestrutura",
                table: "UnidadeInfraestrutura",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "UnidadeInfraestrutura",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeInfraestrutura_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura",
                column: "ResponsavelTecnicoCodResponsavelTecnico");

            migrationBuilder.AddForeignKey(
                name: "FK_UnidadeInfraestrutura_ResponsavelTecnico_ResponsavelTecnicoCodResponsavelTecnico",
                table: "UnidadeInfraestrutura",
                column: "ResponsavelTecnicoCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
