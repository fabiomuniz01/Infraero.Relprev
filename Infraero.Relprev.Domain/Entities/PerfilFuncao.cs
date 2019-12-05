using System;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class PerfilFuncao : AuditableEntity
    {
        public int CodPerfil { get; set; }
        public int CodFuncao { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual FuncaoSistema CodFuncaoNavigation { get; set; }
        public virtual Perfil CodPerfilNavigation { get; set; }
    }
}
