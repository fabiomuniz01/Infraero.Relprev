using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Percistence.Migrations
{
    public partial class Relprev012 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VinculoUnidadeEmpresa",
                columns: table => new
                {
                    CodVinculoUnidadeEmpresa = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodUnidadeInfraestrutura = table.Column<int>(nullable: false),
                    NomUnidadeInfraestrutura = table.Column<string>(nullable: true),
                    CodEmpresa = table.Column<int>(nullable: false),
                    NomEmpresa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinculoUnidadeEmpresa", x => x.CodVinculoUnidadeEmpresa);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VinculoUnidadeEmpresa");
        }
    }
}
