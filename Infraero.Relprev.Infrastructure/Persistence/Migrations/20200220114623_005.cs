using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _005 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modulo",
                columns: table => new
                {
                    CodModulo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    NomModulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulo", x => x.CodModulo);
                });

            migrationBuilder.InsertData(
                table: "Modulo",
                columns: new[] { "CodModulo", "AlteradoPor", "CriadoPor", "DataAlteracao", "DataCriacao", "NomModulo" },
                values: new object[,]
                {
                    { 1, null, "SistemaRelprev", null, new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(5522), "Cadastros" },
                    { 2, null, "SistemaRelprev", null, new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6193), "Relatos" },
                    { 3, null, "SistemaRelprev", null, new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6211), "AtribuirResponsavelRelato" },
                    { 4, null, "SistemaRelprev", null, new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6215), "AtendimentoTecnico" },
                    { 5, null, "SistemaRelprev", null, new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6218), "ParecerTecnico" },
                    { 6, null, "SistemaRelprev", null, new DateTime(2020, 2, 20, 8, 46, 22, 672, DateTimeKind.Local).AddTicks(6221), "ContratoSmartStream" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modulo");
        }
    }
}
