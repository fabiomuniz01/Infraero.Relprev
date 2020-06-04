using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relpre009rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "COD_ASSUNTO",
                table: "CAD_RELATO",
                nullable: false,
                defaultValue: 0,
                comment: "Assunto classificado");

            migrationBuilder.AddColumn<int>(
                name: "COD_LOCAL",
                table: "CAD_RELATO",
                nullable: false,
                defaultValue: 0,
                comment: "Local classificado");

            migrationBuilder.AddColumn<int>(
                name: "COD_SUB_ASSUNTO",
                table: "CAD_RELATO",
                nullable: false,
                defaultValue: 0,
                comment: "Sub assunto classificado");

            migrationBuilder.AddColumn<int>(
                name: "COD_SUB_LOCAL",
                table: "CAD_RELATO",
                nullable: false,
                defaultValue: 0,
                comment: "Sub local classificado");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9282));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 461, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 4, 12, 46, 50, 457, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_USUARIO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "COD_RESPONSAVEL",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_CAD_USUARIO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_ASSUNTO",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_LOCAL",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_SUB_ASSUNTO",
                table: "CAD_RELATO");

            migrationBuilder.DropColumn(
                name: "COD_SUB_LOCAL",
                table: "CAD_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 81, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 3, 0, 30, 22, 76, DateTimeKind.Local).AddTicks(8340));
        }
    }
}
