using System;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class PerfilUsuario : AuditableEntity
    {
        [Key]
        public int CodPerfilUsuario { get; set; }
        public int CodPerfil { get; set; }
        public int CodUsuario { get; set; }
        public DateTime DatInicioVigencia { get; set; }
        public DateTime? DatFimVigencia { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual Perfil CodPerfilNavigation { get; set; }
        public virtual Usuario CodUsuarioNavigation { get; set; }
    }
}
