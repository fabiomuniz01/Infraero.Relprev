﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Ambiente_CodAmbienteNavigationCodAmbiente",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Local_CodLocalidadeNavigationCodLocal",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SituacaoRelato_CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAmbiente_CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Usuario_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodAmbienteNavigationCodAmbiente",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocal",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodAmbiente",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodAmbienteNavigationCodAmbiente",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodAssuntoNavigationCodAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodLocalidade",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodLocalidadeNavigationCodLocal",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodSubAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioRelator",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "DscOcorrenciaCorrigida",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "DthRegistro",
                table: "Relato");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "HorOcorrencia",
                table: "Relato",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AmbienteCodAmbiente",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssuntoCodAssunto",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocalCodLocal",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SituacaoRelatoCodSituacaoRelato",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubAmbienteCodSubAmbiente",
                table: "Relato",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubAssuntoCodSubAssunto",
                table: "Relato",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Relato_AmbienteCodAmbiente",
                table: "Relato",
                column: "AmbienteCodAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_AssuntoCodAssunto",
                table: "Relato",
                column: "AssuntoCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_LocalCodLocal",
                table: "Relato",
                column: "LocalCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_SituacaoRelatoCodSituacaoRelato",
                table: "Relato",
                column: "SituacaoRelatoCodSituacaoRelato");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_SubAmbienteCodSubAmbiente",
                table: "Relato",
                column: "SubAmbienteCodSubAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_SubAssuntoCodSubAssunto",
                table: "Relato",
                column: "SubAssuntoCodSubAssunto");

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Ambiente_AmbienteCodAmbiente",
                table: "Relato",
                column: "AmbienteCodAmbiente",
                principalTable: "Ambiente",
                principalColumn: "CodAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Assunto_AssuntoCodAssunto",
                table: "Relato",
                column: "AssuntoCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Local_LocalCodLocal",
                table: "Relato",
                column: "LocalCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "Relato",
                column: "SituacaoRelatoCodSituacaoRelato",
                principalTable: "SituacaoRelato",
                principalColumn: "CodSituacaoRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "Relato",
                column: "SubAmbienteCodSubAmbiente",
                principalTable: "SubAmbiente",
                principalColumn: "CodSubAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssunto_SubAssuntoCodSubAssunto",
                table: "Relato",
                column: "SubAssuntoCodSubAssunto",
                principalTable: "SubAssunto",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Ambiente_AmbienteCodAmbiente",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Assunto_AssuntoCodAssunto",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Local_LocalCodLocal",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAssunto_SubAssuntoCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_AmbienteCodAmbiente",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_AssuntoCodAssunto",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_LocalCodLocal",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_SituacaoRelatoCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_SubAmbienteCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropIndex(
                name: "IX_Relato_SubAssuntoCodSubAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "AmbienteCodAmbiente",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "AssuntoCodAssunto",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "LocalCodLocal",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "SituacaoRelatoCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "SubAmbienteCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropColumn(
                name: "SubAssuntoCodSubAssunto",
                table: "Relato");

            migrationBuilder.AlterColumn<string>(
                name: "HorOcorrencia",
                table: "Relato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(TimeSpan));

            migrationBuilder.AddColumn<int>(
                name: "CodAmbiente",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodAmbienteNavigationCodAmbiente",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodAssunto",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodAssuntoNavigationCodAssunto",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidade",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodLocalidadeNavigationCodLocal",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSituacaoRelato",
                table: "Relato",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSubAmbiente",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSubAssunto",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioRelator",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DscOcorrenciaCorrigida",
                table: "Relato",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DthRegistro",
                table: "Relato",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodAmbienteNavigationCodAmbiente",
                table: "Relato",
                column: "CodAmbienteNavigationCodAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodLocalidadeNavigationCodLocal",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato",
                column: "CodSituacaoRelatoNavigationCodSituacaoRelato");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato",
                column: "CodSubAmbienteNavigationCodSubAmbiente");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto");

            migrationBuilder.CreateIndex(
                name: "IX_Relato_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationCodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Ambiente_CodAmbienteNavigationCodAmbiente",
                table: "Relato",
                column: "CodAmbienteNavigationCodAmbiente",
                principalTable: "Ambiente",
                principalColumn: "CodAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Assunto_CodAssuntoNavigationCodAssunto",
                table: "Relato",
                column: "CodAssuntoNavigationCodAssunto",
                principalTable: "Assunto",
                principalColumn: "CodAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Local_CodLocalidadeNavigationCodLocal",
                table: "Relato",
                column: "CodLocalidadeNavigationCodLocal",
                principalTable: "Local",
                principalColumn: "CodLocal",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SituacaoRelato_CodSituacaoRelatoNavigationCodSituacaoRelato",
                table: "Relato",
                column: "CodSituacaoRelatoNavigationCodSituacaoRelato",
                principalTable: "SituacaoRelato",
                principalColumn: "CodSituacaoRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAmbiente_CodSubAmbienteNavigationCodSubAmbiente",
                table: "Relato",
                column: "CodSubAmbienteNavigationCodSubAmbiente",
                principalTable: "SubAmbiente",
                principalColumn: "CodSubAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_SubAssunto_CodSubAssuntoNavigationCodSubAssunto",
                table: "Relato",
                column: "CodSubAssuntoNavigationCodSubAssunto",
                principalTable: "SubAssunto",
                principalColumn: "CodSubAssunto",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Usuario_CodUsuarioRelatorNavigationCodUsuario",
                table: "Relato",
                column: "CodUsuarioRelatorNavigationCodUsuario",
                principalTable: "Usuario",
                principalColumn: "CodUsuario",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
