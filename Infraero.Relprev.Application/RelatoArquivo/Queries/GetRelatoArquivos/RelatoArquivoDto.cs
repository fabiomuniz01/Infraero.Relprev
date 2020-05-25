using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;

namespace Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos
{
    public class RelatoArquivoDto : IMapFrom<Domain.Entities.RelatoArquivo>
    {
        public int CodRelatoArquivo { get; set; }
        
        public int CodRelato { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }

        public RelatoArquivoDto(string nomeArquivo, string arquivo, string caminho)
        {
            NomeArquivo = nomeArquivo;
            Arquivo = arquivo;
            Caminho = caminho;
        }

        public RelatoArquivoDto()
        {

        }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.RelatoArquivo, RelatoArquivoDto>();
        }
    }
}
