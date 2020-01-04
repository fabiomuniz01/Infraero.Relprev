using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev018 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CodUnidadeInfraestrutura",
                table: "Relato",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura");

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
                name: "FK_Relato_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");
        }
    }
}
