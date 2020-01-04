using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev019 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relato_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodUnidadeInfraestrutura",
                table: "Relato",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Relato",
                column: "CodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relato_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.AddColumn<int>(
                name: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                type: "int",
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
    }
}
