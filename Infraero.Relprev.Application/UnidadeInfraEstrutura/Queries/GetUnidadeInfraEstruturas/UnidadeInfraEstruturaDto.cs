using System;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Domain.Entities;

namespace Infraero.Relprev.Application.UnidadeInfraEstrutura.Queries.GetUnidadeInfraEstruturas
{
    public class UnidadeInfraEstruturaDto : IMapFrom<UnidadeInfraestrutura>
    {
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodUnidade { get; set; }
        public string Sigla { get; set; }

        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }

        //public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UnidadeInfraestrutura, UnidadeInfraEstruturaDto>().ForMember(
                d => d.DscCodUnidadeDescricao, opt => opt.MapFrom(s => s.CodUnidade + " - " + s.Descricao));
        }

        public string DscCodUnidadeDescricao { get; set; }

        public class Dependencia
        {
            public string dep_codigo { get; set; }
            public string dep_nome { get; set; }
            public string dep_sigla { get; set; }
            public string dep_sigla_nome { get; set; }
            public string dep_endereco_logradouro { get; set; }
            public string dep_endereco_complemento { get; set; }
            public string dep_numero_logradouro { get; set; }
            public string dep_endereco_bairro { get; set; }
            public string dep_endereco_municipio { get; set; }
            public string dep_ufe_sigla { get; set; }
            public string dep_endereco_cep { get; set; }
            public string dep_numero_telefone_1 { get; set; }
        }
    }

    
}
