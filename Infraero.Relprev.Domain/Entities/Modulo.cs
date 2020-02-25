using Infraero.Relprev.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraero.Relprev.Domain.Entities
{
    public class Modulo : AuditableEntity
    {
        [Key]
        public int CodModulo { get; set; }
        public string NomModulo { get; set; }

        [ForeignKey("CodModulo")]
        public List<Funcionalidade> ListFuncionalidades { get; set; }
    }
}
