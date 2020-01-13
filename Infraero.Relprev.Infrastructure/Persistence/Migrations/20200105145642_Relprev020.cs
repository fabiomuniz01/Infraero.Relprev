using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DthRegistro",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "FlgPermiteAlteracao",
                table: "Perfil");

            migrationBuilder.DropColumn(
                name: "TxtObservacao",
                table: "Perfil");

            migrationBuilder.AddColumn<string>(
                name: "NomPerfil",
                table: "Perfil",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomPerfil",
                table: "Perfil");

            migrationBuilder.AddColumn<DateTime>(
                name: "DthRegistro",
                table: "Perfil",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FlgPermiteAlteracao",
                table: "Perfil",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TxtObservacao",
                table: "Perfil",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
