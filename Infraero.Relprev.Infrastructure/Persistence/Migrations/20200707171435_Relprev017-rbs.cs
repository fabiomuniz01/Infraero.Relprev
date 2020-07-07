using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev017rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FlgStatusParecer",
                table: "CAD_PARECER",
                newName: "FLG_STATUS_RELATO");

            migrationBuilder.AddColumn<int>(
                name: "FLG_STATUS_RELATO",
                table: "HST_CAD_PARECER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_HST_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER",
                column: "COD_PARECER");

            migrationBuilder.AddForeignKey(
                name: "FK_HST_CAD_PARECER_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER",
                column: "COD_PARECER",
                principalTable: "CAD_PARECER",
                principalColumn: "SEQ_PARECER",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HST_CAD_PARECER_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER");

            migrationBuilder.DropIndex(
                name: "IX_HST_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER");

            migrationBuilder.DropColumn(
                name: "FLG_STATUS_RELATO",
                table: "HST_CAD_PARECER");

            migrationBuilder.RenameColumn(
                name: "FLG_STATUS_RELATO",
                table: "CAD_PARECER",
                newName: "FlgStatusParecer");
        }
    }
}
