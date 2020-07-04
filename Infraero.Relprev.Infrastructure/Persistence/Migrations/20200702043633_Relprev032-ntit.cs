using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev032ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_LOCAL_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_ARQUIVO_CAD_RELATO_COD_RELATO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBASSUNTO_CAD_ASSUNTO_COD_ASSUNTO",
                table: "CAD_SUBASSUNTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBLOCAL_CAD_LOCAL_COD_LOCAL",
                table: "CAD_SUBLOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionalidade_Modulo_CodModulo",
                table: "Funcionalidade");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_LOCAL_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                column: "COD_UNIDADE_INFRAESTRUTURA",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO",
                column: "COD_UNIDADE_ESINFRAESTRUTURA",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_ARQUIVO_CAD_RELATO_COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBASSUNTO_CAD_ASSUNTO_COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                column: "COD_ASSUNTO",
                principalTable: "CAD_ASSUNTO",
                principalColumn: "SEQ_ASSUNTO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBLOCAL_CAD_LOCAL_COD_LOCAL",
                table: "CAD_SUBLOCAL",
                column: "COD_LOCAL",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionalidade_Modulo_CodModulo",
                table: "Funcionalidade",
                column: "CodModulo",
                principalTable: "Modulo",
                principalColumn: "CodModulo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_LOCAL_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_ARQUIVO_CAD_RELATO_COD_RELATO",
                table: "CAD_RELATO_ARQUIVO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBASSUNTO_CAD_ASSUNTO_COD_ASSUNTO",
                table: "CAD_SUBASSUNTO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBLOCAL_CAD_LOCAL_COD_LOCAL",
                table: "CAD_SUBLOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionalidade_Modulo_CodModulo",
                table: "Funcionalidade");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_LOCAL_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                column: "COD_UNIDADE_INFRAESTRUTURA",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_ESINFRAESTRUTURA",
                table: "CAD_RELATO",
                column: "COD_UNIDADE_ESINFRAESTRUTURA",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_ARQUIVO_CAD_RELATO_COD_RELATO",
                table: "CAD_RELATO_ARQUIVO",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBASSUNTO_CAD_ASSUNTO_COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                column: "COD_ASSUNTO",
                principalTable: "CAD_ASSUNTO",
                principalColumn: "SEQ_ASSUNTO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBLOCAL_CAD_LOCAL_COD_LOCAL",
                table: "CAD_SUBLOCAL",
                column: "COD_LOCAL",
                principalTable: "CAD_LOCAL",
                principalColumn: "SEQ_LOCAL",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_VINCULO_RESPONSAVEL_EMPRESA_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL_TECNICO",
                table: "CAD_VINCULO_RESPONSAVEL_EMPRESA",
                column: "COD_RESPONSAVEL_TECNICO",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionalidade_Modulo_CodModulo",
                table: "Funcionalidade",
                column: "CodModulo",
                principalTable: "Modulo",
                principalColumn: "CodModulo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
