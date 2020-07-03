using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class ParecerArquivo : AuditableEntity
    {
        [Key]
        public int CodParecerArquivo { get; set; }

        public int CodParecer { get; set; }
        public string NomeArquivo { get; set; }
        public string Arquivo { get; set; }
        public string Caminho { get; set; }

    }
}
