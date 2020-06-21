using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public  class Local : AuditableEntity
    {
        [Key]
        public int CodLocal { get; set; }
        public string DscLocal { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }

        [ForeignKey("CodUnidadeInfraestrutura")]
        public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }
    }
}
