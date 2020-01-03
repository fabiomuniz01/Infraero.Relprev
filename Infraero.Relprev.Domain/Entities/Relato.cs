using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Infraero.Relprev.Domain.Common;

namespace Infraero.Relprev.Domain.Entities
{
    public partial class Relato : AuditableEntity
    {

        [Key]
        public int CodRelato { get; set; }
        public DateTime DatOcorrencia { get; set; }
        public TimeSpan HorOcorrencia { get; set; }
        public string DscLocalOcorrenciaRelator { get; set; }
        public string DscEnvolvidosOcorrencia { get; set; }
        public string DscOcorrenciaRelator { get; set; }
        public string NomRelator { get; set; }
        public string EmailRelator { get; set; }
        public string NumTelefoneRelator { get; set; }
        public string NomEmpresaRelator { get; set; }
    }
}
