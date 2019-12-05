using System;
using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class EmpresaResponsavelTecnico : AuditableEntity
    {
        public DateTime DthRegistro { get; set; }
        public string NumDocumentoRepresentacao { get; set; }
        public int CodEmpresa { get; set; }
        public int CodLocalidade { get; set; }
        public int CodResponsavelTecnico { get; set; }

        public virtual Localidade CodLocalidadeNavigation { get; set; }
        public virtual ResponsavelTecnico CodResponsavelTecnicoNavigation { get; set; }
    }
}
