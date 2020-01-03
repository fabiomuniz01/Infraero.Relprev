using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev013 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlteradoPor",
                table: "RelatoArquivo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CriadoPor",
                table: "RelatoArquivo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAlteracao",
                table: "RelatoArquivo",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCriacao",
                table: "RelatoArquivo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlteradoPor",
                table: "RelatoArquivo");

            migrationBuilder.DropColumn(
                name: "CriadoPor",
                table: "RelatoArquivo");

            migrationBuilder.DropColumn(
                name: "DataAlteracao",
                table: "RelatoArquivo");

            migrationBuilder.DropColumn(
                name: "DataCriacao",
                table: "RelatoArquivo");
        }
    }
}
