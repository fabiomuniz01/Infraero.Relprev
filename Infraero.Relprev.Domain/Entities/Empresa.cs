using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public class Empresa : AuditableEntity
    {

        [Key]
        public int CodEmpresa { get; set; }
        public string NomRazaoSocial { get; set; }
        public string NumCnpj { get; set; }
        public DateTime DthRegistro { get; set; }
        public string NumTelefone { get; set; }
        public string CpfCriadoPor { get; set; }
    }
}
