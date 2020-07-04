using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class VinculoResponsavelEmpresa :AuditableEntity
    {
        [Key]
        public int CodVinculoResponsavelEmpresa { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public int CodEmpresa { get; set; }
        public int CodResponsavelTecnico { get; set; }
        
        [ForeignKey("CodEmpresa")]
        public Empresa Empresa { get; set; }
    }
}
