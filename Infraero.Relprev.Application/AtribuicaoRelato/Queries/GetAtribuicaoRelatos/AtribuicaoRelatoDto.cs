using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Usuario.Queries.GetUsuarios;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;

namespace Infraero.Relprev.Application.AtribuicaoRelato.Queries.GetAtribuicaoRelatos
{
    public class AtribuicaoRelatoDto : IMapFrom<Domain.Entities.AtribuicaoRelato>
    {
        [Key]
        public int CodAtribuicaoRelato { get; set; }
        public int CodResponsavelTecnico { get; set; }
        public int CodRelato { get; set; }
        public int CodSituacaoAtribuicao { get; set; }
        public string DscParecerTecnico { get; set; }
        public string CodUsuarioAtribuidor { get; set; }
        public DateTime DthAtribuicao { get; set; }
        public DateTime? DthFimAtendimento { get; set; }
        public string ObsAtribuicao { get; set; }
        public bool FlagAtivo { get; set; }

        [ForeignKey("CodResponsavelTecnico")]
        public ResponsavelTecnicoDto ResponsavelTecnico { get; set; }
        [ForeignKey("CodRelato")]
        public RelatoDto Relato { get; set; }




        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.AtribuicaoRelato, AtribuicaoRelatoDto>();
        }

    }
}
