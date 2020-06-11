using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev015ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.AddColumn<int>(
                name: "COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                defaultValue: 0,
                comment: "Código do responsavel SGSO da atribuicao do relato");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 114, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 11, 0, 26, 34, 109, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RELATO");

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_SGSO");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RELATO",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_USUARIO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL_SGSO",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_USUARIO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_RESPONSAVEL_SGSO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.AddColumn<int>(
                name: "COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Código do respontavel da atribuicao do relato");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 994, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 10, 0, 24, 50, 988, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_RESPONSAVEL_TECNICO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
