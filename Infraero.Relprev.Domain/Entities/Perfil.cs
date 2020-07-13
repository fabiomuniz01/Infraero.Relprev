using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class Perfil : AuditableEntity
    {
        [Key]
        public int CodPerfil { get; set; }
        public string NomPerfil { get; set; }
        public string DscPerfil { get; set; }

    }
}
