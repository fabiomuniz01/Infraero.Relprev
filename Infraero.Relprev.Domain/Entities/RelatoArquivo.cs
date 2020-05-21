using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class RelatoArquivo : AuditableEntity
    {
        [Key]
        public int CodRelatoArquivo { get; set; }

        public int CodRelato { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }
        
        public RelatoArquivo(string nomeArquivo, string arquivo, string caminho)
        {
            NomeArquivo = nomeArquivo;
            Arquivo = arquivo;
            Caminho = caminho;
        }
    }
}
