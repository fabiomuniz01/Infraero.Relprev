using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraero.Relprev.Infrastructure.Persistence.Migrations
{
    public partial class Relprev002ntit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_ResponsavelTecnico_CAD_EMPRESA_CodEmpresa",
                table: "ResponsavelTecnico");

            migrationBuilder.DropForeignKey(
                name: "FK_SubAssunto_CAD_ASSUNTO_CodAssunto",
                table: "SubAssunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubAssunto",
                table: "SubAssunto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResponsavelTecnico",
                table: "ResponsavelTecnico");

            migrationBuilder.RenameTable(
                name: "SubAssunto",
                newName: "CAD_SUBASSUNTO");

            migrationBuilder.RenameTable(
                name: "ResponsavelTecnico",
                newName: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_USUARIO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_USUARIO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_USUARIO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_USUARIO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_USUARIO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_LOCAL",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_LOCAL",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_LOCAL",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_LOCAL",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_LOCAL",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_EMPRESA",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_EMPRESA",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_EMPRESA",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_EMPRESA",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_EMPRESA",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_SUBASSUNTO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "DscSubAssunto",
                table: "CAD_SUBASSUNTO",
                newName: "DSC_SUBASSUNTO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_SUBASSUNTO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_SUBASSUNTO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_SUBASSUNTO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodAssunto",
                table: "CAD_SUBASSUNTO",
                newName: "COD_ASSUNTO");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_SUBASSUNTO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodSubAssunto",
                table: "CAD_SUBASSUNTO",
                newName: "SEQ_SUBASSUNTO");

            migrationBuilder.RenameIndex(
                name: "IX_SubAssunto_CodAssunto",
                table: "CAD_SUBASSUNTO",
                newName: "IX_CAD_SUBASSUNTO_COD_ASSUNTO");

            migrationBuilder.RenameColumn(
                name: "NumTelefone",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "NUM_TELEFONE");

            migrationBuilder.RenameColumn(
                name: "NumDocumento",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "NUM_DOCUMENTO");

            migrationBuilder.RenameColumn(
                name: "NumCpf",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "NUM_CPF");

            migrationBuilder.RenameColumn(
                name: "NomResponsavelTecnico",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "NOM_RESPONSAVEL_TECNICO");

            migrationBuilder.RenameColumn(
                name: "FlagAtivo",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "FLG_ATIVO");

            migrationBuilder.RenameColumn(
                name: "EndEmail",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "END_RESPONSAVEL_TECNICO");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "DTH_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "DTH_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CriadoPor",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "NOM_USU_INCLUSAO");

            migrationBuilder.RenameColumn(
                name: "CodUnidadeInfraestrutura",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "COD_UNIDADE_INFRAESTRUTURA");

            migrationBuilder.RenameColumn(
                name: "CodEmpresa",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "COD_EMPRESA");

            migrationBuilder.RenameColumn(
                name: "AlteradoPor",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "NOM_USU_ALTERACAO");

            migrationBuilder.RenameColumn(
                name: "CodResponsavelTecnico",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "SEQ_RESPONSAVEL_TECNICO");

            migrationBuilder.RenameIndex(
                name: "IX_ResponsavelTecnico_CodEmpresa",
                table: "CAD_RESPONSAVEL_TECNICO",
                newName: "IX_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA");

            migrationBuilder.AlterColumn<string>(
                name: "NOM_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

            migrationBuilder.AlterColumn<string>(
                name: "END_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_SUBASSUNTO",
                table: "CAD_SUBASSUNTO",
                column: "SEQ_SUBASSUNTO");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CAD_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO",
                column: "SEQ_RESPONSAVEL_TECNICO");

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
                name: "FK_AtribuicaoRelato_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_RESPONSAVEL_TECNICO_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO",
                column: "COD_EMPRESA",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CAD_SUBASSUNTO_CAD_ASSUNTO_COD_ASSUNTO",
                table: "CAD_SUBASSUNTO",
                column: "COD_ASSUNTO",
                principalTable: "CAD_ASSUNTO",
                principalColumn: "SEQ_ASSUNTO",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "CAD_RESPONSAVEL_TECNICO",
                principalColumn: "SEQ_RESPONSAVEL_TECNICO",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtribuicaoRelato_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_RESPONSAVEL_TECNICO_CAD_EMPRESA_COD_EMPRESA",
                table: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.DropForeignKey(
                name: "FK_CAD_SUBASSUNTO_CAD_ASSUNTO_COD_ASSUNTO",
                table: "CAD_SUBASSUNTO");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpresaResponsavelTecnico_CAD_RESPONSAVEL_TECNICO_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_SUBASSUNTO",
                table: "CAD_SUBASSUNTO");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CAD_RESPONSAVEL_TECNICO",
                table: "CAD_RESPONSAVEL_TECNICO");

            migrationBuilder.RenameTable(
                name: "CAD_SUBASSUNTO",
                newName: "SubAssunto");

            migrationBuilder.RenameTable(
                name: "CAD_RESPONSAVEL_TECNICO",
                newName: "ResponsavelTecnico");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "CAD_USUARIO",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "CAD_USUARIO",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "CAD_USUARIO",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_USUARIO",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_USUARIO",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "CAD_LOCAL",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "CAD_LOCAL",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "CAD_LOCAL",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_LOCAL",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_LOCAL",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "CAD_EMPRESA",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "CAD_EMPRESA",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "CAD_EMPRESA",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "CAD_EMPRESA",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "CAD_EMPRESA",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "SubAssunto",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "DSC_SUBASSUNTO",
                table: "SubAssunto",
                newName: "DscSubAssunto");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "SubAssunto",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "SubAssunto",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "SubAssunto",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_ASSUNTO",
                table: "SubAssunto",
                newName: "CodAssunto");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "SubAssunto",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_SUBASSUNTO",
                table: "SubAssunto",
                newName: "CodSubAssunto");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_SUBASSUNTO_COD_ASSUNTO",
                table: "SubAssunto",
                newName: "IX_SubAssunto_CodAssunto");

            migrationBuilder.RenameColumn(
                name: "NUM_TELEFONE",
                table: "ResponsavelTecnico",
                newName: "NumTelefone");

            migrationBuilder.RenameColumn(
                name: "NUM_DOCUMENTO",
                table: "ResponsavelTecnico",
                newName: "NumDocumento");

            migrationBuilder.RenameColumn(
                name: "NUM_CPF",
                table: "ResponsavelTecnico",
                newName: "NumCpf");

            migrationBuilder.RenameColumn(
                name: "NOM_RESPONSAVEL_TECNICO",
                table: "ResponsavelTecnico",
                newName: "NomResponsavelTecnico");

            migrationBuilder.RenameColumn(
                name: "FLG_ATIVO",
                table: "ResponsavelTecnico",
                newName: "FlagAtivo");

            migrationBuilder.RenameColumn(
                name: "END_RESPONSAVEL_TECNICO",
                table: "ResponsavelTecnico",
                newName: "EndEmail");

            migrationBuilder.RenameColumn(
                name: "DTH_INCLUSAO",
                table: "ResponsavelTecnico",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "DTH_ALTERACAO",
                table: "ResponsavelTecnico",
                newName: "DataAlteracao");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_INCLUSAO",
                table: "ResponsavelTecnico",
                newName: "CriadoPor");

            migrationBuilder.RenameColumn(
                name: "COD_UNIDADE_INFRAESTRUTURA",
                table: "ResponsavelTecnico",
                newName: "CodUnidadeInfraestrutura");

            migrationBuilder.RenameColumn(
                name: "COD_EMPRESA",
                table: "ResponsavelTecnico",
                newName: "CodEmpresa");

            migrationBuilder.RenameColumn(
                name: "NOM_USU_ALTERACAO",
                table: "ResponsavelTecnico",
                newName: "AlteradoPor");

            migrationBuilder.RenameColumn(
                name: "SEQ_RESPONSAVEL_TECNICO",
                table: "ResponsavelTecnico",
                newName: "CodResponsavelTecnico");

            migrationBuilder.RenameIndex(
                name: "IX_CAD_RESPONSAVEL_TECNICO_COD_EMPRESA",
                table: "ResponsavelTecnico",
                newName: "IX_ResponsavelTecnico_CodEmpresa");

            migrationBuilder.AlterColumn<string>(
                name: "NomResponsavelTecnico",
                table: "ResponsavelTecnico",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "EndEmail",
                table: "ResponsavelTecnico",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubAssunto",
                table: "SubAssunto",
                column: "CodSubAssunto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResponsavelTecnico",
                table: "ResponsavelTecnico",
                column: "CodResponsavelTecnico");

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Funcionalidade",
                keyColumn: "CodFuncionalidade",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 582, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 1,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 2,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 3,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 4,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 5,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 6,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 7,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 8,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 9,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 10,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 11,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 12,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 13,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Modulo",
                keyColumn: "CodModulo",
                keyValue: 14,
                column: "DataCriacao",
                value: new DateTime(2020, 5, 18, 12, 25, 44, 579, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.AddForeignKey(
                name: "FK_AtribuicaoRelato_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "AtribuicaoRelato",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmpresaResponsavelTecnico_ResponsavelTecnico_CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                table: "EmpresaResponsavelTecnico",
                column: "CodResponsavelTecnicoNavigationCodResponsavelTecnico",
                principalTable: "ResponsavelTecnico",
                principalColumn: "CodResponsavelTecnico",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResponsavelTecnico_CAD_EMPRESA_CodEmpresa",
                table: "ResponsavelTecnico",
                column: "CodEmpresa",
                principalTable: "CAD_EMPRESA",
                principalColumn: "SEQ_EMPRESA",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubAssunto_CAD_ASSUNTO_CodAssunto",
                table: "SubAssunto",
                column: "CodAssunto",
                principalTable: "CAD_ASSUNTO",
                principalColumn: "SEQ_ASSUNTO",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
