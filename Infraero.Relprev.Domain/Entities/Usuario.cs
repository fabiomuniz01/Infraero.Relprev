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
        public string CodUsuarioLogin { get; set; }
        public string NomUsuario { get; set; }
        public string NumCpf { get; set; }
        public string NumTelefone { get; set; }
        public string NomPerfil { get; set; }
        public string Email { get; set; }
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodPerfil { get; set; }
        public int CodEmpresa { get; set; }
    }
}
