using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev007 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomUnidade",
                table: "UnidadeInfraestrutura");

            migrationBuilder.AddColumn<string>(
                name: "NomUnidadeÌnfraestrutura",
                table: "UnidadeInfraestrutura",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomUnidadeÌnfraestrutura",
                table: "UnidadeInfraestrutura");

            migrationBuilder.AddColumn<string>(
                name: "NomUnidade",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true);

        }
    }
}
