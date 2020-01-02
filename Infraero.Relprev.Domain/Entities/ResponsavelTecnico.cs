using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class ResponsavelTecnico : AuditableEntity
    {
  

        [Key]
        public int CodResponsavelTecnico { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NumDocumento { get; set; }
        public string EndEmail { get; set; }

        public virtual AtribuicaoRelato AtribuicaoRelato { get; set; }
        public virtual EmpresaResponsavelTecnico EmpresaResponsavelTecnico { get; set; }
    }
}
