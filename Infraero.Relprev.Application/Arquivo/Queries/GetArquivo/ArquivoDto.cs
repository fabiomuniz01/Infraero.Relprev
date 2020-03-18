using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;

namespace Infraero.Relprev.Application.Arquivo.Queries.GetArquivos
{
    public class ArquivoDto : IMapFrom<Domain.Entities.Arquivo>
    {
        public int CodArquivo { get; set; }

        [ForeignKey("CodRelato")]
        public int CodRelato { get; set; }
        public byte[] BinArquivo { get; set; }
        public string NomArquivo { get; set; }
        public RelatoDto Relato { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.Arquivo, ArquivoDto>();
        }
    }
}
