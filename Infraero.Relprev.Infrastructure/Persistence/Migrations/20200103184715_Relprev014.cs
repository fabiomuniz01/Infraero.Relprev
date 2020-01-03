using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssunto_SubAssuntoCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropIndex(
                name: "IX_SubAssunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropIndex(
                name: "IX_Relato_SubAssuntoCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodAssuntoNavigationCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropColumn(
                name: "SubAssuntoCodSubAssunto",
                table: "Relato");

            migrationBuilder.AddColumn<int>(
                name: "AssuntoCodAssunto",
                table: "SubAssunto",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubAssunto_AssuntoCodAssunto",
                table: "SubAssunto",
                column: "AssuntoCodAssunto");

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_AssuntoCodAssunto",
                table: "SubAssunto",
                column: "AssuntoCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_AssuntoCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropIndex(
                name: "IX_SubAssunto_AssuntoCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropColumn(
                name: "AssuntoCodAssunto",
                table: "SubAssunto");

            migrationBuilder.AddColumn<int>(
                name: "CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubAssuntoCodSubAssunto",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubAssunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                column: "CodAssuntoNavigationCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_SubAssuntoCodSubAssunto",
                table: "Relato",
                column: "SubAssuntoCodSubAssunto");

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssunto_SubAssuntoCodSubAssunto",
                table: "Relato",
                column: "SubAssuntoCodSubAssunto",
                principalTable: "SubAssunto",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssuntoNavigationCodAssunto",
                table: "SubAssunto",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
