using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class EmpresaLocalidade : AuditableEntity
    {
        [Key]
        public int CodEmpresa { get; set; }
        public int CodLocalidade { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual Empresa CodEmpresaNavigation { get; set; }
        public virtual Local CodLocalidadeNavigation { get; set; }
    }
}
