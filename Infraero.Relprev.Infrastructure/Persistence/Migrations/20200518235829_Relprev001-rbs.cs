using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev001rbs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arquivo_Relato_RelatoCodRelato",
                table: "Arquivo");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_Relato_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_LOCAL_UnidadeInfraestrutura_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_Relato_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_Ambiente_AmbienteCodAmbiente",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_Relato_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatoArquivo_Relato_CodRelato",
                table: "RelatoArquivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnidadeInfraestrutura",
                table: "UnidadeInfraestrutura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Relato",
                table: "Relato");

            migrationBuilder.RenameTable(
                name: "UnidadeInfraestrutura",
                newName: "CAD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameTable(
                name: "Relato",
                newName: "CAD_RELATO");

            migrationBuilder.RenameColumn(
                name: "Sigla",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "SIG_UNIDADE");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodUnidade",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "COD_UNIDADE");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "SEQ_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_RELATO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_RELATO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_RELATO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "DatOcorrencia",
                table: "CAD_RELATO",
                newName: "DAT_OCORRENCIA");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_RELATO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_RELATO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodRelato",
                table: "CAD_RELATO",
                newName: "SEQ_RELATO");

            migrationBuilder.RenameIndex(
                name: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO",
                newName: "IX_CAD_RELATO_UnidadeInfraestruturaCodUnidadeInfraestrutura");

            migrationBuilder.RenameIndex(
                name: "IX_Relato_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO",
                newName: "IX_CAD_RELATO_SubAmbienteCodSubAmbiente");

            migrationBuilder.RenameIndex(
                name: "IX_Relato_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO",
                newName: "IX_CAD_RELATO_SituacaoRelatoCodSituacaoRelato");

            migrationBuilder.RenameIndex(
                name: "IX_Relato_AmbienteCodAmbiente",
                table: "CAD_RELATO",
                newName: "IX_CAD_RELATO_AmbienteCodAmbiente");

            migrationBuilder.AlterColumn<string>(
                name: "SIG_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "COD_UNIDADE",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA",
                column: "SEQ_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_RELATO",
                table: "CAD_RELATO",
                column: "SEQ_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 450, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 20, 58, 28, 447, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.AddForeignKey(
                name: "FK_Arquivo_CAD_RELATO_RelatoCodRelato",
                table: "Arquivo",
                column: "RelatoCodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato",
                column: "CodRelatoNavigationCodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_LOCAL_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                column: "COD_UNIDADE_INFRAESTRUTURA",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_Ambiente_AmbienteCodAmbiente",
                table: "CAD_RELATO",
                column: "AmbienteCodAmbiente",
                principalTable: "Ambiente",
                principalColumn: "CodAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO",
                column: "SituacaoRelatoCodSituacaoRelato",
                principalTable: "SituacaoRelato",
                principalColumn: "CodSituacaoRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO",
                column: "SubAmbienteCodSubAmbiente",
                principalTable: "SubAmbiente",
                principalColumn: "CodSubAmbiente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "CAD_UNIDADE_INFRAESTRUTURA",
                principalColumn: "SEQ_UNIDADE_INFRAESTRUTURA",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato",
                column: "CodRelatoNavigationCodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoArquivo_CAD_RELATO_CodRelato",
                table: "RelatoArquivo",
                column: "CodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arquivo_CAD_RELATO_RelatoCodRelato",
                table: "Arquivo");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_LOCAL_CAD_UNIDADE_INFRAESTRUTURA_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_Ambiente_AmbienteCodAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_SituacaoRelato_SituacaoRelatoCodSituacaoRelato",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_SubAmbiente_SubAmbienteCodSubAmbiente",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RELATO_CAD_UNIDADE_INFRAESTRUTURA_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "CAD_RELATO");

            migrationBuilder.DropForeignKey(
                name: "FK_HistoricoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_RelatoArquivo_CAD_RELATO_CodRelato",
                table: "RelatoArquivo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_RELATO",
                table: "CAD_RELATO");

            migrationBuilder.RenameTable(
                name: "CAD_UNIDADE_INFRAESTRUTURA",
                newName: "UnidadeInfraestrutura");

            migrationBuilder.RenameTable(
                name: "CAD_RELATO",
                newName: "Relato");

            migrationBuilder.RenameColumn(
                name: "SIG_UNIDADE",
                table: "UnidadeInfraestrutura",
                newName: "Sigla");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "UnidadeInfraestrutura",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "UnidadeInfraestrutura",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "UnidadeInfraestrutura",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "UnidadeInfraestrutura",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE",
                table: "UnidadeInfraestrutura",
                newName: "CodUnidade");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "UnidadeInfraestrutura",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_UNIDADE_INFRAESTRUTURA",
                table: "UnidadeInfraestrutura",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "Relato",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "Relato",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "Relato",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "DAT_OCORRENCIA",
                table: "Relato",
                newName: "DatOcorrencia");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "Relato",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "Relato",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_RELATO",
                table: "Relato",
                newName: "CodRelato");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_RELATO_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                newName: "IX_Relato_UnidadeInfraestruturaCodUnidadeInfraestrutura");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_RELATO_SubAmbienteCodSubAmbiente",
                table: "Relato",
                newName: "IX_Relato_SubAmbienteCodSubAmbiente");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_RELATO_SituacaoRelatoCodSituacaoRelato",
                table: "Relato",
                newName: "IX_Relato_SituacaoRelatoCodSituacaoRelato");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_RELATO_AmbienteCodAmbiente",
                table: "Relato",
                newName: "IX_Relato_AmbienteCodAmbiente");

            migrationBuilder.AlterColumn<string>(
                name: "Sigla",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 8);

            migrationBuilder.AlterColumn<string>(
                name: "CodUnidade",
                table: "UnidadeInfraestrutura",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnidadeInfraestrutura",
                table: "UnidadeInfraestrutura",
                column: "CodUnidadeInfraestrutura");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Relato",
                table: "Relato",
                column: "CodRelato");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 661, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 59, 45, 659, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.AddForeignKey(
                name: "FK_Arquivo_Relato_RelatoCodRelato",
                table: "Arquivo",
                column: "RelatoCodRelato",
                principalTable: "Relato",
                principalColumn: "CodRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_Relato_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato",
                column: "CodRelatoNavigationCodRelato",
                principalTable: "Relato",
                principalColumn: "CodRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_LOCAL_UnidadeInfraestrutura_COD_UNIDADE_INFRAESTRUTURA",
                table: "CAD_LOCAL",
                column: "COD_UNIDADE_INFRAESTRUTURA",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HistoricoRelato_Relato_CodRelatoNavigationCodRelato",
                table: "HistoricoRelato",
                column: "CodRelatoNavigationCodRelato",
                principalTable: "Relato",
                principalColumn: "CodRelato",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relato_Ambiente_AmbienteCodAmbiente",
                table: "Relato",
                column: "AmbienteCodAmbiente",
                principalTable: "Ambiente",
                principalColumn: "CodAmbiente",
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
                name: "FK_Relato_UnidadeInfraestrutura_UnidadeInfraestruturaCodUnidadeInfraestrutura",
                table: "Relato",
                column: "UnidadeInfraestruturaCodUnidadeInfraestrutura",
                principalTable: "UnidadeInfraestrutura",
                principalColumn: "CodUnidadeInfraestrutura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RelatoArquivo_Relato_CodRelato",
                table: "RelatoArquivo",
                column: "CodRelato",
                principalTable: "Relato",
                principalColumn: "CodRelato",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
