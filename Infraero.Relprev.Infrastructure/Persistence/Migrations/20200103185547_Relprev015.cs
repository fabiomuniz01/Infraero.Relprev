using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev015 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Assunto_AssuntoCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Local_LocalCodLocal",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_AssuntoCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropIndex(
                name: "IX_SubAssunto_AssuntoCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropIndex(
                name: "IX_Relato_AssuntoCodAssunto",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_LocalCodLocal",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "AssuntoCodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropColumn(
                name: "AssuntoCodAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "LocalCodLocal",
                table: "Relato");

            migrationBuilder.CreateIndex(
                name: "IX_SubAssunto_CodAssunto",
                table: "SubAssunto",
                column: "CodAssunto");

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssunto",
                table: "SubAssunto",
                column: "CodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_Assunto_CodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropIndex(
                name: "IX_SubAssunto_CodAssunto",
                table: "SubAssunto");

            migrationBuilder.AddColumn<int>(
                name: "AssuntoCodAssunto",
                table: "SubAssunto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssuntoCodAssunto",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalCodLocal",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubAssunto_AssuntoCodAssunto",
                table: "SubAssunto",
                column: "AssuntoCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_AssuntoCodAssunto",
                table: "Relato",
                column: "AssuntoCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_LocalCodLocal",
                table: "Relato",
                column: "LocalCodLocal");

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Assunto_AssuntoCodAssunto",
                table: "Relato",
                column: "AssuntoCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Local_LocalCodLocal",
                table: "Relato",
                column: "LocalCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_Assunto_AssuntoCodAssunto",
                table: "SubAssunto",
                column: "AssuntoCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
