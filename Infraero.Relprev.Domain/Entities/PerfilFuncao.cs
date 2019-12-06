using System;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class PerfilFuncao : AuditableEntity
    {
        [Key]
        public int CodPerfilFuncao { get; set; }
        public int CodPerfil { get; set; }
        public int CodFuncao { get; set; }
        public DateTime DthRegistro { get; set; }

        public virtual FuncaoSistema CodFuncaoNavigation { get; set; }
        public virtual Perfil CodPerfilNavigation { get; set; }
    }
}
