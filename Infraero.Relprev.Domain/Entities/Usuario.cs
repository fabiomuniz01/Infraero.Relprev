using Infraero.Relprev.Domain.Common;
using Infraero.Relprev.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Infraero.Relprev.Domain.Entities
{
    public class Usuario : AuditableEntity
    {
        [Key]
        public int CodUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string EndEmail { get; set; }
        public string NumTelefone { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public UnidadeInfraestrutura UnidadeInfraestrutura { get; set; }
        public int CodPerfil { get; set; }
    }
}
