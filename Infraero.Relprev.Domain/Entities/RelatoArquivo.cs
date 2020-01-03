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

        public string Documento { get; set; }
    }
}
