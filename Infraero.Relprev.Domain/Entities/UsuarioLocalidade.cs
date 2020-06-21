using System;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class UsuarioLocalidade : AuditableEntity
    {
        [Key]
        public int CodUsuarioLocalidade { get; set; }
        public int CodUsuario { get; set; }
        public int CodLocalidade { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual Local CodLocalidadeNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
