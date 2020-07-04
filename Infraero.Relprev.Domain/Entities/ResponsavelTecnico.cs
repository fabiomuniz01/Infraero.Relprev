using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class ResponsavelTecnico : AuditableEntity
    {
        [Key]
        public int CodResponsavelTecnico { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NumDocumento { get; set; }
        public string EndEmail { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public bool FlagGestorSgso { get; set; }

        [ForeignKey("CodResponsavelTecnico")]
        public List<VinculoResponsavelEmpresa> ListVinculoResponsavelEmpresa { get; set; }
    }
}
