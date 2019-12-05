using System;
using System.Collections.Generic;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class ContratoUtilizacaoSistema : AuditableEntity
    {
        public int CodContrato { get; set; }
        public int? CodLocalidade { get; set; }
        public int? CodEmpresa { get; set; }
        public string NumContrato { get; set; }
        public string NumAtoAdm { get; set; }
        public string NomCotratante { get; set; }
        public string EmailContratante { get; set; }
        public string NumTelefoneContratante { get; set; }
        public string NomContratada { get; set; }
        public string EmailContratada { get; set; }
        public string NumTelefoneContratada { get; set; }
        public DateTime DatInicioVigencia { get; set; }
        public DateTime? DatFimVigencia { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual Empresa CodEmpresaNavigation { get; set; }
        public virtual Localidade CodLocalidadeNavigation { get; set; }
    }
}
