using System;
using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class EmpresaLocalidade : AuditableEntity
    {
        public int CodEmpresa { get; set; }
        public int CodLocalidade { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual Empresa CodEmpresaNavigation { get; set; }
        public virtual Localidade CodLocalidadeNavigation { get; set; }
    }
}
