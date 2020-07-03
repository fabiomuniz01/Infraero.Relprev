using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev013rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "COD_RELATO",
                table: "CAD_PARECER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CAD_PARECER_ARQUIVO_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO",
                column: "COD_PARECER");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_PARECER_COD_RELATO",
                table: "CAD_PARECER",
                column: "COD_RELATO");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
                table: "CAD_PARECER",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_PARECER_ARQUIVO_CAD_PARECER_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO",
                column: "COD_PARECER",
                principalTable: "CAD_PARECER",
                principalColumn: "SEQ_PARECER",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
                table: "CAD_PARECER");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_PARECER_ARQUIVO_CAD_PARECER_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_PARECER_ARQUIVO_COD_PARECER",
                table: "CAD_PARECER_ARQUIVO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_PARECER_COD_RELATO",
                table: "CAD_PARECER");

            migrationBuilder.DropColumn(
                name: "COD_RELATO",
                table: "CAD_PARECER");
        }
    }
}
