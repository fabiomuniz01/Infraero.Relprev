using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class Arquivo : AuditableEntity
    {
        [Key]
        public int CodArquivo { get; set; }

        [ForeignKey("CodRelato")]
        public int CodRelato { get; set; }
        public string NomArquivo { get; set; }
        public Relato Relato { get; set; }
        public string PhotoPath { get; set; }
        public int RelatoCodRelato { get; set; }
    }
}
