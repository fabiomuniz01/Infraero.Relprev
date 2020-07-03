using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using AutoMapper;
using Infraero.Relprev.Application.Common.Mappings;


namespace Infraero.Relprev.Application.ParecerArquivo.Queries.GetParecerArquivos
{
    public class ParecerArquivoDto : IMapFrom<Domain.Entities.ParecerArquivo>
    {
        public int CodParecerArquivo { get; set; }
        public int CodParecer { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.Entities.ParecerArquivo, ParecerArquivoDto>();
        }
    }
}
