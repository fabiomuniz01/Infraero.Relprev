using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class VinculoUnidadeEmpresa : AuditableEntity
    {
        [Key]
        public int CodVinculoUnidadeEmpresa { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public string NomUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public string NomEmpresa { get; set; }
    }
}
