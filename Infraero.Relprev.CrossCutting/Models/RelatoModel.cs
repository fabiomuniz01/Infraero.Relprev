using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Microsoft.AspNetCore.Http;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class RelatoModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        //adiciona para exibir na edição
        public string NomUnidadeÌnfraestrutura { get; set; }
        public RelatoDto Relato { get; set; }

        public List<IFormFile> ListArquivo { get; set; }
        public List<RelatoArquivoDto> ListRelatoArquivo { get; set; }
        public IFormFile Arquivo { get; set; }
    }
}
