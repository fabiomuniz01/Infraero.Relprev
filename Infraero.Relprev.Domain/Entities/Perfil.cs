using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Perfil : AuditableEntity
    {
        public Perfil()
        {
            PerfilFuncao = new HashSet<PerfilFuncao>();
            PerfilUsuario = new HashSet<PerfilUsuario>();
        }

        [Key]
        public int CodPerfil { get; set; }
        public string DscPerfil { get; set; }
        public string FlgPermiteAlteracao { get; set; }
        public DateTime DthRegistro { get; set; }
        public string FlgAtivo { get; set; }
        public string TxtObservacao { get; set; }

        public virtual ICollection<PerfilFuncao> PerfilFuncao { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuario { get; set; }
    }
}
