using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class _0006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

           

            migrationBuilder.CreateTable(
                name: "SubLocal",
                columns: table => new
                {
                    CodSubLocal = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    AlteradoPor = table.Column<string>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(nullable: true),
                    DscSubLocal = table.Column<string>(maxLength: 300, nullable: false),
                    CodLocal = table.Column<int>(nullable: false),
                    CodUnidadeInfraestrutura = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubLocal", x => x.CodSubLocal);
                    table.ForeignKey(
                        name: "FK_SubLocal_Local_CodLocal",
                        column: x => x.CodLocal,
                        principalTable: "Local",
                        principalColumn: "CodLocal",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubLocal_UnidadeInfraestrutura_CodUnidadeInfraestrutura",
                        column: x => x.CodUnidadeInfraestrutura,
                        principalTable: "UnidadeInfraestrutura",
                        principalColumn: "CodUnidadeInfraestrutura",
                        onDelete: ReferentialAction.NoAction);
                });

            


            migrationBuilder.CreateIndex(
                name: "IX_SubLocal_CodLocal",
                table: "SubLocal",
                column: "CodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_SubLocal_CodUnidadeInfraestrutura",
                table: "SubLocal",
                column: "CodUnidadeInfraestrutura");

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
