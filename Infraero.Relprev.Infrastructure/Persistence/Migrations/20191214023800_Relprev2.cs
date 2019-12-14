using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnidadeInfraestrutura",
                columns: table => new
                {
                    CodUnidadeInfraestrutura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    CodUnidade = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    DtIniVigencia = table.Column<DateTime>(nullable: false),
                    DtFimVigencia = table.Column<DateTime>(nullable: false),
                    EmpresaCodEmpresa = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeInfraestrutura", x => x.CodUnidadeInfraestrutura);
                    table.ForeignKey(
                        name: "FK_UnidadeInfraestrutura_Empresas_EmpresaCodEmpresa",
                        column: x => x.EmpresaCodEmpresa,
                        principalTable: "Empresas",
                        principalColumn: "CodEmpresa",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnidadeInfraestrutura_EmpresaCodEmpresa",
                table: "UnidadeInfraestrutura",
                column: "EmpresaCodEmpresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnidadeInfraestrutura");
        }
    }
}
