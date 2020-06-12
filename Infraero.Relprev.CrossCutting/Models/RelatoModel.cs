using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using Infraero.Relprev.Application.Relato.Queries.GetRelatos;
using Infraero.Relprev.Application.RelatoArquivo.Queries.GetRelatoArquivos;
using Microsoft.AspNetCore.Http;
using Infraero.Relprev.Application.ResponsavelTecnico.Queries.GetResponsavelTecnicos;

namespace Infraero.Relprev.CrossCutting.Models
{
    public class RelatoModel
    {
        public SelectList ListUnidadeInfraestrutura { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public SelectList ListLocal { get; set; }
        public int CodLocal { get; set; }
        public SelectList ListSubLocal { get; set; }
        public int CodSubLocal { get; set; }
        public SelectList ListAssunto { get; set; }
        public int CodAssunto { get; set; }
        public SelectList ListSubAssunto { get; set; }
        public int CodSubAssunto { get; set; }
        public SelectList ListEmpresa { get; set; }
        public int CodEmpresa { get; set; }
        public SelectList ListResponsavel { get; set; }
        public int CodResponsavel { get; set; }
        public RelatoDto Relato { get; set; }
        public List<IFormFile> ListArquivo { get; set; }
        public List<RelatoArquivoDto> ListRelatoArquivo { get; set; }
        public List<ResponsavelTecnicoDto> ListResponsavelTecnico { get; set; }
        public IFormFile Arquivo { get; set; }
    }
}
