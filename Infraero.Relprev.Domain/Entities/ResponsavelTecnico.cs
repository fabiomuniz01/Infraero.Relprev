using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class ResponsavelTecnico : AuditableEntity
    {
        public ResponsavelTecnico()
        {
            AtribuicaoRelato = new HashSet<AtribuicaoRelato>();
            EmpresaResponsavelTecnico = new HashSet<EmpresaResponsavelTecnico>();
        }

        [Key]
        public int CodResponsavelTecnico { get; set; }
        public string NomResponsavelTecnico { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NumDocumento { get; set; }
        public string EndEmail { get; set; }

        public virtual ICollection<AtribuicaoRelato> AtribuicaoRelato { get; set; }
        public virtual ICollection<EmpresaResponsavelTecnico> EmpresaResponsavelTecnico { get; set; }
    }
}
