using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev012ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_SituacaoAtribuicaoRelato_CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_CAD_USUARIO_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AtribuicaoRelato",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato");

            migrationBuilder.DropIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato");

            migrationBuilder.DropColumn(
                name: "CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato");

            migrationBuilder.RenameTable(
                name: "AtribuicaoRelato",
                newName: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.RenameColumn(
                name: "ObsAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "DSC_OBS_ATRIBUICAO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DthFimAtendimento",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "DTH_FIM_ATENDIMENTO");

            migrationBuilder.RenameColumn(
                name: "DthAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "DTH_ATRIBUICAO");

            migrationBuilder.RenameColumn(
                name: "DscParecerTecnico",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "DSC_PARECER_TECNICO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodUsuarioAtribuidor",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "COD_USUARIO_ATRIBUIDOR");

            migrationBuilder.RenameColumn(
                name: "CodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "COD_SITUACAO_ATRIBUICAO");

            migrationBuilder.RenameColumn(
                name: "CodResponsavelTecnico",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "COD_RESPONSAVEL");

            migrationBuilder.RenameColumn(
                name: "CodRelato",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "COD_RELATO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodAtribuicaoRelato",
                table: "CAD_ATRIBUICAO_RELATO",
                newName: "SEQ_ATRIBUICAO_RELATO");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_OBS_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                comment: "Descrição da observação da atribuição",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "FLG_ATIVO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Indicador de registro ativo",
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_FIM_ATENDIMENTO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                comment: "Data Hora fim do atendimento",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Data Hora da atribuição",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "DSC_PARECER_TECNICO",
                table: "CAD_ATRIBUICAO_RELATO",
                maxLength: 455,
                nullable: true,
                comment: "Descrição do parecer técnico",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Data da inclusão",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DTH_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                comment: "Data de alteração",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                comment: "Usuário que realizou a inclusão",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_SITUACAO_ATRIBUICAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código de situação da atribuição",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "COD_RESPONSAVEL",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código do respontavel da atribuicao do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "COD_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Código sequencial do relato",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true,
                comment: "Usuário de realizou a alteração",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SEQ_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: false,
                comment: "Sequencial da tabela",
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "SEQ_ATRIBUICAO_RELATO");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 919, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 23, 17, 42, 915, DateTimeKind.Local).AddTicks(7167));

            migrationBuilder.CreateIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao");

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelato_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO",
                column: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                principalTable: "SituacaoAtribuicaoRelato",
                principalColumn: "CodSituacaoAtribuicao",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelato_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_ATRIBUICAO_RELATO",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropIndex(
                name: "IX_CAD_ATRIBUICAO_RELATO_SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.DropColumn(
                name: "SituacaoAtribuicaoRelatoCodSituacaoAtribuicao",
                table: "CAD_ATRIBUICAO_RELATO");

            migrationBuilder.RenameTable(
                name: "CAD_ATRIBUICAO_RELATO",
                newName: "AtribuicaoRelato");

            migrationBuilder.RenameColumn(
                name: "DSC_OBS_ATRIBUICAO",
                table: "AtribuicaoRelato",
                newName: "ObsAtribuicao");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "AtribuicaoRelato",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_FIM_ATENDIMENTO",
                table: "AtribuicaoRelato",
                newName: "DthFimAtendimento");

            migrationBuilder.RenameColumn(
                name: "DTH_ATRIBUICAO",
                table: "AtribuicaoRelato",
                newName: "DthAtribuicao");

            migrationBuilder.RenameColumn(
                name: "DSC_PARECER_TECNICO",
                table: "AtribuicaoRelato",
                newName: "DscParecerTecnico");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "AtribuicaoRelato",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "AtribuicaoRelato",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "AtribuicaoRelato",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_USUARIO_ATRIBUIDOR",
                table: "AtribuicaoRelato",
                newName: "CodUsuarioAtribuidor");

            migrationBuilder.RenameColumn(
                name: "COD_SITUACAO_ATRIBUICAO",
                table: "AtribuicaoRelato",
                newName: "CodSituacaoAtribuicao");

            migrationBuilder.RenameColumn(
                name: "COD_RESPONSAVEL",
                table: "AtribuicaoRelato",
                newName: "CodResponsavelTecnico");

            migrationBuilder.RenameColumn(
                name: "COD_RELATO",
                table: "AtribuicaoRelato",
                newName: "CodRelato");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "AtribuicaoRelato",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_ATRIBUICAO_RELATO",
                table: "AtribuicaoRelato",
                newName: "CodAtribuicaoRelato");

            migrationBuilder.AlterColumn<string>(
                name: "ObsAtribuicao",
                table: "AtribuicaoRelato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Descrição da observação da atribuição");

            migrationBuilder.AlterColumn<bool>(
                name: "FlagAtivo",
                table: "AtribuicaoRelato",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldComment: "Indicador de registro ativo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DthFimAtendimento",
                table: "AtribuicaoRelato",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data Hora fim do atendimento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DthAtribuicao",
                table: "AtribuicaoRelato",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data Hora da atribuição");

            migrationBuilder.AlterColumn<string>(
                name: "DscParecerTecnico",
                table: "AtribuicaoRelato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 455,
                oldNullable: true,
                oldComment: "Descrição do parecer técnico");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "AtribuicaoRelato",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldComment: "Data da inclusão");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAlteracao",
                table: "AtribuicaoRelato",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldComment: "Data de alteração");

            migrationBuilder.AlterColumn<string>(
                name: "CriadoPor",
                table: "AtribuicaoRelato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário que realizou a inclusão");

            migrationBuilder.AlterColumn<int>(
                name: "CodUsuarioAtribuidor",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do usuário atribuidor. OBS: caso valor nulo, usuario atribuidor igual a SistemaRelprev");

            migrationBuilder.AlterColumn<int>(
                name: "CodSituacaoAtribuicao",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldComment: "Código de situação da atribuição");

            migrationBuilder.AlterColumn<int>(
                name: "CodResponsavelTecnico",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código do respontavel da atribuicao do relato");

            migrationBuilder.AlterColumn<int>(
                name: "CodRelato",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Código sequencial do relato");

            migrationBuilder.AlterColumn<string>(
                name: "AlteradoPor",
                table: "AtribuicaoRelato",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComment: "Usuário de realizou a alteração");

            migrationBuilder.AlterColumn<int>(
                name: "CodAtribuicaoRelato",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldComment: "Sequencial da tabela")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AtribuicaoRelato",
                table: "AtribuicaoRelato",
                column: "CodAtribuicaoRelato");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 675, DateTimeKind.Local).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 15,
                column: "DataCriacao",
                value: new DateTime(2020, 6, 2, 8, 6, 53, 669, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato",
                column: "CodRelatoNavigationCodRelato");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato",
                column: "CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao");

            migrationBuilder.CreateIndex(
                name: "IX_AtribuicaoRelato_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RELATO_CodRelatoNavigationCodRelato",
                table: "AtribuicaoRelato",
                column: "CodRelatoNavigationCodRelato",
                principalTable: "CAD_RELATO",
                principalColumn: "SEQ_RELATO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_SituacaoAtribuicaoRelato_CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                table: "AtribuicaoRelato",
                column: "CodSituacaoAtribuicaoNavigationCodSituacaoAtribuicao",
                principalTable: "SituacaoAtribuicaoRelato",
                principalColumn: "CodSituacaoAtribuicao",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_CAD_USUARIO_CodUsuarioAtribuidorNavigationCodUsuario",
                table: "AtribuicaoRelato",
                column: "CodUsuarioAtribuidorNavigationCodUsuario",
                principalTable: "CAD_USUARIO",
                principalColumn: "SEQ_USUARIO",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
