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
        public string NomUnidadeÌnfraestrutura { get; set; }
        public string DtIniVigencia { get; set; }
        public string DtFimVigencia { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UnidadeInfraestrutura, UnidadeInfraEstruturaDto>()
                .ForMember(d => d.DtFimVigencia, opt => opt.MapFrom(s => s.DtFimVigencia.ToString("dd/MM/yyyy")))
                .ForMember(d => d.DtIniVigencia, opt => opt.MapFrom(s => s.DtIniVigencia.ToString("dd/MM/yyyy"))); 
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
