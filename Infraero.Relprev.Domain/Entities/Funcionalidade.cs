using Infraero.Relprev.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infraero.Relprev.Domain.Entities
{
    public class Funcionalidade : AuditableEntity
    {
        [Key]
        public int CodFuncionalidade { get; set; }
        public string NomFuncionalidade { get; set; }
        public int CodModulo { get; set; }
    }
}
