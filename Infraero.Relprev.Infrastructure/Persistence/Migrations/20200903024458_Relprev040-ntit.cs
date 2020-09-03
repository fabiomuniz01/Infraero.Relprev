using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev040ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CAD_PARECER_CAD_RELATO_COD_RELATO",
            //    table: "CAD_PARECER");

            migrationBuilder.DropForeignKey(
                name: "FK_HST_CAD_PARECER_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER");

            migrationBuilder.DropIndex(
                name: "IX_HST_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER");

            //migrationBuilder.DropIndex(
            //    name: "IX_CAD_PARECER_COD_RELATO",
            //    table: "CAD_PARECER");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "TAB_MODULO",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "TAB_MODULO",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "TAB_MODULO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "TAB_MODULO",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HST_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER",
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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HST_CAD_PARECER_CAD_PARECER_COD_PARECER",
                table: "HST_CAD_PARECER",
                column: "COD_PARECER",
                principalTable: "CAD_PARECER",
                principalColumn: "SEQ_PARECER",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
