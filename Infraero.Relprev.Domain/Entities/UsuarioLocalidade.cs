using System;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class UsuarioLocalidade : AuditableEntity
    {
        public int CodUsuario { get; set; }
        public int CodLocalidade { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual Localidade CodLocalidadeNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
