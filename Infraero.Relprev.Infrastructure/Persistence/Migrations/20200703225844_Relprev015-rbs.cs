using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev015rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HST_CAD_Parecer",
                table: "HST_CAD_Parecer");

            migrationBuilder.RenameTable(
                name: "HST_CAD_Parecer",
                newName: "HST_CAD_PARECER");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HST_CAD_PARECER",
                table: "HST_CAD_PARECER",
                column: "SEQ_HISTORICO_PARECER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_HST_CAD_PARECER",
                table: "HST_CAD_PARECER");

            migrationBuilder.RenameTable(
                name: "HST_CAD_PARECER",
                newName: "HST_CAD_Parecer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HST_CAD_Parecer",
                table: "HST_CAD_Parecer",
                column: "SEQ_HISTORICO_PARECER");
        }
    }
}
