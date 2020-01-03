using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DscLogin",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DscSenha",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "DthRegistro",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "FlgPrimeiroAcesso",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "FlgUsuarioBloqueado",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "QtdTentativasIncorretas",
                table: "Usuario");

            migrationBuilder.AddColumn<int>(
                name: "CodPerfil",
                table: "Usuario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CodPerfil",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "DscLogin",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscSenha",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DthRegistro",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FlgPrimeiroAcesso",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FlgUsuarioBloqueado",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QtdTentativasIncorretas",
                table: "Usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
