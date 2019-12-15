using Infraero.Relprev.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace Infraero.Relprev.Domain.Entities
{
    public class UnidadeInfraestrutura : AuditableEntity
    {
       

        [Key]
        public int CodUnidadeInfraestrutura { get; set; }
        public string CodUnidade { get; set; }
        public string Sigla { get; set; }

        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public DateTime DtIniVigencia { get; set; }
        public DateTime DtFimVigencia { get; set; }
    }
}
